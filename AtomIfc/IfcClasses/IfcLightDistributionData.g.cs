
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
    public class IfcLightDistributionData : IfcBase, IEquatable<IfcLightDistributionData>
    {
        private double _mainPlaneAngle;
        public double MainPlaneAngle 
        {
            get { 
                return _mainPlaneAngle; 
            }
            set { 
                _mainPlaneAngle = value;
            }
        }
        private List<double> _secondaryPlaneAngle;
        public List<double> SecondaryPlaneAngle 
        {
            get { 
                return _secondaryPlaneAngle; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SecondaryPlaneAngle is not allowed to be null"); 
                _secondaryPlaneAngle = value;
            }
        }
        private List<double> _luminousIntensity;
        public List<double> LuminousIntensity 
        {
            get { 
                return _luminousIntensity; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("LuminousIntensity is not allowed to be null"); 
                _luminousIntensity = value;
            }
        }

        public IfcLightDistributionData(IfcId id, double mainPlaneAngle, List<double> secondaryPlaneAngle, List<double> luminousIntensity) : base(id)
        {
            MainPlaneAngle = mainPlaneAngle;
            SecondaryPlaneAngle = secondaryPlaneAngle;
            LuminousIntensity = luminousIntensity;
        }

        public override ClassId GetClassId() => ClassId.IfcLightDistributionData;

        #region Equality

        public bool Equals(IfcLightDistributionData other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(SecondaryPlaneAngle, other.SecondaryPlaneAngle))
                return false;
            if(!Utils.CompareList(LuminousIntensity, other.LuminousIntensity))
                return false;
            return base.Equals(other)
                && MainPlaneAngle == other.MainPlaneAngle;
        }

        public override bool Equals(object other) => Equals(other as IfcLightDistributionData);

        public static bool operator ==(IfcLightDistributionData one, IfcLightDistributionData other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLightDistributionData one, IfcLightDistributionData other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({MainPlaneAngle},{Utils.ConvertListToString(SecondaryPlaneAngle)},{Utils.ConvertListToString(LuminousIntensity)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLightDistributionData (newId,MainPlaneAngle, SecondaryPlaneAngle, LuminousIntensity);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLightDistributionData },
                { "class", nameof(IfcLightDistributionData) },
                { "parameters" , new JArray
                    {
                        MainPlaneAngle,
                        SecondaryPlaneAngle.ToJArray(),
                        LuminousIntensity.ToJArray(),
                    }
                }
            };
        }

        public static IfcLightDistributionData CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLightDistributionData(
                jObject["id"].ToIfcId(),
                parameters[0].ToDouble(),
                parameters[1].ToDoubleList(),
                parameters[2].ToDoubleList());
        }
        #endregion

    }
}