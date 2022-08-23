
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
    public abstract class IfcCoordinateReferenceSystem : IfcBase, IEquatable<IfcCoordinateReferenceSystem>, IIfcCoordinateReferenceSystemSelect
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
        private string _geodeticDatum;
        public string GeodeticDatum 
        {
            get { 
                return _geodeticDatum; 
            }
            set { 
                _geodeticDatum = value;
            }
        }
        private string _verticalDatum;
        public string VerticalDatum 
        {
            get { 
                return _verticalDatum; 
            }
            set { 
                _verticalDatum = value;  // optional IfcIdentifier
            }
        }

        internal IfcCoordinateReferenceSystem(IfcId id, string name, string description, string geodeticDatum, string verticalDatum) : base(id)
        {
            Name = name;
            Description = description;
            GeodeticDatum = geodeticDatum;
            VerticalDatum = verticalDatum;
        }

        #region Equality

        public bool Equals(IfcCoordinateReferenceSystem other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description
                && GeodeticDatum == other.GeodeticDatum
                && VerticalDatum == other.VerticalDatum;
        }

        public override bool Equals(object other) => Equals(other as IfcCoordinateReferenceSystem);

        public static bool operator ==(IfcCoordinateReferenceSystem one, IfcCoordinateReferenceSystem other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCoordinateReferenceSystem one, IfcCoordinateReferenceSystem other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}