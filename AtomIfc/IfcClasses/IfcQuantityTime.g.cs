
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
    public class IfcQuantityTime : IfcPhysicalSimpleQuantity, IEquatable<IfcQuantityTime>
    {
        private double _timeValue;
        public double TimeValue 
        {
            get { 
                return _timeValue; 
            }
            set { 
                _timeValue = value;
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

        public IfcQuantityTime(IfcId id, string name, string description, IfcId unitId, double timeValue, string formula) : base(id, name, description, unitId)
        {
            TimeValue = timeValue;
            Formula = formula;
        }

        public override ClassId GetClassId() => ClassId.IfcQuantityTime;

        #region Equality

        public bool Equals(IfcQuantityTime other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TimeValue == other.TimeValue
                && Formula == other.Formula;
        }

        public override bool Equals(object other) => Equals(other as IfcQuantityTime);

        public static bool operator ==(IfcQuantityTime one, IfcQuantityTime other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcQuantityTime one, IfcQuantityTime other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{UnitId},{TimeValue},'{Formula}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcQuantityTime (newId,Name, Description, UnitId, TimeValue, Formula);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcQuantityTime },
                { "class", nameof(IfcQuantityTime) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        UnitId.ToJValue(),
                        TimeValue,
                        Formula.ToJValue(),
                    }
                }
            };
        }

        public static IfcQuantityTime CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcQuantityTime(
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