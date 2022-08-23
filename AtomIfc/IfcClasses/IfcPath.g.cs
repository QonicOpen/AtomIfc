
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
    public class IfcPath : IfcTopologicalRepresentationItem, IEquatable<IfcPath>
    {
        private List<IfcId> _edgeIds;
        public List<IfcId> EdgeIds 
        {
            get { 
                return _edgeIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("EdgeIds is not allowed to be null"); 
                _edgeIds = value;
            }
        }

        public IfcPath(IfcId id, List<IfcId> edgeIds) : base(id)
        {
            EdgeIds = edgeIds;
        }

        public override ClassId GetClassId() => ClassId.IfcPath;

        #region Equality

        public bool Equals(IfcPath other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(EdgeIds, other.EdgeIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcPath);

        public static bool operator ==(IfcPath one, IfcPath other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPath one, IfcPath other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(EdgeIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EdgeIds!= null)
                EdgeIds = EdgeIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPath (newId,EdgeIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPath },
                { "class", nameof(IfcPath) },
                { "parameters" , new JArray
                    {
                        EdgeIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcPath CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPath(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}