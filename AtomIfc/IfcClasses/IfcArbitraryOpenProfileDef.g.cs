
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
    public class IfcArbitraryOpenProfileDef : IfcProfileDef, IEquatable<IfcArbitraryOpenProfileDef>
    {
        private IfcId _curveId;
        public IfcId CurveId 
        {
            get { 
                return _curveId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("CurveId is not allowed to be null"); 
                _curveId = value;
            }
        }

        public IfcArbitraryOpenProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId curveId) : base(id, profileType, profileName)
        {
            CurveId = curveId;
        }

        public override ClassId GetClassId() => ClassId.IfcArbitraryOpenProfileDef;

        #region Equality

        public bool Equals(IfcArbitraryOpenProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && CurveId == other.CurveId;
        }

        public override bool Equals(object other) => Equals(other as IfcArbitraryOpenProfileDef);

        public static bool operator ==(IfcArbitraryOpenProfileDef one, IfcArbitraryOpenProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcArbitraryOpenProfileDef one, IfcArbitraryOpenProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{CurveId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CurveId!= null && replacementTable.ContainsKey(CurveId))
                CurveId = replacementTable[CurveId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcArbitraryOpenProfileDef (newId,ProfileType, ProfileName, CurveId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcArbitraryOpenProfileDef },
                { "class", nameof(IfcArbitraryOpenProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        CurveId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcArbitraryOpenProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcArbitraryOpenProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}