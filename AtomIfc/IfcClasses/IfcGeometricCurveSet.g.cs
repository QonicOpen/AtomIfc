
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
    public class IfcGeometricCurveSet : IfcGeometricSet, IEquatable<IfcGeometricCurveSet>
    {
        public IfcGeometricCurveSet(IfcId id, List<IfcId> elementIds) : base(id, elementIds)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcGeometricCurveSet;

        #region Equality

        public bool Equals(IfcGeometricCurveSet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcGeometricCurveSet);

        public static bool operator ==(IfcGeometricCurveSet one, IfcGeometricCurveSet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcGeometricCurveSet one, IfcGeometricCurveSet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(ElementIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcGeometricCurveSet (newId,ElementIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcGeometricCurveSet },
                { "class", nameof(IfcGeometricCurveSet) },
                { "parameters" , new JArray
                    {
                        ElementIds.ToJArray(),
                    }
                }
            };
        }

        public static new IfcGeometricCurveSet CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcGeometricCurveSet(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}