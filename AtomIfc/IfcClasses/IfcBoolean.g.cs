
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
    public class IfcBoolean : IfcBase, IEquatable<IfcBoolean>, IIfcModulusOfRotationalSubgradeReactionSelect, IIfcModulusOfSubgradeReactionSelect, IIfcModulusOfTranslationalSubgradeReactionSelect, IIfcRotationalStiffnessSelect, IIfcSimpleValue, IIfcTranslationalStiffnessSelect, IIfcWarpingStiffnessSelect
    {
        private bool _value;
        public bool Value 
        {
            get { 
                return _value; 
            }
            set { 
                _value = value;
            }
        }

        public IfcBoolean(IfcId id, bool value) : base(id)
        {
            Value = value;
        }

        public override ClassId GetClassId() => ClassId.IfcBoolean;

        #region Equality

        public bool Equals(IfcBoolean other)
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

        public override bool Equals(object other) => Equals(other as IfcBoolean);

        public static bool operator ==(IfcBoolean one, IfcBoolean other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBoolean one, IfcBoolean other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Value})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBoolean (newId,Value);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBoolean },
                { "class", nameof(IfcBoolean) },
                { "parameters" , new JArray
                    {
                        Value,
                    }
                }
            };
        }

        public static IfcBoolean CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBoolean(
                jObject["id"].ToIfcId(),
                parameters[0].ToBool());
        }
        #endregion

    }
}