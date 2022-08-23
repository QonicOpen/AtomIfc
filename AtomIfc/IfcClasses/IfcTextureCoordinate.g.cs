
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
    public abstract class IfcTextureCoordinate : IfcPresentationItem, IEquatable<IfcTextureCoordinate>
    {
        private List<IfcId> _mapIds;
        public List<IfcId> MapIds 
        {
            get { 
                return _mapIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MapIds is not allowed to be null"); 
                _mapIds = value;
            }
        }

        internal IfcTextureCoordinate(IfcId id, List<IfcId> mapIds) : base(id)
        {
            MapIds = mapIds;
        }

        #region Equality

        public bool Equals(IfcTextureCoordinate other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(MapIds, other.MapIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcTextureCoordinate);

        public static bool operator ==(IfcTextureCoordinate one, IfcTextureCoordinate other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTextureCoordinate one, IfcTextureCoordinate other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MapIds!= null)
                MapIds = MapIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
    }
}