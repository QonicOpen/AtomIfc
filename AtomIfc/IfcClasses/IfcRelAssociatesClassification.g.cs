
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
    public class IfcRelAssociatesClassification : IfcRelAssociates, IEquatable<IfcRelAssociatesClassification>
    {
        private IfcId _relatingClassificationId;
        public IfcId RelatingClassificationId 
        {
            get { 
                return _relatingClassificationId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingClassificationId is not allowed to be null"); 
                _relatingClassificationId = value;
            }
        }

        public IfcRelAssociatesClassification(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcId relatingClassificationId) : base(id, ownerHistoryId, name, description, relatedObjectIds)
        {
            RelatingClassificationId = relatingClassificationId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssociatesClassification;

        #region Equality

        public bool Equals(IfcRelAssociatesClassification other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingClassificationId == other.RelatingClassificationId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssociatesClassification);

        public static bool operator ==(IfcRelAssociatesClassification one, IfcRelAssociatesClassification other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssociatesClassification one, IfcRelAssociatesClassification other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},{RelatingClassificationId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingClassificationId!= null && replacementTable.ContainsKey(RelatingClassificationId))
                RelatingClassificationId = replacementTable[RelatingClassificationId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssociatesClassification (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatingClassificationId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssociatesClassification },
                { "class", nameof(IfcRelAssociatesClassification) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatingClassificationId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssociatesClassification CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssociatesClassification(
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