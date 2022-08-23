
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
    public class IfcRelDeclares : IfcRelationship, IEquatable<IfcRelDeclares>
    {
        private IfcId _relatingContextId;
        public IfcId RelatingContextId 
        {
            get { 
                return _relatingContextId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingContextId is not allowed to be null"); 
                _relatingContextId = value;
            }
        }
        private List<IfcId> _relatedDefinitionIds;
        public List<IfcId> RelatedDefinitionIds 
        {
            get { 
                return _relatedDefinitionIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedDefinitionIds is not allowed to be null"); 
                _relatedDefinitionIds = value;
            }
        }

        public IfcRelDeclares(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingContextId, List<IfcId> relatedDefinitionIds) : base(id, ownerHistoryId, name, description)
        {
            RelatingContextId = relatingContextId;
            RelatedDefinitionIds = relatedDefinitionIds;
        }

        public override ClassId GetClassId() => ClassId.IfcRelDeclares;

        #region Equality

        public bool Equals(IfcRelDeclares other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedDefinitionIds, other.RelatedDefinitionIds))
                return false;
            return base.Equals(other)
                && RelatingContextId == other.RelatingContextId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelDeclares);

        public static bool operator ==(IfcRelDeclares one, IfcRelDeclares other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelDeclares one, IfcRelDeclares other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingContextId},{Utils.ConvertListToString(RelatedDefinitionIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingContextId!= null && replacementTable.ContainsKey(RelatingContextId))
                RelatingContextId = replacementTable[RelatingContextId];
            if(RelatedDefinitionIds!= null)
                RelatedDefinitionIds = RelatedDefinitionIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelDeclares (newId,OwnerHistoryId, Name, Description, RelatingContextId, RelatedDefinitionIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelDeclares },
                { "class", nameof(IfcRelDeclares) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingContextId.ToJValue(),
                        RelatedDefinitionIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcRelDeclares CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelDeclares(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcIdList());
        }
        #endregion

    }
}