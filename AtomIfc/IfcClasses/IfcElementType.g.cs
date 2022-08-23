
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
    public abstract class IfcElementType : IfcTypeProduct, IEquatable<IfcElementType>
    {
        private string _elementType;
        public string ElementType 
        {
            get { 
                return _elementType; 
            }
            set { 
                _elementType = value;  // optional IfcLabel
            }
        }

        internal IfcElementType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, string elementType) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag)
        {
            ElementType = elementType;
        }

        #region Equality

        public bool Equals(IfcElementType other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ElementType == other.ElementType;
        }

        public override bool Equals(object other) => Equals(other as IfcElementType);

        public static bool operator ==(IfcElementType one, IfcElementType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcElementType one, IfcElementType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}