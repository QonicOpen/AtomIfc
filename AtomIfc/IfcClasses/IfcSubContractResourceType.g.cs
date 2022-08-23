
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
    public class IfcSubContractResourceType : IfcConstructionResourceType, IEquatable<IfcSubContractResourceType>
    {
        private IfcSubContractResourceTypeEnum _predefinedType;
        public IfcSubContractResourceTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }

        public IfcSubContractResourceType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, string identification, string longDescription, string resourceType, List<IfcId> baseCostIds, IfcId baseQuantityId, IfcSubContractResourceTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, identification, longDescription, resourceType, baseCostIds, baseQuantityId)
        {
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcSubContractResourceType;

        #region Equality

        public bool Equals(IfcSubContractResourceType other)
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

        public override bool Equals(object other) => Equals(other as IfcSubContractResourceType);

        public static bool operator ==(IfcSubContractResourceType one, IfcSubContractResourceType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSubContractResourceType one, IfcSubContractResourceType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},'{Identification}','{LongDescription}','{ResourceType}',{Utils.ConvertListToString(BaseCostIds)},{BaseQuantityId},.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSubContractResourceType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, Identification, LongDescription, ResourceType, BaseCostIds, BaseQuantityId, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSubContractResourceType },
                { "class", nameof(IfcSubContractResourceType) },
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

        public static new IfcSubContractResourceType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSubContractResourceType(
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
                (IfcSubContractResourceTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcSubContractResourceTypeEnum](parameters[11].ToString()));
        }
        #endregion

    }
}