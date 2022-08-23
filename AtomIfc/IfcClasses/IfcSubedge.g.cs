
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
    public class IfcSubedge : IfcEdge, IEquatable<IfcSubedge>
    {
        private IfcId _parentEdgeId;
        public IfcId ParentEdgeId 
        {
            get { 
                return _parentEdgeId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ParentEdgeId is not allowed to be null"); 
                _parentEdgeId = value;
            }
        }

        public IfcSubedge(IfcId id, IfcId edgeStartId, IfcId edgeEndId, IfcId parentEdgeId) : base(id, edgeStartId, edgeEndId)
        {
            ParentEdgeId = parentEdgeId;
        }

        public override ClassId GetClassId() => ClassId.IfcSubedge;

        #region Equality

        public bool Equals(IfcSubedge other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ParentEdgeId == other.ParentEdgeId;
        }

        public override bool Equals(object other) => Equals(other as IfcSubedge);

        public static bool operator ==(IfcSubedge one, IfcSubedge other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSubedge one, IfcSubedge other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({EdgeStartId},{EdgeEndId},{ParentEdgeId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ParentEdgeId!= null && replacementTable.ContainsKey(ParentEdgeId))
                ParentEdgeId = replacementTable[ParentEdgeId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSubedge (newId,EdgeStartId, EdgeEndId, ParentEdgeId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSubedge },
                { "class", nameof(IfcSubedge) },
                { "parameters" , new JArray
                    {
                        EdgeStartId.ToJValue(),
                        EdgeEndId.ToJValue(),
                        ParentEdgeId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcSubedge CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSubedge(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}