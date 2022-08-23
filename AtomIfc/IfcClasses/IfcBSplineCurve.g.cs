
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
    public abstract class IfcBSplineCurve : IfcBoundedCurve, IEquatable<IfcBSplineCurve>
    {
        private int _degree;
        public int Degree 
        {
            get { 
                return _degree; 
            }
            set { 
                _degree = value;
            }
        }
        private List<IfcId> _controlPointIds;
        public List<IfcId> ControlPointIds 
        {
            get { 
                return _controlPointIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ControlPointIds is not allowed to be null"); 
                _controlPointIds = value;
            }
        }
        private IfcBSplineCurveForm _curveForm;
        public IfcBSplineCurveForm CurveForm 
        {
            get { 
                return _curveForm; 
            }
            set { 
                _curveForm = value;
            }
        }
        private bool? _closedCurve;
        public bool? ClosedCurve 
        {
            get { 
                return _closedCurve; 
            }
            set { 
                _closedCurve = value;
            }
        }
        private bool? _selfIntersect;
        public bool? SelfIntersect 
        {
            get { 
                return _selfIntersect; 
            }
            set { 
                _selfIntersect = value;
            }
        }

        internal IfcBSplineCurve(IfcId id, int degree, List<IfcId> controlPointIds, IfcBSplineCurveForm curveForm, bool? closedCurve, bool? selfIntersect) : base(id)
        {
            Degree = degree;
            ControlPointIds = controlPointIds;
            CurveForm = curveForm;
            ClosedCurve = closedCurve;
            SelfIntersect = selfIntersect;
        }

        #region Equality

        public bool Equals(IfcBSplineCurve other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ControlPointIds, other.ControlPointIds))
                return false;
            return base.Equals(other)
                && Degree == other.Degree
                && CurveForm == other.CurveForm
                && ClosedCurve == other.ClosedCurve
                && SelfIntersect == other.SelfIntersect;
        }

        public override bool Equals(object other) => Equals(other as IfcBSplineCurve);

        public static bool operator ==(IfcBSplineCurve one, IfcBSplineCurve other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBSplineCurve one, IfcBSplineCurve other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ControlPointIds!= null)
                ControlPointIds = ControlPointIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
    }
}