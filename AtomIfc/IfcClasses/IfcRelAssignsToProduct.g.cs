
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
    public class IfcRelAssignsToProduct : IfcRelAssigns, IEquatable<IfcRelAssignsToProduct>
    {
        private IfcId _relatingProductId;
        public IfcId RelatingProductId 
        {
            get { 
                return _relatingProductId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingProductId is not allowed to be null"); 
                _relatingProductId = value;
            }
        }

        public IfcRelAssignsToProduct(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcObjectTypeEnum relatedObjectsType, IfcId relatingProductId) : base(id, ownerHistoryId, name, description, relatedObjectIds, relatedObjectsType)
        {
            RelatingProductId = relatingProductId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssignsToProduct;

        #region Equality

        public bool Equals(IfcRelAssignsToProduct other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingProductId == other.RelatingProductId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssignsToProduct);

        public static bool operator ==(IfcRelAssignsToProduct one, IfcRelAssignsToProduct other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssignsToProduct one, IfcRelAssignsToProduct other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},.{RelatedObjectsType}.,{RelatingProductId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingProductId!= null && replacementTable.ContainsKey(RelatingProductId))
                RelatingProductId = replacementTable[RelatingProductId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssignsToProduct (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatedObjectsType, RelatingProductId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssignsToProduct },
                { "class", nameof(IfcRelAssignsToProduct) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatedObjectsType.ToJValue(),
                        RelatingProductId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssignsToProduct CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssignsToProduct(
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