
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
    public class IfcVirtualGridIntersection : IfcBase, IEquatable<IfcVirtualGridIntersection>, IIfcGridPlacementDirectionSelect
    {
        private List<IfcId> _intersectingAxisIds;
        public List<IfcId> IntersectingAxisIds 
        {
            get { 
                return _intersectingAxisIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("IntersectingAxisIds is not allowed to be null"); 
                _intersectingAxisIds = value;
            }
        }
        private List<double> _offsetDistances;
        public List<double> OffsetDistances 
        {
            get { 
                return _offsetDistances; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OffsetDistances is not allowed to be null"); 
                _offsetDistances = value;
            }
        }

        public IfcVirtualGridIntersection(IfcId id, List<IfcId> intersectingAxisIds, List<double> offsetDistances) : base(id)
        {
            IntersectingAxisIds = intersectingAxisIds;
            OffsetDistances = offsetDistances;
        }

        public override ClassId GetClassId() => ClassId.IfcVirtualGridIntersection;

        #region Equality

        public bool Equals(IfcVirtualGridIntersection other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(IntersectingAxisIds, other.IntersectingAxisIds))
                return false;
            if(!Utils.CompareList(OffsetDistances, other.OffsetDistances))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcVirtualGridIntersection);

        public static bool operator ==(IfcVirtualGridIntersection one, IfcVirtualGridIntersection other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcVirtualGridIntersection one, IfcVirtualGridIntersection other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(IntersectingAxisIds)},{Utils.ConvertListToString(OffsetDistances)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(IntersectingAxisIds!= null)
                IntersectingAxisIds = IntersectingAxisIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcVirtualGridIntersection (newId,IntersectingAxisIds, OffsetDistances);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcVirtualGridIntersection },
                { "class", nameof(IfcVirtualGridIntersection) },
                { "parameters" , new JArray
                    {
                        IntersectingAxisIds.ToJArray(),
                        OffsetDistances.ToJArray(),
                    }
                }
            };
        }

        public static IfcVirtualGridIntersection CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcVirtualGridIntersection(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToDoubleList());
        }
        #endregion

    }
}