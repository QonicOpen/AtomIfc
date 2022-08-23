
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
    public class IfcSurfaceStyleRefraction : IfcPresentationItem, IEquatable<IfcSurfaceStyleRefraction>, IIfcSurfaceStyleElementSelect
    {
        private double? _refractionIndex;
        public double? RefractionIndex 
        {
            get { 
                return _refractionIndex; 
            }
            set { 
                _refractionIndex = value;  // optional IfcReal
            }
        }
        private double? _dispersionFactor;
        public double? DispersionFactor 
        {
            get { 
                return _dispersionFactor; 
            }
            set { 
                _dispersionFactor = value;  // optional IfcReal
            }
        }

        public IfcSurfaceStyleRefraction(IfcId id, double? refractionIndex, double? dispersionFactor) : base(id)
        {
            RefractionIndex = refractionIndex;
            DispersionFactor = dispersionFactor;
        }

        public override ClassId GetClassId() => ClassId.IfcSurfaceStyleRefraction;

        #region Equality

        public bool Equals(IfcSurfaceStyleRefraction other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RefractionIndex == other.RefractionIndex
                && DispersionFactor == other.DispersionFactor;
        }

        public override bool Equals(object other) => Equals(other as IfcSurfaceStyleRefraction);

        public static bool operator ==(IfcSurfaceStyleRefraction one, IfcSurfaceStyleRefraction other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSurfaceStyleRefraction one, IfcSurfaceStyleRefraction other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({RefractionIndex},{DispersionFactor})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSurfaceStyleRefraction (newId,RefractionIndex, DispersionFactor);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSurfaceStyleRefraction },
                { "class", nameof(IfcSurfaceStyleRefraction) },
                { "parameters" , new JArray
                    {
                        RefractionIndex.ToJValue(),
                        DispersionFactor.ToJValue(),
                    }
                }
            };
        }

        public static IfcSurfaceStyleRefraction CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSurfaceStyleRefraction(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalDouble(),
                parameters[1].ToOptionalDouble());
        }
        #endregion

    }
}