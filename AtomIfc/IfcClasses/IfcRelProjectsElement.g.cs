
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
    public class IfcRelProjectsElement : IfcRelDecomposes, IEquatable<IfcRelProjectsElement>
    {
        private IfcId _relatingElementId;
        public IfcId RelatingElementId 
        {
            get { 
                return _relatingElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingElementId is not allowed to be null"); 
                _relatingElementId = value;
            }
        }
        private IfcId _relatedFeatureElementId;
        public IfcId RelatedFeatureElementId 
        {
            get { 
                return _relatedFeatureElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedFeatureElementId is not allowed to be null"); 
                _relatedFeatureElementId = value;
            }
        }

        public IfcRelProjectsElement(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingElementId, IfcId relatedFeatureElementId) : base(id, ownerHistoryId, name, description)
        {
            RelatingElementId = relatingElementId;
            RelatedFeatureElementId = relatedFeatureElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelProjectsElement;

        #region Equality

        public bool Equals(IfcRelProjectsElement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingElementId == other.RelatingElementId
                && RelatedFeatureElementId == other.RelatedFeatureElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelProjectsElement);

        public static bool operator ==(IfcRelProjectsElement one, IfcRelProjectsElement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelProjectsElement one, IfcRelProjectsElement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingElementId},{RelatedFeatureElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingElementId!= null && replacementTable.ContainsKey(RelatingElementId))
                RelatingElementId = replacementTable[RelatingElementId];
            if(RelatedFeatureElementId!= null && replacementTable.ContainsKey(RelatedFeatureElementId))
                RelatedFeatureElementId = replacementTable[RelatedFeatureElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelProjectsElement (newId,OwnerHistoryId, Name, Description, RelatingElementId, RelatedFeatureElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelProjectsElement },
                { "class", nameof(IfcRelProjectsElement) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingElementId.ToJValue(),
                        RelatedFeatureElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelProjectsElement CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelProjectsElement(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcId());
        }
        #endregion

    }
}