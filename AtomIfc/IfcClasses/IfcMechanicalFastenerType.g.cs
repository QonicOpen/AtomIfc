
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
    public class IfcMechanicalFastenerType : IfcElementComponentType, IEquatable<IfcMechanicalFastenerType>
    {
        private IfcMechanicalFastenerTypeEnum _predefinedType;
        public IfcMechanicalFastenerTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }
        private double? _nominalDiameter;
        public double? NominalDiameter 
        {
            get { 
                return _nominalDiameter; 
            }
            set { 
                _nominalDiameter = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _nominalLength;
        public double? NominalLength 
        {
            get { 
                return _nominalLength; 
            }
            set { 
                _nominalLength = value;  // optional IfcPositiveLengthMeasure
            }
        }

        public IfcMechanicalFastenerType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, string elementType, IfcMechanicalFastenerTypeEnum predefinedType, double? nominalDiameter, double? nominalLength) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag, elementType)
        {
            PredefinedType = predefinedType;
            NominalDiameter = nominalDiameter;
            NominalLength = nominalLength;
        }

        public override ClassId GetClassId() => ClassId.IfcMechanicalFastenerType;

        #region Equality

        public bool Equals(IfcMechanicalFastenerType other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && NominalDiameter == other.NominalDiameter
                && NominalLength == other.NominalLength;
        }

        public override bool Equals(object other) => Equals(other as IfcMechanicalFastenerType);

        public static bool operator ==(IfcMechanicalFastenerType one, IfcMechanicalFastenerType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMechanicalFastenerType one, IfcMechanicalFastenerType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}','{ElementType}',.{PredefinedType}.,{NominalDiameter},{NominalLength})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMechanicalFastenerType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag, ElementType, PredefinedType, NominalDiameter, NominalLength);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMechanicalFastenerType },
                { "class", nameof(IfcMechanicalFastenerType) },
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
                        NominalDiameter.ToJValue(),
                        NominalLength.ToJValue(),
                    }
                }
            };
        }

        public static new IfcMechanicalFastenerType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMechanicalFastenerType(
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
                (IfcMechanicalFastenerTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcMechanicalFastenerTypeEnum](parameters[9].ToString()),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalDouble());
        }
        #endregion

    }
}