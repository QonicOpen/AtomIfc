
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
    public abstract class IfcConstraint : IfcBase, IEquatable<IfcConstraint>, IIfcResourceObjectSelect
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;
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
        private IfcConstraintEnum _constraintGrade;
        public IfcConstraintEnum ConstraintGrade 
        {
            get { 
                return _constraintGrade; 
            }
            set { 
                _constraintGrade = value;
            }
        }
        private string _constraintSource;
        public string ConstraintSource 
        {
            get { 
                return _constraintSource; 
            }
            set { 
                _constraintSource = value;  // optional IfcLabel
            }
        }
        private IfcId _creatingActorId;
        public IfcId CreatingActorId 
        {
            get { 
                return _creatingActorId; 
            }
            set { 
                _creatingActorId = value;  // optional IfcActorSelect
            }
        }
        private string _creationTime;
        public string CreationTime 
        {
            get { 
                return _creationTime; 
            }
            set { 
                _creationTime = value;  // optional IfcDateTime
            }
        }
        private string _userDefinedGrade;
        public string UserDefinedGrade 
        {
            get { 
                return _userDefinedGrade; 
            }
            set { 
                _userDefinedGrade = value;  // optional IfcLabel
            }
        }

        internal IfcConstraint(IfcId id, string name, string description, IfcConstraintEnum constraintGrade, string constraintSource, IfcId creatingActorId, string creationTime, string userDefinedGrade) : base(id)
        {
            Name = name;
            Description = description;
            ConstraintGrade = constraintGrade;
            ConstraintSource = constraintSource;
            CreatingActorId = creatingActorId;
            CreationTime = creationTime;
            UserDefinedGrade = userDefinedGrade;
        }

        #region Equality

        public bool Equals(IfcConstraint other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description
                && ConstraintGrade == other.ConstraintGrade
                && ConstraintSource == other.ConstraintSource
                && CreatingActorId == other.CreatingActorId
                && CreationTime == other.CreationTime
                && UserDefinedGrade == other.UserDefinedGrade;
        }

        public override bool Equals(object other) => Equals(other as IfcConstraint);

        public static bool operator ==(IfcConstraint one, IfcConstraint other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConstraint one, IfcConstraint other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CreatingActorId!= null && replacementTable.ContainsKey(CreatingActorId))
                CreatingActorId = replacementTable[CreatingActorId];
            base.ReplaceIds(replacementTable);

        }
    }
}