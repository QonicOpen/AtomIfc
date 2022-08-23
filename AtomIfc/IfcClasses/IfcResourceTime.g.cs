
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
    public class IfcResourceTime : IfcSchedulingTime, IEquatable<IfcResourceTime>
    {
        private string _scheduleWork;
        public string ScheduleWork 
        {
            get { 
                return _scheduleWork; 
            }
            set { 
                _scheduleWork = value;  // optional IfcDuration
            }
        }
        private double? _scheduleUsage;
        public double? ScheduleUsage 
        {
            get { 
                return _scheduleUsage; 
            }
            set { 
                _scheduleUsage = value;  // optional IfcPositiveRatioMeasure
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
        private string _scheduleContour;
        public string ScheduleContour 
        {
            get { 
                return _scheduleContour; 
            }
            set { 
                _scheduleContour = value;  // optional IfcLabel
            }
        }
        private string _levelingDelay;
        public string LevelingDelay 
        {
            get { 
                return _levelingDelay; 
            }
            set { 
                _levelingDelay = value;  // optional IfcDuration
            }
        }
        private bool? _isOverAllocated;
        public bool? IsOverAllocated 
        {
            get { 
                return _isOverAllocated; 
            }
            set { 
                _isOverAllocated = value;  // optional bool
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
        private string _actualWork;
        public string ActualWork 
        {
            get { 
                return _actualWork; 
            }
            set { 
                _actualWork = value;  // optional IfcDuration
            }
        }
        private double? _actualUsage;
        public double? ActualUsage 
        {
            get { 
                return _actualUsage; 
            }
            set { 
                _actualUsage = value;  // optional IfcPositiveRatioMeasure
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
        private string _remainingWork;
        public string RemainingWork 
        {
            get { 
                return _remainingWork; 
            }
            set { 
                _remainingWork = value;  // optional IfcDuration
            }
        }
        private double? _remainingUsage;
        public double? RemainingUsage 
        {
            get { 
                return _remainingUsage; 
            }
            set { 
                _remainingUsage = value;  // optional IfcPositiveRatioMeasure
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

        public IfcResourceTime(IfcId id, string name, IfcDataOriginEnum dataOrigin, string userDefinedDataOrigin, string scheduleWork, double? scheduleUsage, string scheduleStart, string scheduleFinish, string scheduleContour, string levelingDelay, bool? isOverAllocated, string statusTime, string actualWork, double? actualUsage, string actualStart, string actualFinish, string remainingWork, double? remainingUsage, double? completion) : base(id, name, dataOrigin, userDefinedDataOrigin)
        {
            ScheduleWork = scheduleWork;
            ScheduleUsage = scheduleUsage;
            ScheduleStart = scheduleStart;
            ScheduleFinish = scheduleFinish;
            ScheduleContour = scheduleContour;
            LevelingDelay = levelingDelay;
            IsOverAllocated = isOverAllocated;
            StatusTime = statusTime;
            ActualWork = actualWork;
            ActualUsage = actualUsage;
            ActualStart = actualStart;
            ActualFinish = actualFinish;
            RemainingWork = remainingWork;
            RemainingUsage = remainingUsage;
            Completion = completion;
        }

        public override ClassId GetClassId() => ClassId.IfcResourceTime;

        #region Equality

        public bool Equals(IfcResourceTime other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ScheduleWork == other.ScheduleWork
                && ScheduleUsage == other.ScheduleUsage
                && ScheduleStart == other.ScheduleStart
                && ScheduleFinish == other.ScheduleFinish
                && ScheduleContour == other.ScheduleContour
                && LevelingDelay == other.LevelingDelay
                && IsOverAllocated == other.IsOverAllocated
                && StatusTime == other.StatusTime
                && ActualWork == other.ActualWork
                && ActualUsage == other.ActualUsage
                && ActualStart == other.ActualStart
                && ActualFinish == other.ActualFinish
                && RemainingWork == other.RemainingWork
                && RemainingUsage == other.RemainingUsage
                && Completion == other.Completion;
        }

        public override bool Equals(object other) => Equals(other as IfcResourceTime);

        public static bool operator ==(IfcResourceTime one, IfcResourceTime other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcResourceTime one, IfcResourceTime other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',.{DataOrigin}.,'{UserDefinedDataOrigin}','{ScheduleWork}',{ScheduleUsage},'{ScheduleStart}','{ScheduleFinish}','{ScheduleContour}','{LevelingDelay}',{(IsOverAllocated == null? ".U." : IsOverAllocated)},'{StatusTime}','{ActualWork}',{ActualUsage},'{ActualStart}','{ActualFinish}','{RemainingWork}',{RemainingUsage},{Completion})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcResourceTime (newId,Name, DataOrigin, UserDefinedDataOrigin, ScheduleWork, ScheduleUsage, ScheduleStart, ScheduleFinish, ScheduleContour, LevelingDelay, IsOverAllocated, StatusTime, ActualWork, ActualUsage, ActualStart, ActualFinish, RemainingWork, RemainingUsage, Completion);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcResourceTime },
                { "class", nameof(IfcResourceTime) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        DataOrigin.ToJValue(),
                        UserDefinedDataOrigin.ToJValue(),
                        ScheduleWork.ToJValue(),
                        ScheduleUsage.ToJValue(),
                        ScheduleStart.ToJValue(),
                        ScheduleFinish.ToJValue(),
                        ScheduleContour.ToJValue(),
                        LevelingDelay.ToJValue(),
                        IsOverAllocated.ToJValue(),
                        StatusTime.ToJValue(),
                        ActualWork.ToJValue(),
                        ActualUsage.ToJValue(),
                        ActualStart.ToJValue(),
                        ActualFinish.ToJValue(),
                        RemainingWork.ToJValue(),
                        RemainingUsage.ToJValue(),
                        Completion.ToJValue(),
                    }
                }
            };
        }

        public static IfcResourceTime CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcResourceTime(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                (IfcDataOriginEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDataOriginEnum](parameters[1].ToString()),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString(),
                parameters[9].ToOptionalBool(),
                parameters[10].ToOptionalString(),
                parameters[11].ToOptionalString(),
                parameters[12].ToOptionalDouble(),
                parameters[13].ToOptionalString(),
                parameters[14].ToOptionalString(),
                parameters[15].ToOptionalString(),
                parameters[16].ToOptionalDouble(),
                parameters[17].ToOptionalDouble());
        }
        #endregion

    }
}