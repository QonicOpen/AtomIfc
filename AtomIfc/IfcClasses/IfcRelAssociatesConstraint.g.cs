
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
    public class IfcRelAssociatesConstraint : IfcRelAssociates, IEquatable<IfcRelAssociatesConstraint>
    {
        private string _intent;
        public string Intent 
        {
            get { 
                return _intent; 
            }
            set { 
                _intent = value;  // optional IfcLabel
            }
        }
        private IfcId _relatingConstraintId;
        public IfcId RelatingConstraintId 
        {
            get { 
                return _relatingConstraintId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingConstraintId is not allowed to be null"); 
                _relatingConstraintId = value;
            }
        }

        public IfcRelAssociatesConstraint(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, string intent, IfcId relatingConstraintId) : base(id, ownerHistoryId, name, description, relatedObjectIds)
        {
            Intent = intent;
            RelatingConstraintId = relatingConstraintId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssociatesConstraint;

        #region Equality

        public bool Equals(IfcRelAssociatesConstraint other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Intent == other.Intent
                && RelatingConstraintId == other.RelatingConstraintId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssociatesConstraint);

        public static bool operator ==(IfcRelAssociatesConstraint one, IfcRelAssociatesConstraint other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssociatesConstraint one, IfcRelAssociatesConstraint other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},'{Intent}',{RelatingConstraintId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingConstraintId!= null && replacementTable.ContainsKey(RelatingConstraintId))
                RelatingConstraintId = replacementTable[RelatingConstraintId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssociatesConstraint (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, Intent, RelatingConstraintId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssociatesConstraint },
                { "class", nameof(IfcRelAssociatesConstraint) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        Intent.ToJValue(),
                        RelatingConstraintId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssociatesConstraint CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssociatesConstraint(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcIdList(),
                parameters[4].ToOptionalString(),
                parameters[5].ToIfcId());
        }
        #endregion

    }
}