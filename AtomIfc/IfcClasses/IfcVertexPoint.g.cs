
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
    public class IfcVertexPoint : IfcVertex, IEquatable<IfcVertexPoint>, IIfcPointOrVertexPoint
    {
        private IfcId _vertexGeometryId;
        public IfcId VertexGeometryId 
        {
            get { 
                return _vertexGeometryId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("VertexGeometryId is not allowed to be null"); 
                _vertexGeometryId = value;
            }
        }

        public IfcVertexPoint(IfcId id, IfcId vertexGeometryId) : base(id)
        {
            VertexGeometryId = vertexGeometryId;
        }

        public override ClassId GetClassId() => ClassId.IfcVertexPoint;

        #region Equality

        public bool Equals(IfcVertexPoint other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && VertexGeometryId == other.VertexGeometryId;
        }

        public override bool Equals(object other) => Equals(other as IfcVertexPoint);

        public static bool operator ==(IfcVertexPoint one, IfcVertexPoint other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcVertexPoint one, IfcVertexPoint other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({VertexGeometryId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(VertexGeometryId!= null && replacementTable.ContainsKey(VertexGeometryId))
                VertexGeometryId = replacementTable[VertexGeometryId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcVertexPoint (newId,VertexGeometryId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcVertexPoint },
                { "class", nameof(IfcVertexPoint) },
                { "parameters" , new JArray
                    {
                        VertexGeometryId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcVertexPoint CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcVertexPoint(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId());
        }
        #endregion

    }
}