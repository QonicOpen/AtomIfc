
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
    public abstract class IfcStructuralActivity : IfcProduct, IEquatable<IfcStructuralActivity>
    {
        private IfcId _appliedLoadId;
        public IfcId AppliedLoadId 
        {
            get { 
                return _appliedLoadId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("AppliedLoadId is not allowed to be null"); 
                _appliedLoadId = value;
            }
        }
        private IfcGlobalOrLocalEnum _globalOrLocal;
        public IfcGlobalOrLocalEnum GlobalOrLocal 
        {
            get { 
                return _globalOrLocal; 
            }
            set { 
                _globalOrLocal = value;
            }
        }

        internal IfcStructuralActivity(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, IfcId appliedLoadId, IfcGlobalOrLocalEnum globalOrLocal) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId)
        {
            AppliedLoadId = appliedLoadId;
            GlobalOrLocal = globalOrLocal;
        }

        #region Equality

        public bool Equals(IfcStructuralActivity other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && AppliedLoadId == other.AppliedLoadId
                && GlobalOrLocal == other.GlobalOrLocal;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralActivity);

        public static bool operator ==(IfcStructuralActivity one, IfcStructuralActivity other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralActivity one, IfcStructuralActivity other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(AppliedLoadId!= null && replacementTable.ContainsKey(AppliedLoadId))
                AppliedLoadId = replacementTable[AppliedLoadId];
            base.ReplaceIds(replacementTable);

        }
    }
}