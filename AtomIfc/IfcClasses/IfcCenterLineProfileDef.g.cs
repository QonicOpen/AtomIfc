
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
    public class IfcCenterLineProfileDef : IfcArbitraryOpenProfileDef, IEquatable<IfcCenterLineProfileDef>
    {
        private double _thickness;
        public double Thickness 
        {
            get { 
                return _thickness; 
            }
            set { 
                _thickness = value;
            }
        }

        public IfcCenterLineProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId curveId, double thickness) : base(id, profileType, profileName, curveId)
        {
            Thickness = thickness;
        }

        public override ClassId GetClassId() => ClassId.IfcCenterLineProfileDef;

        #region Equality

        public bool Equals(IfcCenterLineProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Thickness == other.Thickness;
        }

        public override bool Equals(object other) => Equals(other as IfcCenterLineProfileDef);

        public static bool operator ==(IfcCenterLineProfileDef one, IfcCenterLineProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCenterLineProfileDef one, IfcCenterLineProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{CurveId},{Thickness})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCenterLineProfileDef (newId,ProfileType, ProfileName, CurveId, Thickness);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCenterLineProfileDef },
                { "class", nameof(IfcCenterLineProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        CurveId.ToJValue(),
                        Thickness,
                    }
                }
            };
        }

        public static new IfcCenterLineProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCenterLineProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToDouble());
        }
        #endregion

    }
}