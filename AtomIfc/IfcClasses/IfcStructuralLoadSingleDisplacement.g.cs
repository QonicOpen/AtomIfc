
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
    public class IfcStructuralLoadSingleDisplacement : IfcStructuralLoadStatic, IEquatable<IfcStructuralLoadSingleDisplacement>
    {
        private double? _displacementX;
        public double? DisplacementX 
        {
            get { 
                return _displacementX; 
            }
            set { 
                _displacementX = value;  // optional IfcLengthMeasure
            }
        }
        private double? _displacementY;
        public double? DisplacementY 
        {
            get { 
                return _displacementY; 
            }
            set { 
                _displacementY = value;  // optional IfcLengthMeasure
            }
        }
        private double? _displacementZ;
        public double? DisplacementZ 
        {
            get { 
                return _displacementZ; 
            }
            set { 
                _displacementZ = value;  // optional IfcLengthMeasure
            }
        }
        private double? _rotationalDisplacementRX;
        public double? RotationalDisplacementRX 
        {
            get { 
                return _rotationalDisplacementRX; 
            }
            set { 
                _rotationalDisplacementRX = value;  // optional IfcPlaneAngleMeasure
            }
        }
        private double? _rotationalDisplacementRY;
        public double? RotationalDisplacementRY 
        {
            get { 
                return _rotationalDisplacementRY; 
            }
            set { 
                _rotationalDisplacementRY = value;  // optional IfcPlaneAngleMeasure
            }
        }
        private double? _rotationalDisplacementRZ;
        public double? RotationalDisplacementRZ 
        {
            get { 
                return _rotationalDisplacementRZ; 
            }
            set { 
                _rotationalDisplacementRZ = value;  // optional IfcPlaneAngleMeasure
            }
        }

        public IfcStructuralLoadSingleDisplacement(IfcId id, string name, double? displacementX, double? displacementY, double? displacementZ, double? rotationalDisplacementRX, double? rotationalDisplacementRY, double? rotationalDisplacementRZ) : base(id, name)
        {
            DisplacementX = displacementX;
            DisplacementY = displacementY;
            DisplacementZ = displacementZ;
            RotationalDisplacementRX = rotationalDisplacementRX;
            RotationalDisplacementRY = rotationalDisplacementRY;
            RotationalDisplacementRZ = rotationalDisplacementRZ;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralLoadSingleDisplacement;

        #region Equality

        public bool Equals(IfcStructuralLoadSingleDisplacement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && DisplacementX == other.DisplacementX
                && DisplacementY == other.DisplacementY
                && DisplacementZ == other.DisplacementZ
                && RotationalDisplacementRX == other.RotationalDisplacementRX
                && RotationalDisplacementRY == other.RotationalDisplacementRY
                && RotationalDisplacementRZ == other.RotationalDisplacementRZ;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralLoadSingleDisplacement);

        public static bool operator ==(IfcStructuralLoadSingleDisplacement one, IfcStructuralLoadSingleDisplacement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralLoadSingleDisplacement one, IfcStructuralLoadSingleDisplacement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{DisplacementX},{DisplacementY},{DisplacementZ},{RotationalDisplacementRX},{RotationalDisplacementRY},{RotationalDisplacementRZ})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralLoadSingleDisplacement (newId,Name, DisplacementX, DisplacementY, DisplacementZ, RotationalDisplacementRX, RotationalDisplacementRY, RotationalDisplacementRZ);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralLoadSingleDisplacement },
                { "class", nameof(IfcStructuralLoadSingleDisplacement) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        DisplacementX.ToJValue(),
                        DisplacementY.ToJValue(),
                        DisplacementZ.ToJValue(),
                        RotationalDisplacementRX.ToJValue(),
                        RotationalDisplacementRY.ToJValue(),
                        RotationalDisplacementRZ.ToJValue(),
                    }
                }
            };
        }

        public static IfcStructuralLoadSingleDisplacement CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralLoadSingleDisplacement(
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