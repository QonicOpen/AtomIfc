
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
    public abstract class IfcPhysicalSimpleQuantity : IfcPhysicalQuantity, IEquatable<IfcPhysicalSimpleQuantity>
    {
        private IfcId _unitId;
        public IfcId UnitId 
        {
            get { 
                return _unitId; 
            }
            set { 
                _unitId = value;  // optional IfcNamedUnit
            }
        }

        internal IfcPhysicalSimpleQuantity(IfcId id, string name, string description, IfcId unitId) : base(id, name, description)
        {
            UnitId = unitId;
        }

        #region Equality

        public bool Equals(IfcPhysicalSimpleQuantity other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && UnitId == other.UnitId;
        }

        public override bool Equals(object other) => Equals(other as IfcPhysicalSimpleQuantity);

        public static bool operator ==(IfcPhysicalSimpleQuantity one, IfcPhysicalSimpleQuantity other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPhysicalSimpleQuantity one, IfcPhysicalSimpleQuantity other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(UnitId!= null && replacementTable.ContainsKey(UnitId))
                UnitId = replacementTable[UnitId];
            base.ReplaceIds(replacementTable);

        }
    }
}