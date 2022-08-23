
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
    public abstract class IfcShapeModel : IfcRepresentation, IEquatable<IfcShapeModel>
    {
        internal IfcShapeModel(IfcId id, IfcId contextOfItemsId, string representationIdentifier, string representationType, List<IfcId> itemIds) : base(id, contextOfItemsId, representationIdentifier, representationType, itemIds)
        {
        }

        #region Equality

        public bool Equals(IfcShapeModel other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcShapeModel);

        public static bool operator ==(IfcShapeModel one, IfcShapeModel other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcShapeModel one, IfcShapeModel other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}