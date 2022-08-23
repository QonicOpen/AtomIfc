
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
    public class IfcOwnerHistory : IfcBase, IEquatable<IfcOwnerHistory>
    {
        private IfcId _owningUserId;
        public IfcId OwningUserId 
        {
            get { 
                return _owningUserId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OwningUserId is not allowed to be null"); 
                _owningUserId = value;
            }
        }
        private IfcId _owningApplicationId;
        public IfcId OwningApplicationId 
        {
            get { 
                return _owningApplicationId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OwningApplicationId is not allowed to be null"); 
                _owningApplicationId = value;
            }
        }
        private IfcStateEnum _state;
        public IfcStateEnum State 
        {
            get { 
                return _state; 
            }
            set { 
                _state = value;  // optional IfcStateEnum?
            }
        }
        private IfcChangeActionEnum _changeAction;
        public IfcChangeActionEnum ChangeAction 
        {
            get { 
                return _changeAction; 
            }
            set { 
                _changeAction = value;  // optional IfcChangeActionEnum?
            }
        }
        private int? _lastModifiedDate;
        public int? LastModifiedDate 
        {
            get { 
                return _lastModifiedDate; 
            }
            set { 
                _lastModifiedDate = value;  // optional IfcTimeStamp
            }
        }
        private IfcId _lastModifyingUserId;
        public IfcId LastModifyingUserId 
        {
            get { 
                return _lastModifyingUserId; 
            }
            set { 
                _lastModifyingUserId = value;  // optional IfcPersonAndOrganization
            }
        }
        private IfcId _lastModifyingApplicationId;
        public IfcId LastModifyingApplicationId 
        {
            get { 
                return _lastModifyingApplicationId; 
            }
            set { 
                _lastModifyingApplicationId = value;  // optional IfcApplication
            }
        }
        private int _creationDate;
        public int CreationDate 
        {
            get { 
                return _creationDate; 
            }
            set { 
                _creationDate = value;
            }
        }

        public IfcOwnerHistory(IfcId id, IfcId owningUserId, IfcId owningApplicationId, IfcStateEnum state, IfcChangeActionEnum changeAction, int? lastModifiedDate, IfcId lastModifyingUserId, IfcId lastModifyingApplicationId, int creationDate) : base(id)
        {
            OwningUserId = owningUserId;
            OwningApplicationId = owningApplicationId;
            State = state;
            ChangeAction = changeAction;
            LastModifiedDate = lastModifiedDate;
            LastModifyingUserId = lastModifyingUserId;
            LastModifyingApplicationId = lastModifyingApplicationId;
            CreationDate = creationDate;
        }

        public override ClassId GetClassId() => ClassId.IfcOwnerHistory;

        #region Equality

        public bool Equals(IfcOwnerHistory other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && OwningUserId == other.OwningUserId
                && OwningApplicationId == other.OwningApplicationId
                && State == other.State
                && ChangeAction == other.ChangeAction
                && LastModifiedDate == other.LastModifiedDate
                && LastModifyingUserId == other.LastModifyingUserId
                && LastModifyingApplicationId == other.LastModifyingApplicationId
                && CreationDate == other.CreationDate;
        }

        public override bool Equals(object other) => Equals(other as IfcOwnerHistory);

        public static bool operator ==(IfcOwnerHistory one, IfcOwnerHistory other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcOwnerHistory one, IfcOwnerHistory other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwningUserId},{OwningApplicationId},.{State}.,.{ChangeAction}.,{LastModifiedDate},{LastModifyingUserId},{LastModifyingApplicationId},{CreationDate})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(OwningUserId!= null && replacementTable.ContainsKey(OwningUserId))
                OwningUserId = replacementTable[OwningUserId];
            if(OwningApplicationId!= null && replacementTable.ContainsKey(OwningApplicationId))
                OwningApplicationId = replacementTable[OwningApplicationId];
            if(LastModifyingUserId!= null && replacementTable.ContainsKey(LastModifyingUserId))
                LastModifyingUserId = replacementTable[LastModifyingUserId];
            if(LastModifyingApplicationId!= null && replacementTable.ContainsKey(LastModifyingApplicationId))
                LastModifyingApplicationId = replacementTable[LastModifyingApplicationId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcOwnerHistory (newId,OwningUserId, OwningApplicationId, State, ChangeAction, LastModifiedDate, LastModifyingUserId, LastModifyingApplicationId, CreationDate);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcOwnerHistory },
                { "class", nameof(IfcOwnerHistory) },
                { "parameters" , new JArray
                    {
                        OwningUserId.ToJValue(),
                        OwningApplicationId.ToJValue(),
                        State.ToJValue(),
                        ChangeAction.ToJValue(),
                        LastModifiedDate.ToJValue(),
                        LastModifyingUserId.ToJValue(),
                        LastModifyingApplicationId.ToJValue(),
                        CreationDate,
                    }
                }
            };
        }

        public static IfcOwnerHistory CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcOwnerHistory(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId(),
                (IfcStateEnum)IfcAtom.EnumCreator[(int)EnumId.IfcStateEnum](parameters[2].ToString()),
                (IfcChangeActionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcChangeActionEnum](parameters[3].ToString()),
                parameters[4].ToOptionalInt(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToInt());
        }
        #endregion

    }
}