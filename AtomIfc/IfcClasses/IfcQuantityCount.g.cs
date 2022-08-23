
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
    public class IfcQuantityCount : IfcPhysicalSimpleQuantity, IEquatable<IfcQuantityCount>
    {
        private double _countValue;
        public double CountValue 
        {
            get { 
                return _countValue; 
            }
            set { 
                _countValue = value;
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

        public IfcQuantityCount(IfcId id, string name, string description, IfcId unitId, double countValue, string formula) : base(id, name, description, unitId)
        {
            CountValue = countValue;
            Formula = formula;
        }

        public override ClassId GetClassId() => ClassId.IfcQuantityCount;

        #region Equality

        public bool Equals(IfcQuantityCount other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && CountValue == other.CountValue
                && Formula == other.Formula;
        }

        public override bool Equals(object other) => Equals(other as IfcQuantityCount);

        public static bool operator ==(IfcQuantityCount one, IfcQuantityCount other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcQuantityCount one, IfcQuantityCount other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{UnitId},{CountValue},'{Formula}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcQuantityCount (newId,Name, Description, UnitId, CountValue, Formula);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcQuantityCount },
                { "class", nameof(IfcQuantityCount) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        UnitId.ToJValue(),
                        CountValue,
                        Formula.ToJValue(),
                    }
                }
            };
        }

        public static IfcQuantityCount CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcQuantityCount(
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