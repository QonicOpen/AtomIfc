
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
    public class IfcRectangleProfileDef : IfcParameterizedProfileDef, IEquatable<IfcRectangleProfileDef>
    {
        private double _xDim;
        public double XDim 
        {
            get { 
                return _xDim; 
            }
            set { 
                _xDim = value;
            }
        }
        private double _yDim;
        public double YDim 
        {
            get { 
                return _yDim; 
            }
            set { 
                _yDim = value;
            }
        }

        public IfcRectangleProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double xDim, double yDim) : base(id, profileType, profileName, positionId)
        {
            XDim = xDim;
            YDim = yDim;
        }

        public override ClassId GetClassId() => ClassId.IfcRectangleProfileDef;

        #region Equality

        public bool Equals(IfcRectangleProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && XDim == other.XDim
                && YDim == other.YDim;
        }

        public override bool Equals(object other) => Equals(other as IfcRectangleProfileDef);

        public static bool operator ==(IfcRectangleProfileDef one, IfcRectangleProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRectangleProfileDef one, IfcRectangleProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{XDim},{YDim})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRectangleProfileDef (newId,ProfileType, ProfileName, PositionId, XDim, YDim);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRectangleProfileDef },
                { "class", nameof(IfcRectangleProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        XDim,
                        YDim,
                    }
                }
            };
        }

        public static new IfcRectangleProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRectangleProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToDouble());
        }
        #endregion

    }
}