
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
    public class IfcIndexedPolygonalFaceWithVoids : IfcIndexedPolygonalFace, IEquatable<IfcIndexedPolygonalFaceWithVoids>
    {
        private List<List<int>> _innerCoordIndices;
        public List<List<int>> InnerCoordIndices 
        {
            get { 
                return _innerCoordIndices; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("InnerCoordIndices is not allowed to be null"); 
                _innerCoordIndices = value;
            }
        }

        public IfcIndexedPolygonalFaceWithVoids(IfcId id, List<int> coordIndex, List<List<int>> innerCoordIndices) : base(id, coordIndex)
        {
            InnerCoordIndices = innerCoordIndices;
        }

        public override ClassId GetClassId() => ClassId.IfcIndexedPolygonalFaceWithVoids;

        #region Equality

        public bool Equals(IfcIndexedPolygonalFaceWithVoids other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(InnerCoordIndices, other.InnerCoordIndices))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcIndexedPolygonalFaceWithVoids);

        public static bool operator ==(IfcIndexedPolygonalFaceWithVoids one, IfcIndexedPolygonalFaceWithVoids other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcIndexedPolygonalFaceWithVoids one, IfcIndexedPolygonalFaceWithVoids other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(CoordIndex)},{Utils.ConvertListToString(InnerCoordIndices)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcIndexedPolygonalFaceWithVoids (newId,CoordIndex, InnerCoordIndices);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcIndexedPolygonalFaceWithVoids },
                { "class", nameof(IfcIndexedPolygonalFaceWithVoids) },
                { "parameters" , new JArray
                    {
                        CoordIndex.ToJArray(),
                        InnerCoordIndices.ToJArray(),
                    }
                }
            };
        }

        public static new IfcIndexedPolygonalFaceWithVoids CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcIndexedPolygonalFaceWithVoids(
                jObject["id"].ToIfcId(),
                parameters[0].ToIntList(),
                parameters[1].ToNestedIntList());
        }
        #endregion

    }
}