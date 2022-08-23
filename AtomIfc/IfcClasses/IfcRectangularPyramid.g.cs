
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
    public class IfcRectangularPyramid : IfcCsgPrimitive3D, IEquatable<IfcRectangularPyramid>
    {
        private double _xLength;
        public double XLength 
        {
            get { 
                return _xLength; 
            }
            set { 
                _xLength = value;
            }
        }
        private double _yLength;
        public double YLength 
        {
            get { 
                return _yLength; 
            }
            set { 
                _yLength = value;
            }
        }
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

        public IfcRectangularPyramid(IfcId id, IfcId positionId, double xLength, double yLength, double height) : base(id, positionId)
        {
            XLength = xLength;
            YLength = yLength;
            Height = height;
        }

        public override ClassId GetClassId() => ClassId.IfcRectangularPyramid;

        #region Equality

        public bool Equals(IfcRectangularPyramid other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && XLength == other.XLength
                && YLength == other.YLength
                && Height == other.Height;
        }

        public override bool Equals(object other) => Equals(other as IfcRectangularPyramid);

        public static bool operator ==(IfcRectangularPyramid one, IfcRectangularPyramid other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRectangularPyramid one, IfcRectangularPyramid other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PositionId},{XLength},{YLength},{Height})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRectangularPyramid (newId,PositionId, XLength, YLength, Height);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRectangularPyramid },
                { "class", nameof(IfcRectangularPyramid) },
                { "parameters" , new JArray
                    {
                        PositionId.ToJValue(),
                        XLength,
                        YLength,
                        Height,
                    }
                }
            };
        }

        public static IfcRectangularPyramid CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRectangularPyramid(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToDouble(),
                parameters[3].ToDouble());
        }
        #endregion

    }
}