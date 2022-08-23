
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
    public abstract class IfcTimeSeries : IfcBase, IEquatable<IfcTimeSeries>, IIfcMetricValueSelect, IIfcObjectReferenceSelect, IIfcResourceObjectSelect
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;
            }
        }
        private string _description;
        public string Description 
        {
            get { 
                return _description; 
            }
            set { 
                _description = value;  // optional IfcText
            }
        }
        private string _startTime;
        public string StartTime 
        {
            get { 
                return _startTime; 
            }
            set { 
                _startTime = value;
            }
        }
        private string _endTime;
        public string EndTime 
        {
            get { 
                return _endTime; 
            }
            set { 
                _endTime = value;
            }
        }
        private IfcTimeSeriesDataTypeEnum _timeSeriesDataType;
        public IfcTimeSeriesDataTypeEnum TimeSeriesDataType 
        {
            get { 
                return _timeSeriesDataType; 
            }
            set { 
                _timeSeriesDataType = value;
            }
        }
        private IfcDataOriginEnum _dataOrigin;
        public IfcDataOriginEnum DataOrigin 
        {
            get { 
                return _dataOrigin; 
            }
            set { 
                _dataOrigin = value;
            }
        }
        private string _userDefinedDataOrigin;
        public string UserDefinedDataOrigin 
        {
            get { 
                return _userDefinedDataOrigin; 
            }
            set { 
                _userDefinedDataOrigin = value;  // optional IfcLabel
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

        internal IfcTimeSeries(IfcId id, string name, string description, string startTime, string endTime, IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin, string userDefinedDataOrigin, IfcId unitId) : base(id)
        {
            Name = name;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            TimeSeriesDataType = timeSeriesDataType;
            DataOrigin = dataOrigin;
            UserDefinedDataOrigin = userDefinedDataOrigin;
            UnitId = unitId;
        }

        #region Equality

        public bool Equals(IfcTimeSeries other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description
                && StartTime == other.StartTime
                && EndTime == other.EndTime
                && TimeSeriesDataType == other.TimeSeriesDataType
                && DataOrigin == other.DataOrigin
                && UserDefinedDataOrigin == other.UserDefinedDataOrigin
                && UnitId == other.UnitId;
        }

        public override bool Equals(object other) => Equals(other as IfcTimeSeries);

        public static bool operator ==(IfcTimeSeries one, IfcTimeSeries other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTimeSeries one, IfcTimeSeries other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(UnitId!= null && replacementTable.ContainsKey(UnitId))
                UnitId = replacementTable[UnitId];
            base.ReplaceIds(replacementTable);

        }
    }
}