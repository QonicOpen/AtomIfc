
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
    public class IfcMeasureWithUnit : IfcBase, IEquatable<IfcMeasureWithUnit>, IIfcAppliedValueSelect, IIfcMetricValueSelect
    {
        private IfcId _valueComponentId;
        public IfcId ValueComponentId 
        {
            get { 
                return _valueComponentId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ValueComponentId is not allowed to be null"); 
                _valueComponentId = value;
            }
        }
        private IfcId _unitComponentId;
        public IfcId UnitComponentId 
        {
            get { 
                return _unitComponentId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("UnitComponentId is not allowed to be null"); 
                _unitComponentId = value;
            }
        }

        public IfcMeasureWithUnit(IfcId id, IfcId valueComponentId, IfcId unitComponentId) : base(id)
        {
            ValueComponentId = valueComponentId;
            UnitComponentId = unitComponentId;
        }

        public override ClassId GetClassId() => ClassId.IfcMeasureWithUnit;

        #region Equality

        public bool Equals(IfcMeasureWithUnit other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ValueComponentId == other.ValueComponentId
                && UnitComponentId == other.UnitComponentId;
        }

        public override bool Equals(object other) => Equals(other as IfcMeasureWithUnit);

        public static bool operator ==(IfcMeasureWithUnit one, IfcMeasureWithUnit other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMeasureWithUnit one, IfcMeasureWithUnit other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({ValueComponentId},{UnitComponentId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ValueComponentId!= null && replacementTable.ContainsKey(ValueComponentId))
                ValueComponentId = replacementTable[ValueComponentId];
            if(UnitComponentId!= null && replacementTable.ContainsKey(UnitComponentId))
                UnitComponentId = replacementTable[UnitComponentId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMeasureWithUnit (newId,ValueComponentId, UnitComponentId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMeasureWithUnit },
                { "class", nameof(IfcMeasureWithUnit) },
                { "parameters" , new JArray
                    {
                        ValueComponentId.ToJValue(),
                        UnitComponentId.ToJValue(),
                    }
                }
            };
        }

        public static IfcMeasureWithUnit CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMeasureWithUnit(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId());
        }
        #endregion

    }
}