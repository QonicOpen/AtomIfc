
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
    public class IfcPropertySet : IfcPropertySetDefinition, IEquatable<IfcPropertySet>
    {
        private List<IfcId> _propertyIds;
        public List<IfcId> PropertyIds 
        {
            get { 
                return _propertyIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PropertyIds is not allowed to be null"); 
                _propertyIds = value;
            }
        }

        public IfcPropertySet(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, List<IfcId> propertyIds) : base(id, globalId, ownerHistoryId, name, description)
        {
            PropertyIds = propertyIds;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertySet;

        #region Equality

        public bool Equals(IfcPropertySet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(PropertyIds, other.PropertyIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcPropertySet);

        public static bool operator ==(IfcPropertySet one, IfcPropertySet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertySet one, IfcPropertySet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(PropertyIds.OrderBy(id => (int)id).ToList())})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PropertyIds!= null)
                PropertyIds = PropertyIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertySet (newId,GlobalId, OwnerHistoryId, Name, Description, PropertyIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertySet },
                { "class", nameof(IfcPropertySet) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        PropertyIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcPropertySet CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertySet(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToIfcIdList());
        }
        #endregion

    }
}