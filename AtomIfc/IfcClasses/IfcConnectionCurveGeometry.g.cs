
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
    public class IfcConnectionCurveGeometry : IfcConnectionGeometry, IEquatable<IfcConnectionCurveGeometry>
    {
        private IfcId _curveOnRelatingElementId;
        public IfcId CurveOnRelatingElementId 
        {
            get { 
                return _curveOnRelatingElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("CurveOnRelatingElementId is not allowed to be null"); 
                _curveOnRelatingElementId = value;
            }
        }
        private IfcId _curveOnRelatedElementId;
        public IfcId CurveOnRelatedElementId 
        {
            get { 
                return _curveOnRelatedElementId; 
            }
            set { 
                _curveOnRelatedElementId = value;  // optional IfcCurveOrEdgeCurve
            }
        }

        public IfcConnectionCurveGeometry(IfcId id, IfcId curveOnRelatingElementId, IfcId curveOnRelatedElementId) : base(id)
        {
            CurveOnRelatingElementId = curveOnRelatingElementId;
            CurveOnRelatedElementId = curveOnRelatedElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcConnectionCurveGeometry;

        #region Equality

        public bool Equals(IfcConnectionCurveGeometry other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && CurveOnRelatingElementId == other.CurveOnRelatingElementId
                && CurveOnRelatedElementId == other.CurveOnRelatedElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcConnectionCurveGeometry);

        public static bool operator ==(IfcConnectionCurveGeometry one, IfcConnectionCurveGeometry other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConnectionCurveGeometry one, IfcConnectionCurveGeometry other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({CurveOnRelatingElementId},{CurveOnRelatedElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CurveOnRelatingElementId!= null && replacementTable.ContainsKey(CurveOnRelatingElementId))
                CurveOnRelatingElementId = replacementTable[CurveOnRelatingElementId];
            if(CurveOnRelatedElementId!= null && replacementTable.ContainsKey(CurveOnRelatedElementId))
                CurveOnRelatedElementId = replacementTable[CurveOnRelatedElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcConnectionCurveGeometry (newId,CurveOnRelatingElementId, CurveOnRelatedElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcConnectionCurveGeometry },
                { "class", nameof(IfcConnectionCurveGeometry) },
                { "parameters" , new JArray
                    {
                        CurveOnRelatingElementId.ToJValue(),
                        CurveOnRelatedElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcConnectionCurveGeometry CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcConnectionCurveGeometry(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId());
        }
        #endregion

    }
}