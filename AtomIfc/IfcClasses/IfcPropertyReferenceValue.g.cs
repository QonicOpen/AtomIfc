
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
    public class IfcPropertyReferenceValue : IfcSimpleProperty, IEquatable<IfcPropertyReferenceValue>
    {
        private string _usageName;
        public string UsageName 
        {
            get { 
                return _usageName; 
            }
            set { 
                _usageName = value;  // optional IfcText
            }
        }
        private IfcId _propertyReferenceId;
        public IfcId PropertyReferenceId 
        {
            get { 
                return _propertyReferenceId; 
            }
            set { 
                _propertyReferenceId = value;  // optional IfcObjectReferenceSelect
            }
        }

        public IfcPropertyReferenceValue(IfcId id, string name, string description, string usageName, IfcId propertyReferenceId) : base(id, name, description)
        {
            UsageName = usageName;
            PropertyReferenceId = propertyReferenceId;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertyReferenceValue;

        #region Equality

        public bool Equals(IfcPropertyReferenceValue other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && UsageName == other.UsageName
                && PropertyReferenceId == other.PropertyReferenceId;
        }

        public override bool Equals(object other) => Equals(other as IfcPropertyReferenceValue);

        public static bool operator ==(IfcPropertyReferenceValue one, IfcPropertyReferenceValue other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertyReferenceValue one, IfcPropertyReferenceValue other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}','{UsageName}',{PropertyReferenceId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PropertyReferenceId!= null && replacementTable.ContainsKey(PropertyReferenceId))
                PropertyReferenceId = replacementTable[PropertyReferenceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertyReferenceValue (newId,Name, Description, UsageName, PropertyReferenceId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertyReferenceValue },
                { "class", nameof(IfcPropertyReferenceValue) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        UsageName.ToJValue(),
                        PropertyReferenceId.ToJValue(),
                    }
                }
            };
        }

        public static IfcPropertyReferenceValue CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertyReferenceValue(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId());
        }
        #endregion

    }
}