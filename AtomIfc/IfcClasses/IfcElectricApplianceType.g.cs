
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
    public class IfcElectricApplianceType : IfcFlowTerminalType, IEquatable<IfcElectricApplianceType>
    {
        private IfcElectricApplianceTypeEnum _predefinedType;
        public IfcElectricApplianceTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }

        public IfcElectricApplianceType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, string elementType, IfcElectricApplianceTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag, elementType)
        {
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcElectricApplianceType;

        #region Equality

        public bool Equals(IfcElectricApplianceType other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcElectricApplianceType);

        public static bool operator ==(IfcElectricApplianceType one, IfcElectricApplianceType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcElectricApplianceType one, IfcElectricApplianceType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}','{ElementType}',.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcElectricApplianceType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag, ElementType, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcElectricApplianceType },
                { "class", nameof(IfcElectricApplianceType) },
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
                    }
                }
            };
        }

        public static new IfcElectricApplianceType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcElectricApplianceType(
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
                (IfcElectricApplianceTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcElectricApplianceTypeEnum](parameters[9].ToString()));
        }
        #endregion

    }
}