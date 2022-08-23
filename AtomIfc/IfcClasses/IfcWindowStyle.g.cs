
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
    public class IfcWindowStyle : IfcTypeProduct, IEquatable<IfcWindowStyle>
    {
        private IfcWindowStyleConstructionEnum _constructionType;
        public IfcWindowStyleConstructionEnum ConstructionType 
        {
            get { 
                return _constructionType; 
            }
            set { 
                _constructionType = value;
            }
        }
        private IfcWindowStyleOperationEnum _operationType;
        public IfcWindowStyleOperationEnum OperationType 
        {
            get { 
                return _operationType; 
            }
            set { 
                _operationType = value;
            }
        }
        private bool _parameterTakesPrecedence;
        public bool ParameterTakesPrecedence 
        {
            get { 
                return _parameterTakesPrecedence; 
            }
            set { 
                _parameterTakesPrecedence = value;
            }
        }
        private bool _sizeable;
        public bool Sizeable 
        {
            get { 
                return _sizeable; 
            }
            set { 
                _sizeable = value;
            }
        }

        public IfcWindowStyle(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, IfcWindowStyleConstructionEnum constructionType, IfcWindowStyleOperationEnum operationType, bool parameterTakesPrecedence, bool sizeable) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag)
        {
            ConstructionType = constructionType;
            OperationType = operationType;
            ParameterTakesPrecedence = parameterTakesPrecedence;
            Sizeable = sizeable;
        }

        public override ClassId GetClassId() => ClassId.IfcWindowStyle;

        #region Equality

        public bool Equals(IfcWindowStyle other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ConstructionType == other.ConstructionType
                && OperationType == other.OperationType
                && ParameterTakesPrecedence == other.ParameterTakesPrecedence
                && Sizeable == other.Sizeable;
        }

        public override bool Equals(object other) => Equals(other as IfcWindowStyle);

        public static bool operator ==(IfcWindowStyle one, IfcWindowStyle other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcWindowStyle one, IfcWindowStyle other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}',.{ConstructionType}.,.{OperationType}.,{ParameterTakesPrecedence},{Sizeable})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcWindowStyle (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag, ConstructionType, OperationType, ParameterTakesPrecedence, Sizeable);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcWindowStyle },
                { "class", nameof(IfcWindowStyle) },
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
                        ConstructionType.ToJValue(),
                        OperationType.ToJValue(),
                        ParameterTakesPrecedence,
                        Sizeable,
                    }
                }
            };
        }

        public static new IfcWindowStyle CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcWindowStyle(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcIdList(),
                parameters[6].ToOptionalIfcIdList(),
                parameters[7].ToOptionalString(),
                (IfcWindowStyleConstructionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcWindowStyleConstructionEnum](parameters[8].ToString()),
                (IfcWindowStyleOperationEnum)IfcAtom.EnumCreator[(int)EnumId.IfcWindowStyleOperationEnum](parameters[9].ToString()),
                parameters[10].ToBool(),
                parameters[11].ToBool());
        }
        #endregion

    }
}