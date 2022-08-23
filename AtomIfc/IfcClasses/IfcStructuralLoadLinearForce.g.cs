
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
    public class IfcStructuralLoadLinearForce : IfcStructuralLoadStatic, IEquatable<IfcStructuralLoadLinearForce>
    {
        private double? _linearForceX;
        public double? LinearForceX 
        {
            get { 
                return _linearForceX; 
            }
            set { 
                _linearForceX = value;  // optional IfcLinearForceMeasure
            }
        }
        private double? _linearForceY;
        public double? LinearForceY 
        {
            get { 
                return _linearForceY; 
            }
            set { 
                _linearForceY = value;  // optional IfcLinearForceMeasure
            }
        }
        private double? _linearForceZ;
        public double? LinearForceZ 
        {
            get { 
                return _linearForceZ; 
            }
            set { 
                _linearForceZ = value;  // optional IfcLinearForceMeasure
            }
        }
        private double? _linearMomentX;
        public double? LinearMomentX 
        {
            get { 
                return _linearMomentX; 
            }
            set { 
                _linearMomentX = value;  // optional IfcLinearMomentMeasure
            }
        }
        private double? _linearMomentY;
        public double? LinearMomentY 
        {
            get { 
                return _linearMomentY; 
            }
            set { 
                _linearMomentY = value;  // optional IfcLinearMomentMeasure
            }
        }
        private double? _linearMomentZ;
        public double? LinearMomentZ 
        {
            get { 
                return _linearMomentZ; 
            }
            set { 
                _linearMomentZ = value;  // optional IfcLinearMomentMeasure
            }
        }

        public IfcStructuralLoadLinearForce(IfcId id, string name, double? linearForceX, double? linearForceY, double? linearForceZ, double? linearMomentX, double? linearMomentY, double? linearMomentZ) : base(id, name)
        {
            LinearForceX = linearForceX;
            LinearForceY = linearForceY;
            LinearForceZ = linearForceZ;
            LinearMomentX = linearMomentX;
            LinearMomentY = linearMomentY;
            LinearMomentZ = linearMomentZ;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralLoadLinearForce;

        #region Equality

        public bool Equals(IfcStructuralLoadLinearForce other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LinearForceX == other.LinearForceX
                && LinearForceY == other.LinearForceY
                && LinearForceZ == other.LinearForceZ
                && LinearMomentX == other.LinearMomentX
                && LinearMomentY == other.LinearMomentY
                && LinearMomentZ == other.LinearMomentZ;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralLoadLinearForce);

        public static bool operator ==(IfcStructuralLoadLinearForce one, IfcStructuralLoadLinearForce other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralLoadLinearForce one, IfcStructuralLoadLinearForce other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{LinearForceX},{LinearForceY},{LinearForceZ},{LinearMomentX},{LinearMomentY},{LinearMomentZ})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralLoadLinearForce (newId,Name, LinearForceX, LinearForceY, LinearForceZ, LinearMomentX, LinearMomentY, LinearMomentZ);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralLoadLinearForce },
                { "class", nameof(IfcStructuralLoadLinearForce) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        LinearForceX.ToJValue(),
                        LinearForceY.ToJValue(),
                        LinearForceZ.ToJValue(),
                        LinearMomentX.ToJValue(),
                        LinearMomentY.ToJValue(),
                        LinearMomentZ.ToJValue(),
                    }
                }
            };
        }

        public static IfcStructuralLoadLinearForce CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralLoadLinearForce(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalDouble(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToOptionalDouble(),
                parameters[6].ToOptionalDouble());
        }
        #endregion

    }
}