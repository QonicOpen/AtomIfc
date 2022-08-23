
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
    public class IfcRelConnectsPortToElement : IfcRelConnects, IEquatable<IfcRelConnectsPortToElement>
    {
        private IfcId _relatingPortId;
        public IfcId RelatingPortId 
        {
            get { 
                return _relatingPortId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingPortId is not allowed to be null"); 
                _relatingPortId = value;
            }
        }
        private IfcId _relatedElementId;
        public IfcId RelatedElementId 
        {
            get { 
                return _relatedElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedElementId is not allowed to be null"); 
                _relatedElementId = value;
            }
        }

        public IfcRelConnectsPortToElement(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingPortId, IfcId relatedElementId) : base(id, ownerHistoryId, name, description)
        {
            RelatingPortId = relatingPortId;
            RelatedElementId = relatedElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelConnectsPortToElement;

        #region Equality

        public bool Equals(IfcRelConnectsPortToElement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingPortId == other.RelatingPortId
                && RelatedElementId == other.RelatedElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelConnectsPortToElement);

        public static bool operator ==(IfcRelConnectsPortToElement one, IfcRelConnectsPortToElement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelConnectsPortToElement one, IfcRelConnectsPortToElement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingPortId},{RelatedElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingPortId!= null && replacementTable.ContainsKey(RelatingPortId))
                RelatingPortId = replacementTable[RelatingPortId];
            if(RelatedElementId!= null && replacementTable.ContainsKey(RelatedElementId))
                RelatedElementId = replacementTable[RelatedElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelConnectsPortToElement (newId,OwnerHistoryId, Name, Description, RelatingPortId, RelatedElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelConnectsPortToElement },
                { "class", nameof(IfcRelConnectsPortToElement) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingPortId.ToJValue(),
                        RelatedElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelConnectsPortToElement CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelConnectsPortToElement(
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