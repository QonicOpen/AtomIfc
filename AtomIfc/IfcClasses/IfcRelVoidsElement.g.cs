
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
    public class IfcRelVoidsElement : IfcRelDecomposes, IEquatable<IfcRelVoidsElement>
    {
        private IfcId _relatingBuildingElementId;
        public IfcId RelatingBuildingElementId 
        {
            get { 
                return _relatingBuildingElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingBuildingElementId is not allowed to be null"); 
                _relatingBuildingElementId = value;
            }
        }
        private IfcId _relatedOpeningElementId;
        public IfcId RelatedOpeningElementId 
        {
            get { 
                return _relatedOpeningElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedOpeningElementId is not allowed to be null"); 
                _relatedOpeningElementId = value;
            }
        }

        public IfcRelVoidsElement(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingBuildingElementId, IfcId relatedOpeningElementId) : base(id, ownerHistoryId, name, description)
        {
            RelatingBuildingElementId = relatingBuildingElementId;
            RelatedOpeningElementId = relatedOpeningElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelVoidsElement;

        #region Equality

        public bool Equals(IfcRelVoidsElement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingBuildingElementId == other.RelatingBuildingElementId
                && RelatedOpeningElementId == other.RelatedOpeningElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelVoidsElement);

        public static bool operator ==(IfcRelVoidsElement one, IfcRelVoidsElement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelVoidsElement one, IfcRelVoidsElement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingBuildingElementId},{RelatedOpeningElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingBuildingElementId!= null && replacementTable.ContainsKey(RelatingBuildingElementId))
                RelatingBuildingElementId = replacementTable[RelatingBuildingElementId];
            if(RelatedOpeningElementId!= null && replacementTable.ContainsKey(RelatedOpeningElementId))
                RelatedOpeningElementId = replacementTable[RelatedOpeningElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelVoidsElement (newId,OwnerHistoryId, Name, Description, RelatingBuildingElementId, RelatedOpeningElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelVoidsElement },
                { "class", nameof(IfcRelVoidsElement) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingBuildingElementId.ToJValue(),
                        RelatedOpeningElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelVoidsElement CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelVoidsElement(
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