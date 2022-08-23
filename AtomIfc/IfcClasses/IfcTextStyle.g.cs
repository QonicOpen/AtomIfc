
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
    public class IfcTextStyle : IfcPresentationStyle, IEquatable<IfcTextStyle>, IIfcPresentationStyleSelect
    {
        private IfcId _textCharacterAppearanceId;
        public IfcId TextCharacterAppearanceId 
        {
            get { 
                return _textCharacterAppearanceId; 
            }
            set { 
                _textCharacterAppearanceId = value;  // optional IfcTextStyleForDefinedFont
            }
        }
        private IfcId _textStyleId;
        public IfcId TextStyleId 
        {
            get { 
                return _textStyleId; 
            }
            set { 
                _textStyleId = value;  // optional IfcTextStyleTextModel
            }
        }
        private IfcId _textFontStyleId;
        public IfcId TextFontStyleId 
        {
            get { 
                return _textFontStyleId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TextFontStyleId is not allowed to be null"); 
                _textFontStyleId = value;
            }
        }
        private bool? _modelOrDraughting;
        public bool? ModelOrDraughting 
        {
            get { 
                return _modelOrDraughting; 
            }
            set { 
                _modelOrDraughting = value;  // optional bool
            }
        }

        public IfcTextStyle(IfcId id, string name, IfcId textCharacterAppearanceId, IfcId textStyleId, IfcId textFontStyleId, bool? modelOrDraughting) : base(id, name)
        {
            TextCharacterAppearanceId = textCharacterAppearanceId;
            TextStyleId = textStyleId;
            TextFontStyleId = textFontStyleId;
            ModelOrDraughting = modelOrDraughting;
        }

        public override ClassId GetClassId() => ClassId.IfcTextStyle;

        #region Equality

        public bool Equals(IfcTextStyle other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TextCharacterAppearanceId == other.TextCharacterAppearanceId
                && TextStyleId == other.TextStyleId
                && TextFontStyleId == other.TextFontStyleId
                && ModelOrDraughting == other.ModelOrDraughting;
        }

        public override bool Equals(object other) => Equals(other as IfcTextStyle);

        public static bool operator ==(IfcTextStyle one, IfcTextStyle other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTextStyle one, IfcTextStyle other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{TextCharacterAppearanceId},{TextStyleId},{TextFontStyleId},{(ModelOrDraughting == null? ".U." : ModelOrDraughting)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TextCharacterAppearanceId!= null && replacementTable.ContainsKey(TextCharacterAppearanceId))
                TextCharacterAppearanceId = replacementTable[TextCharacterAppearanceId];
            if(TextStyleId!= null && replacementTable.ContainsKey(TextStyleId))
                TextStyleId = replacementTable[TextStyleId];
            if(TextFontStyleId!= null && replacementTable.ContainsKey(TextFontStyleId))
                TextFontStyleId = replacementTable[TextFontStyleId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTextStyle (newId,Name, TextCharacterAppearanceId, TextStyleId, TextFontStyleId, ModelOrDraughting);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTextStyle },
                { "class", nameof(IfcTextStyle) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        TextCharacterAppearanceId.ToJValue(),
                        TextStyleId.ToJValue(),
                        TextFontStyleId.ToJValue(),
                        ModelOrDraughting.ToJValue(),
                    }
                }
            };
        }

        public static IfcTextStyle CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTextStyle(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToIfcId(),
                parameters[4].ToOptionalBool());
        }
        #endregion

    }
}