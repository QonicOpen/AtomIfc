
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
    public class IfcVoidingFeature : IfcFeatureElementSubtraction, IEquatable<IfcVoidingFeature>
    {
        private IfcVoidingFeatureTypeEnum _predefinedType;
        public IfcVoidingFeatureTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcVoidingFeatureTypeEnum?
            }
        }

        public IfcVoidingFeature(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, IfcVoidingFeatureTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag)
        {
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcVoidingFeature;

        #region Equality

        public bool Equals(IfcVoidingFeature other)
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

        public override bool Equals(object other) => Equals(other as IfcVoidingFeature);

        public static bool operator ==(IfcVoidingFeature one, IfcVoidingFeature other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcVoidingFeature one, IfcVoidingFeature other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}',.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcVoidingFeature (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcVoidingFeature },
                { "class", nameof(IfcVoidingFeature) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        Tag.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcVoidingFeature CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcVoidingFeature(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalString(),
                (IfcVoidingFeatureTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcVoidingFeatureTypeEnum](parameters[8].ToString()));
        }
        #endregion

    }
}