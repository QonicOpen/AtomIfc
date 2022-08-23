
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
    public class IfcCurveStyleFontPattern : IfcPresentationItem, IEquatable<IfcCurveStyleFontPattern>
    {
        private double _visibleSegmentLength;
        public double VisibleSegmentLength 
        {
            get { 
                return _visibleSegmentLength; 
            }
            set { 
                _visibleSegmentLength = value;
            }
        }
        private double _invisibleSegmentLength;
        public double InvisibleSegmentLength 
        {
            get { 
                return _invisibleSegmentLength; 
            }
            set { 
                _invisibleSegmentLength = value;
            }
        }

        public IfcCurveStyleFontPattern(IfcId id, double visibleSegmentLength, double invisibleSegmentLength) : base(id)
        {
            VisibleSegmentLength = visibleSegmentLength;
            InvisibleSegmentLength = invisibleSegmentLength;
        }

        public override ClassId GetClassId() => ClassId.IfcCurveStyleFontPattern;

        #region Equality

        public bool Equals(IfcCurveStyleFontPattern other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && VisibleSegmentLength == other.VisibleSegmentLength
                && InvisibleSegmentLength == other.InvisibleSegmentLength;
        }

        public override bool Equals(object other) => Equals(other as IfcCurveStyleFontPattern);

        public static bool operator ==(IfcCurveStyleFontPattern one, IfcCurveStyleFontPattern other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCurveStyleFontPattern one, IfcCurveStyleFontPattern other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({VisibleSegmentLength},{InvisibleSegmentLength})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCurveStyleFontPattern (newId,VisibleSegmentLength, InvisibleSegmentLength);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCurveStyleFontPattern },
                { "class", nameof(IfcCurveStyleFontPattern) },
                { "parameters" , new JArray
                    {
                        VisibleSegmentLength,
                        InvisibleSegmentLength,
                    }
                }
            };
        }

        public static IfcCurveStyleFontPattern CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCurveStyleFontPattern(
                jObject["id"].ToIfcId(),
                parameters[0].ToDouble(),
                parameters[1].ToDouble());
        }
        #endregion

    }
}