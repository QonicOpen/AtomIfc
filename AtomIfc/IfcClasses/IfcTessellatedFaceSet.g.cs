
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
    public abstract class IfcTessellatedFaceSet : IfcTessellatedItem, IEquatable<IfcTessellatedFaceSet>
    {
        private IfcId _coordinatesId;
        public IfcId CoordinatesId 
        {
            get { 
                return _coordinatesId; 
            }
            set { 
                _coordinatesId = value;  // optional IfcCartesianPointList3D
            }
        }

        internal IfcTessellatedFaceSet(IfcId id, IfcId coordinatesId) : base(id)
        {
            CoordinatesId = coordinatesId;
        }

        #region Equality

        public bool Equals(IfcTessellatedFaceSet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && CoordinatesId == other.CoordinatesId;
        }

        public override bool Equals(object other) => Equals(other as IfcTessellatedFaceSet);

        public static bool operator ==(IfcTessellatedFaceSet one, IfcTessellatedFaceSet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTessellatedFaceSet one, IfcTessellatedFaceSet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CoordinatesId!= null && replacementTable.ContainsKey(CoordinatesId))
                CoordinatesId = replacementTable[CoordinatesId];
            base.ReplaceIds(replacementTable);

        }
    }
}