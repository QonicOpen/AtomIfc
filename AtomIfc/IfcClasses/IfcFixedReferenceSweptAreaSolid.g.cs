
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
    public class IfcFixedReferenceSweptAreaSolid : IfcSweptAreaSolid, IEquatable<IfcFixedReferenceSweptAreaSolid>
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
        private IfcId _fixedReferenceId;
        public IfcId FixedReferenceId 
        {
            get { 
                return _fixedReferenceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("FixedReferenceId is not allowed to be null"); 
                _fixedReferenceId = value;
            }
        }

        public IfcFixedReferenceSweptAreaSolid(IfcId id, IfcId sweptAreaId, IfcId positionId, IfcId directrixId, double? startParam, double? endParam, IfcId fixedReferenceId) : base(id, sweptAreaId, positionId)
        {
            DirectrixId = directrixId;
            StartParam = startParam;
            EndParam = endParam;
            FixedReferenceId = fixedReferenceId;
        }

        public override ClassId GetClassId() => ClassId.IfcFixedReferenceSweptAreaSolid;

        #region Equality

        public bool Equals(IfcFixedReferenceSweptAreaSolid other)
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
                && FixedReferenceId == other.FixedReferenceId;
        }

        public override bool Equals(object other) => Equals(other as IfcFixedReferenceSweptAreaSolid);

        public static bool operator ==(IfcFixedReferenceSweptAreaSolid one, IfcFixedReferenceSweptAreaSolid other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFixedReferenceSweptAreaSolid one, IfcFixedReferenceSweptAreaSolid other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SweptAreaId},{PositionId},{DirectrixId},{StartParam},{EndParam},{FixedReferenceId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DirectrixId!= null && replacementTable.ContainsKey(DirectrixId))
                DirectrixId = replacementTable[DirectrixId];
            if(FixedReferenceId!= null && replacementTable.ContainsKey(FixedReferenceId))
                FixedReferenceId = replacementTable[FixedReferenceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFixedReferenceSweptAreaSolid (newId,SweptAreaId, PositionId, DirectrixId, StartParam, EndParam, FixedReferenceId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFixedReferenceSweptAreaSolid },
                { "class", nameof(IfcFixedReferenceSweptAreaSolid) },
                { "parameters" , new JArray
                    {
                        SweptAreaId.ToJValue(),
                        PositionId.ToJValue(),
                        DirectrixId.ToJValue(),
                        StartParam.ToJValue(),
                        EndParam.ToJValue(),
                        FixedReferenceId.ToJValue(),
                    }
                }
            };
        }

        public static IfcFixedReferenceSweptAreaSolid CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFixedReferenceSweptAreaSolid(
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