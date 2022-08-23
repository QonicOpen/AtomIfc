
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
    public class IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator, IEquatable<IfcCartesianTransformationOperator2D>
    {
        public IfcCartesianTransformationOperator2D(IfcId id, IfcId axis1Id, IfcId axis2Id, IfcId localOriginId, double? scale) : base(id, axis1Id, axis2Id, localOriginId, scale)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcCartesianTransformationOperator2D;

        #region Equality

        public bool Equals(IfcCartesianTransformationOperator2D other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcCartesianTransformationOperator2D);

        public static bool operator ==(IfcCartesianTransformationOperator2D one, IfcCartesianTransformationOperator2D other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCartesianTransformationOperator2D one, IfcCartesianTransformationOperator2D other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Axis1Id},{Axis2Id},{LocalOriginId},{Scale})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCartesianTransformationOperator2D (newId,Axis1Id, Axis2Id, LocalOriginId, Scale);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCartesianTransformationOperator2D },
                { "class", nameof(IfcCartesianTransformationOperator2D) },
                { "parameters" , new JArray
                    {
                        Axis1Id.ToJValue(),
                        Axis2Id.ToJValue(),
                        LocalOriginId.ToJValue(),
                        Scale.ToJValue(),
                    }
                }
            };
        }

        public static IfcCartesianTransformationOperator2D CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCartesianTransformationOperator2D(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToOptionalDouble());
        }
        #endregion

    }
}