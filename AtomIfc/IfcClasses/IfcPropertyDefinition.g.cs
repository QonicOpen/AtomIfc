
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
    public abstract class IfcPropertyDefinition : IfcRoot, IEquatable<IfcPropertyDefinition>, IIfcDefinitionSelect
    {
        internal IfcPropertyDefinition(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description) : base(id, globalId, ownerHistoryId, name, description)
        {
        }

        #region Equality

        public bool Equals(IfcPropertyDefinition other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcPropertyDefinition);

        public static bool operator ==(IfcPropertyDefinition one, IfcPropertyDefinition other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertyDefinition one, IfcPropertyDefinition other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}