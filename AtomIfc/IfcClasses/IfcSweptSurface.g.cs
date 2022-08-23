
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
    public abstract class IfcSweptSurface : IfcSurface, IEquatable<IfcSweptSurface>
    {
        private IfcId _sweptCurveId;
        public IfcId SweptCurveId 
        {
            get { 
                return _sweptCurveId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SweptCurveId is not allowed to be null"); 
                _sweptCurveId = value;
            }
        }
        private IfcId _positionId;
        public IfcId PositionId 
        {
            get { 
                return _positionId; 
            }
            set { 
                _positionId = value;  // optional IfcAxis2Placement3D
            }
        }

        internal IfcSweptSurface(IfcId id, IfcId sweptCurveId, IfcId positionId) : base(id)
        {
            SweptCurveId = sweptCurveId;
            PositionId = positionId;
        }

        #region Equality

        public bool Equals(IfcSweptSurface other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && SweptCurveId == other.SweptCurveId
                && PositionId == other.PositionId;
        }

        public override bool Equals(object other) => Equals(other as IfcSweptSurface);

        public static bool operator ==(IfcSweptSurface one, IfcSweptSurface other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSweptSurface one, IfcSweptSurface other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(SweptCurveId!= null && replacementTable.ContainsKey(SweptCurveId))
                SweptCurveId = replacementTable[SweptCurveId];
            if(PositionId!= null && replacementTable.ContainsKey(PositionId))
                PositionId = replacementTable[PositionId];
            base.ReplaceIds(replacementTable);

        }
    }
}