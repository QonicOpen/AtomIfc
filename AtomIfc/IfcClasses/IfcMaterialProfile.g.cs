
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
    public class IfcMaterialProfile : IfcMaterialDefinition, IEquatable<IfcMaterialProfile>
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;  // optional IfcLabel
            }
        }
        private string _description;
        public string Description 
        {
            get { 
                return _description; 
            }
            set { 
                _description = value;  // optional IfcText
            }
        }
        private IfcId _materialId;
        public IfcId MaterialId 
        {
            get { 
                return _materialId; 
            }
            set { 
                _materialId = value;  // optional IfcMaterial
            }
        }
        private IfcId _profileId;
        public IfcId ProfileId 
        {
            get { 
                return _profileId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ProfileId is not allowed to be null"); 
                _profileId = value;
            }
        }
        private double? _priority;
        public double? Priority 
        {
            get { 
                return _priority; 
            }
            set { 
                _priority = value;  // optional IfcNormalisedRatioMeasure
            }
        }
        private string _category;
        public string Category 
        {
            get { 
                return _category; 
            }
            set { 
                _category = value;  // optional IfcLabel
            }
        }

        public IfcMaterialProfile(IfcId id, string name, string description, IfcId materialId, IfcId profileId, double? priority, string category) : base(id)
        {
            Name = name;
            Description = description;
            MaterialId = materialId;
            ProfileId = profileId;
            Priority = priority;
            Category = category;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialProfile;

        #region Equality

        public bool Equals(IfcMaterialProfile other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description
                && MaterialId == other.MaterialId
                && ProfileId == other.ProfileId
                && Priority == other.Priority
                && Category == other.Category;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialProfile);

        public static bool operator ==(IfcMaterialProfile one, IfcMaterialProfile other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialProfile one, IfcMaterialProfile other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{MaterialId},{ProfileId},{Priority},'{Category}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MaterialId!= null && replacementTable.ContainsKey(MaterialId))
                MaterialId = replacementTable[MaterialId];
            if(ProfileId!= null && replacementTable.ContainsKey(ProfileId))
                ProfileId = replacementTable[ProfileId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialProfile (newId,Name, Description, MaterialId, ProfileId, Priority, Category);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialProfile },
                { "class", nameof(IfcMaterialProfile) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        MaterialId.ToJValue(),
                        ProfileId.ToJValue(),
                        Priority.ToJValue(),
                        Category.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialProfile CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialProfile(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToIfcId(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToOptionalString());
        }
        #endregion

    }
}