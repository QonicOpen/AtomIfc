
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
    public class IfcDoorType : IfcBuildingElementType, IEquatable<IfcDoorType>
    {
        private IfcDoorTypeEnum _predefinedType;
        public IfcDoorTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }
        private IfcDoorTypeOperationEnum _operationType;
        public IfcDoorTypeOperationEnum OperationType 
        {
            get { 
                return _operationType; 
            }
            set { 
                _operationType = value;
            }
        }
        private bool? _parameterTakesPrecedence;
        public bool? ParameterTakesPrecedence 
        {
            get { 
                return _parameterTakesPrecedence; 
            }
            set { 
                _parameterTakesPrecedence = value;  // optional bool
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

        public IfcDoorType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, string elementType, IfcDoorTypeEnum predefinedType, IfcDoorTypeOperationEnum operationType, bool? parameterTakesPrecedence, string userDefinedOperationType) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag, elementType)
        {
            PredefinedType = predefinedType;
            OperationType = operationType;
            ParameterTakesPrecedence = parameterTakesPrecedence;
            UserDefinedOperationType = userDefinedOperationType;
        }

        public override ClassId GetClassId() => ClassId.IfcDoorType;

        #region Equality

        public bool Equals(IfcDoorType other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && OperationType == other.OperationType
                && ParameterTakesPrecedence == other.ParameterTakesPrecedence
                && UserDefinedOperationType == other.UserDefinedOperationType;
        }

        public override bool Equals(object other) => Equals(other as IfcDoorType);

        public static bool operator ==(IfcDoorType one, IfcDoorType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDoorType one, IfcDoorType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}','{ElementType}',.{PredefinedType}.,.{OperationType}.,{(ParameterTakesPrecedence == null? ".U." : ParameterTakesPrecedence)},'{UserDefinedOperationType}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDoorType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag, ElementType, PredefinedType, OperationType, ParameterTakesPrecedence, UserDefinedOperationType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDoorType },
                { "class", nameof(IfcDoorType) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ApplicableOccurrence.ToJValue(),
                        PropertySetIds.ToJArray(),
                        RepresentationMapIds.ToJArray(),
                        Tag.ToJValue(),
                        ElementType.ToJValue(),
                        PredefinedType.ToJValue(),
                        OperationType.ToJValue(),
                        ParameterTakesPrecedence.ToJValue(),
                        UserDefinedOperationType.ToJValue(),
                    }
                }
            };
        }

        public static new IfcDoorType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDoorType(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcIdList(),
                parameters[6].ToOptionalIfcIdList(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString(),
                (IfcDoorTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDoorTypeEnum](parameters[9].ToString()),
                (IfcDoorTypeOperationEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDoorTypeOperationEnum](parameters[10].ToString()),
                parameters[11].ToOptionalBool(),
                parameters[12].ToOptionalString());
        }
        #endregion

    }
}