
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
    public class IfcWindowType : IfcBuildingElementType, IEquatable<IfcWindowType>
    {
        private IfcWindowTypeEnum _predefinedType;
        public IfcWindowTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }
        private IfcWindowTypePartitioningEnum _partitioningType;
        public IfcWindowTypePartitioningEnum PartitioningType 
        {
            get { 
                return _partitioningType; 
            }
            set { 
                _partitioningType = value;
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
        private string _userDefinedPartitioningType;
        public string UserDefinedPartitioningType 
        {
            get { 
                return _userDefinedPartitioningType; 
            }
            set { 
                _userDefinedPartitioningType = value;  // optional IfcLabel
            }
        }

        public IfcWindowType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, string elementType, IfcWindowTypeEnum predefinedType, IfcWindowTypePartitioningEnum partitioningType, bool? parameterTakesPrecedence, string userDefinedPartitioningType) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag, elementType)
        {
            PredefinedType = predefinedType;
            PartitioningType = partitioningType;
            ParameterTakesPrecedence = parameterTakesPrecedence;
            UserDefinedPartitioningType = userDefinedPartitioningType;
        }

        public override ClassId GetClassId() => ClassId.IfcWindowType;

        #region Equality

        public bool Equals(IfcWindowType other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && PartitioningType == other.PartitioningType
                && ParameterTakesPrecedence == other.ParameterTakesPrecedence
                && UserDefinedPartitioningType == other.UserDefinedPartitioningType;
        }

        public override bool Equals(object other) => Equals(other as IfcWindowType);

        public static bool operator ==(IfcWindowType one, IfcWindowType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcWindowType one, IfcWindowType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}','{ElementType}',.{PredefinedType}.,.{PartitioningType}.,{(ParameterTakesPrecedence == null? ".U." : ParameterTakesPrecedence)},'{UserDefinedPartitioningType}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcWindowType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag, ElementType, PredefinedType, PartitioningType, ParameterTakesPrecedence, UserDefinedPartitioningType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcWindowType },
                { "class", nameof(IfcWindowType) },
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
                        PartitioningType.ToJValue(),
                        ParameterTakesPrecedence.ToJValue(),
                        UserDefinedPartitioningType.ToJValue(),
                    }
                }
            };
        }

        public static new IfcWindowType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcWindowType(
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
                (IfcWindowTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcWindowTypeEnum](parameters[9].ToString()),
                (IfcWindowTypePartitioningEnum)IfcAtom.EnumCreator[(int)EnumId.IfcWindowTypePartitioningEnum](parameters[10].ToString()),
                parameters[11].ToOptionalBool(),
                parameters[12].ToOptionalString());
        }
        #endregion

    }
}