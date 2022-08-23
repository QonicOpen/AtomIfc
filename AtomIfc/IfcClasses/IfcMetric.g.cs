
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
    public class IfcMetric : IfcConstraint, IEquatable<IfcMetric>
    {
        private IfcBenchmarkEnum _benchmark;
        public IfcBenchmarkEnum Benchmark 
        {
            get { 
                return _benchmark; 
            }
            set { 
                _benchmark = value;
            }
        }
        private string _valueSource;
        public string ValueSource 
        {
            get { 
                return _valueSource; 
            }
            set { 
                _valueSource = value;  // optional IfcLabel
            }
        }
        private IfcId _dataValueId;
        public IfcId DataValueId 
        {
            get { 
                return _dataValueId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("DataValueId is not allowed to be null"); 
                _dataValueId = value;
            }
        }
        private IfcId _referencePathId;
        public IfcId ReferencePathId 
        {
            get { 
                return _referencePathId; 
            }
            set { 
                _referencePathId = value;  // optional IfcReference
            }
        }

        public IfcMetric(IfcId id, string name, string description, IfcConstraintEnum constraintGrade, string constraintSource, IfcId creatingActorId, string creationTime, string userDefinedGrade, IfcBenchmarkEnum benchmark, string valueSource, IfcId dataValueId, IfcId referencePathId) : base(id, name, description, constraintGrade, constraintSource, creatingActorId, creationTime, userDefinedGrade)
        {
            Benchmark = benchmark;
            ValueSource = valueSource;
            DataValueId = dataValueId;
            ReferencePathId = referencePathId;
        }

        public override ClassId GetClassId() => ClassId.IfcMetric;

        #region Equality

        public bool Equals(IfcMetric other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Benchmark == other.Benchmark
                && ValueSource == other.ValueSource
                && DataValueId == other.DataValueId
                && ReferencePathId == other.ReferencePathId;
        }

        public override bool Equals(object other) => Equals(other as IfcMetric);

        public static bool operator ==(IfcMetric one, IfcMetric other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMetric one, IfcMetric other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',.{ConstraintGrade}.,'{ConstraintSource}',{CreatingActorId},'{CreationTime}','{UserDefinedGrade}',.{Benchmark}.,'{ValueSource}',{DataValueId},{ReferencePathId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DataValueId!= null && replacementTable.ContainsKey(DataValueId))
                DataValueId = replacementTable[DataValueId];
            if(ReferencePathId!= null && replacementTable.ContainsKey(ReferencePathId))
                ReferencePathId = replacementTable[ReferencePathId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMetric (newId,Name, Description, ConstraintGrade, ConstraintSource, CreatingActorId, CreationTime, UserDefinedGrade, Benchmark, ValueSource, DataValueId, ReferencePathId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMetric },
                { "class", nameof(IfcMetric) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ConstraintGrade.ToJValue(),
                        ConstraintSource.ToJValue(),
                        CreatingActorId.ToJValue(),
                        CreationTime.ToJValue(),
                        UserDefinedGrade.ToJValue(),
                        Benchmark.ToJValue(),
                        ValueSource.ToJValue(),
                        DataValueId.ToJValue(),
                        ReferencePathId.ToJValue(),
                    }
                }
            };
        }

        public static IfcMetric CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMetric(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                (IfcConstraintEnum)IfcAtom.EnumCreator[(int)EnumId.IfcConstraintEnum](parameters[2].ToString()),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalIfcId(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                (IfcBenchmarkEnum)IfcAtom.EnumCreator[(int)EnumId.IfcBenchmarkEnum](parameters[7].ToString()),
                parameters[8].ToOptionalString(),
                parameters[9].ToIfcId(),
                parameters[10].ToOptionalIfcId());
        }
        #endregion

    }
}