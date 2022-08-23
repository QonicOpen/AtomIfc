
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
    public class IfcCShapeProfileDef : IfcParameterizedProfileDef, IEquatable<IfcCShapeProfileDef>
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
        private double _width;
        public double Width 
        {
            get { 
                return _width; 
            }
            set { 
                _width = value;
            }
        }
        private double _wallThickness;
        public double WallThickness 
        {
            get { 
                return _wallThickness; 
            }
            set { 
                _wallThickness = value;
            }
        }
        private double _girth;
        public double Girth 
        {
            get { 
                return _girth; 
            }
            set { 
                _girth = value;
            }
        }
        private double? _internalFilletRadius;
        public double? InternalFilletRadius 
        {
            get { 
                return _internalFilletRadius; 
            }
            set { 
                _internalFilletRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }

        public IfcCShapeProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double depth, double width, double wallThickness, double girth, double? internalFilletRadius) : base(id, profileType, profileName, positionId)
        {
            Depth = depth;
            Width = width;
            WallThickness = wallThickness;
            Girth = girth;
            InternalFilletRadius = internalFilletRadius;
        }

        public override ClassId GetClassId() => ClassId.IfcCShapeProfileDef;

        #region Equality

        public bool Equals(IfcCShapeProfileDef other)
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
                && WallThickness == other.WallThickness
                && Girth == other.Girth
                && InternalFilletRadius == other.InternalFilletRadius;
        }

        public override bool Equals(object other) => Equals(other as IfcCShapeProfileDef);

        public static bool operator ==(IfcCShapeProfileDef one, IfcCShapeProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCShapeProfileDef one, IfcCShapeProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{Depth},{Width},{WallThickness},{Girth},{InternalFilletRadius})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCShapeProfileDef (newId,ProfileType, ProfileName, PositionId, Depth, Width, WallThickness, Girth, InternalFilletRadius);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCShapeProfileDef },
                { "class", nameof(IfcCShapeProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        Depth,
                        Width,
                        WallThickness,
                        Girth,
                        InternalFilletRadius.ToJValue(),
                    }
                }
            };
        }

        public static new IfcCShapeProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCShapeProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToDouble(),
                parameters[5].ToDouble(),
                parameters[6].ToDouble(),
                parameters[7].ToOptionalDouble());
        }
        #endregion

    }
}