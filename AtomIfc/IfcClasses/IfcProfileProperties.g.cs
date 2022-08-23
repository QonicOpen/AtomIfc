
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
    public class IfcProfileProperties : IfcExtendedProperties, IEquatable<IfcProfileProperties>
    {
        private IfcId _profileDefinitionId;
        public IfcId ProfileDefinitionId 
        {
            get { 
                return _profileDefinitionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ProfileDefinitionId is not allowed to be null"); 
                _profileDefinitionId = value;
            }
        }

        public IfcProfileProperties(IfcId id, string name, string description, List<IfcId> propertyIds, IfcId profileDefinitionId) : base(id, name, description, propertyIds)
        {
            ProfileDefinitionId = profileDefinitionId;
        }

        public override ClassId GetClassId() => ClassId.IfcProfileProperties;

        #region Equality

        public bool Equals(IfcProfileProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ProfileDefinitionId == other.ProfileDefinitionId;
        }

        public override bool Equals(object other) => Equals(other as IfcProfileProperties);

        public static bool operator ==(IfcProfileProperties one, IfcProfileProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcProfileProperties one, IfcProfileProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(PropertyIds)},{ProfileDefinitionId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ProfileDefinitionId!= null && replacementTable.ContainsKey(ProfileDefinitionId))
                ProfileDefinitionId = replacementTable[ProfileDefinitionId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcProfileProperties (newId,Name, Description, PropertyIds, ProfileDefinitionId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcProfileProperties },
                { "class", nameof(IfcProfileProperties) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        PropertyIds.ToJArray(),
                        ProfileDefinitionId.ToJValue(),
                    }
                }
            };
        }

        public static IfcProfileProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcProfileProperties(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToIfcId());
        }
        #endregion

    }
}