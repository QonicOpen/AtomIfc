
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
    public class IfcZShapeProfileDef : IfcParameterizedProfileDef, IEquatable<IfcZShapeProfileDef>
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

        public IfcZShapeProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double depth, double flangeWidth, double webThickness, double flangeThickness, double? filletRadius, double? edgeRadius) : base(id, profileType, profileName, positionId)
        {
            Depth = depth;
            FlangeWidth = flangeWidth;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
            FilletRadius = filletRadius;
            EdgeRadius = edgeRadius;
        }

        public override ClassId GetClassId() => ClassId.IfcZShapeProfileDef;

        #region Equality

        public bool Equals(IfcZShapeProfileDef other)
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
                && EdgeRadius == other.EdgeRadius;
        }

        public override bool Equals(object other) => Equals(other as IfcZShapeProfileDef);

        public static bool operator ==(IfcZShapeProfileDef one, IfcZShapeProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcZShapeProfileDef one, IfcZShapeProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{Depth},{FlangeWidth},{WebThickness},{FlangeThickness},{FilletRadius},{EdgeRadius})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcZShapeProfileDef (newId,ProfileType, ProfileName, PositionId, Depth, FlangeWidth, WebThickness, FlangeThickness, FilletRadius, EdgeRadius);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcZShapeProfileDef },
                { "class", nameof(IfcZShapeProfileDef) },
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
                        EdgeRadius.ToJValue(),
                    }
                }
            };
        }

        public static new IfcZShapeProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcZShapeProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToDouble(),
                parameters[5].ToDouble(),
                parameters[6].ToDouble(),
                parameters[7].ToOptionalDouble(),
                parameters[8].ToOptionalDouble());
        }
        #endregion

    }
}