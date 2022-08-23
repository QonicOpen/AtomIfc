
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
    public class IfcRelDefinesByType : IfcRelDefines, IEquatable<IfcRelDefinesByType>
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
        private IfcId _relatingTypeId;
        public IfcId RelatingTypeId 
        {
            get { 
                return _relatingTypeId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingTypeId is not allowed to be null"); 
                _relatingTypeId = value;
            }
        }

        public IfcRelDefinesByType(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcId relatingTypeId) : base(id, ownerHistoryId, name, description)
        {
            RelatedObjectIds = relatedObjectIds;
            RelatingTypeId = relatingTypeId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelDefinesByType;

        #region Equality

        public bool Equals(IfcRelDefinesByType other)
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
                && RelatingTypeId == other.RelatingTypeId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelDefinesByType);

        public static bool operator ==(IfcRelDefinesByType one, IfcRelDefinesByType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelDefinesByType one, IfcRelDefinesByType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},{RelatingTypeId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatedObjectIds!= null)
                RelatedObjectIds = RelatedObjectIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(RelatingTypeId!= null && replacementTable.ContainsKey(RelatingTypeId))
                RelatingTypeId = replacementTable[RelatingTypeId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelDefinesByType (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatingTypeId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelDefinesByType },
                { "class", nameof(IfcRelDefinesByType) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatingTypeId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelDefinesByType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelDefinesByType(
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