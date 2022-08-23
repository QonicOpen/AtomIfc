
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
    public abstract class IfcExternalReference : IfcBase, IEquatable<IfcExternalReference>, IIfcLightDistributionDataSourceSelect, IIfcObjectReferenceSelect, IIfcResourceObjectSelect
    {
        private string _location;
        public string Location 
        {
            get { 
                return _location; 
            }
            set { 
                _location = value;  // optional IfcURIReference
            }
        }
        private string _identification;
        public string Identification 
        {
            get { 
                return _identification; 
            }
            set { 
                _identification = value;  // optional IfcIdentifier
            }
        }
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

        internal IfcExternalReference(IfcId id, string location, string identification, string name) : base(id)
        {
            Location = location;
            Identification = identification;
            Name = name;
        }

        #region Equality

        public bool Equals(IfcExternalReference other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Location == other.Location
                && Identification == other.Identification
                && Name == other.Name;
        }

        public override bool Equals(object other) => Equals(other as IfcExternalReference);

        public static bool operator ==(IfcExternalReference one, IfcExternalReference other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcExternalReference one, IfcExternalReference other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}