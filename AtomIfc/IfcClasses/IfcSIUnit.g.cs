
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
    public class IfcSIUnit : IfcNamedUnit, IEquatable<IfcSIUnit>
    {
        private IfcSIPrefix _prefix;
        public IfcSIPrefix Prefix 
        {
            get { 
                return _prefix; 
            }
            set { 
                _prefix = value;  // optional IfcSIPrefix?
            }
        }
        private IfcSIUnitName _name;
        public IfcSIUnitName Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;
            }
        }

        public IfcSIUnit(IfcId id, IfcId dimensionsId, IfcUnitEnum unitType, IfcSIPrefix prefix, IfcSIUnitName name) : base(id, dimensionsId, unitType)
        {
            Prefix = prefix;
            Name = name;
        }

        public override ClassId GetClassId() => ClassId.IfcSIUnit;

        #region Equality

        public bool Equals(IfcSIUnit other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Prefix == other.Prefix
                && Name == other.Name;
        }

        public override bool Equals(object other) => Equals(other as IfcSIUnit);

        public static bool operator ==(IfcSIUnit one, IfcSIUnit other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSIUnit one, IfcSIUnit other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({DimensionsId},.{UnitType}.,.{Prefix}.,.{Name}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSIUnit (newId,DimensionsId, UnitType, Prefix, Name);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSIUnit },
                { "class", nameof(IfcSIUnit) },
                { "parameters" , new JArray
                    {
                        DimensionsId.ToJValue(),
                        UnitType.ToJValue(),
                        Prefix.ToJValue(),
                        Name.ToJValue(),
                    }
                }
            };
        }

        public static IfcSIUnit CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSIUnit(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                (IfcUnitEnum)IfcAtom.EnumCreator[(int)EnumId.IfcUnitEnum](parameters[1].ToString()),
                (IfcSIPrefix)IfcAtom.EnumCreator[(int)EnumId.IfcSIPrefix](parameters[2].ToString()),
                (IfcSIUnitName)IfcAtom.EnumCreator[(int)EnumId.IfcSIUnitName](parameters[3].ToString()));
        }
        #endregion

    }
}