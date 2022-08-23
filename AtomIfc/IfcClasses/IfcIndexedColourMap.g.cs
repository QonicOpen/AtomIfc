
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
    public class IfcIndexedColourMap : IfcPresentationItem, IEquatable<IfcIndexedColourMap>
    {
        private IfcId _mappedToId;
        public IfcId MappedToId 
        {
            get { 
                return _mappedToId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MappedToId is not allowed to be null"); 
                _mappedToId = value;
            }
        }
        private double? _opacity;
        public double? Opacity 
        {
            get { 
                return _opacity; 
            }
            set { 
                _opacity = value;  // optional IfcNormalisedRatioMeasure
            }
        }
        private IfcId _coloursId;
        public IfcId ColoursId 
        {
            get { 
                return _coloursId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ColoursId is not allowed to be null"); 
                _coloursId = value;
            }
        }
        private List<int> _colourIndex;
        public List<int> ColourIndex 
        {
            get { 
                return _colourIndex; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ColourIndex is not allowed to be null"); 
                _colourIndex = value;
            }
        }

        public IfcIndexedColourMap(IfcId id, IfcId mappedToId, double? opacity, IfcId coloursId, List<int> colourIndex) : base(id)
        {
            MappedToId = mappedToId;
            Opacity = opacity;
            ColoursId = coloursId;
            ColourIndex = colourIndex;
        }

        public override ClassId GetClassId() => ClassId.IfcIndexedColourMap;

        #region Equality

        public bool Equals(IfcIndexedColourMap other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ColourIndex, other.ColourIndex))
                return false;
            return base.Equals(other)
                && MappedToId == other.MappedToId
                && Opacity == other.Opacity
                && ColoursId == other.ColoursId;
        }

        public override bool Equals(object other) => Equals(other as IfcIndexedColourMap);

        public static bool operator ==(IfcIndexedColourMap one, IfcIndexedColourMap other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcIndexedColourMap one, IfcIndexedColourMap other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({MappedToId},{Opacity},{ColoursId},{Utils.ConvertListToString(ColourIndex)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MappedToId!= null && replacementTable.ContainsKey(MappedToId))
                MappedToId = replacementTable[MappedToId];
            if(ColoursId!= null && replacementTable.ContainsKey(ColoursId))
                ColoursId = replacementTable[ColoursId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcIndexedColourMap (newId,MappedToId, Opacity, ColoursId, ColourIndex);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcIndexedColourMap },
                { "class", nameof(IfcIndexedColourMap) },
                { "parameters" , new JArray
                    {
                        MappedToId.ToJValue(),
                        Opacity.ToJValue(),
                        ColoursId.ToJValue(),
                        ColourIndex.ToJArray(),
                    }
                }
            };
        }

        public static IfcIndexedColourMap CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcIndexedColourMap(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalDouble(),
                parameters[2].ToIfcId(),
                parameters[3].ToIntList());
        }
        #endregion

    }
}