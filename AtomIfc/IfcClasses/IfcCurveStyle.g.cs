
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
    public class IfcCurveStyle : IfcPresentationStyle, IEquatable<IfcCurveStyle>, IIfcPresentationStyleSelect
    {
        private IfcId _curveFontId;
        public IfcId CurveFontId 
        {
            get { 
                return _curveFontId; 
            }
            set { 
                _curveFontId = value;  // optional IfcCurveFontOrScaledCurveFontSelect
            }
        }
        private IfcId _curveWidthId;
        public IfcId CurveWidthId 
        {
            get { 
                return _curveWidthId; 
            }
            set { 
                _curveWidthId = value;  // optional IfcSizeSelect
            }
        }
        private IfcId _curveColourId;
        public IfcId CurveColourId 
        {
            get { 
                return _curveColourId; 
            }
            set { 
                _curveColourId = value;  // optional IfcColour
            }
        }
        private bool? _modelOrDraughting;
        public bool? ModelOrDraughting 
        {
            get { 
                return _modelOrDraughting; 
            }
            set { 
                _modelOrDraughting = value;  // optional bool
            }
        }

        public IfcCurveStyle(IfcId id, string name, IfcId curveFontId, IfcId curveWidthId, IfcId curveColourId, bool? modelOrDraughting) : base(id, name)
        {
            CurveFontId = curveFontId;
            CurveWidthId = curveWidthId;
            CurveColourId = curveColourId;
            ModelOrDraughting = modelOrDraughting;
        }

        public override ClassId GetClassId() => ClassId.IfcCurveStyle;

        #region Equality

        public bool Equals(IfcCurveStyle other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && CurveFontId == other.CurveFontId
                && CurveWidthId == other.CurveWidthId
                && CurveColourId == other.CurveColourId
                && ModelOrDraughting == other.ModelOrDraughting;
        }

        public override bool Equals(object other) => Equals(other as IfcCurveStyle);

        public static bool operator ==(IfcCurveStyle one, IfcCurveStyle other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCurveStyle one, IfcCurveStyle other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{CurveFontId},{CurveWidthId},{CurveColourId},{(ModelOrDraughting == null? ".U." : ModelOrDraughting)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CurveFontId!= null && replacementTable.ContainsKey(CurveFontId))
                CurveFontId = replacementTable[CurveFontId];
            if(CurveWidthId!= null && replacementTable.ContainsKey(CurveWidthId))
                CurveWidthId = replacementTable[CurveWidthId];
            if(CurveColourId!= null && replacementTable.ContainsKey(CurveColourId))
                CurveColourId = replacementTable[CurveColourId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCurveStyle (newId,Name, CurveFontId, CurveWidthId, CurveColourId, ModelOrDraughting);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCurveStyle },
                { "class", nameof(IfcCurveStyle) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        CurveFontId.ToJValue(),
                        CurveWidthId.ToJValue(),
                        CurveColourId.ToJValue(),
                        ModelOrDraughting.ToJValue(),
                    }
                }
            };
        }

        public static IfcCurveStyle CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCurveStyle(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalBool());
        }
        #endregion

    }
}