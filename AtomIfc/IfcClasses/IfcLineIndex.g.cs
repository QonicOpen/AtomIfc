
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
    public class IfcLineIndex : IfcBase, IEquatable<IfcLineIndex>, IIfcSegmentIndexSelect
    {
        private List<int> _value;
        public List<int> Value 
        {
            get { 
                return _value; 
            }
            set { 
                _value = value;  // optional List<int>
            }
        }

        public IfcLineIndex(IfcId id, List<int> value) : base(id)
        {
            Value = value;
        }

        public override ClassId GetClassId() => ClassId.IfcLineIndex;

        #region Equality

        public bool Equals(IfcLineIndex other)
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

        public override bool Equals(object other) => Equals(other as IfcLineIndex);

        public static bool operator ==(IfcLineIndex one, IfcLineIndex other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLineIndex one, IfcLineIndex other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(Value)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLineIndex (newId,Value);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLineIndex },
                { "class", nameof(IfcLineIndex) },
                { "parameters" , new JArray
                    {
                        Value.ToJArray(),
                    }
                }
            };
        }

        public static IfcLineIndex CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLineIndex(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIntList());
        }
        #endregion

    }
}