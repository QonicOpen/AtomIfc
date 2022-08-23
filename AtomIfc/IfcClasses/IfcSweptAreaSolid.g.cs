
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
    public abstract class IfcSweptAreaSolid : IfcSolidModel, IEquatable<IfcSweptAreaSolid>
    {
        private IfcId _sweptAreaId;
        public IfcId SweptAreaId 
        {
            get { 
                return _sweptAreaId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SweptAreaId is not allowed to be null"); 
                _sweptAreaId = value;
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

        internal IfcSweptAreaSolid(IfcId id, IfcId sweptAreaId, IfcId positionId) : base(id)
        {
            SweptAreaId = sweptAreaId;
            PositionId = positionId;
        }

        #region Equality

        public bool Equals(IfcSweptAreaSolid other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && SweptAreaId == other.SweptAreaId
                && PositionId == other.PositionId;
        }

        public override bool Equals(object other) => Equals(other as IfcSweptAreaSolid);

        public static bool operator ==(IfcSweptAreaSolid one, IfcSweptAreaSolid other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSweptAreaSolid one, IfcSweptAreaSolid other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(SweptAreaId!= null && replacementTable.ContainsKey(SweptAreaId))
                SweptAreaId = replacementTable[SweptAreaId];
            if(PositionId!= null && replacementTable.ContainsKey(PositionId))
                PositionId = replacementTable[PositionId];
            base.ReplaceIds(replacementTable);

        }
    }
}