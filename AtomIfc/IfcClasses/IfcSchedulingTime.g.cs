
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
    public abstract class IfcSchedulingTime : IfcBase, IEquatable<IfcSchedulingTime>
    {
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
        private IfcDataOriginEnum _dataOrigin;
        public IfcDataOriginEnum DataOrigin 
        {
            get { 
                return _dataOrigin; 
            }
            set { 
                _dataOrigin = value;  // optional IfcDataOriginEnum?
            }
        }
        private string _userDefinedDataOrigin;
        public string UserDefinedDataOrigin 
        {
            get { 
                return _userDefinedDataOrigin; 
            }
            set { 
                _userDefinedDataOrigin = value;  // optional IfcLabel
            }
        }

        internal IfcSchedulingTime(IfcId id, string name, IfcDataOriginEnum dataOrigin, string userDefinedDataOrigin) : base(id)
        {
            Name = name;
            DataOrigin = dataOrigin;
            UserDefinedDataOrigin = userDefinedDataOrigin;
        }

        #region Equality

        public bool Equals(IfcSchedulingTime other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name
                && DataOrigin == other.DataOrigin
                && UserDefinedDataOrigin == other.UserDefinedDataOrigin;
        }

        public override bool Equals(object other) => Equals(other as IfcSchedulingTime);

        public static bool operator ==(IfcSchedulingTime one, IfcSchedulingTime other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSchedulingTime one, IfcSchedulingTime other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}