
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
    public class IfcPcurve : IfcCurve, IEquatable<IfcPcurve>, IIfcCurveOnSurface
    {
        private IfcId _basisSurfaceId;
        public IfcId BasisSurfaceId 
        {
            get { 
                return _basisSurfaceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("BasisSurfaceId is not allowed to be null"); 
                _basisSurfaceId = value;
            }
        }
        private IfcId _referenceCurveId;
        public IfcId ReferenceCurveId 
        {
            get { 
                return _referenceCurveId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ReferenceCurveId is not allowed to be null"); 
                _referenceCurveId = value;
            }
        }

        public IfcPcurve(IfcId id, IfcId basisSurfaceId, IfcId referenceCurveId) : base(id)
        {
            BasisSurfaceId = basisSurfaceId;
            ReferenceCurveId = referenceCurveId;
        }

        public override ClassId GetClassId() => ClassId.IfcPcurve;

        #region Equality

        public bool Equals(IfcPcurve other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && BasisSurfaceId == other.BasisSurfaceId
                && ReferenceCurveId == other.ReferenceCurveId;
        }

        public override bool Equals(object other) => Equals(other as IfcPcurve);

        public static bool operator ==(IfcPcurve one, IfcPcurve other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPcurve one, IfcPcurve other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BasisSurfaceId},{ReferenceCurveId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BasisSurfaceId!= null && replacementTable.ContainsKey(BasisSurfaceId))
                BasisSurfaceId = replacementTable[BasisSurfaceId];
            if(ReferenceCurveId!= null && replacementTable.ContainsKey(ReferenceCurveId))
                ReferenceCurveId = replacementTable[ReferenceCurveId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPcurve (newId,BasisSurfaceId, ReferenceCurveId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPcurve },
                { "class", nameof(IfcPcurve) },
                { "parameters" , new JArray
                    {
                        BasisSurfaceId.ToJValue(),
                        ReferenceCurveId.ToJValue(),
                    }
                }
            };
        }

        public static IfcPcurve CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPcurve(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId());
        }
        #endregion

    }
}