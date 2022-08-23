
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
    public abstract class IfcObject : IfcObjectDefinition, IEquatable<IfcObject>
    {
        private string _objectType;
        public string ObjectType 
        {
            get { 
                return _objectType; 
            }
            set { 
                _objectType = value;  // optional IfcLabel
            }
        }

        internal IfcObject(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType) : base(id, globalId, ownerHistoryId, name, description)
        {
            ObjectType = objectType;
        }

        #region Equality

        public bool Equals(IfcObject other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ObjectType == other.ObjectType;
        }

        public override bool Equals(object other) => Equals(other as IfcObject);

        public static bool operator ==(IfcObject one, IfcObject other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcObject one, IfcObject other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}