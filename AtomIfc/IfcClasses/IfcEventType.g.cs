
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
    public class IfcEventType : IfcTypeProcess, IEquatable<IfcEventType>
    {
        private IfcEventTypeEnum _predefinedType;
        public IfcEventTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }
        private IfcEventTriggerTypeEnum _eventTriggerType;
        public IfcEventTriggerTypeEnum EventTriggerType 
        {
            get { 
                return _eventTriggerType; 
            }
            set { 
                _eventTriggerType = value;
            }
        }
        private string _userDefinedEventTriggerType;
        public string UserDefinedEventTriggerType 
        {
            get { 
                return _userDefinedEventTriggerType; 
            }
            set { 
                _userDefinedEventTriggerType = value;  // optional IfcLabel
            }
        }

        public IfcEventType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, string identification, string longDescription, string processType, IfcEventTypeEnum predefinedType, IfcEventTriggerTypeEnum eventTriggerType, string userDefinedEventTriggerType) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, identification, longDescription, processType)
        {
            PredefinedType = predefinedType;
            EventTriggerType = eventTriggerType;
            UserDefinedEventTriggerType = userDefinedEventTriggerType;
        }

        public override ClassId GetClassId() => ClassId.IfcEventType;

        #region Equality

        public bool Equals(IfcEventType other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && EventTriggerType == other.EventTriggerType
                && UserDefinedEventTriggerType == other.UserDefinedEventTriggerType;
        }

        public override bool Equals(object other) => Equals(other as IfcEventType);

        public static bool operator ==(IfcEventType one, IfcEventType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcEventType one, IfcEventType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},'{Identification}','{LongDescription}','{ProcessType}',.{PredefinedType}.,.{EventTriggerType}.,'{UserDefinedEventTriggerType}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcEventType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, Identification, LongDescription, ProcessType, PredefinedType, EventTriggerType, UserDefinedEventTriggerType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcEventType },
                { "class", nameof(IfcEventType) },
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
                        EventTriggerType.ToJValue(),
                        UserDefinedEventTriggerType.ToJValue(),
                    }
                }
            };
        }

        public static new IfcEventType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcEventType(
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
                (IfcEventTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcEventTypeEnum](parameters[9].ToString()),
                (IfcEventTriggerTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcEventTriggerTypeEnum](parameters[10].ToString()),
                parameters[11].ToOptionalString());
        }
        #endregion

    }
}