
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
    public class IfcRelConnectsStructuralMember : IfcRelConnects, IEquatable<IfcRelConnectsStructuralMember>
    {
        private IfcId _relatingStructuralMemberId;
        public IfcId RelatingStructuralMemberId 
        {
            get { 
                return _relatingStructuralMemberId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingStructuralMemberId is not allowed to be null"); 
                _relatingStructuralMemberId = value;
            }
        }
        private IfcId _relatedStructuralConnectionId;
        public IfcId RelatedStructuralConnectionId 
        {
            get { 
                return _relatedStructuralConnectionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedStructuralConnectionId is not allowed to be null"); 
                _relatedStructuralConnectionId = value;
            }
        }
        private IfcId _appliedConditionId;
        public IfcId AppliedConditionId 
        {
            get { 
                return _appliedConditionId; 
            }
            set { 
                _appliedConditionId = value;  // optional IfcBoundaryCondition
            }
        }
        private IfcId _additionalConditionsId;
        public IfcId AdditionalConditionsId 
        {
            get { 
                return _additionalConditionsId; 
            }
            set { 
                _additionalConditionsId = value;  // optional IfcStructuralConnectionCondition
            }
        }
        private double? _supportedLength;
        public double? SupportedLength 
        {
            get { 
                return _supportedLength; 
            }
            set { 
                _supportedLength = value;  // optional IfcLengthMeasure
            }
        }
        private IfcId _conditionCoordinateSystemId;
        public IfcId ConditionCoordinateSystemId 
        {
            get { 
                return _conditionCoordinateSystemId; 
            }
            set { 
                _conditionCoordinateSystemId = value;  // optional IfcAxis2Placement3D
            }
        }

        public IfcRelConnectsStructuralMember(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingStructuralMemberId, IfcId relatedStructuralConnectionId, IfcId appliedConditionId, IfcId additionalConditionsId, double? supportedLength, IfcId conditionCoordinateSystemId) : base(id, ownerHistoryId, name, description)
        {
            RelatingStructuralMemberId = relatingStructuralMemberId;
            RelatedStructuralConnectionId = relatedStructuralConnectionId;
            AppliedConditionId = appliedConditionId;
            AdditionalConditionsId = additionalConditionsId;
            SupportedLength = supportedLength;
            ConditionCoordinateSystemId = conditionCoordinateSystemId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelConnectsStructuralMember;

        #region Equality

        public bool Equals(IfcRelConnectsStructuralMember other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingStructuralMemberId == other.RelatingStructuralMemberId
                && RelatedStructuralConnectionId == other.RelatedStructuralConnectionId
                && AppliedConditionId == other.AppliedConditionId
                && AdditionalConditionsId == other.AdditionalConditionsId
                && SupportedLength == other.SupportedLength
                && ConditionCoordinateSystemId == other.ConditionCoordinateSystemId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelConnectsStructuralMember);

        public static bool operator ==(IfcRelConnectsStructuralMember one, IfcRelConnectsStructuralMember other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelConnectsStructuralMember one, IfcRelConnectsStructuralMember other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingStructuralMemberId},{RelatedStructuralConnectionId},{AppliedConditionId},{AdditionalConditionsId},{SupportedLength},{ConditionCoordinateSystemId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingStructuralMemberId!= null && replacementTable.ContainsKey(RelatingStructuralMemberId))
                RelatingStructuralMemberId = replacementTable[RelatingStructuralMemberId];
            if(RelatedStructuralConnectionId!= null && replacementTable.ContainsKey(RelatedStructuralConnectionId))
                RelatedStructuralConnectionId = replacementTable[RelatedStructuralConnectionId];
            if(AppliedConditionId!= null && replacementTable.ContainsKey(AppliedConditionId))
                AppliedConditionId = replacementTable[AppliedConditionId];
            if(AdditionalConditionsId!= null && replacementTable.ContainsKey(AdditionalConditionsId))
                AdditionalConditionsId = replacementTable[AdditionalConditionsId];
            if(ConditionCoordinateSystemId!= null && replacementTable.ContainsKey(ConditionCoordinateSystemId))
                ConditionCoordinateSystemId = replacementTable[ConditionCoordinateSystemId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelConnectsStructuralMember (newId,OwnerHistoryId, Name, Description, RelatingStructuralMemberId, RelatedStructuralConnectionId, AppliedConditionId, AdditionalConditionsId, SupportedLength, ConditionCoordinateSystemId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelConnectsStructuralMember },
                { "class", nameof(IfcRelConnectsStructuralMember) },
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
                    }
                }
            };
        }

        public static IfcRelConnectsStructuralMember CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelConnectsStructuralMember(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalDouble(),
                parameters[8].ToOptionalIfcId());
        }
        #endregion

    }
}