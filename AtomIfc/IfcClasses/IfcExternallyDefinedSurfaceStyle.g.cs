
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
    public class IfcExternallyDefinedSurfaceStyle : IfcExternalReference, IEquatable<IfcExternallyDefinedSurfaceStyle>, IIfcSurfaceStyleElementSelect
    {
        public IfcExternallyDefinedSurfaceStyle(IfcId id, string location, string identification, string name) : base(id, location, identification, name)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcExternallyDefinedSurfaceStyle;

        #region Equality

        public bool Equals(IfcExternallyDefinedSurfaceStyle other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcExternallyDefinedSurfaceStyle);

        public static bool operator ==(IfcExternallyDefinedSurfaceStyle one, IfcExternallyDefinedSurfaceStyle other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcExternallyDefinedSurfaceStyle one, IfcExternallyDefinedSurfaceStyle other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Location}','{Identification}','{Name}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcExternallyDefinedSurfaceStyle (newId,Location, Identification, Name);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcExternallyDefinedSurfaceStyle },
                { "class", nameof(IfcExternallyDefinedSurfaceStyle) },
                { "parameters" , new JArray
                    {
                        Location.ToJValue(),
                        Identification.ToJValue(),
                        Name.ToJValue(),
                    }
                }
            };
        }

        public static IfcExternallyDefinedSurfaceStyle CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcExternallyDefinedSurfaceStyle(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString());
        }
        #endregion

    }
}