
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
    public class IfcLightSourceSpot : IfcLightSourcePositional, IEquatable<IfcLightSourceSpot>
    {
        private IfcId _orientationId;
        public IfcId OrientationId 
        {
            get { 
                return _orientationId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OrientationId is not allowed to be null"); 
                _orientationId = value;
            }
        }
        private double? _concentrationExponent;
        public double? ConcentrationExponent 
        {
            get { 
                return _concentrationExponent; 
            }
            set { 
                _concentrationExponent = value;  // optional IfcReal
            }
        }
        private double _spreadAngle;
        public double SpreadAngle 
        {
            get { 
                return _spreadAngle; 
            }
            set { 
                _spreadAngle = value;
            }
        }
        private double _beamWidthAngle;
        public double BeamWidthAngle 
        {
            get { 
                return _beamWidthAngle; 
            }
            set { 
                _beamWidthAngle = value;
            }
        }

        public IfcLightSourceSpot(IfcId id, string name, IfcId lightColourId, double? ambientIntensity, double? intensity, IfcId positionId, double radius, double constantAttenuation, double distanceAttenuation, double quadricAttenuation, IfcId orientationId, double? concentrationExponent, double spreadAngle, double beamWidthAngle) : base(id, name, lightColourId, ambientIntensity, intensity, positionId, radius, constantAttenuation, distanceAttenuation, quadricAttenuation)
        {
            OrientationId = orientationId;
            ConcentrationExponent = concentrationExponent;
            SpreadAngle = spreadAngle;
            BeamWidthAngle = beamWidthAngle;
        }

        public override ClassId GetClassId() => ClassId.IfcLightSourceSpot;

        #region Equality

        public bool Equals(IfcLightSourceSpot other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && OrientationId == other.OrientationId
                && ConcentrationExponent == other.ConcentrationExponent
                && SpreadAngle == other.SpreadAngle
                && BeamWidthAngle == other.BeamWidthAngle;
        }

        public override bool Equals(object other) => Equals(other as IfcLightSourceSpot);

        public static bool operator ==(IfcLightSourceSpot one, IfcLightSourceSpot other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLightSourceSpot one, IfcLightSourceSpot other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{LightColourId},{AmbientIntensity},{Intensity},{PositionId},{Radius},{ConstantAttenuation},{DistanceAttenuation},{QuadricAttenuation},{OrientationId},{ConcentrationExponent},{SpreadAngle},{BeamWidthAngle})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(OrientationId!= null && replacementTable.ContainsKey(OrientationId))
                OrientationId = replacementTable[OrientationId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLightSourceSpot (newId,Name, LightColourId, AmbientIntensity, Intensity, PositionId, Radius, ConstantAttenuation, DistanceAttenuation, QuadricAttenuation, OrientationId, ConcentrationExponent, SpreadAngle, BeamWidthAngle);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLightSourceSpot },
                { "class", nameof(IfcLightSourceSpot) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        LightColourId.ToJValue(),
                        AmbientIntensity.ToJValue(),
                        Intensity.ToJValue(),
                        PositionId.ToJValue(),
                        Radius,
                        ConstantAttenuation,
                        DistanceAttenuation,
                        QuadricAttenuation,
                        OrientationId.ToJValue(),
                        ConcentrationExponent.ToJValue(),
                        SpreadAngle,
                        BeamWidthAngle,
                    }
                }
            };
        }

        public static new IfcLightSourceSpot CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLightSourceSpot(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToIfcId(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToIfcId(),
                parameters[5].ToDouble(),
                parameters[6].ToDouble(),
                parameters[7].ToDouble(),
                parameters[8].ToDouble(),
                parameters[9].ToIfcId(),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToDouble(),
                parameters[12].ToDouble());
        }
        #endregion

    }
}