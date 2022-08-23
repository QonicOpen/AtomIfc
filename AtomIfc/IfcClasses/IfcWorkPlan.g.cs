
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
    public class IfcWorkPlan : IfcWorkControl, IEquatable<IfcWorkPlan>
    {
        private IfcWorkPlanTypeEnum _predefinedType;
        public IfcWorkPlanTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcWorkPlanTypeEnum?
            }
        }

        public IfcWorkPlan(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, string creationDate, List<IfcId> creatorIds, string purpose, string duration, string totalFloat, string startTime, string finishTime, IfcWorkPlanTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, identification, creationDate, creatorIds, purpose, duration, totalFloat, startTime, finishTime)
        {
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcWorkPlan;

        #region Equality

        public bool Equals(IfcWorkPlan other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcWorkPlan);

        public static bool operator ==(IfcWorkPlan one, IfcWorkPlan other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcWorkPlan one, IfcWorkPlan other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{Identification}','{CreationDate}',{Utils.ConvertListToString(CreatorIds)},'{Purpose}','{Duration}','{TotalFloat}','{StartTime}','{FinishTime}',.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcWorkPlan (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, Identification, CreationDate, CreatorIds, Purpose, Duration, TotalFloat, StartTime, FinishTime, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcWorkPlan },
                { "class", nameof(IfcWorkPlan) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        Identification.ToJValue(),
                        CreationDate.ToJValue(),
                        CreatorIds.ToJArray(),
                        Purpose.ToJValue(),
                        Duration.ToJValue(),
                        TotalFloat.ToJValue(),
                        StartTime.ToJValue(),
                        FinishTime.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcWorkPlan CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcWorkPlan(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToString(),
                parameters[7].ToOptionalIfcIdList(),
                parameters[8].ToOptionalString(),
                parameters[9].ToOptionalString(),
                parameters[10].ToOptionalString(),
                parameters[11].ToString(),
                parameters[12].ToOptionalString(),
                (IfcWorkPlanTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcWorkPlanTypeEnum](parameters[13].ToString()));
        }
        #endregion

    }
}