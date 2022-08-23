
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
    public class IfcEventTime : IfcSchedulingTime, IEquatable<IfcEventTime>
    {
        private string _actualDate;
        public string ActualDate 
        {
            get { 
                return _actualDate; 
            }
            set { 
                _actualDate = value;  // optional IfcDateTime
            }
        }
        private string _earlyDate;
        public string EarlyDate 
        {
            get { 
                return _earlyDate; 
            }
            set { 
                _earlyDate = value;  // optional IfcDateTime
            }
        }
        private string _lateDate;
        public string LateDate 
        {
            get { 
                return _lateDate; 
            }
            set { 
                _lateDate = value;  // optional IfcDateTime
            }
        }
        private string _scheduleDate;
        public string ScheduleDate 
        {
            get { 
                return _scheduleDate; 
            }
            set { 
                _scheduleDate = value;  // optional IfcDateTime
            }
        }

        public IfcEventTime(IfcId id, string name, IfcDataOriginEnum dataOrigin, string userDefinedDataOrigin, string actualDate, string earlyDate, string lateDate, string scheduleDate) : base(id, name, dataOrigin, userDefinedDataOrigin)
        {
            ActualDate = actualDate;
            EarlyDate = earlyDate;
            LateDate = lateDate;
            ScheduleDate = scheduleDate;
        }

        public override ClassId GetClassId() => ClassId.IfcEventTime;

        #region Equality

        public bool Equals(IfcEventTime other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ActualDate == other.ActualDate
                && EarlyDate == other.EarlyDate
                && LateDate == other.LateDate
                && ScheduleDate == other.ScheduleDate;
        }

        public override bool Equals(object other) => Equals(other as IfcEventTime);

        public static bool operator ==(IfcEventTime one, IfcEventTime other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcEventTime one, IfcEventTime other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',.{DataOrigin}.,'{UserDefinedDataOrigin}','{ActualDate}','{EarlyDate}','{LateDate}','{ScheduleDate}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcEventTime (newId,Name, DataOrigin, UserDefinedDataOrigin, ActualDate, EarlyDate, LateDate, ScheduleDate);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcEventTime },
                { "class", nameof(IfcEventTime) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        DataOrigin.ToJValue(),
                        UserDefinedDataOrigin.ToJValue(),
                        ActualDate.ToJValue(),
                        EarlyDate.ToJValue(),
                        LateDate.ToJValue(),
                        ScheduleDate.ToJValue(),
                    }
                }
            };
        }

        public static IfcEventTime CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcEventTime(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                (IfcDataOriginEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDataOriginEnum](parameters[1].ToString()),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString());
        }
        #endregion

    }
}