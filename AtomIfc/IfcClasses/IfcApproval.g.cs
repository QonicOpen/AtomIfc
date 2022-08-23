
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
    public class IfcApproval : IfcBase, IEquatable<IfcApproval>, IIfcResourceObjectSelect
    {
        private string _identifier;
        public string Identifier 
        {
            get { 
                return _identifier; 
            }
            set { 
                _identifier = value;  // optional IfcIdentifier
            }
        }
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;  // optional IfcLabel
            }
        }
        private string _description;
        public string Description 
        {
            get { 
                return _description; 
            }
            set { 
                _description = value;  // optional IfcText
            }
        }
        private string _timeOfApproval;
        public string TimeOfApproval 
        {
            get { 
                return _timeOfApproval; 
            }
            set { 
                _timeOfApproval = value;  // optional IfcDateTime
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
        private string _level;
        public string Level 
        {
            get { 
                return _level; 
            }
            set { 
                _level = value;  // optional IfcLabel
            }
        }
        private string _qualifier;
        public string Qualifier 
        {
            get { 
                return _qualifier; 
            }
            set { 
                _qualifier = value;  // optional IfcText
            }
        }
        private IfcId _requestingApprovalId;
        public IfcId RequestingApprovalId 
        {
            get { 
                return _requestingApprovalId; 
            }
            set { 
                _requestingApprovalId = value;  // optional IfcActorSelect
            }
        }
        private IfcId _givingApprovalId;
        public IfcId GivingApprovalId 
        {
            get { 
                return _givingApprovalId; 
            }
            set { 
                _givingApprovalId = value;  // optional IfcActorSelect
            }
        }

        public IfcApproval(IfcId id, string identifier, string name, string description, string timeOfApproval, string status, string level, string qualifier, IfcId requestingApprovalId, IfcId givingApprovalId) : base(id)
        {
            Identifier = identifier;
            Name = name;
            Description = description;
            TimeOfApproval = timeOfApproval;
            Status = status;
            Level = level;
            Qualifier = qualifier;
            RequestingApprovalId = requestingApprovalId;
            GivingApprovalId = givingApprovalId;
        }

        public override ClassId GetClassId() => ClassId.IfcApproval;

        #region Equality

        public bool Equals(IfcApproval other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Identifier == other.Identifier
                && Name == other.Name
                && Description == other.Description
                && TimeOfApproval == other.TimeOfApproval
                && Status == other.Status
                && Level == other.Level
                && Qualifier == other.Qualifier
                && RequestingApprovalId == other.RequestingApprovalId
                && GivingApprovalId == other.GivingApprovalId;
        }

        public override bool Equals(object other) => Equals(other as IfcApproval);

        public static bool operator ==(IfcApproval one, IfcApproval other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcApproval one, IfcApproval other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Identifier}','{Name}','{Description}','{TimeOfApproval}','{Status}','{Level}','{Qualifier}',{RequestingApprovalId},{GivingApprovalId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RequestingApprovalId!= null && replacementTable.ContainsKey(RequestingApprovalId))
                RequestingApprovalId = replacementTable[RequestingApprovalId];
            if(GivingApprovalId!= null && replacementTable.ContainsKey(GivingApprovalId))
                GivingApprovalId = replacementTable[GivingApprovalId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcApproval (newId,Identifier, Name, Description, TimeOfApproval, Status, Level, Qualifier, RequestingApprovalId, GivingApprovalId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcApproval },
                { "class", nameof(IfcApproval) },
                { "parameters" , new JArray
                    {
                        Identifier.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        TimeOfApproval.ToJValue(),
                        Status.ToJValue(),
                        Level.ToJValue(),
                        Qualifier.ToJValue(),
                        RequestingApprovalId.ToJValue(),
                        GivingApprovalId.ToJValue(),
                    }
                }
            };
        }

        public static IfcApproval CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcApproval(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalIfcId(),
                parameters[8].ToOptionalIfcId());
        }
        #endregion

    }
}