
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
    public class IfcMaterialProfileSet : IfcMaterialDefinition, IEquatable<IfcMaterialProfileSet>
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
        private List<IfcId> _materialProfileIds;
        public List<IfcId> MaterialProfileIds 
        {
            get { 
                return _materialProfileIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MaterialProfileIds is not allowed to be null"); 
                _materialProfileIds = value;
            }
        }
        private IfcId _compositeProfileId;
        public IfcId CompositeProfileId 
        {
            get { 
                return _compositeProfileId; 
            }
            set { 
                _compositeProfileId = value;  // optional IfcCompositeProfileDef
            }
        }

        public IfcMaterialProfileSet(IfcId id, string name, string description, List<IfcId> materialProfileIds, IfcId compositeProfileId) : base(id)
        {
            Name = name;
            Description = description;
            MaterialProfileIds = materialProfileIds;
            CompositeProfileId = compositeProfileId;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialProfileSet;

        #region Equality

        public bool Equals(IfcMaterialProfileSet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(MaterialProfileIds, other.MaterialProfileIds))
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description
                && CompositeProfileId == other.CompositeProfileId;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialProfileSet);

        public static bool operator ==(IfcMaterialProfileSet one, IfcMaterialProfileSet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialProfileSet one, IfcMaterialProfileSet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(MaterialProfileIds)},{CompositeProfileId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MaterialProfileIds!= null)
                MaterialProfileIds = MaterialProfileIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(CompositeProfileId!= null && replacementTable.ContainsKey(CompositeProfileId))
                CompositeProfileId = replacementTable[CompositeProfileId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialProfileSet (newId,Name, Description, MaterialProfileIds, CompositeProfileId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialProfileSet },
                { "class", nameof(IfcMaterialProfileSet) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        MaterialProfileIds.ToJArray(),
                        CompositeProfileId.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialProfileSet CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialProfileSet(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToOptionalIfcId());
        }
        #endregion

    }
}