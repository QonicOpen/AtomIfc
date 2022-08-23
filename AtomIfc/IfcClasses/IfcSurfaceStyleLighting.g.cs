
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
    public class IfcSurfaceStyleLighting : IfcPresentationItem, IEquatable<IfcSurfaceStyleLighting>, IIfcSurfaceStyleElementSelect
    {
        private IfcId _diffuseTransmissionColourId;
        public IfcId DiffuseTransmissionColourId 
        {
            get { 
                return _diffuseTransmissionColourId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("DiffuseTransmissionColourId is not allowed to be null"); 
                _diffuseTransmissionColourId = value;
            }
        }
        private IfcId _diffuseReflectionColourId;
        public IfcId DiffuseReflectionColourId 
        {
            get { 
                return _diffuseReflectionColourId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("DiffuseReflectionColourId is not allowed to be null"); 
                _diffuseReflectionColourId = value;
            }
        }
        private IfcId _transmissionColourId;
        public IfcId TransmissionColourId 
        {
            get { 
                return _transmissionColourId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TransmissionColourId is not allowed to be null"); 
                _transmissionColourId = value;
            }
        }
        private IfcId _reflectanceColourId;
        public IfcId ReflectanceColourId 
        {
            get { 
                return _reflectanceColourId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ReflectanceColourId is not allowed to be null"); 
                _reflectanceColourId = value;
            }
        }

        public IfcSurfaceStyleLighting(IfcId id, IfcId diffuseTransmissionColourId, IfcId diffuseReflectionColourId, IfcId transmissionColourId, IfcId reflectanceColourId) : base(id)
        {
            DiffuseTransmissionColourId = diffuseTransmissionColourId;
            DiffuseReflectionColourId = diffuseReflectionColourId;
            TransmissionColourId = transmissionColourId;
            ReflectanceColourId = reflectanceColourId;
        }

        public override ClassId GetClassId() => ClassId.IfcSurfaceStyleLighting;

        #region Equality

        public bool Equals(IfcSurfaceStyleLighting other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && DiffuseTransmissionColourId == other.DiffuseTransmissionColourId
                && DiffuseReflectionColourId == other.DiffuseReflectionColourId
                && TransmissionColourId == other.TransmissionColourId
                && ReflectanceColourId == other.ReflectanceColourId;
        }

        public override bool Equals(object other) => Equals(other as IfcSurfaceStyleLighting);

        public static bool operator ==(IfcSurfaceStyleLighting one, IfcSurfaceStyleLighting other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSurfaceStyleLighting one, IfcSurfaceStyleLighting other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({DiffuseTransmissionColourId},{DiffuseReflectionColourId},{TransmissionColourId},{ReflectanceColourId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DiffuseTransmissionColourId!= null && replacementTable.ContainsKey(DiffuseTransmissionColourId))
                DiffuseTransmissionColourId = replacementTable[DiffuseTransmissionColourId];
            if(DiffuseReflectionColourId!= null && replacementTable.ContainsKey(DiffuseReflectionColourId))
                DiffuseReflectionColourId = replacementTable[DiffuseReflectionColourId];
            if(TransmissionColourId!= null && replacementTable.ContainsKey(TransmissionColourId))
                TransmissionColourId = replacementTable[TransmissionColourId];
            if(ReflectanceColourId!= null && replacementTable.ContainsKey(ReflectanceColourId))
                ReflectanceColourId = replacementTable[ReflectanceColourId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSurfaceStyleLighting (newId,DiffuseTransmissionColourId, DiffuseReflectionColourId, TransmissionColourId, ReflectanceColourId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSurfaceStyleLighting },
                { "class", nameof(IfcSurfaceStyleLighting) },
                { "parameters" , new JArray
                    {
                        DiffuseTransmissionColourId.ToJValue(),
                        DiffuseReflectionColourId.ToJValue(),
                        TransmissionColourId.ToJValue(),
                        ReflectanceColourId.ToJValue(),
                    }
                }
            };
        }

        public static IfcSurfaceStyleLighting CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSurfaceStyleLighting(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcId());
        }
        #endregion

    }
}