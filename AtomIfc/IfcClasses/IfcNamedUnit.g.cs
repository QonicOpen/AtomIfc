
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
    public abstract class IfcNamedUnit : IfcBase, IEquatable<IfcNamedUnit>, IIfcUnit
    {
        private IfcId _dimensionsId;
        public IfcId DimensionsId 
        {
            get { 
                return _dimensionsId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("DimensionsId is not allowed to be null"); 
                _dimensionsId = value;
            }
        }
        private IfcUnitEnum _unitType;
        public IfcUnitEnum UnitType 
        {
            get { 
                return _unitType; 
            }
            set { 
                _unitType = value;
            }
        }

        internal IfcNamedUnit(IfcId id, IfcId dimensionsId, IfcUnitEnum unitType) : base(id)
        {
            DimensionsId = dimensionsId;
            UnitType = unitType;
        }

        #region Equality

        public bool Equals(IfcNamedUnit other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && DimensionsId == other.DimensionsId
                && UnitType == other.UnitType;
        }

        public override bool Equals(object other) => Equals(other as IfcNamedUnit);

        public static bool operator ==(IfcNamedUnit one, IfcNamedUnit other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcNamedUnit one, IfcNamedUnit other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DimensionsId!= null && replacementTable.ContainsKey(DimensionsId))
                DimensionsId = replacementTable[DimensionsId];
            base.ReplaceIds(replacementTable);

        }
    }
}