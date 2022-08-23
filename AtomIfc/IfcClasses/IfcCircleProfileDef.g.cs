
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
    public class IfcCircleProfileDef : IfcParameterizedProfileDef, IEquatable<IfcCircleProfileDef>
    {
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

        public IfcCircleProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double radius) : base(id, profileType, profileName, positionId)
        {
            Radius = radius;
        }

        public override ClassId GetClassId() => ClassId.IfcCircleProfileDef;

        #region Equality

        public bool Equals(IfcCircleProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Radius == other.Radius;
        }

        public override bool Equals(object other) => Equals(other as IfcCircleProfileDef);

        public static bool operator ==(IfcCircleProfileDef one, IfcCircleProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCircleProfileDef one, IfcCircleProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{Radius})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCircleProfileDef (newId,ProfileType, ProfileName, PositionId, Radius);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCircleProfileDef },
                { "class", nameof(IfcCircleProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        Radius,
                    }
                }
            };
        }

        public static new IfcCircleProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCircleProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble());
        }
        #endregion

    }
}