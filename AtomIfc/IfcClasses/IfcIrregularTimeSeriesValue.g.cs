
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
    public class IfcIrregularTimeSeriesValue : IfcBase, IEquatable<IfcIrregularTimeSeriesValue>
    {
        private string _timeStamp;
        public string TimeStamp 
        {
            get { 
                return _timeStamp; 
            }
            set { 
                _timeStamp = value;
            }
        }
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

        public IfcIrregularTimeSeriesValue(IfcId id, string timeStamp, List<IfcId> listValueIds) : base(id)
        {
            TimeStamp = timeStamp;
            ListValueIds = listValueIds;
        }

        public override ClassId GetClassId() => ClassId.IfcIrregularTimeSeriesValue;

        #region Equality

        public bool Equals(IfcIrregularTimeSeriesValue other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ListValueIds, other.ListValueIds))
                return false;
            return base.Equals(other)
                && TimeStamp == other.TimeStamp;
        }

        public override bool Equals(object other) => Equals(other as IfcIrregularTimeSeriesValue);

        public static bool operator ==(IfcIrregularTimeSeriesValue one, IfcIrregularTimeSeriesValue other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcIrregularTimeSeriesValue one, IfcIrregularTimeSeriesValue other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{TimeStamp}',{Utils.ConvertListToString(ListValueIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ListValueIds!= null)
                ListValueIds = ListValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcIrregularTimeSeriesValue (newId,TimeStamp, ListValueIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcIrregularTimeSeriesValue },
                { "class", nameof(IfcIrregularTimeSeriesValue) },
                { "parameters" , new JArray
                    {
                        TimeStamp.ToJValue(),
                        ListValueIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcIrregularTimeSeriesValue CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcIrregularTimeSeriesValue(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToIfcIdList());
        }
        #endregion

    }
}