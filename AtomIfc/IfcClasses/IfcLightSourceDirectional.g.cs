
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
    public class IfcLightSourceDirectional : IfcLightSource, IEquatable<IfcLightSourceDirectional>
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

        public IfcLightSourceDirectional(IfcId id, string name, IfcId lightColourId, double? ambientIntensity, double? intensity, IfcId orientationId) : base(id, name, lightColourId, ambientIntensity, intensity)
        {
            OrientationId = orientationId;
        }

        public override ClassId GetClassId() => ClassId.IfcLightSourceDirectional;

        #region Equality

        public bool Equals(IfcLightSourceDirectional other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && OrientationId == other.OrientationId;
        }

        public override bool Equals(object other) => Equals(other as IfcLightSourceDirectional);

        public static bool operator ==(IfcLightSourceDirectional one, IfcLightSourceDirectional other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLightSourceDirectional one, IfcLightSourceDirectional other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{LightColourId},{AmbientIntensity},{Intensity},{OrientationId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(OrientationId!= null && replacementTable.ContainsKey(OrientationId))
                OrientationId = replacementTable[OrientationId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLightSourceDirectional (newId,Name, LightColourId, AmbientIntensity, Intensity, OrientationId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLightSourceDirectional },
                { "class", nameof(IfcLightSourceDirectional) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        LightColourId.ToJValue(),
                        AmbientIntensity.ToJValue(),
                        Intensity.ToJValue(),
                        OrientationId.ToJValue(),
                    }
                }
            };
        }

        public static IfcLightSourceDirectional CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLightSourceDirectional(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToIfcId(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToIfcId());
        }
        #endregion

    }
}