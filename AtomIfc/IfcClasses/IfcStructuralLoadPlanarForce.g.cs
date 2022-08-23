
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
    public class IfcStructuralLoadPlanarForce : IfcStructuralLoadStatic, IEquatable<IfcStructuralLoadPlanarForce>
    {
        private double? _planarForceX;
        public double? PlanarForceX 
        {
            get { 
                return _planarForceX; 
            }
            set { 
                _planarForceX = value;  // optional IfcPlanarForceMeasure
            }
        }
        private double? _planarForceY;
        public double? PlanarForceY 
        {
            get { 
                return _planarForceY; 
            }
            set { 
                _planarForceY = value;  // optional IfcPlanarForceMeasure
            }
        }
        private double? _planarForceZ;
        public double? PlanarForceZ 
        {
            get { 
                return _planarForceZ; 
            }
            set { 
                _planarForceZ = value;  // optional IfcPlanarForceMeasure
            }
        }

        public IfcStructuralLoadPlanarForce(IfcId id, string name, double? planarForceX, double? planarForceY, double? planarForceZ) : base(id, name)
        {
            PlanarForceX = planarForceX;
            PlanarForceY = planarForceY;
            PlanarForceZ = planarForceZ;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralLoadPlanarForce;

        #region Equality

        public bool Equals(IfcStructuralLoadPlanarForce other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PlanarForceX == other.PlanarForceX
                && PlanarForceY == other.PlanarForceY
                && PlanarForceZ == other.PlanarForceZ;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralLoadPlanarForce);

        public static bool operator ==(IfcStructuralLoadPlanarForce one, IfcStructuralLoadPlanarForce other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralLoadPlanarForce one, IfcStructuralLoadPlanarForce other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{PlanarForceX},{PlanarForceY},{PlanarForceZ})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralLoadPlanarForce (newId,Name, PlanarForceX, PlanarForceY, PlanarForceZ);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralLoadPlanarForce },
                { "class", nameof(IfcStructuralLoadPlanarForce) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        PlanarForceX.ToJValue(),
                        PlanarForceY.ToJValue(),
                        PlanarForceZ.ToJValue(),
                    }
                }
            };
        }

        public static IfcStructuralLoadPlanarForce CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralLoadPlanarForce(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalDouble(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble());
        }
        #endregion

    }
}