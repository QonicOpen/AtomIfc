
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
    public class IfcRelReferencedInSpatialStructure : IfcRelConnects, IEquatable<IfcRelReferencedInSpatialStructure>
    {
        private List<IfcId> _relatedElementIds;
        public List<IfcId> RelatedElementIds 
        {
            get { 
                return _relatedElementIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedElementIds is not allowed to be null"); 
                _relatedElementIds = value;
            }
        }
        private IfcId _relatingStructureId;
        public IfcId RelatingStructureId 
        {
            get { 
                return _relatingStructureId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingStructureId is not allowed to be null"); 
                _relatingStructureId = value;
            }
        }

        public IfcRelReferencedInSpatialStructure(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedElementIds, IfcId relatingStructureId) : base(id, ownerHistoryId, name, description)
        {
            RelatedElementIds = relatedElementIds;
            RelatingStructureId = relatingStructureId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelReferencedInSpatialStructure;

        #region Equality

        public bool Equals(IfcRelReferencedInSpatialStructure other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedElementIds, other.RelatedElementIds))
                return false;
            return base.Equals(other)
                && RelatingStructureId == other.RelatingStructureId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelReferencedInSpatialStructure);

        public static bool operator ==(IfcRelReferencedInSpatialStructure one, IfcRelReferencedInSpatialStructure other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelReferencedInSpatialStructure one, IfcRelReferencedInSpatialStructure other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedElementIds)},{RelatingStructureId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatedElementIds!= null)
                RelatedElementIds = RelatedElementIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(RelatingStructureId!= null && replacementTable.ContainsKey(RelatingStructureId))
                RelatingStructureId = replacementTable[RelatingStructureId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelReferencedInSpatialStructure (newId,OwnerHistoryId, Name, Description, RelatedElementIds, RelatingStructureId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelReferencedInSpatialStructure },
                { "class", nameof(IfcRelReferencedInSpatialStructure) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedElementIds.ToJArray(),
                        RelatingStructureId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelReferencedInSpatialStructure CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelReferencedInSpatialStructure(
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