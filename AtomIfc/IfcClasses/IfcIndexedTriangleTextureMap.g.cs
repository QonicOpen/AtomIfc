
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
    public class IfcIndexedTriangleTextureMap : IfcIndexedTextureMap, IEquatable<IfcIndexedTriangleTextureMap>
    {
        private List<List<int>> _texCoordIndex;
        public List<List<int>> TexCoordIndex 
        {
            get { 
                return _texCoordIndex; 
            }
            set { 
                _texCoordIndex = value;  // optional List<List<int>>
            }
        }

        public IfcIndexedTriangleTextureMap(IfcId id, List<IfcId> mapIds, IfcId mappedToId, IfcId texCoordsId, List<List<int>> texCoordIndex) : base(id, mapIds, mappedToId, texCoordsId)
        {
            TexCoordIndex = texCoordIndex;
        }

        public override ClassId GetClassId() => ClassId.IfcIndexedTriangleTextureMap;

        #region Equality

        public bool Equals(IfcIndexedTriangleTextureMap other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(TexCoordIndex, other.TexCoordIndex))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcIndexedTriangleTextureMap);

        public static bool operator ==(IfcIndexedTriangleTextureMap one, IfcIndexedTriangleTextureMap other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcIndexedTriangleTextureMap one, IfcIndexedTriangleTextureMap other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(MapIds)},{MappedToId},{TexCoordsId},{Utils.ConvertListToString(TexCoordIndex)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcIndexedTriangleTextureMap (newId,MapIds, MappedToId, TexCoordsId, TexCoordIndex);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcIndexedTriangleTextureMap },
                { "class", nameof(IfcIndexedTriangleTextureMap) },
                { "parameters" , new JArray
                    {
                        MapIds.ToJArray(),
                        MappedToId.ToJValue(),
                        TexCoordsId.ToJValue(),
                        TexCoordIndex.ToJArray(),
                    }
                }
            };
        }

        public static IfcIndexedTriangleTextureMap CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcIndexedTriangleTextureMap(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToOptionalNestedIntList());
        }
        #endregion

    }
}