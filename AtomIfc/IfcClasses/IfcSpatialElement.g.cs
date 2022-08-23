
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
    public abstract class IfcSpatialElement : IfcProduct, IEquatable<IfcSpatialElement>
    {
        private string _longName;
        public string LongName 
        {
            get { 
                return _longName; 
            }
            set { 
                _longName = value;  // optional IfcLabel
            }
        }

        internal IfcSpatialElement(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string longName) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId)
        {
            LongName = longName;
        }

        #region Equality

        public bool Equals(IfcSpatialElement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LongName == other.LongName;
        }

        public override bool Equals(object other) => Equals(other as IfcSpatialElement);

        public static bool operator ==(IfcSpatialElement one, IfcSpatialElement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSpatialElement one, IfcSpatialElement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}