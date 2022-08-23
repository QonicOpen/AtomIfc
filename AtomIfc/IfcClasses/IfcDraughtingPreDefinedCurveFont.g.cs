
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
    public class IfcDraughtingPreDefinedCurveFont : IfcPreDefinedCurveFont, IEquatable<IfcDraughtingPreDefinedCurveFont>
    {
        public IfcDraughtingPreDefinedCurveFont(IfcId id, string name) : base(id, name)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcDraughtingPreDefinedCurveFont;

        #region Equality

        public bool Equals(IfcDraughtingPreDefinedCurveFont other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcDraughtingPreDefinedCurveFont);

        public static bool operator ==(IfcDraughtingPreDefinedCurveFont one, IfcDraughtingPreDefinedCurveFont other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDraughtingPreDefinedCurveFont one, IfcDraughtingPreDefinedCurveFont other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDraughtingPreDefinedCurveFont (newId,Name);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDraughtingPreDefinedCurveFont },
                { "class", nameof(IfcDraughtingPreDefinedCurveFont) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                    }
                }
            };
        }

        public static IfcDraughtingPreDefinedCurveFont CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDraughtingPreDefinedCurveFont(
                jObject["id"].ToIfcId(),
                parameters[0].ToString());
        }
        #endregion

    }
}