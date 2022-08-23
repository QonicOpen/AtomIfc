
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
    public class IfcRightCircularCylinder : IfcCsgPrimitive3D, IEquatable<IfcRightCircularCylinder>
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
        private double _radius;
        public double Radius 
        {
            get { 
                return _radius; 
            }
            set { 
                _radius = value;
            }
        }

        public IfcRightCircularCylinder(IfcId id, IfcId positionId, double height, double radius) : base(id, positionId)
        {
            Height = height;
            Radius = radius;
        }

        public override ClassId GetClassId() => ClassId.IfcRightCircularCylinder;

        #region Equality

        public bool Equals(IfcRightCircularCylinder other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Height == other.Height
                && Radius == other.Radius;
        }

        public override bool Equals(object other) => Equals(other as IfcRightCircularCylinder);

        public static bool operator ==(IfcRightCircularCylinder one, IfcRightCircularCylinder other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRightCircularCylinder one, IfcRightCircularCylinder other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PositionId},{Height},{Radius})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRightCircularCylinder (newId,PositionId, Height, Radius);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRightCircularCylinder },
                { "class", nameof(IfcRightCircularCylinder) },
                { "parameters" , new JArray
                    {
                        PositionId.ToJValue(),
                        Height,
                        Radius,
                    }
                }
            };
        }

        public static IfcRightCircularCylinder CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRightCircularCylinder(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToDouble());
        }
        #endregion

    }
}