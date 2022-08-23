
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
    public class IfcPointOnSurface : IfcPoint, IEquatable<IfcPointOnSurface>
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
        private double _pointParameterU;
        public double PointParameterU 
        {
            get { 
                return _pointParameterU; 
            }
            set { 
                _pointParameterU = value;
            }
        }
        private double _pointParameterV;
        public double PointParameterV 
        {
            get { 
                return _pointParameterV; 
            }
            set { 
                _pointParameterV = value;
            }
        }

        public IfcPointOnSurface(IfcId id, IfcId basisSurfaceId, double pointParameterU, double pointParameterV) : base(id)
        {
            BasisSurfaceId = basisSurfaceId;
            PointParameterU = pointParameterU;
            PointParameterV = pointParameterV;
        }

        public override ClassId GetClassId() => ClassId.IfcPointOnSurface;

        #region Equality

        public bool Equals(IfcPointOnSurface other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && BasisSurfaceId == other.BasisSurfaceId
                && PointParameterU == other.PointParameterU
                && PointParameterV == other.PointParameterV;
        }

        public override bool Equals(object other) => Equals(other as IfcPointOnSurface);

        public static bool operator ==(IfcPointOnSurface one, IfcPointOnSurface other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPointOnSurface one, IfcPointOnSurface other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BasisSurfaceId},{PointParameterU},{PointParameterV})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BasisSurfaceId!= null && replacementTable.ContainsKey(BasisSurfaceId))
                BasisSurfaceId = replacementTable[BasisSurfaceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPointOnSurface (newId,BasisSurfaceId, PointParameterU, PointParameterV);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPointOnSurface },
                { "class", nameof(IfcPointOnSurface) },
                { "parameters" , new JArray
                    {
                        BasisSurfaceId.ToJValue(),
                        PointParameterU,
                        PointParameterV,
                    }
                }
            };
        }

        public static IfcPointOnSurface CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPointOnSurface(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToDouble());
        }
        #endregion

    }
}