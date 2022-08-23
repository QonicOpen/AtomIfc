
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
    public abstract class IfcStructuralAction : IfcStructuralActivity, IEquatable<IfcStructuralAction>
    {
        private bool? _destabilizingLoad;
        public bool? DestabilizingLoad 
        {
            get { 
                return _destabilizingLoad; 
            }
            set { 
                _destabilizingLoad = value;  // optional bool
            }
        }

        internal IfcStructuralAction(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, IfcId appliedLoadId, IfcGlobalOrLocalEnum globalOrLocal, bool? destabilizingLoad) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, appliedLoadId, globalOrLocal)
        {
            DestabilizingLoad = destabilizingLoad;
        }

        #region Equality

        public bool Equals(IfcStructuralAction other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && DestabilizingLoad == other.DestabilizingLoad;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralAction);

        public static bool operator ==(IfcStructuralAction one, IfcStructuralAction other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralAction one, IfcStructuralAction other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}