
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
    public class IfcConversionBasedUnitWithOffset : IfcConversionBasedUnit, IEquatable<IfcConversionBasedUnitWithOffset>
    {
        private double _conversionOffset;
        public double ConversionOffset 
        {
            get { 
                return _conversionOffset; 
            }
            set { 
                _conversionOffset = value;
            }
        }

        public IfcConversionBasedUnitWithOffset(IfcId id, IfcId dimensionsId, IfcUnitEnum unitType, string name, IfcId conversionFactorId, double conversionOffset) : base(id, dimensionsId, unitType, name, conversionFactorId)
        {
            ConversionOffset = conversionOffset;
        }

        public override ClassId GetClassId() => ClassId.IfcConversionBasedUnitWithOffset;

        #region Equality

        public bool Equals(IfcConversionBasedUnitWithOffset other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ConversionOffset == other.ConversionOffset;
        }

        public override bool Equals(object other) => Equals(other as IfcConversionBasedUnitWithOffset);

        public static bool operator ==(IfcConversionBasedUnitWithOffset one, IfcConversionBasedUnitWithOffset other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConversionBasedUnitWithOffset one, IfcConversionBasedUnitWithOffset other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({DimensionsId},.{UnitType}.,'{Name}',{ConversionFactorId},{ConversionOffset})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcConversionBasedUnitWithOffset (newId,DimensionsId, UnitType, Name, ConversionFactorId, ConversionOffset);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcConversionBasedUnitWithOffset },
                { "class", nameof(IfcConversionBasedUnitWithOffset) },
                { "parameters" , new JArray
                    {
                        DimensionsId.ToJValue(),
                        UnitType.ToJValue(),
                        Name.ToJValue(),
                        ConversionFactorId.ToJValue(),
                        ConversionOffset,
                    }
                }
            };
        }

        public static new IfcConversionBasedUnitWithOffset CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcConversionBasedUnitWithOffset(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                (IfcUnitEnum)IfcAtom.EnumCreator[(int)EnumId.IfcUnitEnum](parameters[1].ToString()),
                parameters[2].ToString(),
                parameters[3].ToIfcId(),
                parameters[4].ToDouble());
        }
        #endregion

    }
}