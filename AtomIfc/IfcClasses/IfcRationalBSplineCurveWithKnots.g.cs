
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
    public class IfcRationalBSplineCurveWithKnots : IfcBSplineCurveWithKnots, IEquatable<IfcRationalBSplineCurveWithKnots>
    {
        private List<double> _weightsData;
        public List<double> WeightsData 
        {
            get { 
                return _weightsData; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("WeightsData is not allowed to be null"); 
                _weightsData = value;
            }
        }

        public IfcRationalBSplineCurveWithKnots(IfcId id, int degree, List<IfcId> controlPointIds, IfcBSplineCurveForm curveForm, bool? closedCurve, bool? selfIntersect, List<int> knotMultiplicities, List<double> knots, IfcKnotType knotSpec, List<double> weightsData) : base(id, degree, controlPointIds, curveForm, closedCurve, selfIntersect, knotMultiplicities, knots, knotSpec)
        {
            WeightsData = weightsData;
        }

        public override ClassId GetClassId() => ClassId.IfcRationalBSplineCurveWithKnots;

        #region Equality

        public bool Equals(IfcRationalBSplineCurveWithKnots other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(WeightsData, other.WeightsData))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcRationalBSplineCurveWithKnots);

        public static bool operator ==(IfcRationalBSplineCurveWithKnots one, IfcRationalBSplineCurveWithKnots other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRationalBSplineCurveWithKnots one, IfcRationalBSplineCurveWithKnots other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Degree},{Utils.ConvertListToString(ControlPointIds)},.{CurveForm}.,{(ClosedCurve == null? ".U." : ClosedCurve)},{(SelfIntersect == null? ".U." : SelfIntersect)},{Utils.ConvertListToString(KnotMultiplicities)},{Utils.ConvertListToString(Knots)},.{KnotSpec}.,{Utils.ConvertListToString(WeightsData)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRationalBSplineCurveWithKnots (newId,Degree, ControlPointIds, CurveForm, ClosedCurve, SelfIntersect, KnotMultiplicities, Knots, KnotSpec, WeightsData);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRationalBSplineCurveWithKnots },
                { "class", nameof(IfcRationalBSplineCurveWithKnots) },
                { "parameters" , new JArray
                    {
                        Degree,
                        ControlPointIds.ToJArray(),
                        CurveForm.ToJValue(),
                        ClosedCurve.ToJValue(),
                        SelfIntersect.ToJValue(),
                        KnotMultiplicities.ToJArray(),
                        Knots.ToJArray(),
                        KnotSpec.ToJValue(),
                        WeightsData.ToJArray(),
                    }
                }
            };
        }

        public static new IfcRationalBSplineCurveWithKnots CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRationalBSplineCurveWithKnots(
                jObject["id"].ToIfcId(),
                parameters[0].ToInt(),
                parameters[1].ToIfcIdList(),
                (IfcBSplineCurveForm)IfcAtom.EnumCreator[(int)EnumId.IfcBSplineCurveForm](parameters[2].ToString()),
                parameters[3].ToOptionalBool(),
                parameters[4].ToOptionalBool(),
                parameters[5].ToIntList(),
                parameters[6].ToDoubleList(),
                (IfcKnotType)IfcAtom.EnumCreator[(int)EnumId.IfcKnotType](parameters[7].ToString()),
                parameters[8].ToDoubleList());
        }
        #endregion

    }
}