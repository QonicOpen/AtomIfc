
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
    public class IfcSweptDiskSolidPolygonal : IfcSweptDiskSolid, IEquatable<IfcSweptDiskSolidPolygonal>
    {
        private double? _filletRadius;
        public double? FilletRadius 
        {
            get { 
                return _filletRadius; 
            }
            set { 
                _filletRadius = value;  // optional IfcPositiveLengthMeasure
            }
        }

        public IfcSweptDiskSolidPolygonal(IfcId id, IfcId directrixId, double radius, double? innerRadius, double? startParam, double? endParam, double? filletRadius) : base(id, directrixId, radius, innerRadius, startParam, endParam)
        {
            FilletRadius = filletRadius;
        }

        public override ClassId GetClassId() => ClassId.IfcSweptDiskSolidPolygonal;

        #region Equality

        public bool Equals(IfcSweptDiskSolidPolygonal other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && FilletRadius == other.FilletRadius;
        }

        public override bool Equals(object other) => Equals(other as IfcSweptDiskSolidPolygonal);

        public static bool operator ==(IfcSweptDiskSolidPolygonal one, IfcSweptDiskSolidPolygonal other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSweptDiskSolidPolygonal one, IfcSweptDiskSolidPolygonal other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({DirectrixId},{Radius},{InnerRadius},{StartParam},{EndParam},{FilletRadius})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSweptDiskSolidPolygonal (newId,DirectrixId, Radius, InnerRadius, StartParam, EndParam, FilletRadius);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSweptDiskSolidPolygonal },
                { "class", nameof(IfcSweptDiskSolidPolygonal) },
                { "parameters" , new JArray
                    {
                        DirectrixId.ToJValue(),
                        Radius,
                        InnerRadius.ToJValue(),
                        StartParam.ToJValue(),
                        EndParam.ToJValue(),
                        FilletRadius.ToJValue(),
                    }
                }
            };
        }

        public static new IfcSweptDiskSolidPolygonal CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSweptDiskSolidPolygonal(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToOptionalDouble());
        }
        #endregion

    }
}