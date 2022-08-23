
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
    public class IfcBlobTexture : IfcSurfaceTexture, IEquatable<IfcBlobTexture>
    {
        private string _rasterFormat;
        public string RasterFormat 
        {
            get { 
                return _rasterFormat; 
            }
            set { 
                _rasterFormat = value;
            }
        }
        private byte[] _rasterCode;
        public byte[] RasterCode 
        {
            get { 
                return _rasterCode; 
            }
            set { 
                _rasterCode = value;
            }
        }

        public IfcBlobTexture(IfcId id, bool repeatS, bool repeatT, string mode, IfcId textureTransformId, List<string> parameter, string rasterFormat, byte[] rasterCode) : base(id, repeatS, repeatT, mode, textureTransformId, parameter)
        {
            RasterFormat = rasterFormat;
            RasterCode = rasterCode;
        }

        public override ClassId GetClassId() => ClassId.IfcBlobTexture;

        #region Equality

        public bool Equals(IfcBlobTexture other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RasterFormat == other.RasterFormat
                && RasterCode == other.RasterCode;
        }

        public override bool Equals(object other) => Equals(other as IfcBlobTexture);

        public static bool operator ==(IfcBlobTexture one, IfcBlobTexture other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBlobTexture one, IfcBlobTexture other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({RepeatS},{RepeatT},'{Mode}',{TextureTransformId},{Parameter.ToJArray()},'{RasterFormat}',{RasterCode})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBlobTexture (newId,RepeatS, RepeatT, Mode, TextureTransformId, Parameter, RasterFormat, RasterCode);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBlobTexture },
                { "class", nameof(IfcBlobTexture) },
                { "parameters" , new JArray
                    {
                        RepeatS,
                        RepeatT,
                        Mode.ToJValue(),
                        TextureTransformId.ToJValue(),
                        Parameter.ToJArray(),
                        RasterFormat.ToJValue(),
                        RasterCode.ToJValue(),
                    }
                }
            };
        }

        public static IfcBlobTexture CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBlobTexture(
                jObject["id"].ToIfcId(),
                parameters[0].ToBool(),
                parameters[1].ToBool(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalStringList(),
                parameters[5].ToString(),
                parameters[6].ToByteArray());
        }
        #endregion

    }
}