
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
    public abstract class IfcCoordinateOperation : IfcBase, IEquatable<IfcCoordinateOperation>
    {
        private IfcId _sourceCRSId;
        public IfcId SourceCRSId 
        {
            get { 
                return _sourceCRSId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SourceCRSId is not allowed to be null"); 
                _sourceCRSId = value;
            }
        }
        private IfcId _targetCRSId;
        public IfcId TargetCRSId 
        {
            get { 
                return _targetCRSId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TargetCRSId is not allowed to be null"); 
                _targetCRSId = value;
            }
        }

        internal IfcCoordinateOperation(IfcId id, IfcId sourceCRSId, IfcId targetCRSId) : base(id)
        {
            SourceCRSId = sourceCRSId;
            TargetCRSId = targetCRSId;
        }

        #region Equality

        public bool Equals(IfcCoordinateOperation other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && SourceCRSId == other.SourceCRSId
                && TargetCRSId == other.TargetCRSId;
        }

        public override bool Equals(object other) => Equals(other as IfcCoordinateOperation);

        public static bool operator ==(IfcCoordinateOperation one, IfcCoordinateOperation other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCoordinateOperation one, IfcCoordinateOperation other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(SourceCRSId!= null && replacementTable.ContainsKey(SourceCRSId))
                SourceCRSId = replacementTable[SourceCRSId];
            if(TargetCRSId!= null && replacementTable.ContainsKey(TargetCRSId))
                TargetCRSId = replacementTable[TargetCRSId];
            base.ReplaceIds(replacementTable);

        }
    }
}