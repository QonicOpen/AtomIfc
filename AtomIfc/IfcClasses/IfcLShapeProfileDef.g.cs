
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
    public class IfcLShapeProfileDef : IfcParameterizedProfileDef, IEquatable<IfcLShapeProfileDef>
    {
        private double _depth;
        public double Depth 
        {
            get { 
                return _depth; 
            }
            set { 
                _depth = value;
            }
        }
        private double? _width;
        public double? Width 
        {
            get { 
                return _width; 
            }
            set { 
                _width = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double _thickness;
        public double Thickness 
        {
            get { 
                return _thickness; 
            }
            set { 
                _thickness = value;
            }
        }
        private double? _filletRadius;
        public double? FilletRadius 
        {
            get { 
                return _filletRadius; 
            }
            set { 
                _filletRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _edgeRadius;
        public double? EdgeRadius 
        {
            get { 
                return _edgeRadius; 
            }
            set { 
                _edgeRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _legSlope;
        public double? LegSlope 
        {
            get { 
                return _legSlope; 
            }
            set { 
                _legSlope = value;  // optional IfcPlaneAngleMeasure
            }
        }

        public IfcLShapeProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double depth, double? width, double thickness, double? filletRadius, double? edgeRadius, double? legSlope) : base(id, profileType, profileName, positionId)
        {
            Depth = depth;
            Width = width;
            Thickness = thickness;
            FilletRadius = filletRadius;
            EdgeRadius = edgeRadius;
            LegSlope = legSlope;
        }

        public override ClassId GetClassId() => ClassId.IfcLShapeProfileDef;

        #region Equality

        public bool Equals(IfcLShapeProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Depth == other.Depth
                && Width == other.Width
                && Thickness == other.Thickness
                && FilletRadius == other.FilletRadius
                && EdgeRadius == other.EdgeRadius
                && LegSlope == other.LegSlope;
        }

        public override bool Equals(object other) => Equals(other as IfcLShapeProfileDef);

        public static bool operator ==(IfcLShapeProfileDef one, IfcLShapeProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLShapeProfileDef one, IfcLShapeProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{Depth},{Width},{Thickness},{FilletRadius},{EdgeRadius},{LegSlope})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLShapeProfileDef (newId,ProfileType, ProfileName, PositionId, Depth, Width, Thickness, FilletRadius, EdgeRadius, LegSlope);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLShapeProfileDef },
                { "class", nameof(IfcLShapeProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        Depth,
                        Width.ToJValue(),
                        Thickness,
                        FilletRadius.ToJValue(),
                        EdgeRadius.ToJValue(),
                        LegSlope.ToJValue(),
                    }
                }
            };
        }

        public static new IfcLShapeProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLShapeProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToDouble(),
                parameters[6].ToOptionalDouble(),
                parameters[7].ToOptionalDouble(),
                parameters[8].ToOptionalDouble());
        }
        #endregion

    }
}