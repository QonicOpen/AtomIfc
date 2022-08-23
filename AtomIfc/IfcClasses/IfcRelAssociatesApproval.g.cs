
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
    public class IfcRelAssociatesApproval : IfcRelAssociates, IEquatable<IfcRelAssociatesApproval>
    {
        private IfcId _relatingApprovalId;
        public IfcId RelatingApprovalId 
        {
            get { 
                return _relatingApprovalId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingApprovalId is not allowed to be null"); 
                _relatingApprovalId = value;
            }
        }

        public IfcRelAssociatesApproval(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcId relatingApprovalId) : base(id, ownerHistoryId, name, description, relatedObjectIds)
        {
            RelatingApprovalId = relatingApprovalId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssociatesApproval;

        #region Equality

        public bool Equals(IfcRelAssociatesApproval other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingApprovalId == other.RelatingApprovalId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssociatesApproval);

        public static bool operator ==(IfcRelAssociatesApproval one, IfcRelAssociatesApproval other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssociatesApproval one, IfcRelAssociatesApproval other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},{RelatingApprovalId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingApprovalId!= null && replacementTable.ContainsKey(RelatingApprovalId))
                RelatingApprovalId = replacementTable[RelatingApprovalId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssociatesApproval (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatingApprovalId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssociatesApproval },
                { "class", nameof(IfcRelAssociatesApproval) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatingApprovalId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssociatesApproval CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssociatesApproval(
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