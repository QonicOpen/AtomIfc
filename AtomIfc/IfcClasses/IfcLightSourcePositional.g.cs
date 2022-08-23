
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
    public class IfcLightSourcePositional : IfcLightSource, IEquatable<IfcLightSourcePositional>
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
        private double _radius;
        public double Radius 
        {
            get { 
                return _radius; 
            }
            set { 
                _radius = value;
            }
        }
        private double _constantAttenuation;
        public double ConstantAttenuation 
        {
            get { 
                return _constantAttenuation; 
            }
            set { 
                _constantAttenuation = value;
            }
        }
        private double _distanceAttenuation;
        public double DistanceAttenuation 
        {
            get { 
                return _distanceAttenuation; 
            }
            set { 
                _distanceAttenuation = value;
            }
        }
        private double _quadricAttenuation;
        public double QuadricAttenuation 
        {
            get { 
                return _quadricAttenuation; 
            }
            set { 
                _quadricAttenuation = value;
            }
        }

        public IfcLightSourcePositional(IfcId id, string name, IfcId lightColourId, double? ambientIntensity, double? intensity, IfcId positionId, double radius, double constantAttenuation, double distanceAttenuation, double quadricAttenuation) : base(id, name, lightColourId, ambientIntensity, intensity)
        {
            PositionId = positionId;
            Radius = radius;
            ConstantAttenuation = constantAttenuation;
            DistanceAttenuation = distanceAttenuation;
            QuadricAttenuation = quadricAttenuation;
        }

        public override ClassId GetClassId() => ClassId.IfcLightSourcePositional;

        #region Equality

        public bool Equals(IfcLightSourcePositional other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PositionId == other.PositionId
                && Radius == other.Radius
                && ConstantAttenuation == other.ConstantAttenuation
                && DistanceAttenuation == other.DistanceAttenuation
                && QuadricAttenuation == other.QuadricAttenuation;
        }

        public override bool Equals(object other) => Equals(other as IfcLightSourcePositional);

        public static bool operator ==(IfcLightSourcePositional one, IfcLightSourcePositional other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLightSourcePositional one, IfcLightSourcePositional other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{LightColourId},{AmbientIntensity},{Intensity},{PositionId},{Radius},{ConstantAttenuation},{DistanceAttenuation},{QuadricAttenuation})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PositionId!= null && replacementTable.ContainsKey(PositionId))
                PositionId = replacementTable[PositionId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLightSourcePositional (newId,Name, LightColourId, AmbientIntensity, Intensity, PositionId, Radius, ConstantAttenuation, DistanceAttenuation, QuadricAttenuation);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLightSourcePositional },
                { "class", nameof(IfcLightSourcePositional) },
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
                    }
                }
            };
        }

        public static IfcLightSourcePositional CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLightSourcePositional(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToIfcId(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToIfcId(),
                parameters[5].ToDouble(),
                parameters[6].ToDouble(),
                parameters[7].ToDouble(),
                parameters[8].ToDouble());
        }
        #endregion

    }
}