
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
    public abstract class IfcBSplineSurface : IfcBoundedSurface, IEquatable<IfcBSplineSurface>
    {
        private int _uDegree;
        public int UDegree 
        {
            get { 
                return _uDegree; 
            }
            set { 
                _uDegree = value;
            }
        }
        private int _vDegree;
        public int VDegree 
        {
            get { 
                return _vDegree; 
            }
            set { 
                _vDegree = value;
            }
        }
        private List<List<IfcId>> _controlPointIds;
        public List<List<IfcId>> ControlPointIds 
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
        private IfcBSplineSurfaceForm _surfaceForm;
        public IfcBSplineSurfaceForm SurfaceForm 
        {
            get { 
                return _surfaceForm; 
            }
            set { 
                _surfaceForm = value;
            }
        }
        private bool? _uClosed;
        public bool? UClosed 
        {
            get { 
                return _uClosed; 
            }
            set { 
                _uClosed = value;
            }
        }
        private bool? _vClosed;
        public bool? VClosed 
        {
            get { 
                return _vClosed; 
            }
            set { 
                _vClosed = value;
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

        internal IfcBSplineSurface(IfcId id, int uDegree, int vDegree, List<List<IfcId>> controlPointIds, IfcBSplineSurfaceForm surfaceForm, bool? uClosed, bool? vClosed, bool? selfIntersect) : base(id)
        {
            UDegree = uDegree;
            VDegree = vDegree;
            ControlPointIds = controlPointIds;
            SurfaceForm = surfaceForm;
            UClosed = uClosed;
            VClosed = vClosed;
            SelfIntersect = selfIntersect;
        }

        #region Equality

        public bool Equals(IfcBSplineSurface other)
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
                && UDegree == other.UDegree
                && VDegree == other.VDegree
                && SurfaceForm == other.SurfaceForm
                && UClosed == other.UClosed
                && VClosed == other.VClosed
                && SelfIntersect == other.SelfIntersect;
        }

        public override bool Equals(object other) => Equals(other as IfcBSplineSurface);

        public static bool operator ==(IfcBSplineSurface one, IfcBSplineSurface other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBSplineSurface one, IfcBSplineSurface other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ControlPointIds!= null)
                ControlPointIds = ControlPointIds.Select(subList => subList.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList()).ToList();
            base.ReplaceIds(replacementTable);

        }
    }
}