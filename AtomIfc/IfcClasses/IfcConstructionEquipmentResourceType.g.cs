
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
    public class IfcConstructionEquipmentResourceType : IfcConstructionResourceType, IEquatable<IfcConstructionEquipmentResourceType>
    {
        private IfcConstructionEquipmentResourceTypeEnum _predefinedType;
        public IfcConstructionEquipmentResourceTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }

        public IfcConstructionEquipmentResourceType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, string identification, string longDescription, string resourceType, List<IfcId> baseCostIds, IfcId baseQuantityId, IfcConstructionEquipmentResourceTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, identification, longDescription, resourceType, baseCostIds, baseQuantityId)
        {
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcConstructionEquipmentResourceType;

        #region Equality

        public bool Equals(IfcConstructionEquipmentResourceType other)
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

        public override bool Equals(object other) => Equals(other as IfcConstructionEquipmentResourceType);

        public static bool operator ==(IfcConstructionEquipmentResourceType one, IfcConstructionEquipmentResourceType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConstructionEquipmentResourceType one, IfcConstructionEquipmentResourceType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},'{Identification}','{LongDescription}','{ResourceType}',{Utils.ConvertListToString(BaseCostIds)},{BaseQuantityId},.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcConstructionEquipmentResourceType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, Identification, LongDescription, ResourceType, BaseCostIds, BaseQuantityId, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcConstructionEquipmentResourceType },
                { "class", nameof(IfcConstructionEquipmentResourceType) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ApplicableOccurrence.ToJValue(),
                        PropertySetIds.ToJArray(),
                        Identification.ToJValue(),
                        LongDescription.ToJValue(),
                        ResourceType.ToJValue(),
                        BaseCostIds.ToJArray(),
                        BaseQuantityId.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static new IfcConstructionEquipmentResourceType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcConstructionEquipmentResourceType(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcIdList(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString(),
                parameters[9].ToOptionalIfcIdList(),
                parameters[10].ToOptionalIfcId(),
                (IfcConstructionEquipmentResourceTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcConstructionEquipmentResourceTypeEnum](parameters[11].ToString()));
        }
        #endregion

    }
}