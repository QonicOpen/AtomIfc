
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
    public class IfcRecurrencePattern : IfcBase, IEquatable<IfcRecurrencePattern>
    {
        private IfcRecurrenceTypeEnum _recurrenceType;
        public IfcRecurrenceTypeEnum RecurrenceType 
        {
            get { 
                return _recurrenceType; 
            }
            set { 
                _recurrenceType = value;
            }
        }
        private List<int> _dayComponent;
        public List<int> DayComponent 
        {
            get { 
                return _dayComponent; 
            }
            set { 
                _dayComponent = value;  // optional List<IfcDayInMonthNumber>
            }
        }
        private List<int> _weekdayComponent;
        public List<int> WeekdayComponent 
        {
            get { 
                return _weekdayComponent; 
            }
            set { 
                _weekdayComponent = value;  // optional List<IfcDayInWeekNumber>
            }
        }
        private List<int> _monthComponent;
        public List<int> MonthComponent 
        {
            get { 
                return _monthComponent; 
            }
            set { 
                _monthComponent = value;  // optional List<IfcMonthInYearNumber>
            }
        }
        private int? _position;
        public int? Position 
        {
            get { 
                return _position; 
            }
            set { 
                _position = value;  // optional IfcInteger
            }
        }
        private int? _interval;
        public int? Interval 
        {
            get { 
                return _interval; 
            }
            set { 
                _interval = value;  // optional IfcInteger
            }
        }
        private int? _occurrences;
        public int? Occurrences 
        {
            get { 
                return _occurrences; 
            }
            set { 
                _occurrences = value;  // optional IfcInteger
            }
        }
        private List<IfcId> _timePeriodIds;
        public List<IfcId> TimePeriodIds 
        {
            get { 
                return _timePeriodIds; 
            }
            set { 
                _timePeriodIds = value;  // optional List<IfcTimePeriod>
            }
        }

        public IfcRecurrencePattern(IfcId id, IfcRecurrenceTypeEnum recurrenceType, List<int> dayComponent, List<int> weekdayComponent, List<int> monthComponent, int? position, int? interval, int? occurrences, List<IfcId> timePeriodIds) : base(id)
        {
            RecurrenceType = recurrenceType;
            DayComponent = dayComponent;
            WeekdayComponent = weekdayComponent;
            MonthComponent = monthComponent;
            Position = position;
            Interval = interval;
            Occurrences = occurrences;
            TimePeriodIds = timePeriodIds;
        }

        public override ClassId GetClassId() => ClassId.IfcRecurrencePattern;

        #region Equality

        public bool Equals(IfcRecurrencePattern other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(DayComponent, other.DayComponent))
                return false;
            if(!Utils.CompareList(WeekdayComponent, other.WeekdayComponent))
                return false;
            if(!Utils.CompareList(MonthComponent, other.MonthComponent))
                return false;
            if(!Utils.CompareList(TimePeriodIds, other.TimePeriodIds))
                return false;
            return base.Equals(other)
                && RecurrenceType == other.RecurrenceType
                && Position == other.Position
                && Interval == other.Interval
                && Occurrences == other.Occurrences;
        }

        public override bool Equals(object other) => Equals(other as IfcRecurrencePattern);

        public static bool operator ==(IfcRecurrencePattern one, IfcRecurrencePattern other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRecurrencePattern one, IfcRecurrencePattern other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{RecurrenceType}.,{Utils.ConvertListToString(DayComponent)},{Utils.ConvertListToString(WeekdayComponent)},{Utils.ConvertListToString(MonthComponent)},{Position},{Interval},{Occurrences},{Utils.ConvertListToString(TimePeriodIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TimePeriodIds!= null)
                TimePeriodIds = TimePeriodIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRecurrencePattern (newId,RecurrenceType, DayComponent, WeekdayComponent, MonthComponent, Position, Interval, Occurrences, TimePeriodIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRecurrencePattern },
                { "class", nameof(IfcRecurrencePattern) },
                { "parameters" , new JArray
                    {
                        RecurrenceType.ToJValue(),
                        DayComponent.ToJArray(),
                        WeekdayComponent.ToJArray(),
                        MonthComponent.ToJArray(),
                        Position.ToJValue(),
                        Interval.ToJValue(),
                        Occurrences.ToJValue(),
                        TimePeriodIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcRecurrencePattern CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRecurrencePattern(
                jObject["id"].ToIfcId(),
                (IfcRecurrenceTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcRecurrenceTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalIntList(),
                parameters[2].ToOptionalIntList(),
                parameters[3].ToOptionalIntList(),
                parameters[4].ToOptionalInt(),
                parameters[5].ToOptionalInt(),
                parameters[6].ToOptionalInt(),
                parameters[7].ToOptionalIfcIdList());
        }
        #endregion

    }
}