
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
    public class IfcApprovalRelationship : IfcResourceLevelRelationship, IEquatable<IfcApprovalRelationship>
    {
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
        private List<IfcId> _relatedApprovalIds;
        public List<IfcId> RelatedApprovalIds 
        {
            get { 
                return _relatedApprovalIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedApprovalIds is not allowed to be null"); 
                _relatedApprovalIds = value;
            }
        }

        public IfcApprovalRelationship(IfcId id, string name, string description, IfcId relatingApprovalId, List<IfcId> relatedApprovalIds) : base(id, name, description)
        {
            RelatingApprovalId = relatingApprovalId;
            RelatedApprovalIds = relatedApprovalIds;
        }

        public override ClassId GetClassId() => ClassId.IfcApprovalRelationship;

        #region Equality

        public bool Equals(IfcApprovalRelationship other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedApprovalIds, other.RelatedApprovalIds))
                return false;
            return base.Equals(other)
                && RelatingApprovalId == other.RelatingApprovalId;
        }

        public override bool Equals(object other) => Equals(other as IfcApprovalRelationship);

        public static bool operator ==(IfcApprovalRelationship one, IfcApprovalRelationship other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcApprovalRelationship one, IfcApprovalRelationship other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{RelatingApprovalId},{Utils.ConvertListToString(RelatedApprovalIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingApprovalId!= null && replacementTable.ContainsKey(RelatingApprovalId))
                RelatingApprovalId = replacementTable[RelatingApprovalId];
            if(RelatedApprovalIds!= null)
                RelatedApprovalIds = RelatedApprovalIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcApprovalRelationship (newId,Name, Description, RelatingApprovalId, RelatedApprovalIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcApprovalRelationship },
                { "class", nameof(IfcApprovalRelationship) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingApprovalId.ToJValue(),
                        RelatedApprovalIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcApprovalRelationship CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcApprovalRelationship(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcIdList());
        }
        #endregion

    }
}