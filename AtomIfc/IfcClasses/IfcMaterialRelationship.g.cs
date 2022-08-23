
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
    public class IfcMaterialRelationship : IfcResourceLevelRelationship, IEquatable<IfcMaterialRelationship>
    {
        private IfcId _relatingMaterialId;
        public IfcId RelatingMaterialId 
        {
            get { 
                return _relatingMaterialId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingMaterialId is not allowed to be null"); 
                _relatingMaterialId = value;
            }
        }
        private List<IfcId> _relatedMaterialIds;
        public List<IfcId> RelatedMaterialIds 
        {
            get { 
                return _relatedMaterialIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedMaterialIds is not allowed to be null"); 
                _relatedMaterialIds = value;
            }
        }
        private string _expression;
        public string Expression 
        {
            get { 
                return _expression; 
            }
            set { 
                _expression = value;  // optional IfcLabel
            }
        }

        public IfcMaterialRelationship(IfcId id, string name, string description, IfcId relatingMaterialId, List<IfcId> relatedMaterialIds, string expression) : base(id, name, description)
        {
            RelatingMaterialId = relatingMaterialId;
            RelatedMaterialIds = relatedMaterialIds;
            Expression = expression;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialRelationship;

        #region Equality

        public bool Equals(IfcMaterialRelationship other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedMaterialIds, other.RelatedMaterialIds))
                return false;
            return base.Equals(other)
                && RelatingMaterialId == other.RelatingMaterialId
                && Expression == other.Expression;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialRelationship);

        public static bool operator ==(IfcMaterialRelationship one, IfcMaterialRelationship other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialRelationship one, IfcMaterialRelationship other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{RelatingMaterialId},{Utils.ConvertListToString(RelatedMaterialIds)},'{Expression}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingMaterialId!= null && replacementTable.ContainsKey(RelatingMaterialId))
                RelatingMaterialId = replacementTable[RelatingMaterialId];
            if(RelatedMaterialIds!= null)
                RelatedMaterialIds = RelatedMaterialIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialRelationship (newId,Name, Description, RelatingMaterialId, RelatedMaterialIds, Expression);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialRelationship },
                { "class", nameof(IfcMaterialRelationship) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingMaterialId.ToJValue(),
                        RelatedMaterialIds.ToJArray(),
                        Expression.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialRelationship CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialRelationship(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcIdList(),
                parameters[4].ToOptionalString());
        }
        #endregion

    }
}