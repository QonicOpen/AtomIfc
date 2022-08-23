
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
    public class IfcTaskTime : IfcSchedulingTime, IEquatable<IfcTaskTime>
    {
        private IfcTaskDurationEnum _durationType;
        public IfcTaskDurationEnum DurationType 
        {
            get { 
                return _durationType; 
            }
            set { 
                _durationType = value;  // optional IfcTaskDurationEnum?
            }
        }
        private string _scheduleDuration;
        public string ScheduleDuration 
        {
            get { 
                return _scheduleDuration; 
            }
            set { 
                _scheduleDuration = value;  // optional IfcDuration
            }
        }
        private string _scheduleStart;
        public string ScheduleStart 
        {
            get { 
                return _scheduleStart; 
            }
            set { 
                _scheduleStart = value;  // optional IfcDateTime
            }
        }
        private string _scheduleFinish;
        public string ScheduleFinish 
        {
            get { 
                return _scheduleFinish; 
            }
            set { 
                _scheduleFinish = value;  // optional IfcDateTime
            }
        }
        private string _earlyStart;
        public string EarlyStart 
        {
            get { 
                return _earlyStart; 
            }
            set { 
                _earlyStart = value;  // optional IfcDateTime
            }
        }
        private string _earlyFinish;
        public string EarlyFinish 
        {
            get { 
                return _earlyFinish; 
            }
            set { 
                _earlyFinish = value;  // optional IfcDateTime
            }
        }
        private string _lateStart;
        public string LateStart 
        {
            get { 
                return _lateStart; 
            }
            set { 
                _lateStart = value;  // optional IfcDateTime
            }
        }
        private string _lateFinish;
        public string LateFinish 
        {
            get { 
                return _lateFinish; 
            }
            set { 
                _lateFinish = value;  // optional IfcDateTime
            }
        }
        private string _freeFloat;
        public string FreeFloat 
        {
            get { 
                return _freeFloat; 
            }
            set { 
                _freeFloat = value;  // optional IfcDuration
            }
        }
        private string _totalFloat;
        public string TotalFloat 
        {
            get { 
                return _totalFloat; 
            }
            set { 
                _totalFloat = value;  // optional IfcDuration
            }
        }
        private bool? _isCritical;
        public bool? IsCritical 
        {
            get { 
                return _isCritical; 
            }
            set { 
                _isCritical = value;  // optional bool
            }
        }
        private string _statusTime;
        public string StatusTime 
        {
            get { 
                return _statusTime; 
            }
            set { 
                _statusTime = value;  // optional IfcDateTime
            }
        }
        private string _actualDuration;
        public string ActualDuration 
        {
            get { 
                return _actualDuration; 
            }
            set { 
                _actualDuration = value;  // optional IfcDuration
            }
        }
        private string _actualStart;
        public string ActualStart 
        {
            get { 
                return _actualStart; 
            }
            set { 
                _actualStart = value;  // optional IfcDateTime
            }
        }
        private string _actualFinish;
        public string ActualFinish 
        {
            get { 
                return _actualFinish; 
            }
            set { 
                _actualFinish = value;  // optional IfcDateTime
            }
        }
        private string _remainingTime;
        public string RemainingTime 
        {
            get { 
                return _remainingTime; 
            }
            set { 
                _remainingTime = value;  // optional IfcDuration
            }
        }
        private double? _completion;
        public double? Completion 
        {
            get { 
                return _completion; 
            }
            set { 
                _completion = value;  // optional IfcPositiveRatioMeasure
            }
        }

        public IfcTaskTime(IfcId id, string name, IfcDataOriginEnum dataOrigin, string userDefinedDataOrigin, IfcTaskDurationEnum durationType, string scheduleDuration, string scheduleStart, string scheduleFinish, string earlyStart, string earlyFinish, string lateStart, string lateFinish, string freeFloat, string totalFloat, bool? isCritical, string statusTime, string actualDuration, string actualStart, string actualFinish, string remainingTime, double? completion) : base(id, name, dataOrigin, userDefinedDataOrigin)
        {
            DurationType = durationType;
            ScheduleDuration = scheduleDuration;
            ScheduleStart = scheduleStart;
            ScheduleFinish = scheduleFinish;
            EarlyStart = earlyStart;
            EarlyFinish = earlyFinish;
            LateStart = lateStart;
            LateFinish = lateFinish;
            FreeFloat = freeFloat;
            TotalFloat = totalFloat;
            IsCritical = isCritical;
            StatusTime = statusTime;
            ActualDuration = actualDuration;
            ActualStart = actualStart;
            ActualFinish = actualFinish;
            RemainingTime = remainingTime;
            Completion = completion;
        }

        public override ClassId GetClassId() => ClassId.IfcTaskTime;

        #region Equality

        public bool Equals(IfcTaskTime other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && DurationType == other.DurationType
                && ScheduleDuration == other.ScheduleDuration
                && ScheduleStart == other.ScheduleStart
                && ScheduleFinish == other.ScheduleFinish
                && EarlyStart == other.EarlyStart
                && EarlyFinish == other.EarlyFinish
                && LateStart == other.LateStart
                && LateFinish == other.LateFinish
                && FreeFloat == other.FreeFloat
                && TotalFloat == other.TotalFloat
                && IsCritical == other.IsCritical
                && StatusTime == other.StatusTime
                && ActualDuration == other.ActualDuration
                && ActualStart == other.ActualStart
                && ActualFinish == other.ActualFinish
                && RemainingTime == other.RemainingTime
                && Completion == other.Completion;
        }

        public override bool Equals(object other) => Equals(other as IfcTaskTime);

        public static bool operator ==(IfcTaskTime one, IfcTaskTime other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTaskTime one, IfcTaskTime other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',.{DataOrigin}.,'{UserDefinedDataOrigin}',.{DurationType}.,'{ScheduleDuration}','{ScheduleStart}','{ScheduleFinish}','{EarlyStart}','{EarlyFinish}','{LateStart}','{LateFinish}','{FreeFloat}','{TotalFloat}',{(IsCritical == null? ".U." : IsCritical)},'{StatusTime}','{ActualDuration}','{ActualStart}','{ActualFinish}','{RemainingTime}',{Completion})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTaskTime (newId,Name, DataOrigin, UserDefinedDataOrigin, DurationType, ScheduleDuration, ScheduleStart, ScheduleFinish, EarlyStart, EarlyFinish, LateStart, LateFinish, FreeFloat, TotalFloat, IsCritical, StatusTime, ActualDuration, ActualStart, ActualFinish, RemainingTime, Completion);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTaskTime },
                { "class", nameof(IfcTaskTime) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        DataOrigin.ToJValue(),
                        UserDefinedDataOrigin.ToJValue(),
                        DurationType.ToJValue(),
                        ScheduleDuration.ToJValue(),
                        ScheduleStart.ToJValue(),
                        ScheduleFinish.ToJValue(),
                        EarlyStart.ToJValue(),
                        EarlyFinish.ToJValue(),
                        LateStart.ToJValue(),
                        LateFinish.ToJValue(),
                        FreeFloat.ToJValue(),
                        TotalFloat.ToJValue(),
                        IsCritical.ToJValue(),
                        StatusTime.ToJValue(),
                        ActualDuration.ToJValue(),
                        ActualStart.ToJValue(),
                        ActualFinish.ToJValue(),
                        RemainingTime.ToJValue(),
                        Completion.ToJValue(),
                    }
                }
            };
        }

        public static IfcTaskTime CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTaskTime(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                (IfcDataOriginEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDataOriginEnum](parameters[1].ToString()),
                parameters[2].ToOptionalString(),
                (IfcTaskDurationEnum)IfcAtom.EnumCreator[(int)EnumId.IfcTaskDurationEnum](parameters[3].ToString()),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString(),
                parameters[9].ToOptionalString(),
                parameters[10].ToOptionalString(),
                parameters[11].ToOptionalString(),
                parameters[12].ToOptionalString(),
                parameters[13].ToOptionalBool(),
                parameters[14].ToOptionalString(),
                parameters[15].ToOptionalString(),
                parameters[16].ToOptionalString(),
                parameters[17].ToOptionalString(),
                parameters[18].ToOptionalString(),
                parameters[19].ToOptionalDouble());
        }
        #endregion

    }
}