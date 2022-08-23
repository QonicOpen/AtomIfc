
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
    public class IfcOffsetCurve2D : IfcCurve, IEquatable<IfcOffsetCurve2D>
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
        private double _distance;
        public double Distance 
        {
            get { 
                return _distance; 
            }
            set { 
                _distance = value;
            }
        }
        private bool? _selfIntersect;
        public bool? SelfIntersect 
        {
            get { 
                return _selfIntersect; 
            }
            set { 
                _selfIntersect = value;
            }
        }

        public IfcOffsetCurve2D(IfcId id, IfcId basisCurveId, double distance, bool? selfIntersect) : base(id)
        {
            BasisCurveId = basisCurveId;
            Distance = distance;
            SelfIntersect = selfIntersect;
        }

        public override ClassId GetClassId() => ClassId.IfcOffsetCurve2D;

        #region Equality

        public bool Equals(IfcOffsetCurve2D other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && BasisCurveId == other.BasisCurveId
                && Distance == other.Distance
                && SelfIntersect == other.SelfIntersect;
        }

        public override bool Equals(object other) => Equals(other as IfcOffsetCurve2D);

        public static bool operator ==(IfcOffsetCurve2D one, IfcOffsetCurve2D other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcOffsetCurve2D one, IfcOffsetCurve2D other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BasisCurveId},{Distance},{(SelfIntersect == null? ".U." : SelfIntersect)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BasisCurveId!= null && replacementTable.ContainsKey(BasisCurveId))
                BasisCurveId = replacementTable[BasisCurveId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcOffsetCurve2D (newId,BasisCurveId, Distance, SelfIntersect);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcOffsetCurve2D },
                { "class", nameof(IfcOffsetCurve2D) },
                { "parameters" , new JArray
                    {
                        BasisCurveId.ToJValue(),
                        Distance,
                        SelfIntersect.ToJValue(),
                    }
                }
            };
        }

        public static IfcOffsetCurve2D CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcOffsetCurve2D(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToOptionalBool());
        }
        #endregion

    }
}