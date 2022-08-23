
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
    public abstract class IfcTypeResource : IfcTypeObject, IEquatable<IfcTypeResource>, IIfcResourceSelect
    {
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
        private string _longDescription;
        public string LongDescription 
        {
            get { 
                return _longDescription; 
            }
            set { 
                _longDescription = value;  // optional IfcText
            }
        }
        private string _resourceType;
        public string ResourceType 
        {
            get { 
                return _resourceType; 
            }
            set { 
                _resourceType = value;  // optional IfcLabel
            }
        }

        internal IfcTypeResource(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, string identification, string longDescription, string resourceType) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds)
        {
            Identification = identification;
            LongDescription = longDescription;
            ResourceType = resourceType;
        }

        #region Equality

        public bool Equals(IfcTypeResource other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Identification == other.Identification
                && LongDescription == other.LongDescription
                && ResourceType == other.ResourceType;
        }

        public override bool Equals(object other) => Equals(other as IfcTypeResource);

        public static bool operator ==(IfcTypeResource one, IfcTypeResource other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTypeResource one, IfcTypeResource other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}