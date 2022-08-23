
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
    public class IfcExternalReferenceRelationship : IfcResourceLevelRelationship, IEquatable<IfcExternalReferenceRelationship>
    {
        private IfcId _relatingReferenceId;
        public IfcId RelatingReferenceId 
        {
            get { 
                return _relatingReferenceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingReferenceId is not allowed to be null"); 
                _relatingReferenceId = value;
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

        public IfcExternalReferenceRelationship(IfcId id, string name, string description, IfcId relatingReferenceId, List<IfcId> relatedResourceObjectIds) : base(id, name, description)
        {
            RelatingReferenceId = relatingReferenceId;
            RelatedResourceObjectIds = relatedResourceObjectIds;
        }

        public override ClassId GetClassId() => ClassId.IfcExternalReferenceRelationship;

        #region Equality

        public bool Equals(IfcExternalReferenceRelationship other)
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
                && RelatingReferenceId == other.RelatingReferenceId;
        }

        public override bool Equals(object other) => Equals(other as IfcExternalReferenceRelationship);

        public static bool operator ==(IfcExternalReferenceRelationship one, IfcExternalReferenceRelationship other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcExternalReferenceRelationship one, IfcExternalReferenceRelationship other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{RelatingReferenceId},{Utils.ConvertListToString(RelatedResourceObjectIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingReferenceId!= null && replacementTable.ContainsKey(RelatingReferenceId))
                RelatingReferenceId = replacementTable[RelatingReferenceId];
            if(RelatedResourceObjectIds!= null)
                RelatedResourceObjectIds = RelatedResourceObjectIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcExternalReferenceRelationship (newId,Name, Description, RelatingReferenceId, RelatedResourceObjectIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcExternalReferenceRelationship },
                { "class", nameof(IfcExternalReferenceRelationship) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingReferenceId.ToJValue(),
                        RelatedResourceObjectIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcExternalReferenceRelationship CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcExternalReferenceRelationship(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcIdList());
        }
        #endregion

    }
}