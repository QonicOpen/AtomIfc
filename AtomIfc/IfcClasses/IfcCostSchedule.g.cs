
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
    public class IfcCostSchedule : IfcControl, IEquatable<IfcCostSchedule>
    {
        private IfcCostScheduleTypeEnum _predefinedType;
        public IfcCostScheduleTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcCostScheduleTypeEnum?
            }
        }
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
        private string _submittedOn;
        public string SubmittedOn 
        {
            get { 
                return _submittedOn; 
            }
            set { 
                _submittedOn = value;  // optional IfcDateTime
            }
        }
        private string _updateDate;
        public string UpdateDate 
        {
            get { 
                return _updateDate; 
            }
            set { 
                _updateDate = value;  // optional IfcDateTime
            }
        }

        public IfcCostSchedule(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, IfcCostScheduleTypeEnum predefinedType, string status, string submittedOn, string updateDate) : base(id, globalId, ownerHistoryId, name, description, objectType, identification)
        {
            PredefinedType = predefinedType;
            Status = status;
            SubmittedOn = submittedOn;
            UpdateDate = updateDate;
        }

        public override ClassId GetClassId() => ClassId.IfcCostSchedule;

        #region Equality

        public bool Equals(IfcCostSchedule other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && Status == other.Status
                && SubmittedOn == other.SubmittedOn
                && UpdateDate == other.UpdateDate;
        }

        public override bool Equals(object other) => Equals(other as IfcCostSchedule);

        public static bool operator ==(IfcCostSchedule one, IfcCostSchedule other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCostSchedule one, IfcCostSchedule other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{Identification}',.{PredefinedType}.,'{Status}','{SubmittedOn}','{UpdateDate}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCostSchedule (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, Identification, PredefinedType, Status, SubmittedOn, UpdateDate);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCostSchedule },
                { "class", nameof(IfcCostSchedule) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        Identification.ToJValue(),
                        PredefinedType.ToJValue(),
                        Status.ToJValue(),
                        SubmittedOn.ToJValue(),
                        UpdateDate.ToJValue(),
                    }
                }
            };
        }

        public static IfcCostSchedule CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCostSchedule(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                (IfcCostScheduleTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcCostScheduleTypeEnum](parameters[6].ToString()),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString(),
                parameters[9].ToOptionalString());
        }
        #endregion

    }
}