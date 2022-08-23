
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
    public abstract class IfcGeometricRepresentationItem : IfcRepresentationItem, IEquatable<IfcGeometricRepresentationItem>
    {
        internal IfcGeometricRepresentationItem(IfcId id) : base(id)
        {
        }

        #region Equality

        public bool Equals(IfcGeometricRepresentationItem other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcGeometricRepresentationItem);

        public static bool operator ==(IfcGeometricRepresentationItem one, IfcGeometricRepresentationItem other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcGeometricRepresentationItem one, IfcGeometricRepresentationItem other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}