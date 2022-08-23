
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
    public abstract class IfcProduct : IfcObject, IEquatable<IfcProduct>, IIfcProductSelect
    {
        private IfcId _objectPlacementId;
        public IfcId ObjectPlacementId 
        {
            get { 
                return _objectPlacementId; 
            }
            set { 
                _objectPlacementId = value;  // optional IfcObjectPlacement
            }
        }
        private IfcId _representationId;
        public IfcId RepresentationId 
        {
            get { 
                return _representationId; 
            }
            set { 
                _representationId = value;  // optional IfcProductRepresentation
            }
        }

        internal IfcProduct(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            ObjectPlacementId = objectPlacementId;
            RepresentationId = representationId;
        }

        #region Equality

        public bool Equals(IfcProduct other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ObjectPlacementId == other.ObjectPlacementId
                && RepresentationId == other.RepresentationId;
        }

        public override bool Equals(object other) => Equals(other as IfcProduct);

        public static bool operator ==(IfcProduct one, IfcProduct other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcProduct one, IfcProduct other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ObjectPlacementId!= null && replacementTable.ContainsKey(ObjectPlacementId))
                ObjectPlacementId = replacementTable[ObjectPlacementId];
            if(RepresentationId!= null && replacementTable.ContainsKey(RepresentationId))
                RepresentationId = replacementTable[RepresentationId];
            base.ReplaceIds(replacementTable);

        }
    }
}