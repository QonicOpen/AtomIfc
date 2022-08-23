
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
    public class IfcCircleHollowProfileDef : IfcCircleProfileDef, IEquatable<IfcCircleHollowProfileDef>
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

        public IfcCircleHollowProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double radius, double wallThickness) : base(id, profileType, profileName, positionId, radius)
        {
            WallThickness = wallThickness;
        }

        public override ClassId GetClassId() => ClassId.IfcCircleHollowProfileDef;

        #region Equality

        public bool Equals(IfcCircleHollowProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && WallThickness == other.WallThickness;
        }

        public override bool Equals(object other) => Equals(other as IfcCircleHollowProfileDef);

        public static bool operator ==(IfcCircleHollowProfileDef one, IfcCircleHollowProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCircleHollowProfileDef one, IfcCircleHollowProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{Radius},{WallThickness})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCircleHollowProfileDef (newId,ProfileType, ProfileName, PositionId, Radius, WallThickness);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCircleHollowProfileDef },
                { "class", nameof(IfcCircleHollowProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        Radius,
                        WallThickness,
                    }
                }
            };
        }

        public static new IfcCircleHollowProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCircleHollowProfileDef(
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