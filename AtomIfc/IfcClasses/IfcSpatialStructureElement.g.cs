
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
    public abstract class IfcSpatialStructureElement : IfcSpatialElement, IEquatable<IfcSpatialStructureElement>
    {
        private IfcElementCompositionEnum _compositionType;
        public IfcElementCompositionEnum CompositionType 
        {
            get { 
                return _compositionType; 
            }
            set { 
                _compositionType = value;  // optional IfcElementCompositionEnum?
            }
        }

        internal IfcSpatialStructureElement(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string longName, IfcElementCompositionEnum compositionType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, longName)
        {
            CompositionType = compositionType;
        }

        #region Equality

        public bool Equals(IfcSpatialStructureElement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && CompositionType == other.CompositionType;
        }

        public override bool Equals(object other) => Equals(other as IfcSpatialStructureElement);

        public static bool operator ==(IfcSpatialStructureElement one, IfcSpatialStructureElement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSpatialStructureElement one, IfcSpatialStructureElement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}