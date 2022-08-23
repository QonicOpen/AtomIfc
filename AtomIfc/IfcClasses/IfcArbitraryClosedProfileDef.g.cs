
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
    public class IfcArbitraryClosedProfileDef : IfcProfileDef, IEquatable<IfcArbitraryClosedProfileDef>
    {
        private IfcId _outerCurveId;
        public IfcId OuterCurveId 
        {
            get { 
                return _outerCurveId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OuterCurveId is not allowed to be null"); 
                _outerCurveId = value;
            }
        }

        public IfcArbitraryClosedProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId outerCurveId) : base(id, profileType, profileName)
        {
            OuterCurveId = outerCurveId;
        }

        public override ClassId GetClassId() => ClassId.IfcArbitraryClosedProfileDef;

        #region Equality

        public bool Equals(IfcArbitraryClosedProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && OuterCurveId == other.OuterCurveId;
        }

        public override bool Equals(object other) => Equals(other as IfcArbitraryClosedProfileDef);

        public static bool operator ==(IfcArbitraryClosedProfileDef one, IfcArbitraryClosedProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcArbitraryClosedProfileDef one, IfcArbitraryClosedProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{OuterCurveId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(OuterCurveId!= null && replacementTable.ContainsKey(OuterCurveId))
                OuterCurveId = replacementTable[OuterCurveId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcArbitraryClosedProfileDef (newId,ProfileType, ProfileName, OuterCurveId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcArbitraryClosedProfileDef },
                { "class", nameof(IfcArbitraryClosedProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        OuterCurveId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcArbitraryClosedProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcArbitraryClosedProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}