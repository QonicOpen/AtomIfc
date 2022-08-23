
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
    public class IfcResourceConstraintRelationship : IfcResourceLevelRelationship, IEquatable<IfcResourceConstraintRelationship>
    {
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
        private List<IfcId> _relatedResourceObjectIds;
        public List<IfcId> RelatedResourceObjectIds 
        {
            get { 
                return _relatedResourceObjectIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedResourceObjectIds is not allowed to be null"); 
                _relatedResourceObjectIds = value;
            }
        }

        public IfcResourceConstraintRelationship(IfcId id, string name, string description, IfcId relatingConstraintId, List<IfcId> relatedResourceObjectIds) : base(id, name, description)
        {
            RelatingConstraintId = relatingConstraintId;
            RelatedResourceObjectIds = relatedResourceObjectIds;
        }

        public override ClassId GetClassId() => ClassId.IfcResourceConstraintRelationship;

        #region Equality

        public bool Equals(IfcResourceConstraintRelationship other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedResourceObjectIds, other.RelatedResourceObjectIds))
                return false;
            return base.Equals(other)
                && RelatingConstraintId == other.RelatingConstraintId;
        }

        public override bool Equals(object other) => Equals(other as IfcResourceConstraintRelationship);

        public static bool operator ==(IfcResourceConstraintRelationship one, IfcResourceConstraintRelationship other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcResourceConstraintRelationship one, IfcResourceConstraintRelationship other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{RelatingConstraintId},{Utils.ConvertListToString(RelatedResourceObjectIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingConstraintId!= null && replacementTable.ContainsKey(RelatingConstraintId))
                RelatingConstraintId = replacementTable[RelatingConstraintId];
            if(RelatedResourceObjectIds!= null)
                RelatedResourceObjectIds = RelatedResourceObjectIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcResourceConstraintRelationship (newId,Name, Description, RelatingConstraintId, RelatedResourceObjectIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcResourceConstraintRelationship },
                { "class", nameof(IfcResourceConstraintRelationship) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingConstraintId.ToJValue(),
                        RelatedResourceObjectIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcResourceConstraintRelationship CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcResourceConstraintRelationship(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcIdList());
        }
        #endregion

    }
}