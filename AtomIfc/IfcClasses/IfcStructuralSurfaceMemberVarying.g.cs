
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
    public class IfcStructuralSurfaceMemberVarying : IfcStructuralSurfaceMember, IEquatable<IfcStructuralSurfaceMemberVarying>
    {
        public IfcStructuralSurfaceMemberVarying(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, IfcStructuralSurfaceMemberTypeEnum predefinedType, double? thickness) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, predefinedType, thickness)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralSurfaceMemberVarying;

        #region Equality

        public bool Equals(IfcStructuralSurfaceMemberVarying other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralSurfaceMemberVarying);

        public static bool operator ==(IfcStructuralSurfaceMemberVarying one, IfcStructuralSurfaceMemberVarying other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralSurfaceMemberVarying one, IfcStructuralSurfaceMemberVarying other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},.{PredefinedType}.,{Thickness})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralSurfaceMemberVarying (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, PredefinedType, Thickness);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralSurfaceMemberVarying },
                { "class", nameof(IfcStructuralSurfaceMemberVarying) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        PredefinedType.ToJValue(),
                        Thickness.ToJValue(),
                    }
                }
            };
        }

        public static new IfcStructuralSurfaceMemberVarying CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralSurfaceMemberVarying(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                (IfcStructuralSurfaceMemberTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcStructuralSurfaceMemberTypeEnum](parameters[7].ToString()),
                parameters[8].ToOptionalDouble());
        }
        #endregion

    }
}