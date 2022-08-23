
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
    public class IfcEdgeCurve : IfcEdge, IEquatable<IfcEdgeCurve>, IIfcCurveOrEdgeCurve
    {
        private IfcId _edgeGeometryId;
        public IfcId EdgeGeometryId 
        {
            get { 
                return _edgeGeometryId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("EdgeGeometryId is not allowed to be null"); 
                _edgeGeometryId = value;
            }
        }
        private bool _sameSense;
        public bool SameSense 
        {
            get { 
                return _sameSense; 
            }
            set { 
                _sameSense = value;
            }
        }

        public IfcEdgeCurve(IfcId id, IfcId edgeStartId, IfcId edgeEndId, IfcId edgeGeometryId, bool sameSense) : base(id, edgeStartId, edgeEndId)
        {
            EdgeGeometryId = edgeGeometryId;
            SameSense = sameSense;
        }

        public override ClassId GetClassId() => ClassId.IfcEdgeCurve;

        #region Equality

        public bool Equals(IfcEdgeCurve other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && EdgeGeometryId == other.EdgeGeometryId
                && SameSense == other.SameSense;
        }

        public override bool Equals(object other) => Equals(other as IfcEdgeCurve);

        public static bool operator ==(IfcEdgeCurve one, IfcEdgeCurve other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcEdgeCurve one, IfcEdgeCurve other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({EdgeStartId},{EdgeEndId},{EdgeGeometryId},{SameSense})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EdgeGeometryId!= null && replacementTable.ContainsKey(EdgeGeometryId))
                EdgeGeometryId = replacementTable[EdgeGeometryId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcEdgeCurve (newId,EdgeStartId, EdgeEndId, EdgeGeometryId, SameSense);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcEdgeCurve },
                { "class", nameof(IfcEdgeCurve) },
                { "parameters" , new JArray
                    {
                        EdgeStartId.ToJValue(),
                        EdgeEndId.ToJValue(),
                        EdgeGeometryId.ToJValue(),
                        SameSense,
                    }
                }
            };
        }

        public static new IfcEdgeCurve CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcEdgeCurve(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToBool());
        }
        #endregion

    }
}