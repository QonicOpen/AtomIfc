
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
    public abstract class IfcCartesianTransformationOperator : IfcGeometricRepresentationItem, IEquatable<IfcCartesianTransformationOperator>
    {
        private IfcId _axis1Id;
        public IfcId Axis1Id 
        {
            get { 
                return _axis1Id; 
            }
            set { 
                _axis1Id = value;  // optional IfcDirection
            }
        }
        private IfcId _axis2Id;
        public IfcId Axis2Id 
        {
            get { 
                return _axis2Id; 
            }
            set { 
                _axis2Id = value;  // optional IfcDirection
            }
        }
        private IfcId _localOriginId;
        public IfcId LocalOriginId 
        {
            get { 
                return _localOriginId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("LocalOriginId is not allowed to be null"); 
                _localOriginId = value;
            }
        }
        private double? _scale;
        public double? Scale 
        {
            get { 
                return _scale; 
            }
            set { 
                _scale = value;  // optional double
            }
        }

        internal IfcCartesianTransformationOperator(IfcId id, IfcId axis1Id, IfcId axis2Id, IfcId localOriginId, double? scale) : base(id)
        {
            Axis1Id = axis1Id;
            Axis2Id = axis2Id;
            LocalOriginId = localOriginId;
            Scale = scale;
        }

        #region Equality

        public bool Equals(IfcCartesianTransformationOperator other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Axis1Id == other.Axis1Id
                && Axis2Id == other.Axis2Id
                && LocalOriginId == other.LocalOriginId
                && Scale == other.Scale;
        }

        public override bool Equals(object other) => Equals(other as IfcCartesianTransformationOperator);

        public static bool operator ==(IfcCartesianTransformationOperator one, IfcCartesianTransformationOperator other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCartesianTransformationOperator one, IfcCartesianTransformationOperator other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(Axis1Id!= null && replacementTable.ContainsKey(Axis1Id))
                Axis1Id = replacementTable[Axis1Id];
            if(Axis2Id!= null && replacementTable.ContainsKey(Axis2Id))
                Axis2Id = replacementTable[Axis2Id];
            if(LocalOriginId!= null && replacementTable.ContainsKey(LocalOriginId))
                LocalOriginId = replacementTable[LocalOriginId];
            base.ReplaceIds(replacementTable);

        }
    }
}