
/*
 *  Copyright (c) 2022 Qonic
 *
 *  This file is auto-generated.
 *
 *  Do not modify manually!
 */

using System;
using System.IO;
using System.Linq;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Ifc
{
    public class IfcContextDependentUnit : IfcNamedUnit, IEquatable<IfcContextDependentUnit>, IIfcResourceObjectSelect
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;
            }
        }

        public IfcContextDependentUnit(IfcId id, IfcId dimensionsId, IfcUnitEnum unitType, string name) : base(id, dimensionsId, unitType)
        {
            Name = name;
        }

        public override ClassId GetClassId() => ClassId.IfcContextDependentUnit;

        #region Equality

        public bool Equals(IfcContextDependentUnit other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name;
        }

        public override bool Equals(object other) => Equals(other as IfcContextDependentUnit);

        public static bool operator ==(IfcContextDependentUnit one, IfcContextDependentUnit other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcContextDependentUnit one, IfcContextDependentUnit other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({DimensionsId},.{UnitType}.,'{Name}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcContextDependentUnit (newId,DimensionsId, UnitType, Name);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcContextDependentUnit },
                { "class", nameof(IfcContextDependentUnit) },
                { "parameters" , new JArray
                    {
                        DimensionsId.ToJValue(),
                        UnitType.ToJValue(),
                        Name.ToJValue(),
                    }
                }
            };
        }

        public static IfcContextDependentUnit CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcContextDependentUnit(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                (IfcUnitEnum)IfcAtom.EnumCreator[(int)EnumId.IfcUnitEnum](parameters[1].ToString()),
                parameters[2].ToString());
        }
        #endregion

    }
}