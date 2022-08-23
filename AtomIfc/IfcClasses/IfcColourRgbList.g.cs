
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
    public class IfcColourRgbList : IfcPresentationItem, IEquatable<IfcColourRgbList>
    {
        private List<List<double>> _colourList;
        public List<List<double>> ColourList 
        {
            get { 
                return _colourList; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ColourList is not allowed to be null"); 
                _colourList = value;
            }
        }

        public IfcColourRgbList(IfcId id, List<List<double>> colourList) : base(id)
        {
            ColourList = colourList;
        }

        public override ClassId GetClassId() => ClassId.IfcColourRgbList;

        #region Equality

        public bool Equals(IfcColourRgbList other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ColourList, other.ColourList))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcColourRgbList);

        public static bool operator ==(IfcColourRgbList one, IfcColourRgbList other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcColourRgbList one, IfcColourRgbList other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(ColourList)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcColourRgbList (newId,ColourList);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcColourRgbList },
                { "class", nameof(IfcColourRgbList) },
                { "parameters" , new JArray
                    {
                        ColourList.ToJArray(),
                    }
                }
            };
        }

        public static IfcColourRgbList CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcColourRgbList(
                jObject["id"].ToIfcId(),
                parameters[0].ToNestedDoubleList());
        }
        #endregion

    }
}