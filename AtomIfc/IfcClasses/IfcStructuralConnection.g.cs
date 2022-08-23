
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
    public abstract class IfcStructuralConnection : IfcStructuralItem, IEquatable<IfcStructuralConnection>
    {
        private IfcId _appliedConditionId;
        public IfcId AppliedConditionId 
        {
            get { 
                return _appliedConditionId; 
            }
            set { 
                _appliedConditionId = value;  // optional IfcBoundaryCondition
            }
        }

        internal IfcStructuralConnection(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, IfcId appliedConditionId) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId)
        {
            AppliedConditionId = appliedConditionId;
        }

        #region Equality

        public bool Equals(IfcStructuralConnection other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && AppliedConditionId == other.AppliedConditionId;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralConnection);

        public static bool operator ==(IfcStructuralConnection one, IfcStructuralConnection other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralConnection one, IfcStructuralConnection other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(AppliedConditionId!= null && replacementTable.ContainsKey(AppliedConditionId))
                AppliedConditionId = replacementTable[AppliedConditionId];
            base.ReplaceIds(replacementTable);

        }
    }
}