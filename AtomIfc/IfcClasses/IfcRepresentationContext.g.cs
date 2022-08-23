
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
    public abstract class IfcRepresentationContext : IfcBase, IEquatable<IfcRepresentationContext>
    {
        private string _contextIdentifier;
        public string ContextIdentifier 
        {
            get { 
                return _contextIdentifier; 
            }
            set { 
                _contextIdentifier = value;  // optional IfcLabel
            }
        }
        private string _contextType;
        public string ContextType 
        {
            get { 
                return _contextType; 
            }
            set { 
                _contextType = value;  // optional IfcLabel
            }
        }

        internal IfcRepresentationContext(IfcId id, string contextIdentifier, string contextType) : base(id)
        {
            ContextIdentifier = contextIdentifier;
            ContextType = contextType;
        }

        #region Equality

        public bool Equals(IfcRepresentationContext other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ContextIdentifier == other.ContextIdentifier
                && ContextType == other.ContextType;
        }

        public override bool Equals(object other) => Equals(other as IfcRepresentationContext);

        public static bool operator ==(IfcRepresentationContext one, IfcRepresentationContext other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRepresentationContext one, IfcRepresentationContext other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}