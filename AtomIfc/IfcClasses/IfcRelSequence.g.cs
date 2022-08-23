
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
    public class IfcRelSequence : IfcRelConnects, IEquatable<IfcRelSequence>
    {
        private IfcId _relatingProcessId;
        public IfcId RelatingProcessId 
        {
            get { 
                return _relatingProcessId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingProcessId is not allowed to be null"); 
                _relatingProcessId = value;
            }
        }
        private IfcId _relatedProcessId;
        public IfcId RelatedProcessId 
        {
            get { 
                return _relatedProcessId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedProcessId is not allowed to be null"); 
                _relatedProcessId = value;
            }
        }
        private IfcId _timeLagId;
        public IfcId TimeLagId 
        {
            get { 
                return _timeLagId; 
            }
            set { 
                _timeLagId = value;  // optional IfcLagTime
            }
        }
        private IfcSequenceEnum _sequenceType;
        public IfcSequenceEnum SequenceType 
        {
            get { 
                return _sequenceType; 
            }
            set { 
                _sequenceType = value;  // optional IfcSequenceEnum?
            }
        }
        private string _userDefinedSequenceType;
        public string UserDefinedSequenceType 
        {
            get { 
                return _userDefinedSequenceType; 
            }
            set { 
                _userDefinedSequenceType = value;  // optional IfcLabel
            }
        }

        public IfcRelSequence(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingProcessId, IfcId relatedProcessId, IfcId timeLagId, IfcSequenceEnum sequenceType, string userDefinedSequenceType) : base(id, ownerHistoryId, name, description)
        {
            RelatingProcessId = relatingProcessId;
            RelatedProcessId = relatedProcessId;
            TimeLagId = timeLagId;
            SequenceType = sequenceType;
            UserDefinedSequenceType = userDefinedSequenceType;
        }

        public override ClassId GetClassId() => ClassId.IfcRelSequence;

        #region Equality

        public bool Equals(IfcRelSequence other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingProcessId == other.RelatingProcessId
                && RelatedProcessId == other.RelatedProcessId
                && TimeLagId == other.TimeLagId
                && SequenceType == other.SequenceType
                && UserDefinedSequenceType == other.UserDefinedSequenceType;
        }

        public override bool Equals(object other) => Equals(other as IfcRelSequence);

        public static bool operator ==(IfcRelSequence one, IfcRelSequence other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelSequence one, IfcRelSequence other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingProcessId},{RelatedProcessId},{TimeLagId},.{SequenceType}.,'{UserDefinedSequenceType}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingProcessId!= null && replacementTable.ContainsKey(RelatingProcessId))
                RelatingProcessId = replacementTable[RelatingProcessId];
            if(RelatedProcessId!= null && replacementTable.ContainsKey(RelatedProcessId))
                RelatedProcessId = replacementTable[RelatedProcessId];
            if(TimeLagId!= null && replacementTable.ContainsKey(TimeLagId))
                TimeLagId = replacementTable[TimeLagId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelSequence (newId,OwnerHistoryId, Name, Description, RelatingProcessId, RelatedProcessId, TimeLagId, SequenceType, UserDefinedSequenceType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelSequence },
                { "class", nameof(IfcRelSequence) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingProcessId.ToJValue(),
                        RelatedProcessId.ToJValue(),
                        TimeLagId.ToJValue(),
                        SequenceType.ToJValue(),
                        UserDefinedSequenceType.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelSequence CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelSequence(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId(),
                (IfcSequenceEnum)IfcAtom.EnumCreator[(int)EnumId.IfcSequenceEnum](parameters[6].ToString()),
                parameters[7].ToOptionalString());
        }
        #endregion

    }
}