
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
    public abstract class IfcManifoldSolidBrep : IfcSolidModel, IEquatable<IfcManifoldSolidBrep>
    {
        private IfcId _outerId;
        public IfcId OuterId 
        {
            get { 
                return _outerId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OuterId is not allowed to be null"); 
                _outerId = value;
            }
        }

        internal IfcManifoldSolidBrep(IfcId id, IfcId outerId) : base(id)
        {
            OuterId = outerId;
        }

        #region Equality

        public bool Equals(IfcManifoldSolidBrep other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && OuterId == other.OuterId;
        }

        public override bool Equals(object other) => Equals(other as IfcManifoldSolidBrep);

        public static bool operator ==(IfcManifoldSolidBrep one, IfcManifoldSolidBrep other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcManifoldSolidBrep one, IfcManifoldSolidBrep other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(OuterId!= null && replacementTable.ContainsKey(OuterId))
                OuterId = replacementTable[OuterId];
            base.ReplaceIds(replacementTable);

        }
    }
}