
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
    public class IfcSpatialZoneType : IfcSpatialElementType, IEquatable<IfcSpatialZoneType>
    {
        private IfcSpatialZoneTypeEnum _predefinedType;
        public IfcSpatialZoneTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }
        private string _longName;
        public string LongName 
        {
            get { 
                return _longName; 
            }
            set { 
                _longName = value;  // optional IfcLabel
            }
        }

        public IfcSpatialZoneType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, string elementType, IfcSpatialZoneTypeEnum predefinedType, string longName) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag, elementType)
        {
            PredefinedType = predefinedType;
            LongName = longName;
        }

        public override ClassId GetClassId() => ClassId.IfcSpatialZoneType;

        #region Equality

        public bool Equals(IfcSpatialZoneType other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && LongName == other.LongName;
        }

        public override bool Equals(object other) => Equals(other as IfcSpatialZoneType);

        public static bool operator ==(IfcSpatialZoneType one, IfcSpatialZoneType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSpatialZoneType one, IfcSpatialZoneType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}','{ElementType}',.{PredefinedType}.,'{LongName}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSpatialZoneType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag, ElementType, PredefinedType, LongName);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSpatialZoneType },
                { "class", nameof(IfcSpatialZoneType) },
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
                        LongName.ToJValue(),
                    }
                }
            };
        }

        public static new IfcSpatialZoneType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSpatialZoneType(
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
                (IfcSpatialZoneTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcSpatialZoneTypeEnum](parameters[9].ToString()),
                parameters[10].ToOptionalString());
        }
        #endregion

    }
}