
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
    public class IfcRelCoversBldgElements : IfcRelConnects, IEquatable<IfcRelCoversBldgElements>
    {
        private IfcId _relatingBuildingElementId;
        public IfcId RelatingBuildingElementId 
        {
            get { 
                return _relatingBuildingElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingBuildingElementId is not allowed to be null"); 
                _relatingBuildingElementId = value;
            }
        }
        private List<IfcId> _relatedCoveringIds;
        public List<IfcId> RelatedCoveringIds 
        {
            get { 
                return _relatedCoveringIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedCoveringIds is not allowed to be null"); 
                _relatedCoveringIds = value;
            }
        }

        public IfcRelCoversBldgElements(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingBuildingElementId, List<IfcId> relatedCoveringIds) : base(id, ownerHistoryId, name, description)
        {
            RelatingBuildingElementId = relatingBuildingElementId;
            RelatedCoveringIds = relatedCoveringIds;
        }

        public override ClassId GetClassId() => ClassId.IfcRelCoversBldgElements;

        #region Equality

        public bool Equals(IfcRelCoversBldgElements other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedCoveringIds, other.RelatedCoveringIds))
                return false;
            return base.Equals(other)
                && RelatingBuildingElementId == other.RelatingBuildingElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelCoversBldgElements);

        public static bool operator ==(IfcRelCoversBldgElements one, IfcRelCoversBldgElements other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelCoversBldgElements one, IfcRelCoversBldgElements other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingBuildingElementId},{Utils.ConvertListToString(RelatedCoveringIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingBuildingElementId!= null && replacementTable.ContainsKey(RelatingBuildingElementId))
                RelatingBuildingElementId = replacementTable[RelatingBuildingElementId];
            if(RelatedCoveringIds!= null)
                RelatedCoveringIds = RelatedCoveringIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelCoversBldgElements (newId,OwnerHistoryId, Name, Description, RelatingBuildingElementId, RelatedCoveringIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelCoversBldgElements },
                { "class", nameof(IfcRelCoversBldgElements) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingBuildingElementId.ToJValue(),
                        RelatedCoveringIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcRelCoversBldgElements CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelCoversBldgElements(
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