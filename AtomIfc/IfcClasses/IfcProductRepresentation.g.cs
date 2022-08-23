
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
    public abstract class IfcProductRepresentation : IfcBase, IEquatable<IfcProductRepresentation>
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;  // optional IfcLabel
            }
        }
        private string _description;
        public string Description 
        {
            get { 
                return _description; 
            }
            set { 
                _description = value;  // optional IfcText
            }
        }
        private List<IfcId> _representationIds;
        public List<IfcId> RepresentationIds 
        {
            get { 
                return _representationIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RepresentationIds is not allowed to be null"); 
                _representationIds = value;
            }
        }

        internal IfcProductRepresentation(IfcId id, string name, string description, List<IfcId> representationIds) : base(id)
        {
            Name = name;
            Description = description;
            RepresentationIds = representationIds;
        }

        #region Equality

        public bool Equals(IfcProductRepresentation other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RepresentationIds, other.RepresentationIds))
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description;
        }

        public override bool Equals(object other) => Equals(other as IfcProductRepresentation);

        public static bool operator ==(IfcProductRepresentation one, IfcProductRepresentation other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcProductRepresentation one, IfcProductRepresentation other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RepresentationIds!= null)
                RepresentationIds = RepresentationIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
    }
}