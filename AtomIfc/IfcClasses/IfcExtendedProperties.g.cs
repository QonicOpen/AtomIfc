
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
    public abstract class IfcExtendedProperties : IfcPropertyAbstraction, IEquatable<IfcExtendedProperties>
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;  // optional IfcIdentifier
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
        private List<IfcId> _propertyIds;
        public List<IfcId> PropertyIds 
        {
            get { 
                return _propertyIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PropertyIds is not allowed to be null"); 
                _propertyIds = value;
            }
        }

        internal IfcExtendedProperties(IfcId id, string name, string description, List<IfcId> propertyIds) : base(id)
        {
            Name = name;
            Description = description;
            PropertyIds = propertyIds;
        }

        #region Equality

        public bool Equals(IfcExtendedProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(PropertyIds, other.PropertyIds))
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description;
        }

        public override bool Equals(object other) => Equals(other as IfcExtendedProperties);

        public static bool operator ==(IfcExtendedProperties one, IfcExtendedProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcExtendedProperties one, IfcExtendedProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PropertyIds!= null)
                PropertyIds = PropertyIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
    }
}