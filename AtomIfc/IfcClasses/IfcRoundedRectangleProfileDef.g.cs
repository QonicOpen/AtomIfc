
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
    public class IfcRoundedRectangleProfileDef : IfcRectangleProfileDef, IEquatable<IfcRoundedRectangleProfileDef>
    {
        private double _roundingRadius;
        public double RoundingRadius 
        {
            get { 
                return _roundingRadius; 
            }
            set { 
                _roundingRadius = value;
            }
        }

        public IfcRoundedRectangleProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double xDim, double yDim, double roundingRadius) : base(id, profileType, profileName, positionId, xDim, yDim)
        {
            RoundingRadius = roundingRadius;
        }

        public override ClassId GetClassId() => ClassId.IfcRoundedRectangleProfileDef;

        #region Equality

        public bool Equals(IfcRoundedRectangleProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RoundingRadius == other.RoundingRadius;
        }

        public override bool Equals(object other) => Equals(other as IfcRoundedRectangleProfileDef);

        public static bool operator ==(IfcRoundedRectangleProfileDef one, IfcRoundedRectangleProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRoundedRectangleProfileDef one, IfcRoundedRectangleProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{XDim},{YDim},{RoundingRadius})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRoundedRectangleProfileDef (newId,ProfileType, ProfileName, PositionId, XDim, YDim, RoundingRadius);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRoundedRectangleProfileDef },
                { "class", nameof(IfcRoundedRectangleProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        XDim,
                        YDim,
                        RoundingRadius,
                    }
                }
            };
        }

        public static new IfcRoundedRectangleProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRoundedRectangleProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToDouble(),
                parameters[5].ToDouble());
        }
        #endregion

    }
}