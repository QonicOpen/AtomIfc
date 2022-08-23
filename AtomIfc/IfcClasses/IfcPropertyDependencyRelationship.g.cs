
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
    public class IfcPropertyDependencyRelationship : IfcResourceLevelRelationship, IEquatable<IfcPropertyDependencyRelationship>
    {
        private IfcId _dependingPropertyId;
        public IfcId DependingPropertyId 
        {
            get { 
                return _dependingPropertyId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("DependingPropertyId is not allowed to be null"); 
                _dependingPropertyId = value;
            }
        }
        private IfcId _dependantPropertyId;
        public IfcId DependantPropertyId 
        {
            get { 
                return _dependantPropertyId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("DependantPropertyId is not allowed to be null"); 
                _dependantPropertyId = value;
            }
        }
        private string _expression;
        public string Expression 
        {
            get { 
                return _expression; 
            }
            set { 
                _expression = value;  // optional IfcText
            }
        }

        public IfcPropertyDependencyRelationship(IfcId id, string name, string description, IfcId dependingPropertyId, IfcId dependantPropertyId, string expression) : base(id, name, description)
        {
            DependingPropertyId = dependingPropertyId;
            DependantPropertyId = dependantPropertyId;
            Expression = expression;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertyDependencyRelationship;

        #region Equality

        public bool Equals(IfcPropertyDependencyRelationship other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && DependingPropertyId == other.DependingPropertyId
                && DependantPropertyId == other.DependantPropertyId
                && Expression == other.Expression;
        }

        public override bool Equals(object other) => Equals(other as IfcPropertyDependencyRelationship);

        public static bool operator ==(IfcPropertyDependencyRelationship one, IfcPropertyDependencyRelationship other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertyDependencyRelationship one, IfcPropertyDependencyRelationship other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{DependingPropertyId},{DependantPropertyId},'{Expression}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DependingPropertyId!= null && replacementTable.ContainsKey(DependingPropertyId))
                DependingPropertyId = replacementTable[DependingPropertyId];
            if(DependantPropertyId!= null && replacementTable.ContainsKey(DependantPropertyId))
                DependantPropertyId = replacementTable[DependantPropertyId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertyDependencyRelationship (newId,Name, Description, DependingPropertyId, DependantPropertyId, Expression);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertyDependencyRelationship },
                { "class", nameof(IfcPropertyDependencyRelationship) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        DependingPropertyId.ToJValue(),
                        DependantPropertyId.ToJValue(),
                        Expression.ToJValue(),
                    }
                }
            };
        }

        public static IfcPropertyDependencyRelationship CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertyDependencyRelationship(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcId(),
                parameters[4].ToOptionalString());
        }
        #endregion

    }
}