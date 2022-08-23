
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
    public class IfcOrientedEdge : IfcEdge, IEquatable<IfcOrientedEdge>
    {
        private IfcId _edgeElementId;
        public IfcId EdgeElementId 
        {
            get { 
                return _edgeElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("EdgeElementId is not allowed to be null"); 
                _edgeElementId = value;
            }
        }
        private bool _orientation;
        public bool Orientation 
        {
            get { 
                return _orientation; 
            }
            set { 
                _orientation = value;
            }
        }

        public IfcOrientedEdge(IfcId id, IfcId edgeStartId, IfcId edgeEndId, IfcId edgeElementId, bool orientation) : base(id, edgeStartId, edgeEndId)
        {
            EdgeElementId = edgeElementId;
            Orientation = orientation;
        }

        public override ClassId GetClassId() => ClassId.IfcOrientedEdge;

        #region Equality

        public bool Equals(IfcOrientedEdge other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && EdgeElementId == other.EdgeElementId
                && Orientation == other.Orientation;
        }

        public override bool Equals(object other) => Equals(other as IfcOrientedEdge);

        public static bool operator ==(IfcOrientedEdge one, IfcOrientedEdge other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcOrientedEdge one, IfcOrientedEdge other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({EdgeStartId},{EdgeEndId},{EdgeElementId},{Orientation})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EdgeElementId!= null && replacementTable.ContainsKey(EdgeElementId))
                EdgeElementId = replacementTable[EdgeElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcOrientedEdge (newId,EdgeStartId, EdgeEndId, EdgeElementId, Orientation);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcOrientedEdge },
                { "class", nameof(IfcOrientedEdge) },
                { "parameters" , new JArray
                    {
                        EdgeStartId.ToJValue(),
                        EdgeEndId.ToJValue(),
                        EdgeElementId.ToJValue(),
                        Orientation,
                    }
                }
            };
        }

        public static new IfcOrientedEdge CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcOrientedEdge(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToBool());
        }
        #endregion

    }
}