
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
    public abstract class IfcConstructionResource : IfcResource, IEquatable<IfcConstructionResource>
    {
        private IfcId _usageId;
        public IfcId UsageId 
        {
            get { 
                return _usageId; 
            }
            set { 
                _usageId = value;  // optional IfcResourceTime
            }
        }
        private List<IfcId> _baseCostIds;
        public List<IfcId> BaseCostIds 
        {
            get { 
                return _baseCostIds; 
            }
            set { 
                _baseCostIds = value;  // optional List<IfcAppliedValue>
            }
        }
        private IfcId _baseQuantityId;
        public IfcId BaseQuantityId 
        {
            get { 
                return _baseQuantityId; 
            }
            set { 
                _baseQuantityId = value;  // optional IfcPhysicalQuantity
            }
        }

        internal IfcConstructionResource(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, string longDescription, IfcId usageId, List<IfcId> baseCostIds, IfcId baseQuantityId) : base(id, globalId, ownerHistoryId, name, description, objectType, identification, longDescription)
        {
            UsageId = usageId;
            BaseCostIds = baseCostIds;
            BaseQuantityId = baseQuantityId;
        }

        #region Equality

        public bool Equals(IfcConstructionResource other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(BaseCostIds, other.BaseCostIds))
                return false;
            return base.Equals(other)
                && UsageId == other.UsageId
                && BaseQuantityId == other.BaseQuantityId;
        }

        public override bool Equals(object other) => Equals(other as IfcConstructionResource);

        public static bool operator ==(IfcConstructionResource one, IfcConstructionResource other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConstructionResource one, IfcConstructionResource other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(UsageId!= null && replacementTable.ContainsKey(UsageId))
                UsageId = replacementTable[UsageId];
            if(BaseCostIds!= null)
                BaseCostIds = BaseCostIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(BaseQuantityId!= null && replacementTable.ContainsKey(BaseQuantityId))
                BaseQuantityId = replacementTable[BaseQuantityId];
            base.ReplaceIds(replacementTable);

        }
    }
}