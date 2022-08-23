
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
    public class IfcCrewResource : IfcConstructionResource, IEquatable<IfcCrewResource>
    {
        private IfcCrewResourceTypeEnum _predefinedType;
        public IfcCrewResourceTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcCrewResourceTypeEnum?
            }
        }

        public IfcCrewResource(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, string longDescription, IfcId usageId, List<IfcId> baseCostIds, IfcId baseQuantityId, IfcCrewResourceTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, identification, longDescription, usageId, baseCostIds, baseQuantityId)
        {
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcCrewResource;

        #region Equality

        public bool Equals(IfcCrewResource other)
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

        public override bool Equals(object other) => Equals(other as IfcCrewResource);

        public static bool operator ==(IfcCrewResource one, IfcCrewResource other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCrewResource one, IfcCrewResource other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{Identification}','{LongDescription}',{UsageId},{Utils.ConvertListToString(BaseCostIds)},{BaseQuantityId},.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCrewResource (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, Identification, LongDescription, UsageId, BaseCostIds, BaseQuantityId, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCrewResource },
                { "class", nameof(IfcCrewResource) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        Identification.ToJValue(),
                        LongDescription.ToJValue(),
                        UsageId.ToJValue(),
                        BaseCostIds.ToJArray(),
                        BaseQuantityId.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcCrewResource CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCrewResource(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalIfcId(),
                parameters[8].ToOptionalIfcIdList(),
                parameters[9].ToOptionalIfcId(),
                (IfcCrewResourceTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcCrewResourceTypeEnum](parameters[10].ToString()));
        }
        #endregion

    }
}