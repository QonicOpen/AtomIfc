
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
    public class IfcAdvancedFace : IfcFaceSurface, IEquatable<IfcAdvancedFace>
    {
        public IfcAdvancedFace(IfcId id, List<IfcId> boundIds, IfcId faceSurfaceId, bool sameSense) : base(id, boundIds, faceSurfaceId, sameSense)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcAdvancedFace;

        #region Equality

        public bool Equals(IfcAdvancedFace other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcAdvancedFace);

        public static bool operator ==(IfcAdvancedFace one, IfcAdvancedFace other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcAdvancedFace one, IfcAdvancedFace other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(BoundIds)},{FaceSurfaceId},{SameSense})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcAdvancedFace (newId,BoundIds, FaceSurfaceId, SameSense);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcAdvancedFace },
                { "class", nameof(IfcAdvancedFace) },
                { "parameters" , new JArray
                    {
                        BoundIds.ToJArray(),
                        FaceSurfaceId.ToJValue(),
                        SameSense,
                    }
                }
            };
        }

        public static new IfcAdvancedFace CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcAdvancedFace(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToIfcId(),
                parameters[2].ToBool());
        }
        #endregion

    }
}