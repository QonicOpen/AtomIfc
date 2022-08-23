
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
    public class IfcQuantityArea : IfcPhysicalSimpleQuantity, IEquatable<IfcQuantityArea>
    {
        private double _areaValue;
        public double AreaValue 
        {
            get { 
                return _areaValue; 
            }
            set { 
                _areaValue = value;
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

        public IfcQuantityArea(IfcId id, string name, string description, IfcId unitId, double areaValue, string formula) : base(id, name, description, unitId)
        {
            AreaValue = areaValue;
            Formula = formula;
        }

        public override ClassId GetClassId() => ClassId.IfcQuantityArea;

        #region Equality

        public bool Equals(IfcQuantityArea other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && AreaValue == other.AreaValue
                && Formula == other.Formula;
        }

        public override bool Equals(object other) => Equals(other as IfcQuantityArea);

        public static bool operator ==(IfcQuantityArea one, IfcQuantityArea other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcQuantityArea one, IfcQuantityArea other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{UnitId},{AreaValue},'{Formula}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcQuantityArea (newId,Name, Description, UnitId, AreaValue, Formula);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcQuantityArea },
                { "class", nameof(IfcQuantityArea) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        UnitId.ToJValue(),
                        AreaValue,
                        Formula.ToJValue(),
                    }
                }
            };
        }

        public static IfcQuantityArea CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcQuantityArea(
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