
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
    public class IfcArbitraryProfileDefWithVoids : IfcArbitraryClosedProfileDef, IEquatable<IfcArbitraryProfileDefWithVoids>
    {
        private List<IfcId> _innerCurveIds;
        public List<IfcId> InnerCurveIds 
        {
            get { 
                return _innerCurveIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("InnerCurveIds is not allowed to be null"); 
                _innerCurveIds = value;
            }
        }

        public IfcArbitraryProfileDefWithVoids(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId outerCurveId, List<IfcId> innerCurveIds) : base(id, profileType, profileName, outerCurveId)
        {
            InnerCurveIds = innerCurveIds;
        }

        public override ClassId GetClassId() => ClassId.IfcArbitraryProfileDefWithVoids;

        #region Equality

        public bool Equals(IfcArbitraryProfileDefWithVoids other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(InnerCurveIds, other.InnerCurveIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcArbitraryProfileDefWithVoids);

        public static bool operator ==(IfcArbitraryProfileDefWithVoids one, IfcArbitraryProfileDefWithVoids other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcArbitraryProfileDefWithVoids one, IfcArbitraryProfileDefWithVoids other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{OuterCurveId},{Utils.ConvertListToString(InnerCurveIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(InnerCurveIds!= null)
                InnerCurveIds = InnerCurveIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcArbitraryProfileDefWithVoids (newId,ProfileType, ProfileName, OuterCurveId, InnerCurveIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcArbitraryProfileDefWithVoids },
                { "class", nameof(IfcArbitraryProfileDefWithVoids) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        OuterCurveId.ToJValue(),
                        InnerCurveIds.ToJArray(),
                    }
                }
            };
        }

        public static new IfcArbitraryProfileDefWithVoids CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcArbitraryProfileDefWithVoids(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcIdList());
        }
        #endregion

    }
}