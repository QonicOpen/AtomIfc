
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
    public class IfcDoorStandardCase : IfcDoor, IEquatable<IfcDoorStandardCase>
    {
        public IfcDoorStandardCase(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, double? overallHeight, double? overallWidth, IfcDoorTypeEnum predefinedType, IfcDoorTypeOperationEnum operationType, string userDefinedOperationType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag, overallHeight, overallWidth, predefinedType, operationType, userDefinedOperationType)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcDoorStandardCase;

        #region Equality

        public bool Equals(IfcDoorStandardCase other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcDoorStandardCase);

        public static bool operator ==(IfcDoorStandardCase one, IfcDoorStandardCase other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDoorStandardCase one, IfcDoorStandardCase other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}',{OverallHeight},{OverallWidth},.{PredefinedType}.,.{OperationType}.,'{UserDefinedOperationType}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDoorStandardCase (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, OverallHeight, OverallWidth, PredefinedType, OperationType, UserDefinedOperationType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDoorStandardCase },
                { "class", nameof(IfcDoorStandardCase) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        Tag.ToJValue(),
                        OverallHeight.ToJValue(),
                        OverallWidth.ToJValue(),
                        PredefinedType.ToJValue(),
                        OperationType.ToJValue(),
                        UserDefinedOperationType.ToJValue(),
                    }
                }
            };
        }

        public static new IfcDoorStandardCase CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDoorStandardCase(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalDouble(),
                parameters[9].ToOptionalDouble(),
                (IfcDoorTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDoorTypeEnum](parameters[10].ToString()),
                (IfcDoorTypeOperationEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDoorTypeOperationEnum](parameters[11].ToString()),
                parameters[12].ToOptionalString());
        }
        #endregion

    }
}