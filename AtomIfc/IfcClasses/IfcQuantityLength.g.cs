
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
    public class IfcQuantityLength : IfcPhysicalSimpleQuantity, IEquatable<IfcQuantityLength>
    {
        private double _lengthValue;
        public double LengthValue 
        {
            get { 
                return _lengthValue; 
            }
            set { 
                _lengthValue = value;
            }
        }
        private string _formula;
        public string Formula 
        {
            get { 
                return _formula; 
            }
            set { 
                _formula = value;  // optional IfcLabel
            }
        }

        public IfcQuantityLength(IfcId id, string name, string description, IfcId unitId, double lengthValue, string formula) : base(id, name, description, unitId)
        {
            LengthValue = lengthValue;
            Formula = formula;
        }

        public override ClassId GetClassId() => ClassId.IfcQuantityLength;

        #region Equality

        public bool Equals(IfcQuantityLength other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LengthValue == other.LengthValue
                && Formula == other.Formula;
        }

        public override bool Equals(object other) => Equals(other as IfcQuantityLength);

        public static bool operator ==(IfcQuantityLength one, IfcQuantityLength other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcQuantityLength one, IfcQuantityLength other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{UnitId},{LengthValue},'{Formula}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcQuantityLength (newId,Name, Description, UnitId, LengthValue, Formula);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcQuantityLength },
                { "class", nameof(IfcQuantityLength) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        UnitId.ToJValue(),
                        LengthValue,
                        Formula.ToJValue(),
                    }
                }
            };
        }

        public static IfcQuantityLength CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcQuantityLength(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToOptionalString());
        }
        #endregion

    }
}