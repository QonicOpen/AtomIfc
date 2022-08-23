
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
    public class IfcRelFillsElement : IfcRelConnects, IEquatable<IfcRelFillsElement>
    {
        private IfcId _relatingOpeningElementId;
        public IfcId RelatingOpeningElementId 
        {
            get { 
                return _relatingOpeningElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingOpeningElementId is not allowed to be null"); 
                _relatingOpeningElementId = value;
            }
        }
        private IfcId _relatedBuildingElementId;
        public IfcId RelatedBuildingElementId 
        {
            get { 
                return _relatedBuildingElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedBuildingElementId is not allowed to be null"); 
                _relatedBuildingElementId = value;
            }
        }

        public IfcRelFillsElement(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingOpeningElementId, IfcId relatedBuildingElementId) : base(id, ownerHistoryId, name, description)
        {
            RelatingOpeningElementId = relatingOpeningElementId;
            RelatedBuildingElementId = relatedBuildingElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelFillsElement;

        #region Equality

        public bool Equals(IfcRelFillsElement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingOpeningElementId == other.RelatingOpeningElementId
                && RelatedBuildingElementId == other.RelatedBuildingElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelFillsElement);

        public static bool operator ==(IfcRelFillsElement one, IfcRelFillsElement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelFillsElement one, IfcRelFillsElement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingOpeningElementId},{RelatedBuildingElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingOpeningElementId!= null && replacementTable.ContainsKey(RelatingOpeningElementId))
                RelatingOpeningElementId = replacementTable[RelatingOpeningElementId];
            if(RelatedBuildingElementId!= null && replacementTable.ContainsKey(RelatedBuildingElementId))
                RelatedBuildingElementId = replacementTable[RelatedBuildingElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelFillsElement (newId,OwnerHistoryId, Name, Description, RelatingOpeningElementId, RelatedBuildingElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelFillsElement },
                { "class", nameof(IfcRelFillsElement) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingOpeningElementId.ToJValue(),
                        RelatedBuildingElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelFillsElement CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelFillsElement(
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