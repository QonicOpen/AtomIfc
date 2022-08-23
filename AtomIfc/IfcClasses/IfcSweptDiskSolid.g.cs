
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
    public class IfcSweptDiskSolid : IfcSolidModel, IEquatable<IfcSweptDiskSolid>
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
        private double _radius;
        public double Radius 
        {
            get { 
                return _radius; 
            }
            set { 
                _radius = value;
            }
        }
        private double? _innerRadius;
        public double? InnerRadius 
        {
            get { 
                return _innerRadius; 
            }
            set { 
                _innerRadius = value;  // optional IfcPositiveLengthMeasure
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

        public IfcSweptDiskSolid(IfcId id, IfcId directrixId, double radius, double? innerRadius, double? startParam, double? endParam) : base(id)
        {
            DirectrixId = directrixId;
            Radius = radius;
            InnerRadius = innerRadius;
            StartParam = startParam;
            EndParam = endParam;
        }

        public override ClassId GetClassId() => ClassId.IfcSweptDiskSolid;

        #region Equality

        public bool Equals(IfcSweptDiskSolid other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && DirectrixId == other.DirectrixId
                && Radius == other.Radius
                && InnerRadius == other.InnerRadius
                && StartParam == other.StartParam
                && EndParam == other.EndParam;
        }

        public override bool Equals(object other) => Equals(other as IfcSweptDiskSolid);

        public static bool operator ==(IfcSweptDiskSolid one, IfcSweptDiskSolid other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSweptDiskSolid one, IfcSweptDiskSolid other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({DirectrixId},{Radius},{InnerRadius},{StartParam},{EndParam})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DirectrixId!= null && replacementTable.ContainsKey(DirectrixId))
                DirectrixId = replacementTable[DirectrixId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSweptDiskSolid (newId,DirectrixId, Radius, InnerRadius, StartParam, EndParam);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSweptDiskSolid },
                { "class", nameof(IfcSweptDiskSolid) },
                { "parameters" , new JArray
                    {
                        DirectrixId.ToJValue(),
                        Radius,
                        InnerRadius.ToJValue(),
                        StartParam.ToJValue(),
                        EndParam.ToJValue(),
                    }
                }
            };
        }

        public static IfcSweptDiskSolid CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSweptDiskSolid(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalDouble());
        }
        #endregion

    }
}