
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
    public class IfcIShapeProfileDef : IfcParameterizedProfileDef, IEquatable<IfcIShapeProfileDef>
    {
        private double _overallWidth;
        public double OverallWidth 
        {
            get { 
                return _overallWidth; 
            }
            set { 
                _overallWidth = value;
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

        public IfcIShapeProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double overallWidth, double overallDepth, double webThickness, double flangeThickness, double? filletRadius, double? flangeEdgeRadius, double? flangeSlope) : base(id, profileType, profileName, positionId)
        {
            OverallWidth = overallWidth;
            OverallDepth = overallDepth;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
            FilletRadius = filletRadius;
            FlangeEdgeRadius = flangeEdgeRadius;
            FlangeSlope = flangeSlope;
        }

        public override ClassId GetClassId() => ClassId.IfcIShapeProfileDef;

        #region Equality

        public bool Equals(IfcIShapeProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && OverallWidth == other.OverallWidth
                && OverallDepth == other.OverallDepth
                && WebThickness == other.WebThickness
                && FlangeThickness == other.FlangeThickness
                && FilletRadius == other.FilletRadius
                && FlangeEdgeRadius == other.FlangeEdgeRadius
                && FlangeSlope == other.FlangeSlope;
        }

        public override bool Equals(object other) => Equals(other as IfcIShapeProfileDef);

        public static bool operator ==(IfcIShapeProfileDef one, IfcIShapeProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcIShapeProfileDef one, IfcIShapeProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{OverallWidth},{OverallDepth},{WebThickness},{FlangeThickness},{FilletRadius},{FlangeEdgeRadius},{FlangeSlope})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcIShapeProfileDef (newId,ProfileType, ProfileName, PositionId, OverallWidth, OverallDepth, WebThickness, FlangeThickness, FilletRadius, FlangeEdgeRadius, FlangeSlope);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcIShapeProfileDef },
                { "class", nameof(IfcIShapeProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        OverallWidth,
                        OverallDepth,
                        WebThickness,
                        FlangeThickness,
                        FilletRadius.ToJValue(),
                        FlangeEdgeRadius.ToJValue(),
                        FlangeSlope.ToJValue(),
                    }
                }
            };
        }

        public static new IfcIShapeProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcIShapeProfileDef(
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
                parameters[9].ToOptionalDouble());
        }
        #endregion

    }
}