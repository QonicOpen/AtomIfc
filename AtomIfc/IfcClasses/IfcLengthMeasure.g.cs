
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
    public class IfcLengthMeasure : IfcBase, IEquatable<IfcLengthMeasure>, IIfcBendingParameterSelect, IIfcMeasureValue, IIfcSizeSelect
    {
        private double _value;
        public double Value 
        {
            get { 
                return _value; 
            }
            set { 
                _value = value;
            }
        }

        public IfcLengthMeasure(IfcId id, double value) : base(id)
        {
            Value = value;
        }

        public override ClassId GetClassId() => ClassId.IfcLengthMeasure;

        #region Equality

        public bool Equals(IfcLengthMeasure other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Value == other.Value;
        }

        public override bool Equals(object other) => Equals(other as IfcLengthMeasure);

        public static bool operator ==(IfcLengthMeasure one, IfcLengthMeasure other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLengthMeasure one, IfcLengthMeasure other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Value})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLengthMeasure (newId,Value);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLengthMeasure },
                { "class", nameof(IfcLengthMeasure) },
                { "parameters" , new JArray
                    {
                        Value,
                    }
                }
            };
        }

        public static IfcLengthMeasure CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLengthMeasure(
                jObject["id"].ToIfcId(),
                parameters[0].ToDouble());
        }
        #endregion

    }
}