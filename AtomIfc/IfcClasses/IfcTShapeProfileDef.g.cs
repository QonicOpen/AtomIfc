
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
    public class IfcTShapeProfileDef : IfcParameterizedProfileDef, IEquatable<IfcTShapeProfileDef>
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
        private double _flangeWidth;
        public double FlangeWidth 
        {
            get { 
                return _flangeWidth; 
            }
            set { 
                _flangeWidth = value;
            }
        }
        private double _webThickness;
        public double WebThickness 
        {
            get { 
                return _webThickness; 
            }
            set { 
                _webThickness = value;
            }
        }
        private double _flangeThickness;
        public double FlangeThickness 
        {
            get { 
                return _flangeThickness; 
            }
            set { 
                _flangeThickness = value;
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
        private double? _flangeEdgeRadius;
        public double? FlangeEdgeRadius 
        {
            get { 
                return _flangeEdgeRadius; 
            }
            set { 
                _flangeEdgeRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _webEdgeRadius;
        public double? WebEdgeRadius 
        {
            get { 
                return _webEdgeRadius; 
            }
            set { 
                _webEdgeRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _webSlope;
        public double? WebSlope 
        {
            get { 
                return _webSlope; 
            }
            set { 
                _webSlope = value;  // optional IfcPlaneAngleMeasure
            }
        }
        private double? _flangeSlope;
        public double? FlangeSlope 
        {
            get { 
                return _flangeSlope; 
            }
            set { 
                _flangeSlope = value;  // optional IfcPlaneAngleMeasure
            }
        }

        public IfcTShapeProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double depth, double flangeWidth, double webThickness, double flangeThickness, double? filletRadius, double? flangeEdgeRadius, double? webEdgeRadius, double? webSlope, double? flangeSlope) : base(id, profileType, profileName, positionId)
        {
            Depth = depth;
            FlangeWidth = flangeWidth;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
            FilletRadius = filletRadius;
            FlangeEdgeRadius = flangeEdgeRadius;
            WebEdgeRadius = webEdgeRadius;
            WebSlope = webSlope;
            FlangeSlope = flangeSlope;
        }

        public override ClassId GetClassId() => ClassId.IfcTShapeProfileDef;

        #region Equality

        public bool Equals(IfcTShapeProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Depth == other.Depth
                && FlangeWidth == other.FlangeWidth
                && WebThickness == other.WebThickness
                && FlangeThickness == other.FlangeThickness
                && FilletRadius == other.FilletRadius
                && FlangeEdgeRadius == other.FlangeEdgeRadius
                && WebEdgeRadius == other.WebEdgeRadius
                && WebSlope == other.WebSlope
                && FlangeSlope == other.FlangeSlope;
        }

        public override bool Equals(object other) => Equals(other as IfcTShapeProfileDef);

        public static bool operator ==(IfcTShapeProfileDef one, IfcTShapeProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTShapeProfileDef one, IfcTShapeProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{Depth},{FlangeWidth},{WebThickness},{FlangeThickness},{FilletRadius},{FlangeEdgeRadius},{WebEdgeRadius},{WebSlope},{FlangeSlope})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTShapeProfileDef (newId,ProfileType, ProfileName, PositionId, Depth, FlangeWidth, WebThickness, FlangeThickness, FilletRadius, FlangeEdgeRadius, WebEdgeRadius, WebSlope, FlangeSlope);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTShapeProfileDef },
                { "class", nameof(IfcTShapeProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        Depth,
                        FlangeWidth,
                        WebThickness,
                        FlangeThickness,
                        FilletRadius.ToJValue(),
                        FlangeEdgeRadius.ToJValue(),
                        WebEdgeRadius.ToJValue(),
                        WebSlope.ToJValue(),
                        FlangeSlope.ToJValue(),
                    }
                }
            };
        }

        public static new IfcTShapeProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTShapeProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToDouble(),
                parameters[5].ToDouble(),
                parameters[6].ToDouble(),
                parameters[7].ToOptionalDouble(),
                parameters[8].ToOptionalDouble(),
                parameters[9].ToOptionalDouble(),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalDouble());
        }
        #endregion

    }
}