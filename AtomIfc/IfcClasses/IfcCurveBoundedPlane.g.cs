
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
    public class IfcCurveBoundedPlane : IfcBoundedSurface, IEquatable<IfcCurveBoundedPlane>
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
        private IfcId _outerBoundaryId;
        public IfcId OuterBoundaryId 
        {
            get { 
                return _outerBoundaryId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OuterBoundaryId is not allowed to be null"); 
                _outerBoundaryId = value;
            }
        }
        private List<IfcId> _innerBoundaryIds;
        public List<IfcId> InnerBoundaryIds 
        {
            get { 
                return _innerBoundaryIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("InnerBoundaryIds is not allowed to be null"); 
                _innerBoundaryIds = value;
            }
        }

        public IfcCurveBoundedPlane(IfcId id, IfcId basisSurfaceId, IfcId outerBoundaryId, List<IfcId> innerBoundaryIds) : base(id)
        {
            BasisSurfaceId = basisSurfaceId;
            OuterBoundaryId = outerBoundaryId;
            InnerBoundaryIds = innerBoundaryIds;
        }

        public override ClassId GetClassId() => ClassId.IfcCurveBoundedPlane;

        #region Equality

        public bool Equals(IfcCurveBoundedPlane other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(InnerBoundaryIds, other.InnerBoundaryIds))
                return false;
            return base.Equals(other)
                && BasisSurfaceId == other.BasisSurfaceId
                && OuterBoundaryId == other.OuterBoundaryId;
        }

        public override bool Equals(object other) => Equals(other as IfcCurveBoundedPlane);

        public static bool operator ==(IfcCurveBoundedPlane one, IfcCurveBoundedPlane other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCurveBoundedPlane one, IfcCurveBoundedPlane other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BasisSurfaceId},{OuterBoundaryId},{Utils.ConvertListToString(InnerBoundaryIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BasisSurfaceId!= null && replacementTable.ContainsKey(BasisSurfaceId))
                BasisSurfaceId = replacementTable[BasisSurfaceId];
            if(OuterBoundaryId!= null && replacementTable.ContainsKey(OuterBoundaryId))
                OuterBoundaryId = replacementTable[OuterBoundaryId];
            if(InnerBoundaryIds!= null)
                InnerBoundaryIds = InnerBoundaryIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCurveBoundedPlane (newId,BasisSurfaceId, OuterBoundaryId, InnerBoundaryIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCurveBoundedPlane },
                { "class", nameof(IfcCurveBoundedPlane) },
                { "parameters" , new JArray
                    {
                        BasisSurfaceId.ToJValue(),
                        OuterBoundaryId.ToJValue(),
                        InnerBoundaryIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcCurveBoundedPlane CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCurveBoundedPlane(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId(),
                parameters[2].ToIfcIdList());
        }
        #endregion

    }
}