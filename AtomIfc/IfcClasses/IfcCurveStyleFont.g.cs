
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
    public class IfcCurveStyleFont : IfcPresentationItem, IEquatable<IfcCurveStyleFont>, IIfcCurveStyleFontSelect
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
        private List<IfcId> _patternIds;
        public List<IfcId> PatternIds 
        {
            get { 
                return _patternIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PatternIds is not allowed to be null"); 
                _patternIds = value;
            }
        }

        public IfcCurveStyleFont(IfcId id, string name, List<IfcId> patternIds) : base(id)
        {
            Name = name;
            PatternIds = patternIds;
        }

        public override ClassId GetClassId() => ClassId.IfcCurveStyleFont;

        #region Equality

        public bool Equals(IfcCurveStyleFont other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(PatternIds, other.PatternIds))
                return false;
            return base.Equals(other)
                && Name == other.Name;
        }

        public override bool Equals(object other) => Equals(other as IfcCurveStyleFont);

        public static bool operator ==(IfcCurveStyleFont one, IfcCurveStyleFont other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCurveStyleFont one, IfcCurveStyleFont other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{Utils.ConvertListToString(PatternIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PatternIds!= null)
                PatternIds = PatternIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCurveStyleFont (newId,Name, PatternIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCurveStyleFont },
                { "class", nameof(IfcCurveStyleFont) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        PatternIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcCurveStyleFont CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCurveStyleFont(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToIfcIdList());
        }
        #endregion

    }
}