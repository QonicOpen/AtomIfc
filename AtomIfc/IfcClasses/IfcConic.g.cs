
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
    public abstract class IfcConic : IfcCurve, IEquatable<IfcConic>
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

        internal IfcConic(IfcId id, IfcId positionId) : base(id)
        {
            PositionId = positionId;
        }

        #region Equality

        public bool Equals(IfcConic other)
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

        public override bool Equals(object other) => Equals(other as IfcConic);

        public static bool operator ==(IfcConic one, IfcConic other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConic one, IfcConic other) => !(one == other);

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