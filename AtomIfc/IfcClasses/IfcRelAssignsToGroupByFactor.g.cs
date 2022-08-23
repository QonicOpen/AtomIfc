
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
    public class IfcRelAssignsToGroupByFactor : IfcRelAssignsToGroup, IEquatable<IfcRelAssignsToGroupByFactor>
    {
        private double _factor;
        public double Factor 
        {
            get { 
                return _factor; 
            }
            set { 
                _factor = value;
            }
        }

        public IfcRelAssignsToGroupByFactor(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcObjectTypeEnum relatedObjectsType, IfcId relatingGroupId, double factor) : base(id, ownerHistoryId, name, description, relatedObjectIds, relatedObjectsType, relatingGroupId)
        {
            Factor = factor;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssignsToGroupByFactor;

        #region Equality

        public bool Equals(IfcRelAssignsToGroupByFactor other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Factor == other.Factor;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssignsToGroupByFactor);

        public static bool operator ==(IfcRelAssignsToGroupByFactor one, IfcRelAssignsToGroupByFactor other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssignsToGroupByFactor one, IfcRelAssignsToGroupByFactor other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},.{RelatedObjectsType}.,{RelatingGroupId},{Factor})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssignsToGroupByFactor (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatedObjectsType, RelatingGroupId, Factor);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssignsToGroupByFactor },
                { "class", nameof(IfcRelAssignsToGroupByFactor) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatedObjectsType.ToJValue(),
                        RelatingGroupId.ToJValue(),
                        Factor,
                    }
                }
            };
        }

        public static new IfcRelAssignsToGroupByFactor CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssignsToGroupByFactor(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcIdList(),
                (IfcObjectTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcObjectTypeEnum](parameters[4].ToString()),
                parameters[5].ToIfcId(),
                parameters[6].ToDouble());
        }
        #endregion

    }
}