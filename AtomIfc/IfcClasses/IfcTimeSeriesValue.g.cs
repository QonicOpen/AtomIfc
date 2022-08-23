
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
    public class IfcTimeSeriesValue : IfcBase, IEquatable<IfcTimeSeriesValue>
    {
        private List<IfcId> _listValueIds;
        public List<IfcId> ListValueIds 
        {
            get { 
                return _listValueIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ListValueIds is not allowed to be null"); 
                _listValueIds = value;
            }
        }

        public IfcTimeSeriesValue(IfcId id, List<IfcId> listValueIds) : base(id)
        {
            ListValueIds = listValueIds;
        }

        public override ClassId GetClassId() => ClassId.IfcTimeSeriesValue;

        #region Equality

        public bool Equals(IfcTimeSeriesValue other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ListValueIds, other.ListValueIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcTimeSeriesValue);

        public static bool operator ==(IfcTimeSeriesValue one, IfcTimeSeriesValue other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTimeSeriesValue one, IfcTimeSeriesValue other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(ListValueIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ListValueIds!= null)
                ListValueIds = ListValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTimeSeriesValue (newId,ListValueIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTimeSeriesValue },
                { "class", nameof(IfcTimeSeriesValue) },
                { "parameters" , new JArray
                    {
                        ListValueIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcTimeSeriesValue CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTimeSeriesValue(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}