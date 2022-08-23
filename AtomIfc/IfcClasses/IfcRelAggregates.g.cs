
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
    public class IfcRelAggregates : IfcRelDecomposes, IEquatable<IfcRelAggregates>
    {
        private IfcId _relatingObjectId;
        public IfcId RelatingObjectId 
        {
            get { 
                return _relatingObjectId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingObjectId is not allowed to be null"); 
                _relatingObjectId = value;
            }
        }
        private List<IfcId> _relatedObjectIds;
        public List<IfcId> RelatedObjectIds 
        {
            get { 
                return _relatedObjectIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedObjectIds is not allowed to be null"); 
                _relatedObjectIds = value;
            }
        }

        public IfcRelAggregates(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingObjectId, List<IfcId> relatedObjectIds) : base(id, ownerHistoryId, name, description)
        {
            RelatingObjectId = relatingObjectId;
            RelatedObjectIds = relatedObjectIds;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAggregates;

        #region Equality

        public bool Equals(IfcRelAggregates other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedObjectIds, other.RelatedObjectIds))
                return false;
            return base.Equals(other)
                && RelatingObjectId == other.RelatingObjectId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAggregates);

        public static bool operator ==(IfcRelAggregates one, IfcRelAggregates other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAggregates one, IfcRelAggregates other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingObjectId},{Utils.ConvertListToString(RelatedObjectIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingObjectId!= null && replacementTable.ContainsKey(RelatingObjectId))
                RelatingObjectId = replacementTable[RelatingObjectId];
            if(RelatedObjectIds!= null)
                RelatedObjectIds = RelatedObjectIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAggregates (newId,OwnerHistoryId, Name, Description, RelatingObjectId, RelatedObjectIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAggregates },
                { "class", nameof(IfcRelAggregates) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingObjectId.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcRelAggregates CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAggregates(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcIdList());
        }
        #endregion

    }
}