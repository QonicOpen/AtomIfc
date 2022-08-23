
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
    public abstract class IfcContext : IfcObjectDefinition, IEquatable<IfcContext>
    {
        private string _objectType;
        public string ObjectType 
        {
            get { 
                return _objectType; 
            }
            set { 
                _objectType = value;  // optional IfcLabel
            }
        }
        private string _longName;
        public string LongName 
        {
            get { 
                return _longName; 
            }
            set { 
                _longName = value;  // optional IfcLabel
            }
        }
        private string _phase;
        public string Phase 
        {
            get { 
                return _phase; 
            }
            set { 
                _phase = value;  // optional IfcLabel
            }
        }
        private List<IfcId> _representationContextIds;
        public List<IfcId> RepresentationContextIds 
        {
            get { 
                return _representationContextIds; 
            }
            set { 
                _representationContextIds = value;  // optional List<IfcRepresentationContext>
            }
        }
        private IfcId _unitsInContextId;
        public IfcId UnitsInContextId 
        {
            get { 
                return _unitsInContextId; 
            }
            set { 
                _unitsInContextId = value;  // optional IfcUnitAssignment
            }
        }

        internal IfcContext(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string longName, string phase, List<IfcId> representationContextIds, IfcId unitsInContextId) : base(id, globalId, ownerHistoryId, name, description)
        {
            ObjectType = objectType;
            LongName = longName;
            Phase = phase;
            RepresentationContextIds = representationContextIds;
            UnitsInContextId = unitsInContextId;
        }

        #region Equality

        public bool Equals(IfcContext other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RepresentationContextIds, other.RepresentationContextIds))
                return false;
            return base.Equals(other)
                && ObjectType == other.ObjectType
                && LongName == other.LongName
                && Phase == other.Phase
                && UnitsInContextId == other.UnitsInContextId;
        }

        public override bool Equals(object other) => Equals(other as IfcContext);

        public static bool operator ==(IfcContext one, IfcContext other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcContext one, IfcContext other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RepresentationContextIds!= null)
                RepresentationContextIds = RepresentationContextIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(UnitsInContextId!= null && replacementTable.ContainsKey(UnitsInContextId))
                UnitsInContextId = replacementTable[UnitsInContextId];
            base.ReplaceIds(replacementTable);

        }
    }
}