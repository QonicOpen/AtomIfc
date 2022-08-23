
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
    public class IfcResourceApprovalRelationship : IfcResourceLevelRelationship, IEquatable<IfcResourceApprovalRelationship>
    {
        private List<IfcId> _relatedResourceObjectIds;
        public List<IfcId> RelatedResourceObjectIds 
        {
            get { 
                return _relatedResourceObjectIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedResourceObjectIds is not allowed to be null"); 
                _relatedResourceObjectIds = value;
            }
        }
        private IfcId _relatingApprovalId;
        public IfcId RelatingApprovalId 
        {
            get { 
                return _relatingApprovalId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingApprovalId is not allowed to be null"); 
                _relatingApprovalId = value;
            }
        }

        public IfcResourceApprovalRelationship(IfcId id, string name, string description, List<IfcId> relatedResourceObjectIds, IfcId relatingApprovalId) : base(id, name, description)
        {
            RelatedResourceObjectIds = relatedResourceObjectIds;
            RelatingApprovalId = relatingApprovalId;
        }

        public override ClassId GetClassId() => ClassId.IfcResourceApprovalRelationship;

        #region Equality

        public bool Equals(IfcResourceApprovalRelationship other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedResourceObjectIds, other.RelatedResourceObjectIds))
                return false;
            return base.Equals(other)
                && RelatingApprovalId == other.RelatingApprovalId;
        }

        public override bool Equals(object other) => Equals(other as IfcResourceApprovalRelationship);

        public static bool operator ==(IfcResourceApprovalRelationship one, IfcResourceApprovalRelationship other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcResourceApprovalRelationship one, IfcResourceApprovalRelationship other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(RelatedResourceObjectIds)},{RelatingApprovalId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatedResourceObjectIds!= null)
                RelatedResourceObjectIds = RelatedResourceObjectIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(RelatingApprovalId!= null && replacementTable.ContainsKey(RelatingApprovalId))
                RelatingApprovalId = replacementTable[RelatingApprovalId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcResourceApprovalRelationship (newId,Name, Description, RelatedResourceObjectIds, RelatingApprovalId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcResourceApprovalRelationship },
                { "class", nameof(IfcResourceApprovalRelationship) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedResourceObjectIds.ToJArray(),
                        RelatingApprovalId.ToJValue(),
                    }
                }
            };
        }

        public static IfcResourceApprovalRelationship CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcResourceApprovalRelationship(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToIfcId());
        }
        #endregion

    }
}