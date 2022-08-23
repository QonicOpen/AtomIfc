
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
    public class IfcImageTexture : IfcSurfaceTexture, IEquatable<IfcImageTexture>
    {
        private string _uRLReference;
        public string URLReference 
        {
            get { 
                return _uRLReference; 
            }
            set { 
                _uRLReference = value;
            }
        }

        public IfcImageTexture(IfcId id, bool repeatS, bool repeatT, string mode, IfcId textureTransformId, List<string> parameter, string uRLReference) : base(id, repeatS, repeatT, mode, textureTransformId, parameter)
        {
            URLReference = uRLReference;
        }

        public override ClassId GetClassId() => ClassId.IfcImageTexture;

        #region Equality

        public bool Equals(IfcImageTexture other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && URLReference == other.URLReference;
        }

        public override bool Equals(object other) => Equals(other as IfcImageTexture);

        public static bool operator ==(IfcImageTexture one, IfcImageTexture other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcImageTexture one, IfcImageTexture other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({RepeatS},{RepeatT},'{Mode}',{TextureTransformId},{Parameter.ToJArray()},'{URLReference}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcImageTexture (newId,RepeatS, RepeatT, Mode, TextureTransformId, Parameter, URLReference);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcImageTexture },
                { "class", nameof(IfcImageTexture) },
                { "parameters" , new JArray
                    {
                        RepeatS,
                        RepeatT,
                        Mode.ToJValue(),
                        TextureTransformId.ToJValue(),
                        Parameter.ToJArray(),
                        URLReference.ToJValue(),
                    }
                }
            };
        }

        public static IfcImageTexture CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcImageTexture(
                jObject["id"].ToIfcId(),
                parameters[0].ToBool(),
                parameters[1].ToBool(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalStringList(),
                parameters[5].ToString());
        }
        #endregion

    }
}