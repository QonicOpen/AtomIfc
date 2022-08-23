
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
    public class IfcTendonType : IfcReinforcingElementType, IEquatable<IfcTendonType>
    {
        private IfcTendonTypeEnum _predefinedType;
        public IfcTendonTypeEnum PredefinedType 
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
        private double? _crossSectionArea;
        public double? CrossSectionArea 
        {
            get { 
                return _crossSectionArea; 
            }
            set { 
                _crossSectionArea = value;  // optional IfcAreaMeasure
            }
        }
        private double? _sheethDiameter;
        public double? SheethDiameter 
        {
            get { 
                return _sheethDiameter; 
            }
            set { 
                _sheethDiameter = value;  // optional IfcPositiveLengthMeasure
            }
        }

        public IfcTendonType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, string elementType, IfcTendonTypeEnum predefinedType, double? nominalDiameter, double? crossSectionArea, double? sheethDiameter) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag, elementType)
        {
            PredefinedType = predefinedType;
            NominalDiameter = nominalDiameter;
            CrossSectionArea = crossSectionArea;
            SheethDiameter = sheethDiameter;
        }

        public override ClassId GetClassId() => ClassId.IfcTendonType;

        #region Equality

        public bool Equals(IfcTendonType other)
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
                && CrossSectionArea == other.CrossSectionArea
                && SheethDiameter == other.SheethDiameter;
        }

        public override bool Equals(object other) => Equals(other as IfcTendonType);

        public static bool operator ==(IfcTendonType one, IfcTendonType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTendonType one, IfcTendonType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}','{ElementType}',.{PredefinedType}.,{NominalDiameter},{CrossSectionArea},{SheethDiameter})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTendonType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag, ElementType, PredefinedType, NominalDiameter, CrossSectionArea, SheethDiameter);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTendonType },
                { "class", nameof(IfcTendonType) },
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
                        CrossSectionArea.ToJValue(),
                        SheethDiameter.ToJValue(),
                    }
                }
            };
        }

        public static new IfcTendonType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTendonType(
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
                (IfcTendonTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcTendonTypeEnum](parameters[9].ToString()),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalDouble(),
                parameters[12].ToOptionalDouble());
        }
        #endregion

    }
}