
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
    public class IfcSurfaceStyleRendering : IfcSurfaceStyleShading, IEquatable<IfcSurfaceStyleRendering>
    {
        private double? _transparency;
        public double? Transparency 
        {
            get { 
                return _transparency; 
            }
            set { 
                _transparency = value;  // optional IfcNormalisedRatioMeasure
            }
        }
        private IfcId _diffuseColourId;
        public IfcId DiffuseColourId 
        {
            get { 
                return _diffuseColourId; 
            }
            set { 
                _diffuseColourId = value;  // optional IfcColourOrFactor
            }
        }
        private IfcId _transmissionColourId;
        public IfcId TransmissionColourId 
        {
            get { 
                return _transmissionColourId; 
            }
            set { 
                _transmissionColourId = value;  // optional IfcColourOrFactor
            }
        }
        private IfcId _diffuseTransmissionColourId;
        public IfcId DiffuseTransmissionColourId 
        {
            get { 
                return _diffuseTransmissionColourId; 
            }
            set { 
                _diffuseTransmissionColourId = value;  // optional IfcColourOrFactor
            }
        }
        private IfcId _reflectionColourId;
        public IfcId ReflectionColourId 
        {
            get { 
                return _reflectionColourId; 
            }
            set { 
                _reflectionColourId = value;  // optional IfcColourOrFactor
            }
        }
        private IfcId _specularColourId;
        public IfcId SpecularColourId 
        {
            get { 
                return _specularColourId; 
            }
            set { 
                _specularColourId = value;  // optional IfcColourOrFactor
            }
        }
        private IfcId _specularHighlightId;
        public IfcId SpecularHighlightId 
        {
            get { 
                return _specularHighlightId; 
            }
            set { 
                _specularHighlightId = value;  // optional IfcSpecularHighlightSelect
            }
        }
        private IfcReflectanceMethodEnum _reflectanceMethod;
        public IfcReflectanceMethodEnum ReflectanceMethod 
        {
            get { 
                return _reflectanceMethod; 
            }
            set { 
                _reflectanceMethod = value;
            }
        }

        public IfcSurfaceStyleRendering(IfcId id, IfcId surfaceColourId, double? transparency, IfcId diffuseColourId, IfcId transmissionColourId, IfcId diffuseTransmissionColourId, IfcId reflectionColourId, IfcId specularColourId, IfcId specularHighlightId, IfcReflectanceMethodEnum reflectanceMethod) : base(id, surfaceColourId)
        {
            Transparency = transparency;
            DiffuseColourId = diffuseColourId;
            TransmissionColourId = transmissionColourId;
            DiffuseTransmissionColourId = diffuseTransmissionColourId;
            ReflectionColourId = reflectionColourId;
            SpecularColourId = specularColourId;
            SpecularHighlightId = specularHighlightId;
            ReflectanceMethod = reflectanceMethod;
        }

        public override ClassId GetClassId() => ClassId.IfcSurfaceStyleRendering;

        #region Equality

        public bool Equals(IfcSurfaceStyleRendering other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Transparency == other.Transparency
                && DiffuseColourId == other.DiffuseColourId
                && TransmissionColourId == other.TransmissionColourId
                && DiffuseTransmissionColourId == other.DiffuseTransmissionColourId
                && ReflectionColourId == other.ReflectionColourId
                && SpecularColourId == other.SpecularColourId
                && SpecularHighlightId == other.SpecularHighlightId
                && ReflectanceMethod == other.ReflectanceMethod;
        }

        public override bool Equals(object other) => Equals(other as IfcSurfaceStyleRendering);

        public static bool operator ==(IfcSurfaceStyleRendering one, IfcSurfaceStyleRendering other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSurfaceStyleRendering one, IfcSurfaceStyleRendering other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SurfaceColourId},{Transparency},{DiffuseColourId},{TransmissionColourId},{DiffuseTransmissionColourId},{ReflectionColourId},{SpecularColourId},{SpecularHighlightId},.{ReflectanceMethod}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DiffuseColourId!= null && replacementTable.ContainsKey(DiffuseColourId))
                DiffuseColourId = replacementTable[DiffuseColourId];
            if(TransmissionColourId!= null && replacementTable.ContainsKey(TransmissionColourId))
                TransmissionColourId = replacementTable[TransmissionColourId];
            if(DiffuseTransmissionColourId!= null && replacementTable.ContainsKey(DiffuseTransmissionColourId))
                DiffuseTransmissionColourId = replacementTable[DiffuseTransmissionColourId];
            if(ReflectionColourId!= null && replacementTable.ContainsKey(ReflectionColourId))
                ReflectionColourId = replacementTable[ReflectionColourId];
            if(SpecularColourId!= null && replacementTable.ContainsKey(SpecularColourId))
                SpecularColourId = replacementTable[SpecularColourId];
            if(SpecularHighlightId!= null && replacementTable.ContainsKey(SpecularHighlightId))
                SpecularHighlightId = replacementTable[SpecularHighlightId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSurfaceStyleRendering (newId,SurfaceColourId, Transparency, DiffuseColourId, TransmissionColourId, DiffuseTransmissionColourId, ReflectionColourId, SpecularColourId, SpecularHighlightId, ReflectanceMethod);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSurfaceStyleRendering },
                { "class", nameof(IfcSurfaceStyleRendering) },
                { "parameters" , new JArray
                    {
                        SurfaceColourId.ToJValue(),
                        Transparency.ToJValue(),
                        DiffuseColourId.ToJValue(),
                        TransmissionColourId.ToJValue(),
                        DiffuseTransmissionColourId.ToJValue(),
                        ReflectionColourId.ToJValue(),
                        SpecularColourId.ToJValue(),
                        SpecularHighlightId.ToJValue(),
                        ReflectanceMethod.ToJValue(),
                    }
                }
            };
        }

        public static new IfcSurfaceStyleRendering CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSurfaceStyleRendering(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalDouble(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalIfcId(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalIfcId(),
                (IfcReflectanceMethodEnum)IfcAtom.EnumCreator[(int)EnumId.IfcReflectanceMethodEnum](parameters[8].ToString()));
        }
        #endregion

    }
}