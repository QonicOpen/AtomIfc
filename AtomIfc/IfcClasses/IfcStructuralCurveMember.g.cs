
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
    public class IfcStructuralCurveMember : IfcStructuralMember, IEquatable<IfcStructuralCurveMember>
    {
        private IfcStructuralCurveMemberTypeEnum _predefinedType;
        public IfcStructuralCurveMemberTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }
        private IfcId _axisId;
        public IfcId AxisId 
        {
            get { 
                return _axisId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("AxisId is not allowed to be null"); 
                _axisId = value;
            }
        }

        public IfcStructuralCurveMember(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, IfcStructuralCurveMemberTypeEnum predefinedType, IfcId axisId) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId)
        {
            PredefinedType = predefinedType;
            AxisId = axisId;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralCurveMember;

        #region Equality

        public bool Equals(IfcStructuralCurveMember other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && AxisId == other.AxisId;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralCurveMember);

        public static bool operator ==(IfcStructuralCurveMember one, IfcStructuralCurveMember other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralCurveMember one, IfcStructuralCurveMember other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},.{PredefinedType}.,{AxisId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(AxisId!= null && replacementTable.ContainsKey(AxisId))
                AxisId = replacementTable[AxisId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralCurveMember (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, PredefinedType, AxisId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralCurveMember },
                { "class", nameof(IfcStructuralCurveMember) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        PredefinedType.ToJValue(),
                        AxisId.ToJValue(),
                    }
                }
            };
        }

        public static IfcStructuralCurveMember CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralCurveMember(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                (IfcStructuralCurveMemberTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcStructuralCurveMemberTypeEnum](parameters[7].ToString()),
                parameters[8].ToIfcId());
        }
        #endregion

    }
}