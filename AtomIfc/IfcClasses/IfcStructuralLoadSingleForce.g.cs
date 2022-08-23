
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
    public class IfcStructuralLoadSingleForce : IfcStructuralLoadStatic, IEquatable<IfcStructuralLoadSingleForce>
    {
        private double? _forceX;
        public double? ForceX 
        {
            get { 
                return _forceX; 
            }
            set { 
                _forceX = value;  // optional IfcForceMeasure
            }
        }
        private double? _forceY;
        public double? ForceY 
        {
            get { 
                return _forceY; 
            }
            set { 
                _forceY = value;  // optional IfcForceMeasure
            }
        }
        private double? _forceZ;
        public double? ForceZ 
        {
            get { 
                return _forceZ; 
            }
            set { 
                _forceZ = value;  // optional IfcForceMeasure
            }
        }
        private double? _momentX;
        public double? MomentX 
        {
            get { 
                return _momentX; 
            }
            set { 
                _momentX = value;  // optional IfcTorqueMeasure
            }
        }
        private double? _momentY;
        public double? MomentY 
        {
            get { 
                return _momentY; 
            }
            set { 
                _momentY = value;  // optional IfcTorqueMeasure
            }
        }
        private double? _momentZ;
        public double? MomentZ 
        {
            get { 
                return _momentZ; 
            }
            set { 
                _momentZ = value;  // optional IfcTorqueMeasure
            }
        }

        public IfcStructuralLoadSingleForce(IfcId id, string name, double? forceX, double? forceY, double? forceZ, double? momentX, double? momentY, double? momentZ) : base(id, name)
        {
            ForceX = forceX;
            ForceY = forceY;
            ForceZ = forceZ;
            MomentX = momentX;
            MomentY = momentY;
            MomentZ = momentZ;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralLoadSingleForce;

        #region Equality

        public bool Equals(IfcStructuralLoadSingleForce other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ForceX == other.ForceX
                && ForceY == other.ForceY
                && ForceZ == other.ForceZ
                && MomentX == other.MomentX
                && MomentY == other.MomentY
                && MomentZ == other.MomentZ;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralLoadSingleForce);

        public static bool operator ==(IfcStructuralLoadSingleForce one, IfcStructuralLoadSingleForce other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralLoadSingleForce one, IfcStructuralLoadSingleForce other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{ForceX},{ForceY},{ForceZ},{MomentX},{MomentY},{MomentZ})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralLoadSingleForce (newId,Name, ForceX, ForceY, ForceZ, MomentX, MomentY, MomentZ);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralLoadSingleForce },
                { "class", nameof(IfcStructuralLoadSingleForce) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        ForceX.ToJValue(),
                        ForceY.ToJValue(),
                        ForceZ.ToJValue(),
                        MomentX.ToJValue(),
                        MomentY.ToJValue(),
                        MomentZ.ToJValue(),
                    }
                }
            };
        }

        public static IfcStructuralLoadSingleForce CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralLoadSingleForce(
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