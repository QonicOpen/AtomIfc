
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
    public class IfcRectangleHollowProfileDef : IfcRectangleProfileDef, IEquatable<IfcRectangleHollowProfileDef>
    {
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
        private double? _innerFilletRadius;
        public double? InnerFilletRadius 
        {
            get { 
                return _innerFilletRadius; 
            }
            set { 
                _innerFilletRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _outerFilletRadius;
        public double? OuterFilletRadius 
        {
            get { 
                return _outerFilletRadius; 
            }
            set { 
                _outerFilletRadius = value;  // optional IfcNonNegativeLengthMeasure
            }
        }

        public IfcRectangleHollowProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double xDim, double yDim, double wallThickness, double? innerFilletRadius, double? outerFilletRadius) : base(id, profileType, profileName, positionId, xDim, yDim)
        {
            WallThickness = wallThickness;
            InnerFilletRadius = innerFilletRadius;
            OuterFilletRadius = outerFilletRadius;
        }

        public override ClassId GetClassId() => ClassId.IfcRectangleHollowProfileDef;

        #region Equality

        public bool Equals(IfcRectangleHollowProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && WallThickness == other.WallThickness
                && InnerFilletRadius == other.InnerFilletRadius
                && OuterFilletRadius == other.OuterFilletRadius;
        }

        public override bool Equals(object other) => Equals(other as IfcRectangleHollowProfileDef);

        public static bool operator ==(IfcRectangleHollowProfileDef one, IfcRectangleHollowProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRectangleHollowProfileDef one, IfcRectangleHollowProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{XDim},{YDim},{WallThickness},{InnerFilletRadius},{OuterFilletRadius})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRectangleHollowProfileDef (newId,ProfileType, ProfileName, PositionId, XDim, YDim, WallThickness, InnerFilletRadius, OuterFilletRadius);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRectangleHollowProfileDef },
                { "class", nameof(IfcRectangleHollowProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        XDim,
                        YDim,
                        WallThickness,
                        InnerFilletRadius.ToJValue(),
                        OuterFilletRadius.ToJValue(),
                    }
                }
            };
        }

        public static new IfcRectangleHollowProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRectangleHollowProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToDouble(),
                parameters[5].ToDouble(),
                parameters[6].ToOptionalDouble(),
                parameters[7].ToOptionalDouble());
        }
        #endregion

    }
}