
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
    public abstract class IfcWorkControl : IfcControl, IEquatable<IfcWorkControl>
    {
        private string _creationDate;
        public string CreationDate 
        {
            get { 
                return _creationDate; 
            }
            set { 
                _creationDate = value;
            }
        }
        private List<IfcId> _creatorIds;
        public List<IfcId> CreatorIds 
        {
            get { 
                return _creatorIds; 
            }
            set { 
                _creatorIds = value;  // optional List<IfcPerson>
            }
        }
        private string _purpose;
        public string Purpose 
        {
            get { 
                return _purpose; 
            }
            set { 
                _purpose = value;  // optional IfcLabel
            }
        }
        private string _duration;
        public string Duration 
        {
            get { 
                return _duration; 
            }
            set { 
                _duration = value;  // optional IfcDuration
            }
        }
        private string _totalFloat;
        public string TotalFloat 
        {
            get { 
                return _totalFloat; 
            }
            set { 
                _totalFloat = value;  // optional IfcDuration
            }
        }
        private string _startTime;
        public string StartTime 
        {
            get { 
                return _startTime; 
            }
            set { 
                _startTime = value;
            }
        }
        private string _finishTime;
        public string FinishTime 
        {
            get { 
                return _finishTime; 
            }
            set { 
                _finishTime = value;  // optional IfcDateTime
            }
        }

        internal IfcWorkControl(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, string creationDate, List<IfcId> creatorIds, string purpose, string duration, string totalFloat, string startTime, string finishTime) : base(id, globalId, ownerHistoryId, name, description, objectType, identification)
        {
            CreationDate = creationDate;
            CreatorIds = creatorIds;
            Purpose = purpose;
            Duration = duration;
            TotalFloat = totalFloat;
            StartTime = startTime;
            FinishTime = finishTime;
        }

        #region Equality

        public bool Equals(IfcWorkControl other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(CreatorIds, other.CreatorIds))
                return false;
            return base.Equals(other)
                && CreationDate == other.CreationDate
                && Purpose == other.Purpose
                && Duration == other.Duration
                && TotalFloat == other.TotalFloat
                && StartTime == other.StartTime
                && FinishTime == other.FinishTime;
        }

        public override bool Equals(object other) => Equals(other as IfcWorkControl);

        public static bool operator ==(IfcWorkControl one, IfcWorkControl other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcWorkControl one, IfcWorkControl other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CreatorIds!= null)
                CreatorIds = CreatorIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
    }
}