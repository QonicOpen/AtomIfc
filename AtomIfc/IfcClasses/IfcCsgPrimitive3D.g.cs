
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
    public abstract class IfcCsgPrimitive3D : IfcGeometricRepresentationItem, IEquatable<IfcCsgPrimitive3D>, IIfcBooleanOperand, IIfcCsgSelect
    {
        private IfcId _positionId;
        public IfcId PositionId 
        {
            get { 
                return _positionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PositionId is not allowed to be null"); 
                _positionId = value;
            }
        }

        internal IfcCsgPrimitive3D(IfcId id, IfcId positionId) : base(id)
        {
            PositionId = positionId;
        }

        #region Equality

        public bool Equals(IfcCsgPrimitive3D other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PositionId == other.PositionId;
        }

        public override bool Equals(object other) => Equals(other as IfcCsgPrimitive3D);

        public static bool operator ==(IfcCsgPrimitive3D one, IfcCsgPrimitive3D other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCsgPrimitive3D one, IfcCsgPrimitive3D other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PositionId!= null && replacementTable.ContainsKey(PositionId))
                PositionId = replacementTable[PositionId];
            base.ReplaceIds(replacementTable);

        }
    }
}