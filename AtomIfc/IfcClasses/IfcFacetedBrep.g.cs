
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
    public class IfcFacetedBrep : IfcManifoldSolidBrep, IEquatable<IfcFacetedBrep>
    {
        public IfcFacetedBrep(IfcId id, IfcId outerId) : base(id, outerId)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcFacetedBrep;

        #region Equality

        public bool Equals(IfcFacetedBrep other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcFacetedBrep);

        public static bool operator ==(IfcFacetedBrep one, IfcFacetedBrep other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFacetedBrep one, IfcFacetedBrep other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OuterId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFacetedBrep (newId,OuterId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFacetedBrep },
                { "class", nameof(IfcFacetedBrep) },
                { "parameters" , new JArray
                    {
                        OuterId.ToJValue(),
                    }
                }
            };
        }

        public static IfcFacetedBrep CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFacetedBrep(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId());
        }
        #endregion

    }
}