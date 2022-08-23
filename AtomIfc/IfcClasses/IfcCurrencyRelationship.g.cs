
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
    public class IfcCurrencyRelationship : IfcResourceLevelRelationship, IEquatable<IfcCurrencyRelationship>
    {
        private IfcId _relatingMonetaryUnitId;
        public IfcId RelatingMonetaryUnitId 
        {
            get { 
                return _relatingMonetaryUnitId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingMonetaryUnitId is not allowed to be null"); 
                _relatingMonetaryUnitId = value;
            }
        }
        private IfcId _relatedMonetaryUnitId;
        public IfcId RelatedMonetaryUnitId 
        {
            get { 
                return _relatedMonetaryUnitId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedMonetaryUnitId is not allowed to be null"); 
                _relatedMonetaryUnitId = value;
            }
        }
        private double _exchangeRate;
        public double ExchangeRate 
        {
            get { 
                return _exchangeRate; 
            }
            set { 
                _exchangeRate = value;
            }
        }
        private string _rateDateTime;
        public string RateDateTime 
        {
            get { 
                return _rateDateTime; 
            }
            set { 
                _rateDateTime = value;  // optional IfcDateTime
            }
        }
        private IfcId _rateSourceId;
        public IfcId RateSourceId 
        {
            get { 
                return _rateSourceId; 
            }
            set { 
                _rateSourceId = value;  // optional IfcLibraryInformation
            }
        }

        public IfcCurrencyRelationship(IfcId id, string name, string description, IfcId relatingMonetaryUnitId, IfcId relatedMonetaryUnitId, double exchangeRate, string rateDateTime, IfcId rateSourceId) : base(id, name, description)
        {
            RelatingMonetaryUnitId = relatingMonetaryUnitId;
            RelatedMonetaryUnitId = relatedMonetaryUnitId;
            ExchangeRate = exchangeRate;
            RateDateTime = rateDateTime;
            RateSourceId = rateSourceId;
        }

        public override ClassId GetClassId() => ClassId.IfcCurrencyRelationship;

        #region Equality

        public bool Equals(IfcCurrencyRelationship other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingMonetaryUnitId == other.RelatingMonetaryUnitId
                && RelatedMonetaryUnitId == other.RelatedMonetaryUnitId
                && ExchangeRate == other.ExchangeRate
                && RateDateTime == other.RateDateTime
                && RateSourceId == other.RateSourceId;
        }

        public override bool Equals(object other) => Equals(other as IfcCurrencyRelationship);

        public static bool operator ==(IfcCurrencyRelationship one, IfcCurrencyRelationship other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCurrencyRelationship one, IfcCurrencyRelationship other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{RelatingMonetaryUnitId},{RelatedMonetaryUnitId},{ExchangeRate},'{RateDateTime}',{RateSourceId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingMonetaryUnitId!= null && replacementTable.ContainsKey(RelatingMonetaryUnitId))
                RelatingMonetaryUnitId = replacementTable[RelatingMonetaryUnitId];
            if(RelatedMonetaryUnitId!= null && replacementTable.ContainsKey(RelatedMonetaryUnitId))
                RelatedMonetaryUnitId = replacementTable[RelatedMonetaryUnitId];
            if(RateSourceId!= null && replacementTable.ContainsKey(RateSourceId))
                RateSourceId = replacementTable[RateSourceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCurrencyRelationship (newId,Name, Description, RelatingMonetaryUnitId, RelatedMonetaryUnitId, ExchangeRate, RateDateTime, RateSourceId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCurrencyRelationship },
                { "class", nameof(IfcCurrencyRelationship) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingMonetaryUnitId.ToJValue(),
                        RelatedMonetaryUnitId.ToJValue(),
                        ExchangeRate,
                        RateDateTime.ToJValue(),
                        RateSourceId.ToJValue(),
                    }
                }
            };
        }

        public static IfcCurrencyRelationship CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCurrencyRelationship(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcId(),
                parameters[4].ToDouble(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalIfcId());
        }
        #endregion

    }
}