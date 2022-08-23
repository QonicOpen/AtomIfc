
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
    public class IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D, IEquatable<IfcCartesianTransformationOperator2DnonUniform>
    {
        private double? _scale2;
        public double? Scale2 
        {
            get { 
                return _scale2; 
            }
            set { 
                _scale2 = value;  // optional double
            }
        }

        public IfcCartesianTransformationOperator2DnonUniform(IfcId id, IfcId axis1Id, IfcId axis2Id, IfcId localOriginId, double? scale, double? scale2) : base(id, axis1Id, axis2Id, localOriginId, scale)
        {
            Scale2 = scale2;
        }

        public override ClassId GetClassId() => ClassId.IfcCartesianTransformationOperator2DnonUniform;

        #region Equality

        public bool Equals(IfcCartesianTransformationOperator2DnonUniform other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Scale2 == other.Scale2;
        }

        public override bool Equals(object other) => Equals(other as IfcCartesianTransformationOperator2DnonUniform);

        public static bool operator ==(IfcCartesianTransformationOperator2DnonUniform one, IfcCartesianTransformationOperator2DnonUniform other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCartesianTransformationOperator2DnonUniform one, IfcCartesianTransformationOperator2DnonUniform other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Axis1Id},{Axis2Id},{LocalOriginId},{Scale},{Scale2})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCartesianTransformationOperator2DnonUniform (newId,Axis1Id, Axis2Id, LocalOriginId, Scale, Scale2);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCartesianTransformationOperator2DnonUniform },
                { "class", nameof(IfcCartesianTransformationOperator2DnonUniform) },
                { "parameters" , new JArray
                    {
                        Axis1Id.ToJValue(),
                        Axis2Id.ToJValue(),
                        LocalOriginId.ToJValue(),
                        Scale.ToJValue(),
                        Scale2.ToJValue(),
                    }
                }
            };
        }

        public static new IfcCartesianTransformationOperator2DnonUniform CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCartesianTransformationOperator2DnonUniform(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalDouble());
        }
        #endregion

    }
}