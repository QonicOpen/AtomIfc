
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
    public class IfcPolyline : IfcBoundedCurve, IEquatable<IfcPolyline>
    {
        private List<IfcId> _pointIds;
        public List<IfcId> PointIds 
        {
            get { 
                return _pointIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PointIds is not allowed to be null"); 
                _pointIds = value;
            }
        }

        public IfcPolyline(IfcId id, List<IfcId> pointIds) : base(id)
        {
            PointIds = pointIds;
        }

        public override ClassId GetClassId() => ClassId.IfcPolyline;

        #region Equality

        public bool Equals(IfcPolyline other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(PointIds, other.PointIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcPolyline);

        public static bool operator ==(IfcPolyline one, IfcPolyline other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPolyline one, IfcPolyline other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(PointIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PointIds!= null)
                PointIds = PointIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPolyline (newId,PointIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPolyline },
                { "class", nameof(IfcPolyline) },
                { "parameters" , new JArray
                    {
                        PointIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcPolyline CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPolyline(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}