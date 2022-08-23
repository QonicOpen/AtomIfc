
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
    public abstract class IfcReinforcingElement : IfcElementComponent, IEquatable<IfcReinforcingElement>
    {
        private string _steelGrade;
        public string SteelGrade 
        {
            get { 
                return _steelGrade; 
            }
            set { 
                _steelGrade = value;  // optional IfcLabel
            }
        }

        internal IfcReinforcingElement(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, string steelGrade) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag)
        {
            SteelGrade = steelGrade;
        }

        #region Equality

        public bool Equals(IfcReinforcingElement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && SteelGrade == other.SteelGrade;
        }

        public override bool Equals(object other) => Equals(other as IfcReinforcingElement);

        public static bool operator ==(IfcReinforcingElement one, IfcReinforcingElement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcReinforcingElement one, IfcReinforcingElement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
    }
}