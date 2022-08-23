
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
    public class IfcRelFlowControlElements : IfcRelConnects, IEquatable<IfcRelFlowControlElements>
    {
        private List<IfcId> _relatedControlElementIds;
        public List<IfcId> RelatedControlElementIds 
        {
            get { 
                return _relatedControlElementIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedControlElementIds is not allowed to be null"); 
                _relatedControlElementIds = value;
            }
        }
        private IfcId _relatingFlowElementId;
        public IfcId RelatingFlowElementId 
        {
            get { 
                return _relatingFlowElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingFlowElementId is not allowed to be null"); 
                _relatingFlowElementId = value;
            }
        }

        public IfcRelFlowControlElements(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedControlElementIds, IfcId relatingFlowElementId) : base(id, ownerHistoryId, name, description)
        {
            RelatedControlElementIds = relatedControlElementIds;
            RelatingFlowElementId = relatingFlowElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelFlowControlElements;

        #region Equality

        public bool Equals(IfcRelFlowControlElements other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedControlElementIds, other.RelatedControlElementIds))
                return false;
            return base.Equals(other)
                && RelatingFlowElementId == other.RelatingFlowElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelFlowControlElements);

        public static bool operator ==(IfcRelFlowControlElements one, IfcRelFlowControlElements other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelFlowControlElements one, IfcRelFlowControlElements other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedControlElementIds)},{RelatingFlowElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatedControlElementIds!= null)
                RelatedControlElementIds = RelatedControlElementIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(RelatingFlowElementId!= null && replacementTable.ContainsKey(RelatingFlowElementId))
                RelatingFlowElementId = replacementTable[RelatingFlowElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelFlowControlElements (newId,OwnerHistoryId, Name, Description, RelatedControlElementIds, RelatingFlowElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelFlowControlElements },
                { "class", nameof(IfcRelFlowControlElements) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedControlElementIds.ToJArray(),
                        RelatingFlowElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelFlowControlElements CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelFlowControlElements(
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