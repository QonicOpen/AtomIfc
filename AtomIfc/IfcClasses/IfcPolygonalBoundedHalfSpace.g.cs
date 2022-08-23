
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
    public class IfcPolygonalBoundedHalfSpace : IfcHalfSpaceSolid, IEquatable<IfcPolygonalBoundedHalfSpace>
    {
        private IfcId _positionId;
        public IfcId PositionId 
        {
            get { 
                return _positionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PositionId is not allowed to be null"); 
                _positionId = value;
            }
        }
        private IfcId _polygonalBoundaryId;
        public IfcId PolygonalBoundaryId 
        {
            get { 
                return _polygonalBoundaryId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PolygonalBoundaryId is not allowed to be null"); 
                _polygonalBoundaryId = value;
            }
        }

        public IfcPolygonalBoundedHalfSpace(IfcId id, IfcId baseSurfaceId, bool agreementFlag, IfcId positionId, IfcId polygonalBoundaryId) : base(id, baseSurfaceId, agreementFlag)
        {
            PositionId = positionId;
            PolygonalBoundaryId = polygonalBoundaryId;
        }

        public override ClassId GetClassId() => ClassId.IfcPolygonalBoundedHalfSpace;

        #region Equality

        public bool Equals(IfcPolygonalBoundedHalfSpace other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PositionId == other.PositionId
                && PolygonalBoundaryId == other.PolygonalBoundaryId;
        }

        public override bool Equals(object other) => Equals(other as IfcPolygonalBoundedHalfSpace);

        public static bool operator ==(IfcPolygonalBoundedHalfSpace one, IfcPolygonalBoundedHalfSpace other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPolygonalBoundedHalfSpace one, IfcPolygonalBoundedHalfSpace other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BaseSurfaceId},{AgreementFlag},{PositionId},{PolygonalBoundaryId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PositionId!= null && replacementTable.ContainsKey(PositionId))
                PositionId = replacementTable[PositionId];
            if(PolygonalBoundaryId!= null && replacementTable.ContainsKey(PolygonalBoundaryId))
                PolygonalBoundaryId = replacementTable[PolygonalBoundaryId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPolygonalBoundedHalfSpace (newId,BaseSurfaceId, AgreementFlag, PositionId, PolygonalBoundaryId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPolygonalBoundedHalfSpace },
                { "class", nameof(IfcPolygonalBoundedHalfSpace) },
                { "parameters" , new JArray
                    {
                        BaseSurfaceId.ToJValue(),
                        AgreementFlag,
                        PositionId.ToJValue(),
                        PolygonalBoundaryId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcPolygonalBoundedHalfSpace CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPolygonalBoundedHalfSpace(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToBool(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcId());
        }
        #endregion

    }
}