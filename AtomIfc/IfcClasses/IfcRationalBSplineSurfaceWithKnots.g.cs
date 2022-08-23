
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
    public class IfcRationalBSplineSurfaceWithKnots : IfcBSplineSurfaceWithKnots, IEquatable<IfcRationalBSplineSurfaceWithKnots>
    {
        private List<List<double>> _weightsData;
        public List<List<double>> WeightsData 
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

        public IfcRationalBSplineSurfaceWithKnots(IfcId id, int uDegree, int vDegree, List<List<IfcId>> controlPointIds, IfcBSplineSurfaceForm surfaceForm, bool? uClosed, bool? vClosed, bool? selfIntersect, List<int> uMultiplicities, List<int> vMultiplicities, List<double> uKnots, List<double> vKnots, IfcKnotType knotSpec, List<List<double>> weightsData) : base(id, uDegree, vDegree, controlPointIds, surfaceForm, uClosed, vClosed, selfIntersect, uMultiplicities, vMultiplicities, uKnots, vKnots, knotSpec)
        {
            WeightsData = weightsData;
        }

        public override ClassId GetClassId() => ClassId.IfcRationalBSplineSurfaceWithKnots;

        #region Equality

        public bool Equals(IfcRationalBSplineSurfaceWithKnots other)
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

        public override bool Equals(object other) => Equals(other as IfcRationalBSplineSurfaceWithKnots);

        public static bool operator ==(IfcRationalBSplineSurfaceWithKnots one, IfcRationalBSplineSurfaceWithKnots other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRationalBSplineSurfaceWithKnots one, IfcRationalBSplineSurfaceWithKnots other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({UDegree},{VDegree},{Utils.ConvertListToString(ControlPointIds)},.{SurfaceForm}.,{(UClosed == null? ".U." : UClosed)},{(VClosed == null? ".U." : VClosed)},{(SelfIntersect == null? ".U." : SelfIntersect)},{Utils.ConvertListToString(UMultiplicities)},{Utils.ConvertListToString(VMultiplicities)},{Utils.ConvertListToString(UKnots)},{Utils.ConvertListToString(VKnots)},.{KnotSpec}.,{Utils.ConvertListToString(WeightsData)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRationalBSplineSurfaceWithKnots (newId,UDegree, VDegree, ControlPointIds, SurfaceForm, UClosed, VClosed, SelfIntersect, UMultiplicities, VMultiplicities, UKnots, VKnots, KnotSpec, WeightsData);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRationalBSplineSurfaceWithKnots },
                { "class", nameof(IfcRationalBSplineSurfaceWithKnots) },
                { "parameters" , new JArray
                    {
                        UDegree,
                        VDegree,
                        ControlPointIds.ToJArray(),
                        SurfaceForm.ToJValue(),
                        UClosed.ToJValue(),
                        VClosed.ToJValue(),
                        SelfIntersect.ToJValue(),
                        UMultiplicities.ToJArray(),
                        VMultiplicities.ToJArray(),
                        UKnots.ToJArray(),
                        VKnots.ToJArray(),
                        KnotSpec.ToJValue(),
                        WeightsData.ToJArray(),
                    }
                }
            };
        }

        public static new IfcRationalBSplineSurfaceWithKnots CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRationalBSplineSurfaceWithKnots(
                jObject["id"].ToIfcId(),
                parameters[0].ToInt(),
                parameters[1].ToInt(),
                parameters[2].ToNestedIfcIdList(),
                (IfcBSplineSurfaceForm)IfcAtom.EnumCreator[(int)EnumId.IfcBSplineSurfaceForm](parameters[3].ToString()),
                parameters[4].ToOptionalBool(),
                parameters[5].ToOptionalBool(),
                parameters[6].ToOptionalBool(),
                parameters[7].ToIntList(),
                parameters[8].ToIntList(),
                parameters[9].ToDoubleList(),
                parameters[10].ToDoubleList(),
                (IfcKnotType)IfcAtom.EnumCreator[(int)EnumId.IfcKnotType](parameters[11].ToString()),
                parameters[12].ToNestedDoubleList());
        }
        #endregion

    }
}