
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
    public class IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D, IEquatable<IfcCartesianTransformationOperator3DnonUniform>
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
        private double? _scale3;
        public double? Scale3 
        {
            get { 
                return _scale3; 
            }
            set { 
                _scale3 = value;  // optional double
            }
        }

        public IfcCartesianTransformationOperator3DnonUniform(IfcId id, IfcId axis1Id, IfcId axis2Id, IfcId localOriginId, double? scale, IfcId axis3Id, double? scale2, double? scale3) : base(id, axis1Id, axis2Id, localOriginId, scale, axis3Id)
        {
            Scale2 = scale2;
            Scale3 = scale3;
        }

        public override ClassId GetClassId() => ClassId.IfcCartesianTransformationOperator3DnonUniform;

        #region Equality

        public bool Equals(IfcCartesianTransformationOperator3DnonUniform other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Scale2 == other.Scale2
                && Scale3 == other.Scale3;
        }

        public override bool Equals(object other) => Equals(other as IfcCartesianTransformationOperator3DnonUniform);

        public static bool operator ==(IfcCartesianTransformationOperator3DnonUniform one, IfcCartesianTransformationOperator3DnonUniform other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCartesianTransformationOperator3DnonUniform one, IfcCartesianTransformationOperator3DnonUniform other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Axis1Id},{Axis2Id},{LocalOriginId},{Scale},{Axis3Id},{Scale2},{Scale3})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCartesianTransformationOperator3DnonUniform (newId,Axis1Id, Axis2Id, LocalOriginId, Scale, Axis3Id, Scale2, Scale3);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCartesianTransformationOperator3DnonUniform },
                { "class", nameof(IfcCartesianTransformationOperator3DnonUniform) },
                { "parameters" , new JArray
                    {
                        Axis1Id.ToJValue(),
                        Axis2Id.ToJValue(),
                        LocalOriginId.ToJValue(),
                        Scale.ToJValue(),
                        Axis3Id.ToJValue(),
                        Scale2.ToJValue(),
                        Scale3.ToJValue(),
                    }
                }
            };
        }

        public static new IfcCartesianTransformationOperator3DnonUniform CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCartesianTransformationOperator3DnonUniform(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalIfcId(),
                parameters[5].ToOptionalDouble(),
                parameters[6].ToOptionalDouble());
        }
        #endregion

    }
}