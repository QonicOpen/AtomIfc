
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
    public class IfcBSplineSurfaceWithKnots : IfcBSplineSurface, IEquatable<IfcBSplineSurfaceWithKnots>
    {
        private List<int> _uMultiplicities;
        public List<int> UMultiplicities 
        {
            get { 
                return _uMultiplicities; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("UMultiplicities is not allowed to be null"); 
                _uMultiplicities = value;
            }
        }
        private List<int> _vMultiplicities;
        public List<int> VMultiplicities 
        {
            get { 
                return _vMultiplicities; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("VMultiplicities is not allowed to be null"); 
                _vMultiplicities = value;
            }
        }
        private List<double> _uKnots;
        public List<double> UKnots 
        {
            get { 
                return _uKnots; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("UKnots is not allowed to be null"); 
                _uKnots = value;
            }
        }
        private List<double> _vKnots;
        public List<double> VKnots 
        {
            get { 
                return _vKnots; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("VKnots is not allowed to be null"); 
                _vKnots = value;
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

        public IfcBSplineSurfaceWithKnots(IfcId id, int uDegree, int vDegree, List<List<IfcId>> controlPointIds, IfcBSplineSurfaceForm surfaceForm, bool? uClosed, bool? vClosed, bool? selfIntersect, List<int> uMultiplicities, List<int> vMultiplicities, List<double> uKnots, List<double> vKnots, IfcKnotType knotSpec) : base(id, uDegree, vDegree, controlPointIds, surfaceForm, uClosed, vClosed, selfIntersect)
        {
            UMultiplicities = uMultiplicities;
            VMultiplicities = vMultiplicities;
            UKnots = uKnots;
            VKnots = vKnots;
            KnotSpec = knotSpec;
        }

        public override ClassId GetClassId() => ClassId.IfcBSplineSurfaceWithKnots;

        #region Equality

        public bool Equals(IfcBSplineSurfaceWithKnots other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(UMultiplicities, other.UMultiplicities))
                return false;
            if(!Utils.CompareList(VMultiplicities, other.VMultiplicities))
                return false;
            if(!Utils.CompareList(UKnots, other.UKnots))
                return false;
            if(!Utils.CompareList(VKnots, other.VKnots))
                return false;
            return base.Equals(other)
                && KnotSpec == other.KnotSpec;
        }

        public override bool Equals(object other) => Equals(other as IfcBSplineSurfaceWithKnots);

        public static bool operator ==(IfcBSplineSurfaceWithKnots one, IfcBSplineSurfaceWithKnots other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBSplineSurfaceWithKnots one, IfcBSplineSurfaceWithKnots other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({UDegree},{VDegree},{Utils.ConvertListToString(ControlPointIds)},.{SurfaceForm}.,{(UClosed == null? ".U." : UClosed)},{(VClosed == null? ".U." : VClosed)},{(SelfIntersect == null? ".U." : SelfIntersect)},{Utils.ConvertListToString(UMultiplicities)},{Utils.ConvertListToString(VMultiplicities)},{Utils.ConvertListToString(UKnots)},{Utils.ConvertListToString(VKnots)},.{KnotSpec}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBSplineSurfaceWithKnots (newId,UDegree, VDegree, ControlPointIds, SurfaceForm, UClosed, VClosed, SelfIntersect, UMultiplicities, VMultiplicities, UKnots, VKnots, KnotSpec);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBSplineSurfaceWithKnots },
                { "class", nameof(IfcBSplineSurfaceWithKnots) },
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
                    }
                }
            };
        }

        public static IfcBSplineSurfaceWithKnots CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBSplineSurfaceWithKnots(
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
                (IfcKnotType)IfcAtom.EnumCreator[(int)EnumId.IfcKnotType](parameters[11].ToString()));
        }
        #endregion

    }
}