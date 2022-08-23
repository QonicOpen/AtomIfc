
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
    public class IfcPropertyBoundedValue : IfcSimpleProperty, IEquatable<IfcPropertyBoundedValue>
    {
        private IfcId _upperBoundValueId;
        public IfcId UpperBoundValueId 
        {
            get { 
                return _upperBoundValueId; 
            }
            set { 
                _upperBoundValueId = value;  // optional IfcValue
            }
        }
        private IfcId _lowerBoundValueId;
        public IfcId LowerBoundValueId 
        {
            get { 
                return _lowerBoundValueId; 
            }
            set { 
                _lowerBoundValueId = value;  // optional IfcValue
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
        private IfcId _setPointValueId;
        public IfcId SetPointValueId 
        {
            get { 
                return _setPointValueId; 
            }
            set { 
                _setPointValueId = value;  // optional IfcValue
            }
        }

        public IfcPropertyBoundedValue(IfcId id, string name, string description, IfcId upperBoundValueId, IfcId lowerBoundValueId, IfcId unitId, IfcId setPointValueId) : base(id, name, description)
        {
            UpperBoundValueId = upperBoundValueId;
            LowerBoundValueId = lowerBoundValueId;
            UnitId = unitId;
            SetPointValueId = setPointValueId;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertyBoundedValue;

        #region Equality

        public bool Equals(IfcPropertyBoundedValue other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && UpperBoundValueId == other.UpperBoundValueId
                && LowerBoundValueId == other.LowerBoundValueId
                && UnitId == other.UnitId
                && SetPointValueId == other.SetPointValueId;
        }

        public override bool Equals(object other) => Equals(other as IfcPropertyBoundedValue);

        public static bool operator ==(IfcPropertyBoundedValue one, IfcPropertyBoundedValue other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertyBoundedValue one, IfcPropertyBoundedValue other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{UpperBoundValueId},{LowerBoundValueId},{UnitId},{SetPointValueId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(UpperBoundValueId!= null && replacementTable.ContainsKey(UpperBoundValueId))
                UpperBoundValueId = replacementTable[UpperBoundValueId];
            if(LowerBoundValueId!= null && replacementTable.ContainsKey(LowerBoundValueId))
                LowerBoundValueId = replacementTable[LowerBoundValueId];
            if(UnitId!= null && replacementTable.ContainsKey(UnitId))
                UnitId = replacementTable[UnitId];
            if(SetPointValueId!= null && replacementTable.ContainsKey(SetPointValueId))
                SetPointValueId = replacementTable[SetPointValueId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertyBoundedValue (newId,Name, Description, UpperBoundValueId, LowerBoundValueId, UnitId, SetPointValueId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertyBoundedValue },
                { "class", nameof(IfcPropertyBoundedValue) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        UpperBoundValueId.ToJValue(),
                        LowerBoundValueId.ToJValue(),
                        UnitId.ToJValue(),
                        SetPointValueId.ToJValue(),
                    }
                }
            };
        }

        public static IfcPropertyBoundedValue CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertyBoundedValue(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalIfcId(),
                parameters[5].ToOptionalIfcId());
        }
        #endregion

    }
}