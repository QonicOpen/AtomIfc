
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
    public class IfcRelAssignsToGroup : IfcRelAssigns, IEquatable<IfcRelAssignsToGroup>
    {
        private IfcId _relatingGroupId;
        public IfcId RelatingGroupId 
        {
            get { 
                return _relatingGroupId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingGroupId is not allowed to be null"); 
                _relatingGroupId = value;
            }
        }

        public IfcRelAssignsToGroup(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcObjectTypeEnum relatedObjectsType, IfcId relatingGroupId) : base(id, ownerHistoryId, name, description, relatedObjectIds, relatedObjectsType)
        {
            RelatingGroupId = relatingGroupId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssignsToGroup;

        #region Equality

        public bool Equals(IfcRelAssignsToGroup other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingGroupId == other.RelatingGroupId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssignsToGroup);

        public static bool operator ==(IfcRelAssignsToGroup one, IfcRelAssignsToGroup other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssignsToGroup one, IfcRelAssignsToGroup other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},.{RelatedObjectsType}.,{RelatingGroupId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingGroupId!= null && replacementTable.ContainsKey(RelatingGroupId))
                RelatingGroupId = replacementTable[RelatingGroupId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssignsToGroup (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatedObjectsType, RelatingGroupId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssignsToGroup },
                { "class", nameof(IfcRelAssignsToGroup) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatedObjectsType.ToJValue(),
                        RelatingGroupId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssignsToGroup CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssignsToGroup(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcIdList(),
                (IfcObjectTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcObjectTypeEnum](parameters[4].ToString()),
                parameters[5].ToIfcId());
        }
        #endregion

    }
}