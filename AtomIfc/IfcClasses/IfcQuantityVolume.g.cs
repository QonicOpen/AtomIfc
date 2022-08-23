
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
    public class IfcQuantityVolume : IfcPhysicalSimpleQuantity, IEquatable<IfcQuantityVolume>
    {
        private double _volumeValue;
        public double VolumeValue 
        {
            get { 
                return _volumeValue; 
            }
            set { 
                _volumeValue = value;
            }
        }
        private string _formula;
        public string Formula 
        {
            get { 
                return _formula; 
            }
            set { 
                _formula = value;  // optional IfcLabel
            }
        }

        public IfcQuantityVolume(IfcId id, string name, string description, IfcId unitId, double volumeValue, string formula) : base(id, name, description, unitId)
        {
            VolumeValue = volumeValue;
            Formula = formula;
        }

        public override ClassId GetClassId() => ClassId.IfcQuantityVolume;

        #region Equality

        public bool Equals(IfcQuantityVolume other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && VolumeValue == other.VolumeValue
                && Formula == other.Formula;
        }

        public override bool Equals(object other) => Equals(other as IfcQuantityVolume);

        public static bool operator ==(IfcQuantityVolume one, IfcQuantityVolume other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcQuantityVolume one, IfcQuantityVolume other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{UnitId},{VolumeValue},'{Formula}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcQuantityVolume (newId,Name, Description, UnitId, VolumeValue, Formula);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcQuantityVolume },
                { "class", nameof(IfcQuantityVolume) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        UnitId.ToJValue(),
                        VolumeValue,
                        Formula.ToJValue(),
                    }
                }
            };
        }

        public static IfcQuantityVolume CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcQuantityVolume(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToOptionalString());
        }
        #endregion

    }
}