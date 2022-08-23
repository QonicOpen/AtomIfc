
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
    public class IfcNumericMeasure : IfcBase, IEquatable<IfcNumericMeasure>, IIfcMeasureValue
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

        public IfcNumericMeasure(IfcId id, double value) : base(id)
        {
            Value = value;
        }

        public override ClassId GetClassId() => ClassId.IfcNumericMeasure;

        #region Equality

        public bool Equals(IfcNumericMeasure other)
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

        public override bool Equals(object other) => Equals(other as IfcNumericMeasure);

        public static bool operator ==(IfcNumericMeasure one, IfcNumericMeasure other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcNumericMeasure one, IfcNumericMeasure other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Value})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcNumericMeasure (newId,Value);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcNumericMeasure },
                { "class", nameof(IfcNumericMeasure) },
                { "parameters" , new JArray
                    {
                        Value,
                    }
                }
            };
        }

        public static IfcNumericMeasure CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcNumericMeasure(
                jObject["id"].ToIfcId(),
                parameters[0].ToDouble());
        }
        #endregion

    }
}