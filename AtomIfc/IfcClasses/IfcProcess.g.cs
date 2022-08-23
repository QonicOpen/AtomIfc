
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
    public abstract class IfcProcess : IfcObject, IEquatable<IfcProcess>, IIfcProcessSelect
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

        internal IfcProcess(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, string longDescription) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            Identification = identification;
            LongDescription = longDescription;
        }

        #region Equality

        public bool Equals(IfcProcess other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Identification == other.Identification
                && LongDescription == other.LongDescription;
        }

        public override bool Equals(object other) => Equals(other as IfcProcess);

        public static bool operator ==(IfcProcess one, IfcProcess other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcProcess one, IfcProcess other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}