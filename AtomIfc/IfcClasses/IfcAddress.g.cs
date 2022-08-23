
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
    public abstract class IfcAddress : IfcBase, IEquatable<IfcAddress>, IIfcObjectReferenceSelect
    {
        private IfcAddressTypeEnum _purpose;
        public IfcAddressTypeEnum Purpose 
        {
            get { 
                return _purpose; 
            }
            set { 
                _purpose = value;  // optional IfcAddressTypeEnum?
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
        private string _userDefinedPurpose;
        public string UserDefinedPurpose 
        {
            get { 
                return _userDefinedPurpose; 
            }
            set { 
                _userDefinedPurpose = value;  // optional IfcLabel
            }
        }

        internal IfcAddress(IfcId id, IfcAddressTypeEnum purpose, string description, string userDefinedPurpose) : base(id)
        {
            Purpose = purpose;
            Description = description;
            UserDefinedPurpose = userDefinedPurpose;
        }

        #region Equality

        public bool Equals(IfcAddress other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Purpose == other.Purpose
                && Description == other.Description
                && UserDefinedPurpose == other.UserDefinedPurpose;
        }

        public override bool Equals(object other) => Equals(other as IfcAddress);

        public static bool operator ==(IfcAddress one, IfcAddress other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcAddress one, IfcAddress other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}