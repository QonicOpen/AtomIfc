
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
    public class IfcArcIndex : IfcBase, IEquatable<IfcArcIndex>, IIfcSegmentIndexSelect
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

        public IfcArcIndex(IfcId id, List<int> value) : base(id)
        {
            Value = value;
        }

        public override ClassId GetClassId() => ClassId.IfcArcIndex;

        #region Equality

        public bool Equals(IfcArcIndex other)
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

        public override bool Equals(object other) => Equals(other as IfcArcIndex);

        public static bool operator ==(IfcArcIndex one, IfcArcIndex other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcArcIndex one, IfcArcIndex other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(Value)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcArcIndex (newId,Value);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcArcIndex },
                { "class", nameof(IfcArcIndex) },
                { "parameters" , new JArray
                    {
                        Value.ToJArray(),
                    }
                }
            };
        }

        public static IfcArcIndex CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcArcIndex(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIntList());
        }
        #endregion

    }
}