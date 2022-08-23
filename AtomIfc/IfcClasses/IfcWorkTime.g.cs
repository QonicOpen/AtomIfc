
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
    public class IfcWorkTime : IfcSchedulingTime, IEquatable<IfcWorkTime>
    {
        private IfcId _recurrencePatternId;
        public IfcId RecurrencePatternId 
        {
            get { 
                return _recurrencePatternId; 
            }
            set { 
                _recurrencePatternId = value;  // optional IfcRecurrencePattern
            }
        }
        private string _start;
        public string Start 
        {
            get { 
                return _start; 
            }
            set { 
                _start = value;  // optional IfcDate
            }
        }
        private string _finish;
        public string Finish 
        {
            get { 
                return _finish; 
            }
            set { 
                _finish = value;  // optional IfcDate
            }
        }

        public IfcWorkTime(IfcId id, string name, IfcDataOriginEnum dataOrigin, string userDefinedDataOrigin, IfcId recurrencePatternId, string start, string finish) : base(id, name, dataOrigin, userDefinedDataOrigin)
        {
            RecurrencePatternId = recurrencePatternId;
            Start = start;
            Finish = finish;
        }

        public override ClassId GetClassId() => ClassId.IfcWorkTime;

        #region Equality

        public bool Equals(IfcWorkTime other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RecurrencePatternId == other.RecurrencePatternId
                && Start == other.Start
                && Finish == other.Finish;
        }

        public override bool Equals(object other) => Equals(other as IfcWorkTime);

        public static bool operator ==(IfcWorkTime one, IfcWorkTime other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcWorkTime one, IfcWorkTime other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',.{DataOrigin}.,'{UserDefinedDataOrigin}',{RecurrencePatternId},'{Start}','{Finish}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RecurrencePatternId!= null && replacementTable.ContainsKey(RecurrencePatternId))
                RecurrencePatternId = replacementTable[RecurrencePatternId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcWorkTime (newId,Name, DataOrigin, UserDefinedDataOrigin, RecurrencePatternId, Start, Finish);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcWorkTime },
                { "class", nameof(IfcWorkTime) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        DataOrigin.ToJValue(),
                        UserDefinedDataOrigin.ToJValue(),
                        RecurrencePatternId.ToJValue(),
                        Start.ToJValue(),
                        Finish.ToJValue(),
                    }
                }
            };
        }

        public static IfcWorkTime CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcWorkTime(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                (IfcDataOriginEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDataOriginEnum](parameters[1].ToString()),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString());
        }
        #endregion

    }
}