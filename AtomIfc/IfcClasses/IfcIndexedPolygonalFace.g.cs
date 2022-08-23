
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
    public class IfcIndexedPolygonalFace : IfcTessellatedItem, IEquatable<IfcIndexedPolygonalFace>
    {
        private List<int> _coordIndex;
        public List<int> CoordIndex 
        {
            get { 
                return _coordIndex; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("CoordIndex is not allowed to be null"); 
                _coordIndex = value;
            }
        }

        public IfcIndexedPolygonalFace(IfcId id, List<int> coordIndex) : base(id)
        {
            CoordIndex = coordIndex;
        }

        public override ClassId GetClassId() => ClassId.IfcIndexedPolygonalFace;

        #region Equality

        public bool Equals(IfcIndexedPolygonalFace other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(CoordIndex, other.CoordIndex))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcIndexedPolygonalFace);

        public static bool operator ==(IfcIndexedPolygonalFace one, IfcIndexedPolygonalFace other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcIndexedPolygonalFace one, IfcIndexedPolygonalFace other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(CoordIndex)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcIndexedPolygonalFace (newId,CoordIndex);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcIndexedPolygonalFace },
                { "class", nameof(IfcIndexedPolygonalFace) },
                { "parameters" , new JArray
                    {
                        CoordIndex.ToJArray(),
                    }
                }
            };
        }

        public static IfcIndexedPolygonalFace CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcIndexedPolygonalFace(
                jObject["id"].ToIfcId(),
                parameters[0].ToIntList());
        }
        #endregion

    }
}