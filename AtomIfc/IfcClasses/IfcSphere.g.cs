
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
    public class IfcSphere : IfcCsgPrimitive3D, IEquatable<IfcSphere>
    {
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

        public IfcSphere(IfcId id, IfcId positionId, double radius) : base(id, positionId)
        {
            Radius = radius;
        }

        public override ClassId GetClassId() => ClassId.IfcSphere;

        #region Equality

        public bool Equals(IfcSphere other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Radius == other.Radius;
        }

        public override bool Equals(object other) => Equals(other as IfcSphere);

        public static bool operator ==(IfcSphere one, IfcSphere other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSphere one, IfcSphere other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PositionId},{Radius})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSphere (newId,PositionId, Radius);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSphere },
                { "class", nameof(IfcSphere) },
                { "parameters" , new JArray
                    {
                        PositionId.ToJValue(),
                        Radius,
                    }
                }
            };
        }

        public static IfcSphere CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSphere(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble());
        }
        #endregion

    }
}