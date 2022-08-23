
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
    public class IfcConnectionPointEccentricity : IfcConnectionPointGeometry, IEquatable<IfcConnectionPointEccentricity>
    {
        private double? _eccentricityInX;
        public double? EccentricityInX 
        {
            get { 
                return _eccentricityInX; 
            }
            set { 
                _eccentricityInX = value;  // optional IfcLengthMeasure
            }
        }
        private double? _eccentricityInY;
        public double? EccentricityInY 
        {
            get { 
                return _eccentricityInY; 
            }
            set { 
                _eccentricityInY = value;  // optional IfcLengthMeasure
            }
        }
        private double? _eccentricityInZ;
        public double? EccentricityInZ 
        {
            get { 
                return _eccentricityInZ; 
            }
            set { 
                _eccentricityInZ = value;  // optional IfcLengthMeasure
            }
        }

        public IfcConnectionPointEccentricity(IfcId id, IfcId pointOnRelatingElementId, IfcId pointOnRelatedElementId, double? eccentricityInX, double? eccentricityInY, double? eccentricityInZ) : base(id, pointOnRelatingElementId, pointOnRelatedElementId)
        {
            EccentricityInX = eccentricityInX;
            EccentricityInY = eccentricityInY;
            EccentricityInZ = eccentricityInZ;
        }

        public override ClassId GetClassId() => ClassId.IfcConnectionPointEccentricity;

        #region Equality

        public bool Equals(IfcConnectionPointEccentricity other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && EccentricityInX == other.EccentricityInX
                && EccentricityInY == other.EccentricityInY
                && EccentricityInZ == other.EccentricityInZ;
        }

        public override bool Equals(object other) => Equals(other as IfcConnectionPointEccentricity);

        public static bool operator ==(IfcConnectionPointEccentricity one, IfcConnectionPointEccentricity other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConnectionPointEccentricity one, IfcConnectionPointEccentricity other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PointOnRelatingElementId},{PointOnRelatedElementId},{EccentricityInX},{EccentricityInY},{EccentricityInZ})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcConnectionPointEccentricity (newId,PointOnRelatingElementId, PointOnRelatedElementId, EccentricityInX, EccentricityInY, EccentricityInZ);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcConnectionPointEccentricity },
                { "class", nameof(IfcConnectionPointEccentricity) },
                { "parameters" , new JArray
                    {
                        PointOnRelatingElementId.ToJValue(),
                        PointOnRelatedElementId.ToJValue(),
                        EccentricityInX.ToJValue(),
                        EccentricityInY.ToJValue(),
                        EccentricityInZ.ToJValue(),
                    }
                }
            };
        }

        public static new IfcConnectionPointEccentricity CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcConnectionPointEccentricity(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalDouble());
        }
        #endregion

    }
}