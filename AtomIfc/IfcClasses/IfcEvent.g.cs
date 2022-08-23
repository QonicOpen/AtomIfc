
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
    public class IfcEvent : IfcProcess, IEquatable<IfcEvent>
    {
        private IfcEventTypeEnum _predefinedType;
        public IfcEventTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcEventTypeEnum?
            }
        }
        private IfcEventTriggerTypeEnum _eventTriggerType;
        public IfcEventTriggerTypeEnum EventTriggerType 
        {
            get { 
                return _eventTriggerType; 
            }
            set { 
                _eventTriggerType = value;  // optional IfcEventTriggerTypeEnum?
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
        private IfcId _eventOccurenceTimeId;
        public IfcId EventOccurenceTimeId 
        {
            get { 
                return _eventOccurenceTimeId; 
            }
            set { 
                _eventOccurenceTimeId = value;  // optional IfcEventTime
            }
        }

        public IfcEvent(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, string longDescription, IfcEventTypeEnum predefinedType, IfcEventTriggerTypeEnum eventTriggerType, string userDefinedEventTriggerType, IfcId eventOccurenceTimeId) : base(id, globalId, ownerHistoryId, name, description, objectType, identification, longDescription)
        {
            PredefinedType = predefinedType;
            EventTriggerType = eventTriggerType;
            UserDefinedEventTriggerType = userDefinedEventTriggerType;
            EventOccurenceTimeId = eventOccurenceTimeId;
        }

        public override ClassId GetClassId() => ClassId.IfcEvent;

        #region Equality

        public bool Equals(IfcEvent other)
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
                && UserDefinedEventTriggerType == other.UserDefinedEventTriggerType
                && EventOccurenceTimeId == other.EventOccurenceTimeId;
        }

        public override bool Equals(object other) => Equals(other as IfcEvent);

        public static bool operator ==(IfcEvent one, IfcEvent other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcEvent one, IfcEvent other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{Identification}','{LongDescription}',.{PredefinedType}.,.{EventTriggerType}.,'{UserDefinedEventTriggerType}',{EventOccurenceTimeId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EventOccurenceTimeId!= null && replacementTable.ContainsKey(EventOccurenceTimeId))
                EventOccurenceTimeId = replacementTable[EventOccurenceTimeId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcEvent (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, Identification, LongDescription, PredefinedType, EventTriggerType, UserDefinedEventTriggerType, EventOccurenceTimeId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcEvent },
                { "class", nameof(IfcEvent) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        Identification.ToJValue(),
                        LongDescription.ToJValue(),
                        PredefinedType.ToJValue(),
                        EventTriggerType.ToJValue(),
                        UserDefinedEventTriggerType.ToJValue(),
                        EventOccurenceTimeId.ToJValue(),
                    }
                }
            };
        }

        public static IfcEvent CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcEvent(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                (IfcEventTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcEventTypeEnum](parameters[7].ToString()),
                (IfcEventTriggerTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcEventTriggerTypeEnum](parameters[8].ToString()),
                parameters[9].ToOptionalString(),
                parameters[10].ToOptionalIfcId());
        }
        #endregion

    }
}