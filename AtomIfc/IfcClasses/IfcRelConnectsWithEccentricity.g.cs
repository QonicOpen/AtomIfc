
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
    public class IfcRelConnectsWithEccentricity : IfcRelConnectsStructuralMember, IEquatable<IfcRelConnectsWithEccentricity>
    {
        private IfcId _connectionConstraintId;
        public IfcId ConnectionConstraintId 
        {
            get { 
                return _connectionConstraintId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ConnectionConstraintId is not allowed to be null"); 
                _connectionConstraintId = value;
            }
        }

        public IfcRelConnectsWithEccentricity(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingStructuralMemberId, IfcId relatedStructuralConnectionId, IfcId appliedConditionId, IfcId additionalConditionsId, double? supportedLength, IfcId conditionCoordinateSystemId, IfcId connectionConstraintId) : base(id, ownerHistoryId, name, description, relatingStructuralMemberId, relatedStructuralConnectionId, appliedConditionId, additionalConditionsId, supportedLength, conditionCoordinateSystemId)
        {
            ConnectionConstraintId = connectionConstraintId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelConnectsWithEccentricity;

        #region Equality

        public bool Equals(IfcRelConnectsWithEccentricity other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ConnectionConstraintId == other.ConnectionConstraintId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelConnectsWithEccentricity);

        public static bool operator ==(IfcRelConnectsWithEccentricity one, IfcRelConnectsWithEccentricity other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelConnectsWithEccentricity one, IfcRelConnectsWithEccentricity other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingStructuralMemberId},{RelatedStructuralConnectionId},{AppliedConditionId},{AdditionalConditionsId},{SupportedLength},{ConditionCoordinateSystemId},{ConnectionConstraintId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ConnectionConstraintId!= null && replacementTable.ContainsKey(ConnectionConstraintId))
                ConnectionConstraintId = replacementTable[ConnectionConstraintId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelConnectsWithEccentricity (newId,OwnerHistoryId, Name, Description, RelatingStructuralMemberId, RelatedStructuralConnectionId, AppliedConditionId, AdditionalConditionsId, SupportedLength, ConditionCoordinateSystemId, ConnectionConstraintId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelConnectsWithEccentricity },
                { "class", nameof(IfcRelConnectsWithEccentricity) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingStructuralMemberId.ToJValue(),
                        RelatedStructuralConnectionId.ToJValue(),
                        AppliedConditionId.ToJValue(),
                        AdditionalConditionsId.ToJValue(),
                        SupportedLength.ToJValue(),
                        ConditionCoordinateSystemId.ToJValue(),
                        ConnectionConstraintId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcRelConnectsWithEccentricity CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelConnectsWithEccentricity(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalDouble(),
                parameters[8].ToOptionalIfcId(),
                parameters[9].ToIfcId());
        }
        #endregion

    }
}