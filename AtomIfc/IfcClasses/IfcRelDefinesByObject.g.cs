
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
    public class IfcRelDefinesByObject : IfcRelDefines, IEquatable<IfcRelDefinesByObject>
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
        private IfcId _relatingObjectId;
        public IfcId RelatingObjectId 
        {
            get { 
                return _relatingObjectId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingObjectId is not allowed to be null"); 
                _relatingObjectId = value;
            }
        }

        public IfcRelDefinesByObject(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcId relatingObjectId) : base(id, ownerHistoryId, name, description)
        {
            RelatedObjectIds = relatedObjectIds;
            RelatingObjectId = relatingObjectId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelDefinesByObject;

        #region Equality

        public bool Equals(IfcRelDefinesByObject other)
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
                && RelatingObjectId == other.RelatingObjectId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelDefinesByObject);

        public static bool operator ==(IfcRelDefinesByObject one, IfcRelDefinesByObject other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelDefinesByObject one, IfcRelDefinesByObject other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},{RelatingObjectId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatedObjectIds!= null)
                RelatedObjectIds = RelatedObjectIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(RelatingObjectId!= null && replacementTable.ContainsKey(RelatingObjectId))
                RelatingObjectId = replacementTable[RelatingObjectId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelDefinesByObject (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatingObjectId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelDefinesByObject },
                { "class", nameof(IfcRelDefinesByObject) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatingObjectId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelDefinesByObject CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelDefinesByObject(
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