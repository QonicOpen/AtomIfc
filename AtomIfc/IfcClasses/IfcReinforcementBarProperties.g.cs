
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
    public class IfcReinforcementBarProperties : IfcPreDefinedProperties, IEquatable<IfcReinforcementBarProperties>
    {
        private double _totalCrossSectionArea;
        public double TotalCrossSectionArea 
        {
            get { 
                return _totalCrossSectionArea; 
            }
            set { 
                _totalCrossSectionArea = value;
            }
        }
        private string _steelGrade;
        public string SteelGrade 
        {
            get { 
                return _steelGrade; 
            }
            set { 
                _steelGrade = value;
            }
        }
        private IfcReinforcingBarSurfaceEnum _barSurface;
        public IfcReinforcingBarSurfaceEnum BarSurface 
        {
            get { 
                return _barSurface; 
            }
            set { 
                _barSurface = value;  // optional IfcReinforcingBarSurfaceEnum?
            }
        }
        private double? _effectiveDepth;
        public double? EffectiveDepth 
        {
            get { 
                return _effectiveDepth; 
            }
            set { 
                _effectiveDepth = value;  // optional IfcLengthMeasure
            }
        }
        private double? _nominalBarDiameter;
        public double? NominalBarDiameter 
        {
            get { 
                return _nominalBarDiameter; 
            }
            set { 
                _nominalBarDiameter = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _barCount;
        public double? BarCount 
        {
            get { 
                return _barCount; 
            }
            set { 
                _barCount = value;  // optional IfcCountMeasure
            }
        }

        public IfcReinforcementBarProperties(IfcId id, double totalCrossSectionArea, string steelGrade, IfcReinforcingBarSurfaceEnum barSurface, double? effectiveDepth, double? nominalBarDiameter, double? barCount) : base(id)
        {
            TotalCrossSectionArea = totalCrossSectionArea;
            SteelGrade = steelGrade;
            BarSurface = barSurface;
            EffectiveDepth = effectiveDepth;
            NominalBarDiameter = nominalBarDiameter;
            BarCount = barCount;
        }

        public override ClassId GetClassId() => ClassId.IfcReinforcementBarProperties;

        #region Equality

        public bool Equals(IfcReinforcementBarProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TotalCrossSectionArea == other.TotalCrossSectionArea
                && SteelGrade == other.SteelGrade
                && BarSurface == other.BarSurface
                && EffectiveDepth == other.EffectiveDepth
                && NominalBarDiameter == other.NominalBarDiameter
                && BarCount == other.BarCount;
        }

        public override bool Equals(object other) => Equals(other as IfcReinforcementBarProperties);

        public static bool operator ==(IfcReinforcementBarProperties one, IfcReinforcementBarProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcReinforcementBarProperties one, IfcReinforcementBarProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({TotalCrossSectionArea},'{SteelGrade}',.{BarSurface}.,{EffectiveDepth},{NominalBarDiameter},{BarCount})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcReinforcementBarProperties (newId,TotalCrossSectionArea, SteelGrade, BarSurface, EffectiveDepth, NominalBarDiameter, BarCount);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcReinforcementBarProperties },
                { "class", nameof(IfcReinforcementBarProperties) },
                { "parameters" , new JArray
                    {
                        TotalCrossSectionArea,
                        SteelGrade.ToJValue(),
                        BarSurface.ToJValue(),
                        EffectiveDepth.ToJValue(),
                        NominalBarDiameter.ToJValue(),
                        BarCount.ToJValue(),
                    }
                }
            };
        }

        public static IfcReinforcementBarProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcReinforcementBarProperties(
                jObject["id"].ToIfcId(),
                parameters[0].ToDouble(),
                parameters[1].ToString(),
                (IfcReinforcingBarSurfaceEnum)IfcAtom.EnumCreator[(int)EnumId.IfcReinforcingBarSurfaceEnum](parameters[2].ToString()),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToOptionalDouble());
        }
        #endregion

    }
}