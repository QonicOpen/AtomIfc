
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
    public abstract class IfcLightSource : IfcGeometricRepresentationItem, IEquatable<IfcLightSource>
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;  // optional IfcLabel
            }
        }
        private IfcId _lightColourId;
        public IfcId LightColourId 
        {
            get { 
                return _lightColourId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("LightColourId is not allowed to be null"); 
                _lightColourId = value;
            }
        }
        private double? _ambientIntensity;
        public double? AmbientIntensity 
        {
            get { 
                return _ambientIntensity; 
            }
            set { 
                _ambientIntensity = value;  // optional IfcNormalisedRatioMeasure
            }
        }
        private double? _intensity;
        public double? Intensity 
        {
            get { 
                return _intensity; 
            }
            set { 
                _intensity = value;  // optional IfcNormalisedRatioMeasure
            }
        }

        internal IfcLightSource(IfcId id, string name, IfcId lightColourId, double? ambientIntensity, double? intensity) : base(id)
        {
            Name = name;
            LightColourId = lightColourId;
            AmbientIntensity = ambientIntensity;
            Intensity = intensity;
        }

        #region Equality

        public bool Equals(IfcLightSource other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name
                && LightColourId == other.LightColourId
                && AmbientIntensity == other.AmbientIntensity
                && Intensity == other.Intensity;
        }

        public override bool Equals(object other) => Equals(other as IfcLightSource);

        public static bool operator ==(IfcLightSource one, IfcLightSource other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLightSource one, IfcLightSource other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(LightColourId!= null && replacementTable.ContainsKey(LightColourId))
                LightColourId = replacementTable[LightColourId];
            base.ReplaceIds(replacementTable);

        }
    }
}