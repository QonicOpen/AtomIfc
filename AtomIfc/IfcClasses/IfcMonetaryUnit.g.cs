
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
    public class IfcMonetaryUnit : IfcBase, IEquatable<IfcMonetaryUnit>, IIfcUnit
    {
        private string _currency;
        public string Currency 
        {
            get { 
                return _currency; 
            }
            set { 
                _currency = value;
            }
        }

        public IfcMonetaryUnit(IfcId id, string currency) : base(id)
        {
            Currency = currency;
        }

        public override ClassId GetClassId() => ClassId.IfcMonetaryUnit;

        #region Equality

        public bool Equals(IfcMonetaryUnit other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Currency == other.Currency;
        }

        public override bool Equals(object other) => Equals(other as IfcMonetaryUnit);

        public static bool operator ==(IfcMonetaryUnit one, IfcMonetaryUnit other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMonetaryUnit one, IfcMonetaryUnit other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Currency}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMonetaryUnit (newId,Currency);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMonetaryUnit },
                { "class", nameof(IfcMonetaryUnit) },
                { "parameters" , new JArray
                    {
                        Currency.ToJValue(),
                    }
                }
            };
        }

        public static IfcMonetaryUnit CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMonetaryUnit(
                jObject["id"].ToIfcId(),
                parameters[0].ToString());
        }
        #endregion

    }
}