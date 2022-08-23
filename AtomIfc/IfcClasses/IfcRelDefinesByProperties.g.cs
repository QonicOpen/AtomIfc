
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
    public class IfcRelDefinesByProperties : IfcRelDefines, IEquatable<IfcRelDefinesByProperties>
    {
        private List<IfcId> _relatedObjectIds;
        public List<IfcId> RelatedObjectIds 
        {
            get { 
                return _relatedObjectIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedObjectIds is not allowed to be null"); 
                _relatedObjectIds = value;
            }
        }
        private IfcId _relatingPropertyDefinitionId;
        public IfcId RelatingPropertyDefinitionId 
        {
            get { 
                return _relatingPropertyDefinitionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingPropertyDefinitionId is not allowed to be null"); 
                _relatingPropertyDefinitionId = value;
            }
        }

        public IfcRelDefinesByProperties(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcId relatingPropertyDefinitionId) : base(id, ownerHistoryId, name, description)
        {
            RelatedObjectIds = relatedObjectIds;
            RelatingPropertyDefinitionId = relatingPropertyDefinitionId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelDefinesByProperties;

        #region Equality

        public bool Equals(IfcRelDefinesByProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedObjectIds, other.RelatedObjectIds))
                return false;
            return base.Equals(other)
                && RelatingPropertyDefinitionId == other.RelatingPropertyDefinitionId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelDefinesByProperties);

        public static bool operator ==(IfcRelDefinesByProperties one, IfcRelDefinesByProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelDefinesByProperties one, IfcRelDefinesByProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},{RelatingPropertyDefinitionId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatedObjectIds!= null)
                RelatedObjectIds = RelatedObjectIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(RelatingPropertyDefinitionId!= null && replacementTable.ContainsKey(RelatingPropertyDefinitionId))
                RelatingPropertyDefinitionId = replacementTable[RelatingPropertyDefinitionId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelDefinesByProperties (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatingPropertyDefinitionId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelDefinesByProperties },
                { "class", nameof(IfcRelDefinesByProperties) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatingPropertyDefinitionId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelDefinesByProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelDefinesByProperties(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcIdList(),
                parameters[4].ToIfcId());
        }
        #endregion

    }
}