
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
    public class IfcMaterial : IfcMaterialDefinition, IEquatable<IfcMaterial>
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;
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

        public IfcMaterial(IfcId id, string name, string description, string category) : base(id)
        {
            Name = name;
            Description = description;
            Category = category;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterial;

        #region Equality

        public bool Equals(IfcMaterial other)
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
                && Category == other.Category;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterial);

        public static bool operator ==(IfcMaterial one, IfcMaterial other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterial one, IfcMaterial other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}','{Category}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterial (newId,Name, Description, Category);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterial },
                { "class", nameof(IfcMaterial) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        Category.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterial CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterial(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString());
        }
        #endregion

    }
}