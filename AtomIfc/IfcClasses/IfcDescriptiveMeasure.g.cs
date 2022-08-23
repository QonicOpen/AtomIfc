
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
    public class IfcDescriptiveMeasure : IfcBase, IEquatable<IfcDescriptiveMeasure>, IIfcMeasureValue, IIfcSizeSelect
    {
        private string _value;
        public string Value 
        {
            get { 
                return _value; 
            }
            set { 
                _value = value;
            }
        }

        public IfcDescriptiveMeasure(IfcId id, string value) : base(id)
        {
            Value = value;
        }

        public override ClassId GetClassId() => ClassId.IfcDescriptiveMeasure;

        #region Equality

        public bool Equals(IfcDescriptiveMeasure other)
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

        public override bool Equals(object other) => Equals(other as IfcDescriptiveMeasure);

        public static bool operator ==(IfcDescriptiveMeasure one, IfcDescriptiveMeasure other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDescriptiveMeasure one, IfcDescriptiveMeasure other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Value}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDescriptiveMeasure (newId,Value);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDescriptiveMeasure },
                { "class", nameof(IfcDescriptiveMeasure) },
                { "parameters" , new JArray
                    {
                        Value.ToJValue(),
                    }
                }
            };
        }

        public static IfcDescriptiveMeasure CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDescriptiveMeasure(
                jObject["id"].ToIfcId(),
                parameters[0].ToString());
        }
        #endregion

    }
}