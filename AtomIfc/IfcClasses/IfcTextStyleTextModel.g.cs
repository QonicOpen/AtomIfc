
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
    public class IfcTextStyleTextModel : IfcPresentationItem, IEquatable<IfcTextStyleTextModel>
    {
        private IfcId _textIndentId;
        public IfcId TextIndentId 
        {
            get { 
                return _textIndentId; 
            }
            set { 
                _textIndentId = value;  // optional IfcSizeSelect
            }
        }
        private string _textAlign;
        public string TextAlign 
        {
            get { 
                return _textAlign; 
            }
            set { 
                _textAlign = value;  // optional IfcTextAlignment
            }
        }
        private string _textDecoration;
        public string TextDecoration 
        {
            get { 
                return _textDecoration; 
            }
            set { 
                _textDecoration = value;  // optional IfcTextDecoration
            }
        }
        private IfcId _letterSpacingId;
        public IfcId LetterSpacingId 
        {
            get { 
                return _letterSpacingId; 
            }
            set { 
                _letterSpacingId = value;  // optional IfcSizeSelect
            }
        }
        private IfcId _wordSpacingId;
        public IfcId WordSpacingId 
        {
            get { 
                return _wordSpacingId; 
            }
            set { 
                _wordSpacingId = value;  // optional IfcSizeSelect
            }
        }
        private string _textTransform;
        public string TextTransform 
        {
            get { 
                return _textTransform; 
            }
            set { 
                _textTransform = value;  // optional IfcTextTransformation
            }
        }
        private IfcId _lineHeightId;
        public IfcId LineHeightId 
        {
            get { 
                return _lineHeightId; 
            }
            set { 
                _lineHeightId = value;  // optional IfcSizeSelect
            }
        }

        public IfcTextStyleTextModel(IfcId id, IfcId textIndentId, string textAlign, string textDecoration, IfcId letterSpacingId, IfcId wordSpacingId, string textTransform, IfcId lineHeightId) : base(id)
        {
            TextIndentId = textIndentId;
            TextAlign = textAlign;
            TextDecoration = textDecoration;
            LetterSpacingId = letterSpacingId;
            WordSpacingId = wordSpacingId;
            TextTransform = textTransform;
            LineHeightId = lineHeightId;
        }

        public override ClassId GetClassId() => ClassId.IfcTextStyleTextModel;

        #region Equality

        public bool Equals(IfcTextStyleTextModel other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TextIndentId == other.TextIndentId
                && TextAlign == other.TextAlign
                && TextDecoration == other.TextDecoration
                && LetterSpacingId == other.LetterSpacingId
                && WordSpacingId == other.WordSpacingId
                && TextTransform == other.TextTransform
                && LineHeightId == other.LineHeightId;
        }

        public override bool Equals(object other) => Equals(other as IfcTextStyleTextModel);

        public static bool operator ==(IfcTextStyleTextModel one, IfcTextStyleTextModel other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTextStyleTextModel one, IfcTextStyleTextModel other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({TextIndentId},'{TextAlign}','{TextDecoration}',{LetterSpacingId},{WordSpacingId},'{TextTransform}',{LineHeightId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TextIndentId!= null && replacementTable.ContainsKey(TextIndentId))
                TextIndentId = replacementTable[TextIndentId];
            if(LetterSpacingId!= null && replacementTable.ContainsKey(LetterSpacingId))
                LetterSpacingId = replacementTable[LetterSpacingId];
            if(WordSpacingId!= null && replacementTable.ContainsKey(WordSpacingId))
                WordSpacingId = replacementTable[WordSpacingId];
            if(LineHeightId!= null && replacementTable.ContainsKey(LineHeightId))
                LineHeightId = replacementTable[LineHeightId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTextStyleTextModel (newId,TextIndentId, TextAlign, TextDecoration, LetterSpacingId, WordSpacingId, TextTransform, LineHeightId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTextStyleTextModel },
                { "class", nameof(IfcTextStyleTextModel) },
                { "parameters" , new JArray
                    {
                        TextIndentId.ToJValue(),
                        TextAlign.ToJValue(),
                        TextDecoration.ToJValue(),
                        LetterSpacingId.ToJValue(),
                        WordSpacingId.ToJValue(),
                        TextTransform.ToJValue(),
                        LineHeightId.ToJValue(),
                    }
                }
            };
        }

        public static IfcTextStyleTextModel CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTextStyleTextModel(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalIfcId(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalIfcId());
        }
        #endregion

    }
}