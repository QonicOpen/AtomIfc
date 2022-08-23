
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
    public class IfcCompositeCurve : IfcBoundedCurve, IEquatable<IfcCompositeCurve>
    {
        private List<IfcId> _segmentIds;
        public List<IfcId> SegmentIds 
        {
            get { 
                return _segmentIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SegmentIds is not allowed to be null"); 
                _segmentIds = value;
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

        public IfcCompositeCurve(IfcId id, List<IfcId> segmentIds, bool? selfIntersect) : base(id)
        {
            SegmentIds = segmentIds;
            SelfIntersect = selfIntersect;
        }

        public override ClassId GetClassId() => ClassId.IfcCompositeCurve;

        #region Equality

        public bool Equals(IfcCompositeCurve other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(SegmentIds, other.SegmentIds))
                return false;
            return base.Equals(other)
                && SelfIntersect == other.SelfIntersect;
        }

        public override bool Equals(object other) => Equals(other as IfcCompositeCurve);

        public static bool operator ==(IfcCompositeCurve one, IfcCompositeCurve other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCompositeCurve one, IfcCompositeCurve other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(SegmentIds)},{(SelfIntersect == null? ".U." : SelfIntersect)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(SegmentIds!= null)
                SegmentIds = SegmentIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCompositeCurve (newId,SegmentIds, SelfIntersect);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCompositeCurve },
                { "class", nameof(IfcCompositeCurve) },
                { "parameters" , new JArray
                    {
                        SegmentIds.ToJArray(),
                        SelfIntersect.ToJValue(),
                    }
                }
            };
        }

        public static IfcCompositeCurve CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCompositeCurve(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToOptionalBool());
        }
        #endregion

    }
}