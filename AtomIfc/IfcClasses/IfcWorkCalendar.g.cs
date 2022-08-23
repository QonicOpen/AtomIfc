
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
    public class IfcWorkCalendar : IfcControl, IEquatable<IfcWorkCalendar>
    {
        private List<IfcId> _workingTimeIds;
        public List<IfcId> WorkingTimeIds 
        {
            get { 
                return _workingTimeIds; 
            }
            set { 
                _workingTimeIds = value;  // optional List<IfcWorkTime>
            }
        }
        private List<IfcId> _exceptionTimeIds;
        public List<IfcId> ExceptionTimeIds 
        {
            get { 
                return _exceptionTimeIds; 
            }
            set { 
                _exceptionTimeIds = value;  // optional List<IfcWorkTime>
            }
        }
        private IfcWorkCalendarTypeEnum _predefinedType;
        public IfcWorkCalendarTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcWorkCalendarTypeEnum?
            }
        }

        public IfcWorkCalendar(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, List<IfcId> workingTimeIds, List<IfcId> exceptionTimeIds, IfcWorkCalendarTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, identification)
        {
            WorkingTimeIds = workingTimeIds;
            ExceptionTimeIds = exceptionTimeIds;
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcWorkCalendar;

        #region Equality

        public bool Equals(IfcWorkCalendar other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(WorkingTimeIds, other.WorkingTimeIds))
                return false;
            if(!Utils.CompareList(ExceptionTimeIds, other.ExceptionTimeIds))
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcWorkCalendar);

        public static bool operator ==(IfcWorkCalendar one, IfcWorkCalendar other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcWorkCalendar one, IfcWorkCalendar other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{Identification}',{Utils.ConvertListToString(WorkingTimeIds)},{Utils.ConvertListToString(ExceptionTimeIds)},.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(WorkingTimeIds!= null)
                WorkingTimeIds = WorkingTimeIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(ExceptionTimeIds!= null)
                ExceptionTimeIds = ExceptionTimeIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcWorkCalendar (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, Identification, WorkingTimeIds, ExceptionTimeIds, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcWorkCalendar },
                { "class", nameof(IfcWorkCalendar) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        Identification.ToJValue(),
                        WorkingTimeIds.ToJArray(),
                        ExceptionTimeIds.ToJArray(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcWorkCalendar CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcWorkCalendar(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalIfcIdList(),
                parameters[7].ToOptionalIfcIdList(),
                (IfcWorkCalendarTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcWorkCalendarTypeEnum](parameters[8].ToString()));
        }
        #endregion

    }
}