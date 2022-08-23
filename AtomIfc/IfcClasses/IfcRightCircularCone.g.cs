
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
    public class IfcRightCircularCone : IfcCsgPrimitive3D, IEquatable<IfcRightCircularCone>
    {
        private double _height;
        public double Height 
        {
            get { 
                return _height; 
            }
            set { 
                _height = value;
            }
        }
        private double _bottomRadius;
        public double BottomRadius 
        {
            get { 
                return _bottomRadius; 
            }
            set { 
                _bottomRadius = value;
            }
        }

        public IfcRightCircularCone(IfcId id, IfcId positionId, double height, double bottomRadius) : base(id, positionId)
        {
            Height = height;
            BottomRadius = bottomRadius;
        }

        public override ClassId GetClassId() => ClassId.IfcRightCircularCone;

        #region Equality

        public bool Equals(IfcRightCircularCone other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Height == other.Height
                && BottomRadius == other.BottomRadius;
        }

        public override bool Equals(object other) => Equals(other as IfcRightCircularCone);

        public static bool operator ==(IfcRightCircularCone one, IfcRightCircularCone other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRightCircularCone one, IfcRightCircularCone other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PositionId},{Height},{BottomRadius})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRightCircularCone (newId,PositionId, Height, BottomRadius);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRightCircularCone },
                { "class", nameof(IfcRightCircularCone) },
                { "parameters" , new JArray
                    {
                        PositionId.ToJValue(),
                        Height,
                        BottomRadius,
                    }
                }
            };
        }

        public static IfcRightCircularCone CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRightCircularCone(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToDouble());
        }
        #endregion

    }
}