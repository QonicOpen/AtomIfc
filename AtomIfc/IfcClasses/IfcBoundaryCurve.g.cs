
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
    public class IfcBoundaryCurve : IfcCompositeCurveOnSurface, IEquatable<IfcBoundaryCurve>
    {
        public IfcBoundaryCurve(IfcId id, List<IfcId> segmentIds, bool? selfIntersect) : base(id, segmentIds, selfIntersect)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcBoundaryCurve;

        #region Equality

        public bool Equals(IfcBoundaryCurve other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcBoundaryCurve);

        public static bool operator ==(IfcBoundaryCurve one, IfcBoundaryCurve other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBoundaryCurve one, IfcBoundaryCurve other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(SegmentIds)},{(SelfIntersect == null? ".U." : SelfIntersect)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBoundaryCurve (newId,SegmentIds, SelfIntersect);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBoundaryCurve },
                { "class", nameof(IfcBoundaryCurve) },
                { "parameters" , new JArray
                    {
                        SegmentIds.ToJArray(),
                        SelfIntersect.ToJValue(),
                    }
                }
            };
        }

        public static new IfcBoundaryCurve CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBoundaryCurve(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToOptionalBool());
        }
        #endregion

    }
}