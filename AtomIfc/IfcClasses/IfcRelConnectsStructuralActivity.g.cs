
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
    public class IfcRelConnectsStructuralActivity : IfcRelConnects, IEquatable<IfcRelConnectsStructuralActivity>
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
        private IfcId _relatedStructuralActivityId;
        public IfcId RelatedStructuralActivityId 
        {
            get { 
                return _relatedStructuralActivityId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedStructuralActivityId is not allowed to be null"); 
                _relatedStructuralActivityId = value;
            }
        }

        public IfcRelConnectsStructuralActivity(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingElementId, IfcId relatedStructuralActivityId) : base(id, ownerHistoryId, name, description)
        {
            RelatingElementId = relatingElementId;
            RelatedStructuralActivityId = relatedStructuralActivityId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelConnectsStructuralActivity;

        #region Equality

        public bool Equals(IfcRelConnectsStructuralActivity other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingElementId == other.RelatingElementId
                && RelatedStructuralActivityId == other.RelatedStructuralActivityId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelConnectsStructuralActivity);

        public static bool operator ==(IfcRelConnectsStructuralActivity one, IfcRelConnectsStructuralActivity other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelConnectsStructuralActivity one, IfcRelConnectsStructuralActivity other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingElementId},{RelatedStructuralActivityId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingElementId!= null && replacementTable.ContainsKey(RelatingElementId))
                RelatingElementId = replacementTable[RelatingElementId];
            if(RelatedStructuralActivityId!= null && replacementTable.ContainsKey(RelatedStructuralActivityId))
                RelatedStructuralActivityId = replacementTable[RelatedStructuralActivityId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelConnectsStructuralActivity (newId,OwnerHistoryId, Name, Description, RelatingElementId, RelatedStructuralActivityId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelConnectsStructuralActivity },
                { "class", nameof(IfcRelConnectsStructuralActivity) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingElementId.ToJValue(),
                        RelatedStructuralActivityId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelConnectsStructuralActivity CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelConnectsStructuralActivity(
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