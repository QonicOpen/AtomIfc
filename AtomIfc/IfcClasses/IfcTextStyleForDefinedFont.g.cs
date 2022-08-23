
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
    public class IfcTextStyleForDefinedFont : IfcPresentationItem, IEquatable<IfcTextStyleForDefinedFont>
    {
        private IfcId _colourId;
        public IfcId ColourId 
        {
            get { 
                return _colourId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ColourId is not allowed to be null"); 
                _colourId = value;
            }
        }
        private IfcId _backgroundColourId;
        public IfcId BackgroundColourId 
        {
            get { 
                return _backgroundColourId; 
            }
            set { 
                _backgroundColourId = value;  // optional IfcColour
            }
        }

        public IfcTextStyleForDefinedFont(IfcId id, IfcId colourId, IfcId backgroundColourId) : base(id)
        {
            ColourId = colourId;
            BackgroundColourId = backgroundColourId;
        }

        public override ClassId GetClassId() => ClassId.IfcTextStyleForDefinedFont;

        #region Equality

        public bool Equals(IfcTextStyleForDefinedFont other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ColourId == other.ColourId
                && BackgroundColourId == other.BackgroundColourId;
        }

        public override bool Equals(object other) => Equals(other as IfcTextStyleForDefinedFont);

        public static bool operator ==(IfcTextStyleForDefinedFont one, IfcTextStyleForDefinedFont other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTextStyleForDefinedFont one, IfcTextStyleForDefinedFont other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({ColourId},{BackgroundColourId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ColourId!= null && replacementTable.ContainsKey(ColourId))
                ColourId = replacementTable[ColourId];
            if(BackgroundColourId!= null && replacementTable.ContainsKey(BackgroundColourId))
                BackgroundColourId = replacementTable[BackgroundColourId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTextStyleForDefinedFont (newId,ColourId, BackgroundColourId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTextStyleForDefinedFont },
                { "class", nameof(IfcTextStyleForDefinedFont) },
                { "parameters" , new JArray
                    {
                        ColourId.ToJValue(),
                        BackgroundColourId.ToJValue(),
                    }
                }
            };
        }

        public static IfcTextStyleForDefinedFont CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTextStyleForDefinedFont(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId());
        }
        #endregion

    }
}