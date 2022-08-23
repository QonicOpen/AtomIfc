
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
    public class IfcProductDefinitionShape : IfcProductRepresentation, IEquatable<IfcProductDefinitionShape>, IIfcProductRepresentationSelect
    {
        public IfcProductDefinitionShape(IfcId id, string name, string description, List<IfcId> representationIds) : base(id, name, description, representationIds)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcProductDefinitionShape;

        #region Equality

        public bool Equals(IfcProductDefinitionShape other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcProductDefinitionShape);

        public static bool operator ==(IfcProductDefinitionShape one, IfcProductDefinitionShape other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcProductDefinitionShape one, IfcProductDefinitionShape other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(RepresentationIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcProductDefinitionShape (newId,Name, Description, RepresentationIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcProductDefinitionShape },
                { "class", nameof(IfcProductDefinitionShape) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RepresentationIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcProductDefinitionShape CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcProductDefinitionShape(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcIdList());
        }
        #endregion

    }
}