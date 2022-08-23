
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
    public class IfcDuration : IfcBase, IEquatable<IfcDuration>, IIfcSimpleValue, IIfcTimeOrRatioSelect
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

        public IfcDuration(IfcId id, string value) : base(id)
        {
            Value = value;
        }

        public override ClassId GetClassId() => ClassId.IfcDuration;

        #region Equality

        public bool Equals(IfcDuration other)
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

        public override bool Equals(object other) => Equals(other as IfcDuration);

        public static bool operator ==(IfcDuration one, IfcDuration other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDuration one, IfcDuration other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Value}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDuration (newId,Value);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDuration },
                { "class", nameof(IfcDuration) },
                { "parameters" , new JArray
                    {
                        Value.ToJValue(),
                    }
                }
            };
        }

        public static IfcDuration CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDuration(
                jObject["id"].ToIfcId(),
                parameters[0].ToString());
        }
        #endregion

    }
}