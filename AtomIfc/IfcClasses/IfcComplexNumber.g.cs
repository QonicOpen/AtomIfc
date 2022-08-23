
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
    public class IfcComplexNumber : IfcBase, IEquatable<IfcComplexNumber>, IIfcMeasureValue
    {
        private List<double> _value;
        public List<double> Value 
        {
            get { 
                return _value; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("Value is not allowed to be null"); 
                _value = value;
            }
        }

        public IfcComplexNumber(IfcId id, List<double> value) : base(id)
        {
            Value = value;
        }

        public override ClassId GetClassId() => ClassId.IfcComplexNumber;

        #region Equality

        public bool Equals(IfcComplexNumber other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(Value, other.Value))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcComplexNumber);

        public static bool operator ==(IfcComplexNumber one, IfcComplexNumber other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcComplexNumber one, IfcComplexNumber other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(Value)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcComplexNumber (newId,Value);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcComplexNumber },
                { "class", nameof(IfcComplexNumber) },
                { "parameters" , new JArray
                    {
                        Value.ToJArray(),
                    }
                }
            };
        }

        public static IfcComplexNumber CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcComplexNumber(
                jObject["id"].ToIfcId(),
                parameters[0].ToDoubleList());
        }
        #endregion

    }
}