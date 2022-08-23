
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
    public class IfcRelAssignsToResource : IfcRelAssigns, IEquatable<IfcRelAssignsToResource>
    {
        private IfcId _relatingResourceId;
        public IfcId RelatingResourceId 
        {
            get { 
                return _relatingResourceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingResourceId is not allowed to be null"); 
                _relatingResourceId = value;
            }
        }

        public IfcRelAssignsToResource(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcObjectTypeEnum relatedObjectsType, IfcId relatingResourceId) : base(id, ownerHistoryId, name, description, relatedObjectIds, relatedObjectsType)
        {
            RelatingResourceId = relatingResourceId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssignsToResource;

        #region Equality

        public bool Equals(IfcRelAssignsToResource other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingResourceId == other.RelatingResourceId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssignsToResource);

        public static bool operator ==(IfcRelAssignsToResource one, IfcRelAssignsToResource other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssignsToResource one, IfcRelAssignsToResource other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},.{RelatedObjectsType}.,{RelatingResourceId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingResourceId!= null && replacementTable.ContainsKey(RelatingResourceId))
                RelatingResourceId = replacementTable[RelatingResourceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssignsToResource (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatedObjectsType, RelatingResourceId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssignsToResource },
                { "class", nameof(IfcRelAssignsToResource) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatedObjectsType.ToJValue(),
                        RelatingResourceId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssignsToResource CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssignsToResource(
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