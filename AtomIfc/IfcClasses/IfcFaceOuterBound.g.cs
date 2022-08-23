
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
    public class IfcFaceOuterBound : IfcFaceBound, IEquatable<IfcFaceOuterBound>
    {
        public IfcFaceOuterBound(IfcId id, IfcId boundId, bool orientation) : base(id, boundId, orientation)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcFaceOuterBound;

        #region Equality

        public bool Equals(IfcFaceOuterBound other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcFaceOuterBound);

        public static bool operator ==(IfcFaceOuterBound one, IfcFaceOuterBound other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFaceOuterBound one, IfcFaceOuterBound other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BoundId},{Orientation})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFaceOuterBound (newId,BoundId, Orientation);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFaceOuterBound },
                { "class", nameof(IfcFaceOuterBound) },
                { "parameters" , new JArray
                    {
                        BoundId.ToJValue(),
                        Orientation,
                    }
                }
            };
        }

        public static new IfcFaceOuterBound CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFaceOuterBound(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToBool());
        }
        #endregion

    }
}