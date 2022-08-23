
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
    public class IfcSurfaceCurveSweptAreaSolid : IfcSweptAreaSolid, IEquatable<IfcSurfaceCurveSweptAreaSolid>
    {
        private IfcId _directrixId;
        public IfcId DirectrixId 
        {
            get { 
                return _directrixId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("DirectrixId is not allowed to be null"); 
                _directrixId = value;
            }
        }
        private double? _startParam;
        public double? StartParam 
        {
            get { 
                return _startParam; 
            }
            set { 
                _startParam = value;  // optional IfcParameterValue
            }
        }
        private double? _endParam;
        public double? EndParam 
        {
            get { 
                return _endParam; 
            }
            set { 
                _endParam = value;  // optional IfcParameterValue
            }
        }
        private IfcId _referenceSurfaceId;
        public IfcId ReferenceSurfaceId 
        {
            get { 
                return _referenceSurfaceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ReferenceSurfaceId is not allowed to be null"); 
                _referenceSurfaceId = value;
            }
        }

        public IfcSurfaceCurveSweptAreaSolid(IfcId id, IfcId sweptAreaId, IfcId positionId, IfcId directrixId, double? startParam, double? endParam, IfcId referenceSurfaceId) : base(id, sweptAreaId, positionId)
        {
            DirectrixId = directrixId;
            StartParam = startParam;
            EndParam = endParam;
            ReferenceSurfaceId = referenceSurfaceId;
        }

        public override ClassId GetClassId() => ClassId.IfcSurfaceCurveSweptAreaSolid;

        #region Equality

        public bool Equals(IfcSurfaceCurveSweptAreaSolid other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && DirectrixId == other.DirectrixId
                && StartParam == other.StartParam
                && EndParam == other.EndParam
                && ReferenceSurfaceId == other.ReferenceSurfaceId;
        }

        public override bool Equals(object other) => Equals(other as IfcSurfaceCurveSweptAreaSolid);

        public static bool operator ==(IfcSurfaceCurveSweptAreaSolid one, IfcSurfaceCurveSweptAreaSolid other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSurfaceCurveSweptAreaSolid one, IfcSurfaceCurveSweptAreaSolid other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SweptAreaId},{PositionId},{DirectrixId},{StartParam},{EndParam},{ReferenceSurfaceId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DirectrixId!= null && replacementTable.ContainsKey(DirectrixId))
                DirectrixId = replacementTable[DirectrixId];
            if(ReferenceSurfaceId!= null && replacementTable.ContainsKey(ReferenceSurfaceId))
                ReferenceSurfaceId = replacementTable[ReferenceSurfaceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSurfaceCurveSweptAreaSolid (newId,SweptAreaId, PositionId, DirectrixId, StartParam, EndParam, ReferenceSurfaceId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSurfaceCurveSweptAreaSolid },
                { "class", nameof(IfcSurfaceCurveSweptAreaSolid) },
                { "parameters" , new JArray
                    {
                        SweptAreaId.ToJValue(),
                        PositionId.ToJValue(),
                        DirectrixId.ToJValue(),
                        StartParam.ToJValue(),
                        EndParam.ToJValue(),
                        ReferenceSurfaceId.ToJValue(),
                    }
                }
            };
        }

        public static IfcSurfaceCurveSweptAreaSolid CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSurfaceCurveSweptAreaSolid(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToIfcId());
        }
        #endregion

    }
}