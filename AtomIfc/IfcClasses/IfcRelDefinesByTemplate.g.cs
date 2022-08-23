
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
    public class IfcRelDefinesByTemplate : IfcRelDefines, IEquatable<IfcRelDefinesByTemplate>
    {
        private List<IfcId> _relatedPropertySetIds;
        public List<IfcId> RelatedPropertySetIds 
        {
            get { 
                return _relatedPropertySetIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedPropertySetIds is not allowed to be null"); 
                _relatedPropertySetIds = value;
            }
        }
        private IfcId _relatingTemplateId;
        public IfcId RelatingTemplateId 
        {
            get { 
                return _relatingTemplateId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingTemplateId is not allowed to be null"); 
                _relatingTemplateId = value;
            }
        }

        public IfcRelDefinesByTemplate(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedPropertySetIds, IfcId relatingTemplateId) : base(id, ownerHistoryId, name, description)
        {
            RelatedPropertySetIds = relatedPropertySetIds;
            RelatingTemplateId = relatingTemplateId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelDefinesByTemplate;

        #region Equality

        public bool Equals(IfcRelDefinesByTemplate other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedPropertySetIds, other.RelatedPropertySetIds))
                return false;
            return base.Equals(other)
                && RelatingTemplateId == other.RelatingTemplateId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelDefinesByTemplate);

        public static bool operator ==(IfcRelDefinesByTemplate one, IfcRelDefinesByTemplate other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelDefinesByTemplate one, IfcRelDefinesByTemplate other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedPropertySetIds)},{RelatingTemplateId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatedPropertySetIds!= null)
                RelatedPropertySetIds = RelatedPropertySetIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(RelatingTemplateId!= null && replacementTable.ContainsKey(RelatingTemplateId))
                RelatingTemplateId = replacementTable[RelatingTemplateId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelDefinesByTemplate (newId,OwnerHistoryId, Name, Description, RelatedPropertySetIds, RelatingTemplateId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelDefinesByTemplate },
                { "class", nameof(IfcRelDefinesByTemplate) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedPropertySetIds.ToJArray(),
                        RelatingTemplateId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelDefinesByTemplate CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelDefinesByTemplate(
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