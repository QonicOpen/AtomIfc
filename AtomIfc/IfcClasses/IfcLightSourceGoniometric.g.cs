
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
    public class IfcLightSourceGoniometric : IfcLightSource, IEquatable<IfcLightSourceGoniometric>
    {
        private IfcId _positionId;
        public IfcId PositionId 
        {
            get { 
                return _positionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PositionId is not allowed to be null"); 
                _positionId = value;
            }
        }
        private IfcId _colourAppearanceId;
        public IfcId ColourAppearanceId 
        {
            get { 
                return _colourAppearanceId; 
            }
            set { 
                _colourAppearanceId = value;  // optional IfcColourRgb
            }
        }
        private double _colourTemperature;
        public double ColourTemperature 
        {
            get { 
                return _colourTemperature; 
            }
            set { 
                _colourTemperature = value;
            }
        }
        private double _luminousFlux;
        public double LuminousFlux 
        {
            get { 
                return _luminousFlux; 
            }
            set { 
                _luminousFlux = value;
            }
        }
        private IfcLightEmissionSourceEnum _lightEmissionSource;
        public IfcLightEmissionSourceEnum LightEmissionSource 
        {
            get { 
                return _lightEmissionSource; 
            }
            set { 
                _lightEmissionSource = value;
            }
        }
        private IfcId _lightDistributionDataSourceId;
        public IfcId LightDistributionDataSourceId 
        {
            get { 
                return _lightDistributionDataSourceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("LightDistributionDataSourceId is not allowed to be null"); 
                _lightDistributionDataSourceId = value;
            }
        }

        public IfcLightSourceGoniometric(IfcId id, string name, IfcId lightColourId, double? ambientIntensity, double? intensity, IfcId positionId, IfcId colourAppearanceId, double colourTemperature, double luminousFlux, IfcLightEmissionSourceEnum lightEmissionSource, IfcId lightDistributionDataSourceId) : base(id, name, lightColourId, ambientIntensity, intensity)
        {
            PositionId = positionId;
            ColourAppearanceId = colourAppearanceId;
            ColourTemperature = colourTemperature;
            LuminousFlux = luminousFlux;
            LightEmissionSource = lightEmissionSource;
            LightDistributionDataSourceId = lightDistributionDataSourceId;
        }

        public override ClassId GetClassId() => ClassId.IfcLightSourceGoniometric;

        #region Equality

        public bool Equals(IfcLightSourceGoniometric other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PositionId == other.PositionId
                && ColourAppearanceId == other.ColourAppearanceId
                && ColourTemperature == other.ColourTemperature
                && LuminousFlux == other.LuminousFlux
                && LightEmissionSource == other.LightEmissionSource
                && LightDistributionDataSourceId == other.LightDistributionDataSourceId;
        }

        public override bool Equals(object other) => Equals(other as IfcLightSourceGoniometric);

        public static bool operator ==(IfcLightSourceGoniometric one, IfcLightSourceGoniometric other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLightSourceGoniometric one, IfcLightSourceGoniometric other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{LightColourId},{AmbientIntensity},{Intensity},{PositionId},{ColourAppearanceId},{ColourTemperature},{LuminousFlux},.{LightEmissionSource}.,{LightDistributionDataSourceId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PositionId!= null && replacementTable.ContainsKey(PositionId))
                PositionId = replacementTable[PositionId];
            if(ColourAppearanceId!= null && replacementTable.ContainsKey(ColourAppearanceId))
                ColourAppearanceId = replacementTable[ColourAppearanceId];
            if(LightDistributionDataSourceId!= null && replacementTable.ContainsKey(LightDistributionDataSourceId))
                LightDistributionDataSourceId = replacementTable[LightDistributionDataSourceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLightSourceGoniometric (newId,Name, LightColourId, AmbientIntensity, Intensity, PositionId, ColourAppearanceId, ColourTemperature, LuminousFlux, LightEmissionSource, LightDistributionDataSourceId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLightSourceGoniometric },
                { "class", nameof(IfcLightSourceGoniometric) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        LightColourId.ToJValue(),
                        AmbientIntensity.ToJValue(),
                        Intensity.ToJValue(),
                        PositionId.ToJValue(),
                        ColourAppearanceId.ToJValue(),
                        ColourTemperature,
                        LuminousFlux,
                        LightEmissionSource.ToJValue(),
                        LightDistributionDataSourceId.ToJValue(),
                    }
                }
            };
        }

        public static IfcLightSourceGoniometric CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLightSourceGoniometric(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToIfcId(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToDouble(),
                parameters[7].ToDouble(),
                (IfcLightEmissionSourceEnum)IfcAtom.EnumCreator[(int)EnumId.IfcLightEmissionSourceEnum](parameters[8].ToString()),
                parameters[9].ToIfcId());
        }
        #endregion

    }
}