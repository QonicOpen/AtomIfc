
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
    public class IfcOrganizationRelationship : IfcResourceLevelRelationship, IEquatable<IfcOrganizationRelationship>
    {
        private IfcId _relatingOrganizationId;
        public IfcId RelatingOrganizationId 
        {
            get { 
                return _relatingOrganizationId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingOrganizationId is not allowed to be null"); 
                _relatingOrganizationId = value;
            }
        }
        private List<IfcId> _relatedOrganizationIds;
        public List<IfcId> RelatedOrganizationIds 
        {
            get { 
                return _relatedOrganizationIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedOrganizationIds is not allowed to be null"); 
                _relatedOrganizationIds = value;
            }
        }

        public IfcOrganizationRelationship(IfcId id, string name, string description, IfcId relatingOrganizationId, List<IfcId> relatedOrganizationIds) : base(id, name, description)
        {
            RelatingOrganizationId = relatingOrganizationId;
            RelatedOrganizationIds = relatedOrganizationIds;
        }

        public override ClassId GetClassId() => ClassId.IfcOrganizationRelationship;

        #region Equality

        public bool Equals(IfcOrganizationRelationship other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedOrganizationIds, other.RelatedOrganizationIds))
                return false;
            return base.Equals(other)
                && RelatingOrganizationId == other.RelatingOrganizationId;
        }

        public override bool Equals(object other) => Equals(other as IfcOrganizationRelationship);

        public static bool operator ==(IfcOrganizationRelationship one, IfcOrganizationRelationship other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcOrganizationRelationship one, IfcOrganizationRelationship other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{RelatingOrganizationId},{Utils.ConvertListToString(RelatedOrganizationIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingOrganizationId!= null && replacementTable.ContainsKey(RelatingOrganizationId))
                RelatingOrganizationId = replacementTable[RelatingOrganizationId];
            if(RelatedOrganizationIds!= null)
                RelatedOrganizationIds = RelatedOrganizationIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcOrganizationRelationship (newId,Name, Description, RelatingOrganizationId, RelatedOrganizationIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcOrganizationRelationship },
                { "class", nameof(IfcOrganizationRelationship) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingOrganizationId.ToJValue(),
                        RelatedOrganizationIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcOrganizationRelationship CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcOrganizationRelationship(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcIdList());
        }
        #endregion

    }
}