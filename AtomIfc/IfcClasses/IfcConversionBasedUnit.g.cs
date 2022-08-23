
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
    public class IfcConversionBasedUnit : IfcNamedUnit, IEquatable<IfcConversionBasedUnit>, IIfcResourceObjectSelect
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
        private IfcId _conversionFactorId;
        public IfcId ConversionFactorId 
        {
            get { 
                return _conversionFactorId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ConversionFactorId is not allowed to be null"); 
                _conversionFactorId = value;
            }
        }

        public IfcConversionBasedUnit(IfcId id, IfcId dimensionsId, IfcUnitEnum unitType, string name, IfcId conversionFactorId) : base(id, dimensionsId, unitType)
        {
            Name = name;
            ConversionFactorId = conversionFactorId;
        }

        public override ClassId GetClassId() => ClassId.IfcConversionBasedUnit;

        #region Equality

        public bool Equals(IfcConversionBasedUnit other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name
                && ConversionFactorId == other.ConversionFactorId;
        }

        public override bool Equals(object other) => Equals(other as IfcConversionBasedUnit);

        public static bool operator ==(IfcConversionBasedUnit one, IfcConversionBasedUnit other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConversionBasedUnit one, IfcConversionBasedUnit other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({DimensionsId},.{UnitType}.,'{Name}',{ConversionFactorId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ConversionFactorId!= null && replacementTable.ContainsKey(ConversionFactorId))
                ConversionFactorId = replacementTable[ConversionFactorId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcConversionBasedUnit (newId,DimensionsId, UnitType, Name, ConversionFactorId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcConversionBasedUnit },
                { "class", nameof(IfcConversionBasedUnit) },
                { "parameters" , new JArray
                    {
                        DimensionsId.ToJValue(),
                        UnitType.ToJValue(),
                        Name.ToJValue(),
                        ConversionFactorId.ToJValue(),
                    }
                }
            };
        }

        public static IfcConversionBasedUnit CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcConversionBasedUnit(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                (IfcUnitEnum)IfcAtom.EnumCreator[(int)EnumId.IfcUnitEnum](parameters[1].ToString()),
                parameters[2].ToString(),
                parameters[3].ToIfcId());
        }
        #endregion

    }
}