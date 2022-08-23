
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
    public class IfcDoor : IfcBuildingElement, IEquatable<IfcDoor>
    {
        private double? _overallHeight;
        public double? OverallHeight 
        {
            get { 
                return _overallHeight; 
            }
            set { 
                _overallHeight = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _overallWidth;
        public double? OverallWidth 
        {
            get { 
                return _overallWidth; 
            }
            set { 
                _overallWidth = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private IfcDoorTypeEnum _predefinedType;
        public IfcDoorTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcDoorTypeEnum?
            }
        }
        private IfcDoorTypeOperationEnum _operationType;
        public IfcDoorTypeOperationEnum OperationType 
        {
            get { 
                return _operationType; 
            }
            set { 
                _operationType = value;  // optional IfcDoorTypeOperationEnum?
            }
        }
        private string _userDefinedOperationType;
        public string UserDefinedOperationType 
        {
            get { 
                return _userDefinedOperationType; 
            }
            set { 
                _userDefinedOperationType = value;  // optional IfcLabel
            }
        }

        public IfcDoor(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, double? overallHeight, double? overallWidth, IfcDoorTypeEnum predefinedType, IfcDoorTypeOperationEnum operationType, string userDefinedOperationType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag)
        {
            OverallHeight = overallHeight;
            OverallWidth = overallWidth;
            PredefinedType = predefinedType;
            OperationType = operationType;
            UserDefinedOperationType = userDefinedOperationType;
        }

        public override ClassId GetClassId() => ClassId.IfcDoor;

        #region Equality

        public bool Equals(IfcDoor other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && OverallHeight == other.OverallHeight
                && OverallWidth == other.OverallWidth
                && PredefinedType == other.PredefinedType
                && OperationType == other.OperationType
                && UserDefinedOperationType == other.UserDefinedOperationType;
        }

        public override bool Equals(object other) => Equals(other as IfcDoor);

        public static bool operator ==(IfcDoor one, IfcDoor other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDoor one, IfcDoor other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}',{OverallHeight},{OverallWidth},.{PredefinedType}.,.{OperationType}.,'{UserDefinedOperationType}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDoor (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, OverallHeight, OverallWidth, PredefinedType, OperationType, UserDefinedOperationType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDoor },
                { "class", nameof(IfcDoor) },
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

        public static IfcDoor CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDoor(
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