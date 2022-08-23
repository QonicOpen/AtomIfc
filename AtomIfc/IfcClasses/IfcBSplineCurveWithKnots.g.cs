
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
    public class IfcBSplineCurveWithKnots : IfcBSplineCurve, IEquatable<IfcBSplineCurveWithKnots>
    {
        private List<int> _knotMultiplicities;
        public List<int> KnotMultiplicities 
        {
            get { 
                return _knotMultiplicities; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("KnotMultiplicities is not allowed to be null"); 
                _knotMultiplicities = value;
            }
        }
        private List<double> _knots;
        public List<double> Knots 
        {
            get { 
                return _knots; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("Knots is not allowed to be null"); 
                _knots = value;
            }
        }
        private IfcKnotType _knotSpec;
        public IfcKnotType KnotSpec 
        {
            get { 
                return _knotSpec; 
            }
            set { 
                _knotSpec = value;
            }
        }

        public IfcBSplineCurveWithKnots(IfcId id, int degree, List<IfcId> controlPointIds, IfcBSplineCurveForm curveForm, bool? closedCurve, bool? selfIntersect, List<int> knotMultiplicities, List<double> knots, IfcKnotType knotSpec) : base(id, degree, controlPointIds, curveForm, closedCurve, selfIntersect)
        {
            KnotMultiplicities = knotMultiplicities;
            Knots = knots;
            KnotSpec = knotSpec;
        }

        public override ClassId GetClassId() => ClassId.IfcBSplineCurveWithKnots;

        #region Equality

        public bool Equals(IfcBSplineCurveWithKnots other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(KnotMultiplicities, other.KnotMultiplicities))
                return false;
            if(!Utils.CompareList(Knots, other.Knots))
                return false;
            return base.Equals(other)
                && KnotSpec == other.KnotSpec;
        }

        public override bool Equals(object other) => Equals(other as IfcBSplineCurveWithKnots);

        public static bool operator ==(IfcBSplineCurveWithKnots one, IfcBSplineCurveWithKnots other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBSplineCurveWithKnots one, IfcBSplineCurveWithKnots other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Degree},{Utils.ConvertListToString(ControlPointIds)},.{CurveForm}.,{(ClosedCurve == null? ".U." : ClosedCurve)},{(SelfIntersect == null? ".U." : SelfIntersect)},{Utils.ConvertListToString(KnotMultiplicities)},{Utils.ConvertListToString(Knots)},.{KnotSpec}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBSplineCurveWithKnots (newId,Degree, ControlPointIds, CurveForm, ClosedCurve, SelfIntersect, KnotMultiplicities, Knots, KnotSpec);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBSplineCurveWithKnots },
                { "class", nameof(IfcBSplineCurveWithKnots) },
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
                    }
                }
            };
        }

        public static IfcBSplineCurveWithKnots CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBSplineCurveWithKnots(
                jObject["id"].ToIfcId(),
                parameters[0].ToInt(),
                parameters[1].ToIfcIdList(),
                (IfcBSplineCurveForm)IfcAtom.EnumCreator[(int)EnumId.IfcBSplineCurveForm](parameters[2].ToString()),
                parameters[3].ToOptionalBool(),
                parameters[4].ToOptionalBool(),
                parameters[5].ToIntList(),
                parameters[6].ToDoubleList(),
                (IfcKnotType)IfcAtom.EnumCreator[(int)EnumId.IfcKnotType](parameters[7].ToString()));
        }
        #endregion

    }
}