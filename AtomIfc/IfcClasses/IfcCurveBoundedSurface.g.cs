
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
    public class IfcCurveBoundedSurface : IfcBoundedSurface, IEquatable<IfcCurveBoundedSurface>
    {
        private IfcId _basisSurfaceId;
        public IfcId BasisSurfaceId 
        {
            get { 
                return _basisSurfaceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("BasisSurfaceId is not allowed to be null"); 
                _basisSurfaceId = value;
            }
        }
        private List<IfcId> _boundaryIds;
        public List<IfcId> BoundaryIds 
        {
            get { 
                return _boundaryIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("BoundaryIds is not allowed to be null"); 
                _boundaryIds = value;
            }
        }
        private bool _implicitOuter;
        public bool ImplicitOuter 
        {
            get { 
                return _implicitOuter; 
            }
            set { 
                _implicitOuter = value;
            }
        }

        public IfcCurveBoundedSurface(IfcId id, IfcId basisSurfaceId, List<IfcId> boundaryIds, bool implicitOuter) : base(id)
        {
            BasisSurfaceId = basisSurfaceId;
            BoundaryIds = boundaryIds;
            ImplicitOuter = implicitOuter;
        }

        public override ClassId GetClassId() => ClassId.IfcCurveBoundedSurface;

        #region Equality

        public bool Equals(IfcCurveBoundedSurface other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(BoundaryIds, other.BoundaryIds))
                return false;
            return base.Equals(other)
                && BasisSurfaceId == other.BasisSurfaceId
                && ImplicitOuter == other.ImplicitOuter;
        }

        public override bool Equals(object other) => Equals(other as IfcCurveBoundedSurface);

        public static bool operator ==(IfcCurveBoundedSurface one, IfcCurveBoundedSurface other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCurveBoundedSurface one, IfcCurveBoundedSurface other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BasisSurfaceId},{Utils.ConvertListToString(BoundaryIds)},{ImplicitOuter})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BasisSurfaceId!= null && replacementTable.ContainsKey(BasisSurfaceId))
                BasisSurfaceId = replacementTable[BasisSurfaceId];
            if(BoundaryIds!= null)
                BoundaryIds = BoundaryIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCurveBoundedSurface (newId,BasisSurfaceId, BoundaryIds, ImplicitOuter);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCurveBoundedSurface },
                { "class", nameof(IfcCurveBoundedSurface) },
                { "parameters" , new JArray
                    {
                        BasisSurfaceId.ToJValue(),
                        BoundaryIds.ToJArray(),
                        ImplicitOuter,
                    }
                }
            };
        }

        public static IfcCurveBoundedSurface CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCurveBoundedSurface(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcIdList(),
                parameters[2].ToBool());
        }
        #endregion

    }
}