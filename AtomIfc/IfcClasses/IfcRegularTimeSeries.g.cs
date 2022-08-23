
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
    public class IfcRegularTimeSeries : IfcTimeSeries, IEquatable<IfcRegularTimeSeries>
    {
        private double _timeStep;
        public double TimeStep 
        {
            get { 
                return _timeStep; 
            }
            set { 
                _timeStep = value;
            }
        }
        private List<IfcId> _valueIds;
        public List<IfcId> ValueIds 
        {
            get { 
                return _valueIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ValueIds is not allowed to be null"); 
                _valueIds = value;
            }
        }

        public IfcRegularTimeSeries(IfcId id, string name, string description, string startTime, string endTime, IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin, string userDefinedDataOrigin, IfcId unitId, double timeStep, List<IfcId> valueIds) : base(id, name, description, startTime, endTime, timeSeriesDataType, dataOrigin, userDefinedDataOrigin, unitId)
        {
            TimeStep = timeStep;
            ValueIds = valueIds;
        }

        public override ClassId GetClassId() => ClassId.IfcRegularTimeSeries;

        #region Equality

        public bool Equals(IfcRegularTimeSeries other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ValueIds, other.ValueIds))
                return false;
            return base.Equals(other)
                && TimeStep == other.TimeStep;
        }

        public override bool Equals(object other) => Equals(other as IfcRegularTimeSeries);

        public static bool operator ==(IfcRegularTimeSeries one, IfcRegularTimeSeries other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRegularTimeSeries one, IfcRegularTimeSeries other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}','{StartTime}','{EndTime}',.{TimeSeriesDataType}.,.{DataOrigin}.,'{UserDefinedDataOrigin}',{UnitId},{TimeStep},{Utils.ConvertListToString(ValueIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ValueIds!= null)
                ValueIds = ValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRegularTimeSeries (newId,Name, Description, StartTime, EndTime, TimeSeriesDataType, DataOrigin, UserDefinedDataOrigin, UnitId, TimeStep, ValueIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRegularTimeSeries },
                { "class", nameof(IfcRegularTimeSeries) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        StartTime.ToJValue(),
                        EndTime.ToJValue(),
                        TimeSeriesDataType.ToJValue(),
                        DataOrigin.ToJValue(),
                        UserDefinedDataOrigin.ToJValue(),
                        UnitId.ToJValue(),
                        TimeStep,
                        ValueIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcRegularTimeSeries CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRegularTimeSeries(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToString(),
                parameters[3].ToString(),
                (IfcTimeSeriesDataTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcTimeSeriesDataTypeEnum](parameters[4].ToString()),
                (IfcDataOriginEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDataOriginEnum](parameters[5].ToString()),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalIfcId(),
                parameters[8].ToDouble(),
                parameters[9].ToIfcIdList());
        }
        #endregion

    }
}