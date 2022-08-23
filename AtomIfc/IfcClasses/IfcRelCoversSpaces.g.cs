
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
    public class IfcRelCoversSpaces : IfcRelConnects, IEquatable<IfcRelCoversSpaces>
    {
        private IfcId _relatingSpaceId;
        public IfcId RelatingSpaceId 
        {
            get { 
                return _relatingSpaceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingSpaceId is not allowed to be null"); 
                _relatingSpaceId = value;
            }
        }
        private List<IfcId> _relatedCoveringIds;
        public List<IfcId> RelatedCoveringIds 
        {
            get { 
                return _relatedCoveringIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedCoveringIds is not allowed to be null"); 
                _relatedCoveringIds = value;
            }
        }

        public IfcRelCoversSpaces(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingSpaceId, List<IfcId> relatedCoveringIds) : base(id, ownerHistoryId, name, description)
        {
            RelatingSpaceId = relatingSpaceId;
            RelatedCoveringIds = relatedCoveringIds;
        }

        public override ClassId GetClassId() => ClassId.IfcRelCoversSpaces;

        #region Equality

        public bool Equals(IfcRelCoversSpaces other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedCoveringIds, other.RelatedCoveringIds))
                return false;
            return base.Equals(other)
                && RelatingSpaceId == other.RelatingSpaceId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelCoversSpaces);

        public static bool operator ==(IfcRelCoversSpaces one, IfcRelCoversSpaces other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelCoversSpaces one, IfcRelCoversSpaces other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingSpaceId},{Utils.ConvertListToString(RelatedCoveringIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingSpaceId!= null && replacementTable.ContainsKey(RelatingSpaceId))
                RelatingSpaceId = replacementTable[RelatingSpaceId];
            if(RelatedCoveringIds!= null)
                RelatedCoveringIds = RelatedCoveringIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelCoversSpaces (newId,OwnerHistoryId, Name, Description, RelatingSpaceId, RelatedCoveringIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelCoversSpaces },
                { "class", nameof(IfcRelCoversSpaces) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingSpaceId.ToJValue(),
                        RelatedCoveringIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcRelCoversSpaces CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelCoversSpaces(
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