
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
    public class IfcCurveStyleFontAndScaling : IfcPresentationItem, IEquatable<IfcCurveStyleFontAndScaling>, IIfcCurveFontOrScaledCurveFontSelect
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;  // optional IfcLabel
            }
        }
        private IfcId _curveFontId;
        public IfcId CurveFontId 
        {
            get { 
                return _curveFontId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("CurveFontId is not allowed to be null"); 
                _curveFontId = value;
            }
        }
        private double _curveFontScaling;
        public double CurveFontScaling 
        {
            get { 
                return _curveFontScaling; 
            }
            set { 
                _curveFontScaling = value;
            }
        }

        public IfcCurveStyleFontAndScaling(IfcId id, string name, IfcId curveFontId, double curveFontScaling) : base(id)
        {
            Name = name;
            CurveFontId = curveFontId;
            CurveFontScaling = curveFontScaling;
        }

        public override ClassId GetClassId() => ClassId.IfcCurveStyleFontAndScaling;

        #region Equality

        public bool Equals(IfcCurveStyleFontAndScaling other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name
                && CurveFontId == other.CurveFontId
                && CurveFontScaling == other.CurveFontScaling;
        }

        public override bool Equals(object other) => Equals(other as IfcCurveStyleFontAndScaling);

        public static bool operator ==(IfcCurveStyleFontAndScaling one, IfcCurveStyleFontAndScaling other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCurveStyleFontAndScaling one, IfcCurveStyleFontAndScaling other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{CurveFontId},{CurveFontScaling})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CurveFontId!= null && replacementTable.ContainsKey(CurveFontId))
                CurveFontId = replacementTable[CurveFontId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCurveStyleFontAndScaling (newId,Name, CurveFontId, CurveFontScaling);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCurveStyleFontAndScaling },
                { "class", nameof(IfcCurveStyleFontAndScaling) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        CurveFontId.ToJValue(),
                        CurveFontScaling,
                    }
                }
            };
        }

        public static IfcCurveStyleFontAndScaling CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCurveStyleFontAndScaling(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToIfcId(),
                parameters[2].ToDouble());
        }
        #endregion

    }
}