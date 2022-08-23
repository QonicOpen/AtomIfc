
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
    public class IfcAsymmetricIShapeProfileDef : IfcParameterizedProfileDef, IEquatable<IfcAsymmetricIShapeProfileDef>
    {
        private double _bottomFlangeWidth;
        public double BottomFlangeWidth 
        {
            get { 
                return _bottomFlangeWidth; 
            }
            set { 
                _bottomFlangeWidth = value;
            }
        }
        private double _overallDepth;
        public double OverallDepth 
        {
            get { 
                return _overallDepth; 
            }
            set { 
                _overallDepth = value;
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
        private double _bottomFlangeThickness;
        public double BottomFlangeThickness 
        {
            get { 
                return _bottomFlangeThickness; 
            }
            set { 
                _bottomFlangeThickness = value;
            }
        }
        private double? _bottomFlangeFilletRadius;
        public double? BottomFlangeFilletRadius 
        {
            get { 
                return _bottomFlangeFilletRadius; 
            }
            set { 
                _bottomFlangeFilletRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double _topFlangeWidth;
        public double TopFlangeWidth 
        {
            get { 
                return _topFlangeWidth; 
            }
            set { 
                _topFlangeWidth = value;
            }
        }
        private double? _topFlangeThickness;
        public double? TopFlangeThickness 
        {
            get { 
                return _topFlangeThickness; 
            }
            set { 
                _topFlangeThickness = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _topFlangeFilletRadius;
        public double? TopFlangeFilletRadius 
        {
            get { 
                return _topFlangeFilletRadius; 
            }
            set { 
                _topFlangeFilletRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _bottomFlangeEdgeRadius;
        public double? BottomFlangeEdgeRadius 
        {
            get { 
                return _bottomFlangeEdgeRadius; 
            }
            set { 
                _bottomFlangeEdgeRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _bottomFlangeSlope;
        public double? BottomFlangeSlope 
        {
            get { 
                return _bottomFlangeSlope; 
            }
            set { 
                _bottomFlangeSlope = value;  // optional IfcPlaneAngleMeasure
            }
        }
        private double? _topFlangeEdgeRadius;
        public double? TopFlangeEdgeRadius 
        {
            get { 
                return _topFlangeEdgeRadius; 
            }
            set { 
                _topFlangeEdgeRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _topFlangeSlope;
        public double? TopFlangeSlope 
        {
            get { 
                return _topFlangeSlope; 
            }
            set { 
                _topFlangeSlope = value;  // optional IfcPlaneAngleMeasure
            }
        }

        public IfcAsymmetricIShapeProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double bottomFlangeWidth, double overallDepth, double webThickness, double bottomFlangeThickness, double? bottomFlangeFilletRadius, double topFlangeWidth, double? topFlangeThickness, double? topFlangeFilletRadius, double? bottomFlangeEdgeRadius, double? bottomFlangeSlope, double? topFlangeEdgeRadius, double? topFlangeSlope) : base(id, profileType, profileName, positionId)
        {
            BottomFlangeWidth = bottomFlangeWidth;
            OverallDepth = overallDepth;
            WebThickness = webThickness;
            BottomFlangeThickness = bottomFlangeThickness;
            BottomFlangeFilletRadius = bottomFlangeFilletRadius;
            TopFlangeWidth = topFlangeWidth;
            TopFlangeThickness = topFlangeThickness;
            TopFlangeFilletRadius = topFlangeFilletRadius;
            BottomFlangeEdgeRadius = bottomFlangeEdgeRadius;
            BottomFlangeSlope = bottomFlangeSlope;
            TopFlangeEdgeRadius = topFlangeEdgeRadius;
            TopFlangeSlope = topFlangeSlope;
        }

        public override ClassId GetClassId() => ClassId.IfcAsymmetricIShapeProfileDef;

        #region Equality

        public bool Equals(IfcAsymmetricIShapeProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && BottomFlangeWidth == other.BottomFlangeWidth
                && OverallDepth == other.OverallDepth
                && WebThickness == other.WebThickness
                && BottomFlangeThickness == other.BottomFlangeThickness
                && BottomFlangeFilletRadius == other.BottomFlangeFilletRadius
                && TopFlangeWidth == other.TopFlangeWidth
                && TopFlangeThickness == other.TopFlangeThickness
                && TopFlangeFilletRadius == other.TopFlangeFilletRadius
                && BottomFlangeEdgeRadius == other.BottomFlangeEdgeRadius
                && BottomFlangeSlope == other.BottomFlangeSlope
                && TopFlangeEdgeRadius == other.TopFlangeEdgeRadius
                && TopFlangeSlope == other.TopFlangeSlope;
        }

        public override bool Equals(object other) => Equals(other as IfcAsymmetricIShapeProfileDef);

        public static bool operator ==(IfcAsymmetricIShapeProfileDef one, IfcAsymmetricIShapeProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcAsymmetricIShapeProfileDef one, IfcAsymmetricIShapeProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{BottomFlangeWidth},{OverallDepth},{WebThickness},{BottomFlangeThickness},{BottomFlangeFilletRadius},{TopFlangeWidth},{TopFlangeThickness},{TopFlangeFilletRadius},{BottomFlangeEdgeRadius},{BottomFlangeSlope},{TopFlangeEdgeRadius},{TopFlangeSlope})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcAsymmetricIShapeProfileDef (newId,ProfileType, ProfileName, PositionId, BottomFlangeWidth, OverallDepth, WebThickness, BottomFlangeThickness, BottomFlangeFilletRadius, TopFlangeWidth, TopFlangeThickness, TopFlangeFilletRadius, BottomFlangeEdgeRadius, BottomFlangeSlope, TopFlangeEdgeRadius, TopFlangeSlope);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcAsymmetricIShapeProfileDef },
                { "class", nameof(IfcAsymmetricIShapeProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        BottomFlangeWidth,
                        OverallDepth,
                        WebThickness,
                        BottomFlangeThickness,
                        BottomFlangeFilletRadius.ToJValue(),
                        TopFlangeWidth,
                        TopFlangeThickness.ToJValue(),
                        TopFlangeFilletRadius.ToJValue(),
                        BottomFlangeEdgeRadius.ToJValue(),
                        BottomFlangeSlope.ToJValue(),
                        TopFlangeEdgeRadius.ToJValue(),
                        TopFlangeSlope.ToJValue(),
                    }
                }
            };
        }

        public static new IfcAsymmetricIShapeProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcAsymmetricIShapeProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToDouble(),
                parameters[5].ToDouble(),
                parameters[6].ToDouble(),
                parameters[7].ToOptionalDouble(),
                parameters[8].ToDouble(),
                parameters[9].ToOptionalDouble(),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalDouble(),
                parameters[12].ToOptionalDouble(),
                parameters[13].ToOptionalDouble(),
                parameters[14].ToOptionalDouble());
        }
        #endregion

    }
}