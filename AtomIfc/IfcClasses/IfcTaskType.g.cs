
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
    public class IfcTaskType : IfcTypeProcess, IEquatable<IfcTaskType>
    {
        private IfcTaskTypeEnum _predefinedType;
        public IfcTaskTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
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

        public IfcTaskType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, string identification, string longDescription, string processType, IfcTaskTypeEnum predefinedType, string workMethod) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, identification, longDescription, processType)
        {
            PredefinedType = predefinedType;
            WorkMethod = workMethod;
        }

        public override ClassId GetClassId() => ClassId.IfcTaskType;

        #region Equality

        public bool Equals(IfcTaskType other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && WorkMethod == other.WorkMethod;
        }

        public override bool Equals(object other) => Equals(other as IfcTaskType);

        public static bool operator ==(IfcTaskType one, IfcTaskType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTaskType one, IfcTaskType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},'{Identification}','{LongDescription}','{ProcessType}',.{PredefinedType}.,'{WorkMethod}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTaskType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, Identification, LongDescription, ProcessType, PredefinedType, WorkMethod);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTaskType },
                { "class", nameof(IfcTaskType) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ApplicableOccurrence.ToJValue(),
                        PropertySetIds.ToJArray(),
                        Identification.ToJValue(),
                        LongDescription.ToJValue(),
                        ProcessType.ToJValue(),
                        PredefinedType.ToJValue(),
                        WorkMethod.ToJValue(),
                    }
                }
            };
        }

        public static new IfcTaskType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTaskType(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcIdList(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString(),
                (IfcTaskTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcTaskTypeEnum](parameters[9].ToString()),
                parameters[10].ToOptionalString());
        }
        #endregion

    }
}