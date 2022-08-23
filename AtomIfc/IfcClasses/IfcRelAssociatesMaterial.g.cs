
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
    public class IfcRelAssociatesMaterial : IfcRelAssociates, IEquatable<IfcRelAssociatesMaterial>
    {
        private IfcId _relatingMaterialId;
        public IfcId RelatingMaterialId 
        {
            get { 
                return _relatingMaterialId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingMaterialId is not allowed to be null"); 
                _relatingMaterialId = value;
            }
        }

        public IfcRelAssociatesMaterial(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcId relatingMaterialId) : base(id, ownerHistoryId, name, description, relatedObjectIds)
        {
            RelatingMaterialId = relatingMaterialId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssociatesMaterial;

        #region Equality

        public bool Equals(IfcRelAssociatesMaterial other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingMaterialId == other.RelatingMaterialId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssociatesMaterial);

        public static bool operator ==(IfcRelAssociatesMaterial one, IfcRelAssociatesMaterial other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssociatesMaterial one, IfcRelAssociatesMaterial other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},{RelatingMaterialId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingMaterialId!= null && replacementTable.ContainsKey(RelatingMaterialId))
                RelatingMaterialId = replacementTable[RelatingMaterialId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssociatesMaterial (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatingMaterialId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssociatesMaterial },
                { "class", nameof(IfcRelAssociatesMaterial) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatingMaterialId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssociatesMaterial CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssociatesMaterial(
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