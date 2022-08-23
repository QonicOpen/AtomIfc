
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
    public abstract class IfcRepresentation : IfcBase, IEquatable<IfcRepresentation>, IIfcLayeredItem
    {
        private IfcId _contextOfItemsId;
        public IfcId ContextOfItemsId 
        {
            get { 
                return _contextOfItemsId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ContextOfItemsId is not allowed to be null"); 
                _contextOfItemsId = value;
            }
        }
        private string _representationIdentifier;
        public string RepresentationIdentifier 
        {
            get { 
                return _representationIdentifier; 
            }
            set { 
                _representationIdentifier = value;  // optional IfcLabel
            }
        }
        private string _representationType;
        public string RepresentationType 
        {
            get { 
                return _representationType; 
            }
            set { 
                _representationType = value;  // optional IfcLabel
            }
        }
        private List<IfcId> _itemIds;
        public List<IfcId> ItemIds 
        {
            get { 
                return _itemIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ItemIds is not allowed to be null"); 
                _itemIds = value;
            }
        }

        internal IfcRepresentation(IfcId id, IfcId contextOfItemsId, string representationIdentifier, string representationType, List<IfcId> itemIds) : base(id)
        {
            ContextOfItemsId = contextOfItemsId;
            RepresentationIdentifier = representationIdentifier;
            RepresentationType = representationType;
            ItemIds = itemIds;
        }

        #region Equality

        public bool Equals(IfcRepresentation other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ItemIds, other.ItemIds))
                return false;
            return base.Equals(other)
                && ContextOfItemsId == other.ContextOfItemsId
                && RepresentationIdentifier == other.RepresentationIdentifier
                && RepresentationType == other.RepresentationType;
        }

        public override bool Equals(object other) => Equals(other as IfcRepresentation);

        public static bool operator ==(IfcRepresentation one, IfcRepresentation other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRepresentation one, IfcRepresentation other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ContextOfItemsId!= null && replacementTable.ContainsKey(ContextOfItemsId))
                ContextOfItemsId = replacementTable[ContextOfItemsId];
            if(ItemIds!= null)
                ItemIds = ItemIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
    }
}