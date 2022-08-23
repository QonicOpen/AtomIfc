
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
    public abstract class IfcRoot : IfcBase, IEquatable<IfcRoot>
    {
        private string _globalId;
        public string GlobalId 
        {
            get { 
                return _globalId; 
            }
            set { 
                _globalId = value;
            }
        }
        private IfcId _ownerHistoryId;
        public IfcId OwnerHistoryId 
        {
            get { 
                return _ownerHistoryId; 
            }
            set { 
                _ownerHistoryId = value;  // optional IfcOwnerHistory
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

        internal IfcRoot(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description) : base(id)
        {
            GlobalId = globalId;
            OwnerHistoryId = ownerHistoryId;
            Name = name;
            Description = description;
        }

        #region Equality

        public bool Equals(IfcRoot other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && GlobalId == other.GlobalId
                && OwnerHistoryId == other.OwnerHistoryId
                && Name == other.Name
                && Description == other.Description;
        }

        public override bool Equals(object other) => Equals(other as IfcRoot);

        public static bool operator ==(IfcRoot one, IfcRoot other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRoot one, IfcRoot other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(OwnerHistoryId!= null && replacementTable.ContainsKey(OwnerHistoryId))
                OwnerHistoryId = replacementTable[OwnerHistoryId];
            base.ReplaceIds(replacementTable);

        }
    }
}