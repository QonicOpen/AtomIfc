
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
    public class IfcTextStyleFontModel : IfcPreDefinedTextFont, IEquatable<IfcTextStyleFontModel>
    {
        private List<string> _fontFamily;
        public List<string> FontFamily 
        {
            get { 
                return _fontFamily; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("FontFamily is not allowed to be null"); 
                _fontFamily = value;
            }
        }
        private string _fontStyle;
        public string FontStyle 
        {
            get { 
                return _fontStyle; 
            }
            set { 
                _fontStyle = value;  // optional IfcFontStyle
            }
        }
        private string _fontVariant;
        public string FontVariant 
        {
            get { 
                return _fontVariant; 
            }
            set { 
                _fontVariant = value;  // optional IfcFontVariant
            }
        }
        private string _fontWeight;
        public string FontWeight 
        {
            get { 
                return _fontWeight; 
            }
            set { 
                _fontWeight = value;  // optional IfcFontWeight
            }
        }
        private IfcId _fontSizeId;
        public IfcId FontSizeId 
        {
            get { 
                return _fontSizeId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("FontSizeId is not allowed to be null"); 
                _fontSizeId = value;
            }
        }

        public IfcTextStyleFontModel(IfcId id, string name, List<string> fontFamily, string fontStyle, string fontVariant, string fontWeight, IfcId fontSizeId) : base(id, name)
        {
            FontFamily = fontFamily;
            FontStyle = fontStyle;
            FontVariant = fontVariant;
            FontWeight = fontWeight;
            FontSizeId = fontSizeId;
        }

        public override ClassId GetClassId() => ClassId.IfcTextStyleFontModel;

        #region Equality

        public bool Equals(IfcTextStyleFontModel other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(FontFamily, other.FontFamily))
                return false;
            return base.Equals(other)
                && FontStyle == other.FontStyle
                && FontVariant == other.FontVariant
                && FontWeight == other.FontWeight
                && FontSizeId == other.FontSizeId;
        }

        public override bool Equals(object other) => Equals(other as IfcTextStyleFontModel);

        public static bool operator ==(IfcTextStyleFontModel one, IfcTextStyleFontModel other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTextStyleFontModel one, IfcTextStyleFontModel other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{FontFamily.ToJArray()},'{FontStyle}','{FontVariant}','{FontWeight}',{FontSizeId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(FontSizeId!= null && replacementTable.ContainsKey(FontSizeId))
                FontSizeId = replacementTable[FontSizeId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTextStyleFontModel (newId,Name, FontFamily, FontStyle, FontVariant, FontWeight, FontSizeId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTextStyleFontModel },
                { "class", nameof(IfcTextStyleFontModel) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        FontFamily.ToJArray(),
                        FontStyle.ToJValue(),
                        FontVariant.ToJValue(),
                        FontWeight.ToJValue(),
                        FontSizeId.ToJValue(),
                    }
                }
            };
        }

        public static IfcTextStyleFontModel CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTextStyleFontModel(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToStringList(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToIfcId());
        }
        #endregion

    }
}