
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
    public class IfcTask : IfcProcess, IEquatable<IfcTask>
    {
        private string _status;
        public string Status 
        {
            get { 
                return _status; 
            }
            set { 
                _status = value;  // optional IfcLabel
            }
        }
        private string _workMethod;
        public string WorkMethod 
        {
            get { 
                return _workMethod; 
            }
            set { 
                _workMethod = value;  // optional IfcLabel
            }
        }
        private bool _isMilestone;
        public bool IsMilestone 
        {
            get { 
                return _isMilestone; 
            }
            set { 
                _isMilestone = value;
            }
        }
        private int? _priority;
        public int? Priority 
        {
            get { 
                return _priority; 
            }
            set { 
                _priority = value;  // optional int?
            }
        }
        private IfcId _taskTimeId;
        public IfcId TaskTimeId 
        {
            get { 
                return _taskTimeId; 
            }
            set { 
                _taskTimeId = value;  // optional IfcTaskTime
            }
        }
        private IfcTaskTypeEnum _predefinedType;
        public IfcTaskTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcTaskTypeEnum?
            }
        }

        public IfcTask(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, string longDescription, string status, string workMethod, bool isMilestone, int? priority, IfcId taskTimeId, IfcTaskTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, identification, longDescription)
        {
            Status = status;
            WorkMethod = workMethod;
            IsMilestone = isMilestone;
            Priority = priority;
            TaskTimeId = taskTimeId;
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcTask;

        #region Equality

        public bool Equals(IfcTask other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Status == other.Status
                && WorkMethod == other.WorkMethod
                && IsMilestone == other.IsMilestone
                && Priority == other.Priority
                && TaskTimeId == other.TaskTimeId
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcTask);

        public static bool operator ==(IfcTask one, IfcTask other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTask one, IfcTask other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{Identification}','{LongDescription}','{Status}','{WorkMethod}',{IsMilestone},{Priority},{TaskTimeId},.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TaskTimeId!= null && replacementTable.ContainsKey(TaskTimeId))
                TaskTimeId = replacementTable[TaskTimeId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTask (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, Identification, LongDescription, Status, WorkMethod, IsMilestone, Priority, TaskTimeId, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTask },
                { "class", nameof(IfcTask) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        Identification.ToJValue(),
                        LongDescription.ToJValue(),
                        Status.ToJValue(),
                        WorkMethod.ToJValue(),
                        IsMilestone,
                        Priority.ToJValue(),
                        TaskTimeId.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcTask CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTask(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString(),
                parameters[9].ToBool(),
                parameters[10].ToOptionalInt(),
                parameters[11].ToOptionalIfcId(),
                (IfcTaskTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcTaskTypeEnum](parameters[12].ToString()));
        }
        #endregion

    }
}