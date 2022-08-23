
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
    public class IfcPlane : IfcElementarySurface, IEquatable<IfcPlane>
    {
        public IfcPlane(IfcId id, IfcId positionId) : base(id, positionId)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcPlane;

        #region Equality

        public bool Equals(IfcPlane other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcPlane);

        public static bool operator ==(IfcPlane one, IfcPlane other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPlane one, IfcPlane other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PositionId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPlane (newId,PositionId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPlane },
                { "class", nameof(IfcPlane) },
                { "parameters" , new JArray
                    {
                        PositionId.ToJValue(),
                    }
                }
            };
        }

        public static IfcPlane CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPlane(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId());
        }
        #endregion

    }
}