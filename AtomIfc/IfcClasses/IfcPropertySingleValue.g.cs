
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
    public class IfcPropertySingleValue : IfcSimpleProperty, IEquatable<IfcPropertySingleValue>
    {
        private IfcId _nominalValueId;
        public IfcId NominalValueId 
        {
            get { 
                return _nominalValueId; 
            }
            set { 
                _nominalValueId = value;  // optional IfcValue
            }
        }
        private IfcId _unitId;
        public IfcId UnitId 
        {
            get { 
                return _unitId; 
            }
            set { 
                _unitId = value;  // optional IfcUnit
            }
        }

        public IfcPropertySingleValue(IfcId id, string name, string description, IfcId nominalValueId, IfcId unitId) : base(id, name, description)
        {
            NominalValueId = nominalValueId;
            UnitId = unitId;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertySingleValue;

        #region Equality

        public bool Equals(IfcPropertySingleValue other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && NominalValueId == other.NominalValueId
                && UnitId == other.UnitId;
        }

        public override bool Equals(object other) => Equals(other as IfcPropertySingleValue);

        public static bool operator ==(IfcPropertySingleValue one, IfcPropertySingleValue other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertySingleValue one, IfcPropertySingleValue other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{NominalValueId},{UnitId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(NominalValueId!= null && replacementTable.ContainsKey(NominalValueId))
                NominalValueId = replacementTable[NominalValueId];
            if(UnitId!= null && replacementTable.ContainsKey(UnitId))
                UnitId = replacementTable[UnitId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertySingleValue (newId,Name, Description, NominalValueId, UnitId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertySingleValue },
                { "class", nameof(IfcPropertySingleValue) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        NominalValueId.ToJValue(),
                        UnitId.ToJValue(),
                    }
                }
            };
        }

        public static IfcPropertySingleValue CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertySingleValue(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalIfcId());
        }
        #endregion

    }
}