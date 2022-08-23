
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
    public class IfcDimensionalExponents : IfcBase, IEquatable<IfcDimensionalExponents>
    {
        private int _lengthExponent;
        public int LengthExponent 
        {
            get { 
                return _lengthExponent; 
            }
            set { 
                _lengthExponent = value;
            }
        }
        private int _massExponent;
        public int MassExponent 
        {
            get { 
                return _massExponent; 
            }
            set { 
                _massExponent = value;
            }
        }
        private int _timeExponent;
        public int TimeExponent 
        {
            get { 
                return _timeExponent; 
            }
            set { 
                _timeExponent = value;
            }
        }
        private int _electricCurrentExponent;
        public int ElectricCurrentExponent 
        {
            get { 
                return _electricCurrentExponent; 
            }
            set { 
                _electricCurrentExponent = value;
            }
        }
        private int _thermodynamicTemperatureExponent;
        public int ThermodynamicTemperatureExponent 
        {
            get { 
                return _thermodynamicTemperatureExponent; 
            }
            set { 
                _thermodynamicTemperatureExponent = value;
            }
        }
        private int _amountOfSubstanceExponent;
        public int AmountOfSubstanceExponent 
        {
            get { 
                return _amountOfSubstanceExponent; 
            }
            set { 
                _amountOfSubstanceExponent = value;
            }
        }
        private int _luminousIntensityExponent;
        public int LuminousIntensityExponent 
        {
            get { 
                return _luminousIntensityExponent; 
            }
            set { 
                _luminousIntensityExponent = value;
            }
        }

        public IfcDimensionalExponents(IfcId id, int lengthExponent, int massExponent, int timeExponent, int electricCurrentExponent, int thermodynamicTemperatureExponent, int amountOfSubstanceExponent, int luminousIntensityExponent) : base(id)
        {
            LengthExponent = lengthExponent;
            MassExponent = massExponent;
            TimeExponent = timeExponent;
            ElectricCurrentExponent = electricCurrentExponent;
            ThermodynamicTemperatureExponent = thermodynamicTemperatureExponent;
            AmountOfSubstanceExponent = amountOfSubstanceExponent;
            LuminousIntensityExponent = luminousIntensityExponent;
        }

        public override ClassId GetClassId() => ClassId.IfcDimensionalExponents;

        #region Equality

        public bool Equals(IfcDimensionalExponents other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LengthExponent == other.LengthExponent
                && MassExponent == other.MassExponent
                && TimeExponent == other.TimeExponent
                && ElectricCurrentExponent == other.ElectricCurrentExponent
                && ThermodynamicTemperatureExponent == other.ThermodynamicTemperatureExponent
                && AmountOfSubstanceExponent == other.AmountOfSubstanceExponent
                && LuminousIntensityExponent == other.LuminousIntensityExponent;
        }

        public override bool Equals(object other) => Equals(other as IfcDimensionalExponents);

        public static bool operator ==(IfcDimensionalExponents one, IfcDimensionalExponents other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDimensionalExponents one, IfcDimensionalExponents other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({LengthExponent},{MassExponent},{TimeExponent},{ElectricCurrentExponent},{ThermodynamicTemperatureExponent},{AmountOfSubstanceExponent},{LuminousIntensityExponent})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDimensionalExponents (newId,LengthExponent, MassExponent, TimeExponent, ElectricCurrentExponent, ThermodynamicTemperatureExponent, AmountOfSubstanceExponent, LuminousIntensityExponent);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDimensionalExponents },
                { "class", nameof(IfcDimensionalExponents) },
                { "parameters" , new JArray
                    {
                        LengthExponent,
                        MassExponent,
                        TimeExponent,
                        ElectricCurrentExponent,
                        ThermodynamicTemperatureExponent,
                        AmountOfSubstanceExponent,
                        LuminousIntensityExponent,
                    }
                }
            };
        }

        public static IfcDimensionalExponents CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDimensionalExponents(
                jObject["id"].ToIfcId(),
                parameters[0].ToInt(),
                parameters[1].ToInt(),
                parameters[2].ToInt(),
                parameters[3].ToInt(),
                parameters[4].ToInt(),
                parameters[5].ToInt(),
                parameters[6].ToInt());
        }
        #endregion

    }
}