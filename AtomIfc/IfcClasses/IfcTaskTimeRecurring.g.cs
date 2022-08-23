
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
    public class IfcTaskTimeRecurring : IfcTaskTime, IEquatable<IfcTaskTimeRecurring>
    {
        private IfcId _recurranceId;
        public IfcId RecurranceId 
        {
            get { 
                return _recurranceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RecurranceId is not allowed to be null"); 
                _recurranceId = value;
            }
        }

        public IfcTaskTimeRecurring(IfcId id, string name, IfcDataOriginEnum dataOrigin, string userDefinedDataOrigin, IfcTaskDurationEnum durationType, string scheduleDuration, string scheduleStart, string scheduleFinish, string earlyStart, string earlyFinish, string lateStart, string lateFinish, string freeFloat, string totalFloat, bool? isCritical, string statusTime, string actualDuration, string actualStart, string actualFinish, string remainingTime, double? completion, IfcId recurranceId) : base(id, name, dataOrigin, userDefinedDataOrigin, durationType, scheduleDuration, scheduleStart, scheduleFinish, earlyStart, earlyFinish, lateStart, lateFinish, freeFloat, totalFloat, isCritical, statusTime, actualDuration, actualStart, actualFinish, remainingTime, completion)
        {
            RecurranceId = recurranceId;
        }

        public override ClassId GetClassId() => ClassId.IfcTaskTimeRecurring;

        #region Equality

        public bool Equals(IfcTaskTimeRecurring other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RecurranceId == other.RecurranceId;
        }

        public override bool Equals(object other) => Equals(other as IfcTaskTimeRecurring);

        public static bool operator ==(IfcTaskTimeRecurring one, IfcTaskTimeRecurring other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTaskTimeRecurring one, IfcTaskTimeRecurring other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',.{DataOrigin}.,'{UserDefinedDataOrigin}',.{DurationType}.,'{ScheduleDuration}','{ScheduleStart}','{ScheduleFinish}','{EarlyStart}','{EarlyFinish}','{LateStart}','{LateFinish}','{FreeFloat}','{TotalFloat}',{(IsCritical == null? ".U." : IsCritical)},'{StatusTime}','{ActualDuration}','{ActualStart}','{ActualFinish}','{RemainingTime}',{Completion},{RecurranceId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RecurranceId!= null && replacementTable.ContainsKey(RecurranceId))
                RecurranceId = replacementTable[RecurranceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTaskTimeRecurring (newId,Name, DataOrigin, UserDefinedDataOrigin, DurationType, ScheduleDuration, ScheduleStart, ScheduleFinish, EarlyStart, EarlyFinish, LateStart, LateFinish, FreeFloat, TotalFloat, IsCritical, StatusTime, ActualDuration, ActualStart, ActualFinish, RemainingTime, Completion, RecurranceId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTaskTimeRecurring },
                { "class", nameof(IfcTaskTimeRecurring) },
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
                        RecurranceId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcTaskTimeRecurring CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTaskTimeRecurring(
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
                parameters[19].ToOptionalDouble(),
                parameters[20].ToIfcId());
        }
        #endregion

    }
}