
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
    public class IfcGridAxis : IfcBase, IEquatable<IfcGridAxis>
    {
        private string _axisTag;
        public string AxisTag 
        {
            get { 
                return _axisTag; 
            }
            set { 
                _axisTag = value;  // optional IfcLabel
            }
        }
        private IfcId _axisCurveId;
        public IfcId AxisCurveId 
        {
            get { 
                return _axisCurveId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("AxisCurveId is not allowed to be null"); 
                _axisCurveId = value;
            }
        }
        private IfcId _sameSenseId;
        public IfcId SameSenseId 
        {
            get { 
                return _sameSenseId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SameSenseId is not allowed to be null"); 
                _sameSenseId = value;
            }
        }

        public IfcGridAxis(IfcId id, string axisTag, IfcId axisCurveId, IfcId sameSenseId) : base(id)
        {
            AxisTag = axisTag;
            AxisCurveId = axisCurveId;
            SameSenseId = sameSenseId;
        }

        public override ClassId GetClassId() => ClassId.IfcGridAxis;

        #region Equality

        public bool Equals(IfcGridAxis other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && AxisTag == other.AxisTag
                && AxisCurveId == other.AxisCurveId
                && SameSenseId == other.SameSenseId;
        }

        public override bool Equals(object other) => Equals(other as IfcGridAxis);

        public static bool operator ==(IfcGridAxis one, IfcGridAxis other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcGridAxis one, IfcGridAxis other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{AxisTag}',{AxisCurveId},{SameSenseId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(AxisCurveId!= null && replacementTable.ContainsKey(AxisCurveId))
                AxisCurveId = replacementTable[AxisCurveId];
            if(SameSenseId!= null && replacementTable.ContainsKey(SameSenseId))
                SameSenseId = replacementTable[SameSenseId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcGridAxis (newId,AxisTag, AxisCurveId, SameSenseId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcGridAxis },
                { "class", nameof(IfcGridAxis) },
                { "parameters" , new JArray
                    {
                        AxisTag.ToJValue(),
                        AxisCurveId.ToJValue(),
                        SameSenseId.ToJValue(),
                    }
                }
            };
        }

        public static IfcGridAxis CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcGridAxis(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToIfcId(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}