
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
    public class IfcMaterialConstituentSet : IfcMaterialDefinition, IEquatable<IfcMaterialConstituentSet>
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
        private List<IfcId> _materialConstituentIds;
        public List<IfcId> MaterialConstituentIds 
        {
            get { 
                return _materialConstituentIds; 
            }
            set { 
                _materialConstituentIds = value;  // optional List<IfcMaterialConstituent>
            }
        }

        public IfcMaterialConstituentSet(IfcId id, string name, string description, List<IfcId> materialConstituentIds) : base(id)
        {
            Name = name;
            Description = description;
            MaterialConstituentIds = materialConstituentIds;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialConstituentSet;

        #region Equality

        public bool Equals(IfcMaterialConstituentSet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(MaterialConstituentIds, other.MaterialConstituentIds))
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialConstituentSet);

        public static bool operator ==(IfcMaterialConstituentSet one, IfcMaterialConstituentSet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialConstituentSet one, IfcMaterialConstituentSet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(MaterialConstituentIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MaterialConstituentIds!= null)
                MaterialConstituentIds = MaterialConstituentIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialConstituentSet (newId,Name, Description, MaterialConstituentIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialConstituentSet },
                { "class", nameof(IfcMaterialConstituentSet) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        MaterialConstituentIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcMaterialConstituentSet CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialConstituentSet(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcIdList());
        }
        #endregion

    }
}