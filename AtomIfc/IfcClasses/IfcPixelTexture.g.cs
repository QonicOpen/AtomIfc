
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
    public class IfcPixelTexture : IfcSurfaceTexture, IEquatable<IfcPixelTexture>
    {
        private int _width;
        public int Width 
        {
            get { 
                return _width; 
            }
            set { 
                _width = value;
            }
        }
        private int _height;
        public int Height 
        {
            get { 
                return _height; 
            }
            set { 
                _height = value;
            }
        }
        private int _colourComponents;
        public int ColourComponents 
        {
            get { 
                return _colourComponents; 
            }
            set { 
                _colourComponents = value;
            }
        }
        private List<byte[]> _pixel;
        public List<byte[]> Pixel 
        {
            get { 
                return _pixel; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("Pixel is not allowed to be null"); 
                _pixel = value;
            }
        }

        public IfcPixelTexture(IfcId id, bool repeatS, bool repeatT, string mode, IfcId textureTransformId, List<string> parameter, int width, int height, int colourComponents, List<byte[]> pixel) : base(id, repeatS, repeatT, mode, textureTransformId, parameter)
        {
            Width = width;
            Height = height;
            ColourComponents = colourComponents;
            Pixel = pixel;
        }

        public override ClassId GetClassId() => ClassId.IfcPixelTexture;

        #region Equality

        public bool Equals(IfcPixelTexture other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(Pixel, other.Pixel))
                return false;
            return base.Equals(other)
                && Width == other.Width
                && Height == other.Height
                && ColourComponents == other.ColourComponents;
        }

        public override bool Equals(object other) => Equals(other as IfcPixelTexture);

        public static bool operator ==(IfcPixelTexture one, IfcPixelTexture other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPixelTexture one, IfcPixelTexture other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({RepeatS},{RepeatT},'{Mode}',{TextureTransformId},{Parameter.ToJArray()},{Width},{Height},{ColourComponents},{Utils.ConvertListToString(Pixel)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPixelTexture (newId,RepeatS, RepeatT, Mode, TextureTransformId, Parameter, Width, Height, ColourComponents, Pixel);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPixelTexture },
                { "class", nameof(IfcPixelTexture) },
                { "parameters" , new JArray
                    {
                        RepeatS,
                        RepeatT,
                        Mode.ToJValue(),
                        TextureTransformId.ToJValue(),
                        Parameter.ToJArray(),
                        Width,
                        Height,
                        ColourComponents,
                        Pixel.ToJArray(),
                    }
                }
            };
        }

        public static IfcPixelTexture CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPixelTexture(
                jObject["id"].ToIfcId(),
                parameters[0].ToBool(),
                parameters[1].ToBool(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalStringList(),
                parameters[5].ToInt(),
                parameters[6].ToInt(),
                parameters[7].ToInt(),
                parameters[8].ToByteArrayList());
        }
        #endregion

    }
}