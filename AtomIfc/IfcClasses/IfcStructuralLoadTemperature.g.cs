
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
    public class IfcStructuralLoadTemperature : IfcStructuralLoadStatic, IEquatable<IfcStructuralLoadTemperature>
    {
        private double? _deltaTConstant;
        public double? DeltaTConstant 
        {
            get { 
                return _deltaTConstant; 
            }
            set { 
                _deltaTConstant = value;  // optional IfcThermodynamicTemperatureMeasure
            }
        }
        private double? _deltaTY;
        public double? DeltaTY 
        {
            get { 
                return _deltaTY; 
            }
            set { 
                _deltaTY = value;  // optional IfcThermodynamicTemperatureMeasure
            }
        }
        private double? _deltaTZ;
        public double? DeltaTZ 
        {
            get { 
                return _deltaTZ; 
            }
            set { 
                _deltaTZ = value;  // optional IfcThermodynamicTemperatureMeasure
            }
        }

        public IfcStructuralLoadTemperature(IfcId id, string name, double? deltaTConstant, double? deltaTY, double? deltaTZ) : base(id, name)
        {
            DeltaTConstant = deltaTConstant;
            DeltaTY = deltaTY;
            DeltaTZ = deltaTZ;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralLoadTemperature;

        #region Equality

        public bool Equals(IfcStructuralLoadTemperature other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && DeltaTConstant == other.DeltaTConstant
                && DeltaTY == other.DeltaTY
                && DeltaTZ == other.DeltaTZ;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralLoadTemperature);

        public static bool operator ==(IfcStructuralLoadTemperature one, IfcStructuralLoadTemperature other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralLoadTemperature one, IfcStructuralLoadTemperature other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{DeltaTConstant},{DeltaTY},{DeltaTZ})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralLoadTemperature (newId,Name, DeltaTConstant, DeltaTY, DeltaTZ);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralLoadTemperature },
                { "class", nameof(IfcStructuralLoadTemperature) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        DeltaTConstant.ToJValue(),
                        DeltaTY.ToJValue(),
                        DeltaTZ.ToJValue(),
                    }
                }
            };
        }

        public static IfcStructuralLoadTemperature CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralLoadTemperature(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalDouble(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble());
        }
        #endregion

    }
}