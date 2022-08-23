
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
    public class IfcIndexedPolyCurve : IfcBoundedCurve, IEquatable<IfcIndexedPolyCurve>
    {
        private IfcId _pointsId;
        public IfcId PointsId 
        {
            get { 
                return _pointsId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PointsId is not allowed to be null"); 
                _pointsId = value;
            }
        }
        private IfcId _segmentsId;
        public IfcId SegmentsId 
        {
            get { 
                return _segmentsId; 
            }
            set { 
                _segmentsId = value;  // optional IfcSegmentIndexSelect
            }
        }
        private bool? _selfIntersect;
        public bool? SelfIntersect 
        {
            get { 
                return _selfIntersect; 
            }
            set { 
                _selfIntersect = value;  // optional bool?
            }
        }

        public IfcIndexedPolyCurve(IfcId id, IfcId pointsId, IfcId segmentsId, bool? selfIntersect) : base(id)
        {
            PointsId = pointsId;
            SegmentsId = segmentsId;
            SelfIntersect = selfIntersect;
        }

        public override ClassId GetClassId() => ClassId.IfcIndexedPolyCurve;

        #region Equality

        public bool Equals(IfcIndexedPolyCurve other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PointsId == other.PointsId
                && SegmentsId == other.SegmentsId
                && SelfIntersect == other.SelfIntersect;
        }

        public override bool Equals(object other) => Equals(other as IfcIndexedPolyCurve);

        public static bool operator ==(IfcIndexedPolyCurve one, IfcIndexedPolyCurve other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcIndexedPolyCurve one, IfcIndexedPolyCurve other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PointsId},{SegmentsId},{(SelfIntersect == null? ".U." : SelfIntersect)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PointsId!= null && replacementTable.ContainsKey(PointsId))
                PointsId = replacementTable[PointsId];
            if(SegmentsId!= null && replacementTable.ContainsKey(SegmentsId))
                SegmentsId = replacementTable[SegmentsId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcIndexedPolyCurve (newId,PointsId, SegmentsId, SelfIntersect);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcIndexedPolyCurve },
                { "class", nameof(IfcIndexedPolyCurve) },
                { "parameters" , new JArray
                    {
                        PointsId.ToJValue(),
                        SegmentsId.ToJValue(),
                        SelfIntersect.ToJValue(),
                    }
                }
            };
        }

        public static IfcIndexedPolyCurve CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcIndexedPolyCurve(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalBool());
        }
        #endregion

    }
}