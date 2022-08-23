
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
    public class IfcSoundPowerMeasure : IfcBase, IEquatable<IfcSoundPowerMeasure>, IIfcDerivedMeasureValue
    {
        private double _value;
        public double Value 
        {
            get { 
                return _value; 
            }
            set { 
                _value = value;
            }
        }

        public IfcSoundPowerMeasure(IfcId id, double value) : base(id)
        {
            Value = value;
        }

        public override ClassId GetClassId() => ClassId.IfcSoundPowerMeasure;

        #region Equality

        public bool Equals(IfcSoundPowerMeasure other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Value == other.Value;
        }

        public override bool Equals(object other) => Equals(other as IfcSoundPowerMeasure);

        public static bool operator ==(IfcSoundPowerMeasure one, IfcSoundPowerMeasure other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSoundPowerMeasure one, IfcSoundPowerMeasure other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Value})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSoundPowerMeasure (newId,Value);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSoundPowerMeasure },
                { "class", nameof(IfcSoundPowerMeasure) },
                { "parameters" , new JArray
                    {
                        Value,
                    }
                }
            };
        }

        public static IfcSoundPowerMeasure CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSoundPowerMeasure(
                jObject["id"].ToIfcId(),
                parameters[0].ToDouble());
        }
        #endregion

    }
}