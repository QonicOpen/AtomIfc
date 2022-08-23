
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
    public abstract class IfcControl : IfcObject, IEquatable<IfcControl>
    {
        private string _identification;
        public string Identification 
        {
            get { 
                return _identification; 
            }
            set { 
                _identification = value;  // optional IfcIdentifier
            }
        }

        internal IfcControl(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            Identification = identification;
        }

        #region Equality

        public bool Equals(IfcControl other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Identification == other.Identification;
        }

        public override bool Equals(object other) => Equals(other as IfcControl);

        public static bool operator ==(IfcControl one, IfcControl other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcControl one, IfcControl other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}