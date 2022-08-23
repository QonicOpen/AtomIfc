
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
    public class IfcLightIntensityDistribution : IfcBase, IEquatable<IfcLightIntensityDistribution>, IIfcLightDistributionDataSourceSelect
    {
        private IfcLightDistributionCurveEnum _lightDistributionCurve;
        public IfcLightDistributionCurveEnum LightDistributionCurve 
        {
            get { 
                return _lightDistributionCurve; 
            }
            set { 
                _lightDistributionCurve = value;
            }
        }
        private List<IfcId> _distributionDataIds;
        public List<IfcId> DistributionDataIds 
        {
            get { 
                return _distributionDataIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("DistributionDataIds is not allowed to be null"); 
                _distributionDataIds = value;
            }
        }

        public IfcLightIntensityDistribution(IfcId id, IfcLightDistributionCurveEnum lightDistributionCurve, List<IfcId> distributionDataIds) : base(id)
        {
            LightDistributionCurve = lightDistributionCurve;
            DistributionDataIds = distributionDataIds;
        }

        public override ClassId GetClassId() => ClassId.IfcLightIntensityDistribution;

        #region Equality

        public bool Equals(IfcLightIntensityDistribution other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(DistributionDataIds, other.DistributionDataIds))
                return false;
            return base.Equals(other)
                && LightDistributionCurve == other.LightDistributionCurve;
        }

        public override bool Equals(object other) => Equals(other as IfcLightIntensityDistribution);

        public static bool operator ==(IfcLightIntensityDistribution one, IfcLightIntensityDistribution other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLightIntensityDistribution one, IfcLightIntensityDistribution other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{LightDistributionCurve}.,{Utils.ConvertListToString(DistributionDataIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DistributionDataIds!= null)
                DistributionDataIds = DistributionDataIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLightIntensityDistribution (newId,LightDistributionCurve, DistributionDataIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLightIntensityDistribution },
                { "class", nameof(IfcLightIntensityDistribution) },
                { "parameters" , new JArray
                    {
                        LightDistributionCurve.ToJValue(),
                        DistributionDataIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcLightIntensityDistribution CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLightIntensityDistribution(
                jObject["id"].ToIfcId(),
                (IfcLightDistributionCurveEnum)IfcAtom.EnumCreator[(int)EnumId.IfcLightDistributionCurveEnum](parameters[0].ToString()),
                parameters[1].ToIfcIdList());
        }
        #endregion

    }
}