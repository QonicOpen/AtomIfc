
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
    public class IfcBuildingElementProxyType : IfcBuildingElementType, IEquatable<IfcBuildingElementProxyType>
    {
        private IfcBuildingElementProxyTypeEnum _predefinedType;
        public IfcBuildingElementProxyTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }

        public IfcBuildingElementProxyType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, string elementType, IfcBuildingElementProxyTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag, elementType)
        {
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcBuildingElementProxyType;

        #region Equality

        public bool Equals(IfcBuildingElementProxyType other)
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

        public override bool Equals(object other) => Equals(other as IfcBuildingElementProxyType);

        public static bool operator ==(IfcBuildingElementProxyType one, IfcBuildingElementProxyType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBuildingElementProxyType one, IfcBuildingElementProxyType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}','{ElementType}',.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBuildingElementProxyType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag, ElementType, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBuildingElementProxyType },
                { "class", nameof(IfcBuildingElementProxyType) },
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

        public static new IfcBuildingElementProxyType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBuildingElementProxyType(
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
                (IfcBuildingElementProxyTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcBuildingElementProxyTypeEnum](parameters[9].ToString()));
        }
        #endregion

    }
}