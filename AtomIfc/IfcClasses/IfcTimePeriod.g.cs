
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
    public class IfcTimePeriod : IfcBase, IEquatable<IfcTimePeriod>
    {
        private string _startTime;
        public string StartTime 
        {
            get { 
                return _startTime; 
            }
            set { 
                _startTime = value;
            }
        }
        private string _endTime;
        public string EndTime 
        {
            get { 
                return _endTime; 
            }
            set { 
                _endTime = value;
            }
        }

        public IfcTimePeriod(IfcId id, string startTime, string endTime) : base(id)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public override ClassId GetClassId() => ClassId.IfcTimePeriod;

        #region Equality

        public bool Equals(IfcTimePeriod other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && StartTime == other.StartTime
                && EndTime == other.EndTime;
        }

        public override bool Equals(object other) => Equals(other as IfcTimePeriod);

        public static bool operator ==(IfcTimePeriod one, IfcTimePeriod other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTimePeriod one, IfcTimePeriod other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{StartTime}','{EndTime}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTimePeriod (newId,StartTime, EndTime);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTimePeriod },
                { "class", nameof(IfcTimePeriod) },
                { "parameters" , new JArray
                    {
                        StartTime.ToJValue(),
                        EndTime.ToJValue(),
                    }
                }
            };
        }

        public static IfcTimePeriod CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTimePeriod(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToString());
        }
        #endregion

    }
}