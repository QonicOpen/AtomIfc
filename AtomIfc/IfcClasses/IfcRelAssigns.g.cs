
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
    public abstract class IfcRelAssigns : IfcRelationship, IEquatable<IfcRelAssigns>
    {
        private List<IfcId> _relatedObjectIds;
        public List<IfcId> RelatedObjectIds 
        {
            get { 
                return _relatedObjectIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedObjectIds is not allowed to be null"); 
                _relatedObjectIds = value;
            }
        }
        private IfcObjectTypeEnum _relatedObjectsType;
        public IfcObjectTypeEnum RelatedObjectsType 
        {
            get { 
                return _relatedObjectsType; 
            }
            set { 
                _relatedObjectsType = value;  // optional IfcObjectTypeEnum?
            }
        }

        internal IfcRelAssigns(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcObjectTypeEnum relatedObjectsType) : base(id, ownerHistoryId, name, description)
        {
            RelatedObjectIds = relatedObjectIds;
            RelatedObjectsType = relatedObjectsType;
        }

        #region Equality

        public bool Equals(IfcRelAssigns other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedObjectIds, other.RelatedObjectIds))
                return false;
            return base.Equals(other)
                && RelatedObjectsType == other.RelatedObjectsType;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssigns);

        public static bool operator ==(IfcRelAssigns one, IfcRelAssigns other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssigns one, IfcRelAssigns other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatedObjectIds!= null)
                RelatedObjectIds = RelatedObjectIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
    }
}