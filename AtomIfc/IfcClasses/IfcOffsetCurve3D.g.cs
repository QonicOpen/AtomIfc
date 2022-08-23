
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
    public class IfcOffsetCurve3D : IfcCurve, IEquatable<IfcOffsetCurve3D>
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
        private IfcId _refDirectionId;
        public IfcId RefDirectionId 
        {
            get { 
                return _refDirectionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RefDirectionId is not allowed to be null"); 
                _refDirectionId = value;
            }
        }

        public IfcOffsetCurve3D(IfcId id, IfcId basisCurveId, double distance, bool? selfIntersect, IfcId refDirectionId) : base(id)
        {
            BasisCurveId = basisCurveId;
            Distance = distance;
            SelfIntersect = selfIntersect;
            RefDirectionId = refDirectionId;
        }

        public override ClassId GetClassId() => ClassId.IfcOffsetCurve3D;

        #region Equality

        public bool Equals(IfcOffsetCurve3D other)
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
                && SelfIntersect == other.SelfIntersect
                && RefDirectionId == other.RefDirectionId;
        }

        public override bool Equals(object other) => Equals(other as IfcOffsetCurve3D);

        public static bool operator ==(IfcOffsetCurve3D one, IfcOffsetCurve3D other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcOffsetCurve3D one, IfcOffsetCurve3D other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BasisCurveId},{Distance},{(SelfIntersect == null? ".U." : SelfIntersect)},{RefDirectionId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BasisCurveId!= null && replacementTable.ContainsKey(BasisCurveId))
                BasisCurveId = replacementTable[BasisCurveId];
            if(RefDirectionId!= null && replacementTable.ContainsKey(RefDirectionId))
                RefDirectionId = replacementTable[RefDirectionId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcOffsetCurve3D (newId,BasisCurveId, Distance, SelfIntersect, RefDirectionId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcOffsetCurve3D },
                { "class", nameof(IfcOffsetCurve3D) },
                { "parameters" , new JArray
                    {
                        BasisCurveId.ToJValue(),
                        Distance,
                        SelfIntersect.ToJValue(),
                        RefDirectionId.ToJValue(),
                    }
                }
            };
        }

        public static IfcOffsetCurve3D CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcOffsetCurve3D(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToOptionalBool(),
                parameters[3].ToIfcId());
        }
        #endregion

    }
}