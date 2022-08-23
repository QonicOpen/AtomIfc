
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
    public class IfcRelAssignsToActor : IfcRelAssigns, IEquatable<IfcRelAssignsToActor>
    {
        private IfcId _relatingActorId;
        public IfcId RelatingActorId 
        {
            get { 
                return _relatingActorId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingActorId is not allowed to be null"); 
                _relatingActorId = value;
            }
        }
        private IfcId _actingRoleId;
        public IfcId ActingRoleId 
        {
            get { 
                return _actingRoleId; 
            }
            set { 
                _actingRoleId = value;  // optional IfcActorRole
            }
        }

        public IfcRelAssignsToActor(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcObjectTypeEnum relatedObjectsType, IfcId relatingActorId, IfcId actingRoleId) : base(id, ownerHistoryId, name, description, relatedObjectIds, relatedObjectsType)
        {
            RelatingActorId = relatingActorId;
            ActingRoleId = actingRoleId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssignsToActor;

        #region Equality

        public bool Equals(IfcRelAssignsToActor other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingActorId == other.RelatingActorId
                && ActingRoleId == other.ActingRoleId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssignsToActor);

        public static bool operator ==(IfcRelAssignsToActor one, IfcRelAssignsToActor other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssignsToActor one, IfcRelAssignsToActor other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},.{RelatedObjectsType}.,{RelatingActorId},{ActingRoleId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingActorId!= null && replacementTable.ContainsKey(RelatingActorId))
                RelatingActorId = replacementTable[RelatingActorId];
            if(ActingRoleId!= null && replacementTable.ContainsKey(ActingRoleId))
                ActingRoleId = replacementTable[ActingRoleId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssignsToActor (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatedObjectsType, RelatingActorId, ActingRoleId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssignsToActor },
                { "class", nameof(IfcRelAssignsToActor) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatedObjectsType.ToJValue(),
                        RelatingActorId.ToJValue(),
                        ActingRoleId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssignsToActor CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssignsToActor(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcIdList(),
                (IfcObjectTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcObjectTypeEnum](parameters[4].ToString()),
                parameters[5].ToIfcId(),
                parameters[6].ToOptionalIfcId());
        }
        #endregion

    }
}