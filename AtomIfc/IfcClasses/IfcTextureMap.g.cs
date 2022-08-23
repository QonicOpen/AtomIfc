
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
    public class IfcTextureMap : IfcTextureCoordinate, IEquatable<IfcTextureMap>
    {
        private List<IfcId> _vertexIds;
        public List<IfcId> VertexIds 
        {
            get { 
                return _vertexIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("VertexIds is not allowed to be null"); 
                _vertexIds = value;
            }
        }
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

        public IfcTextureMap(IfcId id, List<IfcId> mapIds, List<IfcId> vertexIds, IfcId mappedToId) : base(id, mapIds)
        {
            VertexIds = vertexIds;
            MappedToId = mappedToId;
        }

        public override ClassId GetClassId() => ClassId.IfcTextureMap;

        #region Equality

        public bool Equals(IfcTextureMap other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(VertexIds, other.VertexIds))
                return false;
            return base.Equals(other)
                && MappedToId == other.MappedToId;
        }

        public override bool Equals(object other) => Equals(other as IfcTextureMap);

        public static bool operator ==(IfcTextureMap one, IfcTextureMap other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTextureMap one, IfcTextureMap other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(MapIds)},{Utils.ConvertListToString(VertexIds)},{MappedToId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(VertexIds!= null)
                VertexIds = VertexIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(MappedToId!= null && replacementTable.ContainsKey(MappedToId))
                MappedToId = replacementTable[MappedToId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTextureMap (newId,MapIds, VertexIds, MappedToId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTextureMap },
                { "class", nameof(IfcTextureMap) },
                { "parameters" , new JArray
                    {
                        MapIds.ToJArray(),
                        VertexIds.ToJArray(),
                        MappedToId.ToJValue(),
                    }
                }
            };
        }

        public static IfcTextureMap CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTextureMap(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToIfcIdList(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}