
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
    public abstract class IfcPlacement : IfcGeometricRepresentationItem, IEquatable<IfcPlacement>
    {
        private IfcId _locationId;
        public IfcId LocationId 
        {
            get { 
                return _locationId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("LocationId is not allowed to be null"); 
                _locationId = value;
            }
        }

        internal IfcPlacement(IfcId id, IfcId locationId) : base(id)
        {
            LocationId = locationId;
        }

        #region Equality

        public bool Equals(IfcPlacement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LocationId == other.LocationId;
        }

        public override bool Equals(object other) => Equals(other as IfcPlacement);

        public static bool operator ==(IfcPlacement one, IfcPlacement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPlacement one, IfcPlacement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(LocationId!= null && replacementTable.ContainsKey(LocationId))
                LocationId = replacementTable[LocationId];
            base.ReplaceIds(replacementTable);

        }
    }
}