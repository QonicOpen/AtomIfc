
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
    public class IfcRelAssignsToControl : IfcRelAssigns, IEquatable<IfcRelAssignsToControl>
    {
        private IfcId _relatingControlId;
        public IfcId RelatingControlId 
        {
            get { 
                return _relatingControlId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingControlId is not allowed to be null"); 
                _relatingControlId = value;
            }
        }

        public IfcRelAssignsToControl(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcObjectTypeEnum relatedObjectsType, IfcId relatingControlId) : base(id, ownerHistoryId, name, description, relatedObjectIds, relatedObjectsType)
        {
            RelatingControlId = relatingControlId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssignsToControl;

        #region Equality

        public bool Equals(IfcRelAssignsToControl other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingControlId == other.RelatingControlId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssignsToControl);

        public static bool operator ==(IfcRelAssignsToControl one, IfcRelAssignsToControl other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssignsToControl one, IfcRelAssignsToControl other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},.{RelatedObjectsType}.,{RelatingControlId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingControlId!= null && replacementTable.ContainsKey(RelatingControlId))
                RelatingControlId = replacementTable[RelatingControlId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssignsToControl (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatedObjectsType, RelatingControlId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssignsToControl },
                { "class", nameof(IfcRelAssignsToControl) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatedObjectsType.ToJValue(),
                        RelatingControlId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssignsToControl CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssignsToControl(
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