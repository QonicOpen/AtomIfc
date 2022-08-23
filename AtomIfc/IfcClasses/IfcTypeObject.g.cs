
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
    public class IfcTypeObject : IfcObjectDefinition, IEquatable<IfcTypeObject>
    {
        private string _applicableOccurrence;
        public string ApplicableOccurrence 
        {
            get { 
                return _applicableOccurrence; 
            }
            set { 
                _applicableOccurrence = value;  // optional IfcIdentifier
            }
        }
        private List<IfcId> _propertySetIds;
        public List<IfcId> PropertySetIds 
        {
            get { 
                return _propertySetIds; 
            }
            set { 
                _propertySetIds = value;  // optional List<IfcPropertySetDefinition>
            }
        }

        public IfcTypeObject(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds) : base(id, globalId, ownerHistoryId, name, description)
        {
            ApplicableOccurrence = applicableOccurrence;
            PropertySetIds = propertySetIds;
        }

        public override ClassId GetClassId() => ClassId.IfcTypeObject;

        #region Equality

        public bool Equals(IfcTypeObject other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(PropertySetIds, other.PropertySetIds))
                return false;
            return base.Equals(other)
                && ApplicableOccurrence == other.ApplicableOccurrence;
        }

        public override bool Equals(object other) => Equals(other as IfcTypeObject);

        public static bool operator ==(IfcTypeObject one, IfcTypeObject other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTypeObject one, IfcTypeObject other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PropertySetIds!= null)
                PropertySetIds = PropertySetIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTypeObject (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTypeObject },
                { "class", nameof(IfcTypeObject) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ApplicableOccurrence.ToJValue(),
                        PropertySetIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcTypeObject CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTypeObject(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcIdList());
        }
        #endregion

    }
}