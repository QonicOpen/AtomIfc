
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
    public class IfcDocumentInformationRelationship : IfcResourceLevelRelationship, IEquatable<IfcDocumentInformationRelationship>
    {
        private IfcId _relatingDocumentId;
        public IfcId RelatingDocumentId 
        {
            get { 
                return _relatingDocumentId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingDocumentId is not allowed to be null"); 
                _relatingDocumentId = value;
            }
        }
        private List<IfcId> _relatedDocumentIds;
        public List<IfcId> RelatedDocumentIds 
        {
            get { 
                return _relatedDocumentIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedDocumentIds is not allowed to be null"); 
                _relatedDocumentIds = value;
            }
        }
        private string _relationshipType;
        public string RelationshipType 
        {
            get { 
                return _relationshipType; 
            }
            set { 
                _relationshipType = value;  // optional IfcLabel
            }
        }

        public IfcDocumentInformationRelationship(IfcId id, string name, string description, IfcId relatingDocumentId, List<IfcId> relatedDocumentIds, string relationshipType) : base(id, name, description)
        {
            RelatingDocumentId = relatingDocumentId;
            RelatedDocumentIds = relatedDocumentIds;
            RelationshipType = relationshipType;
        }

        public override ClassId GetClassId() => ClassId.IfcDocumentInformationRelationship;

        #region Equality

        public bool Equals(IfcDocumentInformationRelationship other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedDocumentIds, other.RelatedDocumentIds))
                return false;
            return base.Equals(other)
                && RelatingDocumentId == other.RelatingDocumentId
                && RelationshipType == other.RelationshipType;
        }

        public override bool Equals(object other) => Equals(other as IfcDocumentInformationRelationship);

        public static bool operator ==(IfcDocumentInformationRelationship one, IfcDocumentInformationRelationship other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDocumentInformationRelationship one, IfcDocumentInformationRelationship other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{RelatingDocumentId},{Utils.ConvertListToString(RelatedDocumentIds)},'{RelationshipType}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingDocumentId!= null && replacementTable.ContainsKey(RelatingDocumentId))
                RelatingDocumentId = replacementTable[RelatingDocumentId];
            if(RelatedDocumentIds!= null)
                RelatedDocumentIds = RelatedDocumentIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDocumentInformationRelationship (newId,Name, Description, RelatingDocumentId, RelatedDocumentIds, RelationshipType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDocumentInformationRelationship },
                { "class", nameof(IfcDocumentInformationRelationship) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingDocumentId.ToJValue(),
                        RelatedDocumentIds.ToJArray(),
                        RelationshipType.ToJValue(),
                    }
                }
            };
        }

        public static IfcDocumentInformationRelationship CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDocumentInformationRelationship(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcIdList(),
                parameters[4].ToOptionalString());
        }
        #endregion

    }
}