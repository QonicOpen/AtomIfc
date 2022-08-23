
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
    public class IfcBlock : IfcCsgPrimitive3D, IEquatable<IfcBlock>
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
        private double _zLength;
        public double ZLength 
        {
            get { 
                return _zLength; 
            }
            set { 
                _zLength = value;
            }
        }

        public IfcBlock(IfcId id, IfcId positionId, double xLength, double yLength, double zLength) : base(id, positionId)
        {
            XLength = xLength;
            YLength = yLength;
            ZLength = zLength;
        }

        public override ClassId GetClassId() => ClassId.IfcBlock;

        #region Equality

        public bool Equals(IfcBlock other)
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
                && ZLength == other.ZLength;
        }

        public override bool Equals(object other) => Equals(other as IfcBlock);

        public static bool operator ==(IfcBlock one, IfcBlock other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBlock one, IfcBlock other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PositionId},{XLength},{YLength},{ZLength})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBlock (newId,PositionId, XLength, YLength, ZLength);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBlock },
                { "class", nameof(IfcBlock) },
                { "parameters" , new JArray
                    {
                        PositionId.ToJValue(),
                        XLength,
                        YLength,
                        ZLength,
                    }
                }
            };
        }

        public static IfcBlock CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBlock(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToDouble(),
                parameters[3].ToDouble());
        }
        #endregion

    }
}