
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
    public class IfcPointOnCurve : IfcPoint, IEquatable<IfcPointOnCurve>
    {
        private IfcId _basisCurveId;
        public IfcId BasisCurveId 
        {
            get { 
                return _basisCurveId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("BasisCurveId is not allowed to be null"); 
                _basisCurveId = value;
            }
        }
        private double _pointParameter;
        public double PointParameter 
        {
            get { 
                return _pointParameter; 
            }
            set { 
                _pointParameter = value;
            }
        }

        public IfcPointOnCurve(IfcId id, IfcId basisCurveId, double pointParameter) : base(id)
        {
            BasisCurveId = basisCurveId;
            PointParameter = pointParameter;
        }

        public override ClassId GetClassId() => ClassId.IfcPointOnCurve;

        #region Equality

        public bool Equals(IfcPointOnCurve other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && BasisCurveId == other.BasisCurveId
                && PointParameter == other.PointParameter;
        }

        public override bool Equals(object other) => Equals(other as IfcPointOnCurve);

        public static bool operator ==(IfcPointOnCurve one, IfcPointOnCurve other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPointOnCurve one, IfcPointOnCurve other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BasisCurveId},{PointParameter})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BasisCurveId!= null && replacementTable.ContainsKey(BasisCurveId))
                BasisCurveId = replacementTable[BasisCurveId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPointOnCurve (newId,BasisCurveId, PointParameter);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPointOnCurve },
                { "class", nameof(IfcPointOnCurve) },
                { "parameters" , new JArray
                    {
                        BasisCurveId.ToJValue(),
                        PointParameter,
                    }
                }
            };
        }

        public static IfcPointOnCurve CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPointOnCurve(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble());
        }
        #endregion

    }
}