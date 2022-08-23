
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
    public class IfcEdge : IfcTopologicalRepresentationItem, IEquatable<IfcEdge>
    {
        private IfcId _edgeStartId;
        public IfcId EdgeStartId 
        {
            get { 
                return _edgeStartId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("EdgeStartId is not allowed to be null"); 
                _edgeStartId = value;
            }
        }
        private IfcId _edgeEndId;
        public IfcId EdgeEndId 
        {
            get { 
                return _edgeEndId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("EdgeEndId is not allowed to be null"); 
                _edgeEndId = value;
            }
        }

        public IfcEdge(IfcId id, IfcId edgeStartId, IfcId edgeEndId) : base(id)
        {
            EdgeStartId = edgeStartId;
            EdgeEndId = edgeEndId;
        }

        public override ClassId GetClassId() => ClassId.IfcEdge;

        #region Equality

        public bool Equals(IfcEdge other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && EdgeStartId == other.EdgeStartId
                && EdgeEndId == other.EdgeEndId;
        }

        public override bool Equals(object other) => Equals(other as IfcEdge);

        public static bool operator ==(IfcEdge one, IfcEdge other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcEdge one, IfcEdge other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({EdgeStartId},{EdgeEndId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EdgeStartId!= null && replacementTable.ContainsKey(EdgeStartId))
                EdgeStartId = replacementTable[EdgeStartId];
            if(EdgeEndId!= null && replacementTable.ContainsKey(EdgeEndId))
                EdgeEndId = replacementTable[EdgeEndId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcEdge (newId,EdgeStartId, EdgeEndId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcEdge },
                { "class", nameof(IfcEdge) },
                { "parameters" , new JArray
                    {
                        EdgeStartId.ToJValue(),
                        EdgeEndId.ToJValue(),
                    }
                }
            };
        }

        public static IfcEdge CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcEdge(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId());
        }
        #endregion

    }
}