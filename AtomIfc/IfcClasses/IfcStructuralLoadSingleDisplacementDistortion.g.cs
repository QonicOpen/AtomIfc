
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
    public class IfcStructuralLoadSingleDisplacementDistortion : IfcStructuralLoadSingleDisplacement, IEquatable<IfcStructuralLoadSingleDisplacementDistortion>
    {
        private double? _distortion;
        public double? Distortion 
        {
            get { 
                return _distortion; 
            }
            set { 
                _distortion = value;  // optional IfcCurvatureMeasure
            }
        }

        public IfcStructuralLoadSingleDisplacementDistortion(IfcId id, string name, double? displacementX, double? displacementY, double? displacementZ, double? rotationalDisplacementRX, double? rotationalDisplacementRY, double? rotationalDisplacementRZ, double? distortion) : base(id, name, displacementX, displacementY, displacementZ, rotationalDisplacementRX, rotationalDisplacementRY, rotationalDisplacementRZ)
        {
            Distortion = distortion;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralLoadSingleDisplacementDistortion;

        #region Equality

        public bool Equals(IfcStructuralLoadSingleDisplacementDistortion other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Distortion == other.Distortion;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralLoadSingleDisplacementDistortion);

        public static bool operator ==(IfcStructuralLoadSingleDisplacementDistortion one, IfcStructuralLoadSingleDisplacementDistortion other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralLoadSingleDisplacementDistortion one, IfcStructuralLoadSingleDisplacementDistortion other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{DisplacementX},{DisplacementY},{DisplacementZ},{RotationalDisplacementRX},{RotationalDisplacementRY},{RotationalDisplacementRZ},{Distortion})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralLoadSingleDisplacementDistortion (newId,Name, DisplacementX, DisplacementY, DisplacementZ, RotationalDisplacementRX, RotationalDisplacementRY, RotationalDisplacementRZ, Distortion);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralLoadSingleDisplacementDistortion },
                { "class", nameof(IfcStructuralLoadSingleDisplacementDistortion) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        DisplacementX.ToJValue(),
                        DisplacementY.ToJValue(),
                        DisplacementZ.ToJValue(),
                        RotationalDisplacementRX.ToJValue(),
                        RotationalDisplacementRY.ToJValue(),
                        RotationalDisplacementRZ.ToJValue(),
                        Distortion.ToJValue(),
                    }
                }
            };
        }

        public static new IfcStructuralLoadSingleDisplacementDistortion CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralLoadSingleDisplacementDistortion(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalDouble(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToOptionalDouble(),
                parameters[6].ToOptionalDouble(),
                parameters[7].ToOptionalDouble());
        }
        #endregion

    }
}