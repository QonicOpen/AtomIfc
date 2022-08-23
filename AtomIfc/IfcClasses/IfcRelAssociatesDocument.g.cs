
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
    public class IfcRelAssociatesDocument : IfcRelAssociates, IEquatable<IfcRelAssociatesDocument>
    {
        private IfcId _relatingDocumentId;
        public IfcId RelatingDocumentId 
        {
            get { 
                return _relatingDocumentId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingDocumentId is not allowed to be null"); 
                _relatingDocumentId = value;
            }
        }

        public IfcRelAssociatesDocument(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcId relatingDocumentId) : base(id, ownerHistoryId, name, description, relatedObjectIds)
        {
            RelatingDocumentId = relatingDocumentId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssociatesDocument;

        #region Equality

        public bool Equals(IfcRelAssociatesDocument other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingDocumentId == other.RelatingDocumentId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssociatesDocument);

        public static bool operator ==(IfcRelAssociatesDocument one, IfcRelAssociatesDocument other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssociatesDocument one, IfcRelAssociatesDocument other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},{RelatingDocumentId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingDocumentId!= null && replacementTable.ContainsKey(RelatingDocumentId))
                RelatingDocumentId = replacementTable[RelatingDocumentId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssociatesDocument (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatingDocumentId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssociatesDocument },
                { "class", nameof(IfcRelAssociatesDocument) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatingDocumentId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssociatesDocument CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssociatesDocument(
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