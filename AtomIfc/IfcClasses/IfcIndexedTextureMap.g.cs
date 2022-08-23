
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
    public abstract class IfcIndexedTextureMap : IfcTextureCoordinate, IEquatable<IfcIndexedTextureMap>
    {
        private IfcId _mappedToId;
        public IfcId MappedToId 
        {
            get { 
                return _mappedToId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MappedToId is not allowed to be null"); 
                _mappedToId = value;
            }
        }
        private IfcId _texCoordsId;
        public IfcId TexCoordsId 
        {
            get { 
                return _texCoordsId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TexCoordsId is not allowed to be null"); 
                _texCoordsId = value;
            }
        }

        internal IfcIndexedTextureMap(IfcId id, List<IfcId> mapIds, IfcId mappedToId, IfcId texCoordsId) : base(id, mapIds)
        {
            MappedToId = mappedToId;
            TexCoordsId = texCoordsId;
        }

        #region Equality

        public bool Equals(IfcIndexedTextureMap other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && MappedToId == other.MappedToId
                && TexCoordsId == other.TexCoordsId;
        }

        public override bool Equals(object other) => Equals(other as IfcIndexedTextureMap);

        public static bool operator ==(IfcIndexedTextureMap one, IfcIndexedTextureMap other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcIndexedTextureMap one, IfcIndexedTextureMap other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MappedToId!= null && replacementTable.ContainsKey(MappedToId))
                MappedToId = replacementTable[MappedToId];
            if(TexCoordsId!= null && replacementTable.ContainsKey(TexCoordsId))
                TexCoordsId = replacementTable[TexCoordsId];
            base.ReplaceIds(replacementTable);

        }
    }
}