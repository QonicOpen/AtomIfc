
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
    public class IfcPolyLoop : IfcLoop, IEquatable<IfcPolyLoop>
    {
        private List<IfcId> _polygonIds;
        public List<IfcId> PolygonIds 
        {
            get { 
                return _polygonIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PolygonIds is not allowed to be null"); 
                _polygonIds = value;
            }
        }

        public IfcPolyLoop(IfcId id, List<IfcId> polygonIds) : base(id)
        {
            PolygonIds = polygonIds;
        }

        public override ClassId GetClassId() => ClassId.IfcPolyLoop;

        #region Equality

        public bool Equals(IfcPolyLoop other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(PolygonIds, other.PolygonIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcPolyLoop);

        public static bool operator ==(IfcPolyLoop one, IfcPolyLoop other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPolyLoop one, IfcPolyLoop other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(PolygonIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PolygonIds!= null)
                PolygonIds = PolygonIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPolyLoop (newId,PolygonIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPolyLoop },
                { "class", nameof(IfcPolyLoop) },
                { "parameters" , new JArray
                    {
                        PolygonIds.ToJArray(),
                    }
                }
            };
        }

        public static new IfcPolyLoop CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPolyLoop(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}