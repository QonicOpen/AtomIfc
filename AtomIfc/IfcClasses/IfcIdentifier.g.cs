
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
    public class IfcIdentifier : IfcBase, IEquatable<IfcIdentifier>, IIfcSimpleValue
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

        public IfcIdentifier(IfcId id, string value) : base(id)
        {
            Value = value;
        }

        public override ClassId GetClassId() => ClassId.IfcIdentifier;

        #region Equality

        public bool Equals(IfcIdentifier other)
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

        public override bool Equals(object other) => Equals(other as IfcIdentifier);

        public static bool operator ==(IfcIdentifier one, IfcIdentifier other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcIdentifier one, IfcIdentifier other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Value}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcIdentifier (newId,Value);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcIdentifier },
                { "class", nameof(IfcIdentifier) },
                { "parameters" , new JArray
                    {
                        Value.ToJValue(),
                    }
                }
            };
        }

        public static IfcIdentifier CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcIdentifier(
                jObject["id"].ToIfcId(),
                parameters[0].ToString());
        }
        #endregion

    }
}