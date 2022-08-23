
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
    public class IfcObjective : IfcConstraint, IEquatable<IfcObjective>
    {
        private List<IfcId> _benchmarkValueIds;
        public List<IfcId> BenchmarkValueIds 
        {
            get { 
                return _benchmarkValueIds; 
            }
            set { 
                _benchmarkValueIds = value;  // optional List<IfcConstraint>
            }
        }
        private IfcLogicalOperatorEnum _logicalAggregator;
        public IfcLogicalOperatorEnum LogicalAggregator 
        {
            get { 
                return _logicalAggregator; 
            }
            set { 
                _logicalAggregator = value;  // optional IfcLogicalOperatorEnum?
            }
        }
        private IfcObjectiveEnum _objectiveQualifier;
        public IfcObjectiveEnum ObjectiveQualifier 
        {
            get { 
                return _objectiveQualifier; 
            }
            set { 
                _objectiveQualifier = value;
            }
        }
        private string _userDefinedQualifier;
        public string UserDefinedQualifier 
        {
            get { 
                return _userDefinedQualifier; 
            }
            set { 
                _userDefinedQualifier = value;  // optional IfcLabel
            }
        }

        public IfcObjective(IfcId id, string name, string description, IfcConstraintEnum constraintGrade, string constraintSource, IfcId creatingActorId, string creationTime, string userDefinedGrade, List<IfcId> benchmarkValueIds, IfcLogicalOperatorEnum logicalAggregator, IfcObjectiveEnum objectiveQualifier, string userDefinedQualifier) : base(id, name, description, constraintGrade, constraintSource, creatingActorId, creationTime, userDefinedGrade)
        {
            BenchmarkValueIds = benchmarkValueIds;
            LogicalAggregator = logicalAggregator;
            ObjectiveQualifier = objectiveQualifier;
            UserDefinedQualifier = userDefinedQualifier;
        }

        public override ClassId GetClassId() => ClassId.IfcObjective;

        #region Equality

        public bool Equals(IfcObjective other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(BenchmarkValueIds, other.BenchmarkValueIds))
                return false;
            return base.Equals(other)
                && LogicalAggregator == other.LogicalAggregator
                && ObjectiveQualifier == other.ObjectiveQualifier
                && UserDefinedQualifier == other.UserDefinedQualifier;
        }

        public override bool Equals(object other) => Equals(other as IfcObjective);

        public static bool operator ==(IfcObjective one, IfcObjective other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcObjective one, IfcObjective other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',.{ConstraintGrade}.,'{ConstraintSource}',{CreatingActorId},'{CreationTime}','{UserDefinedGrade}',{Utils.ConvertListToString(BenchmarkValueIds)},.{LogicalAggregator}.,.{ObjectiveQualifier}.,'{UserDefinedQualifier}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BenchmarkValueIds!= null)
                BenchmarkValueIds = BenchmarkValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcObjective (newId,Name, Description, ConstraintGrade, ConstraintSource, CreatingActorId, CreationTime, UserDefinedGrade, BenchmarkValueIds, LogicalAggregator, ObjectiveQualifier, UserDefinedQualifier);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcObjective },
                { "class", nameof(IfcObjective) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ConstraintGrade.ToJValue(),
                        ConstraintSource.ToJValue(),
                        CreatingActorId.ToJValue(),
                        CreationTime.ToJValue(),
                        UserDefinedGrade.ToJValue(),
                        BenchmarkValueIds.ToJArray(),
                        LogicalAggregator.ToJValue(),
                        ObjectiveQualifier.ToJValue(),
                        UserDefinedQualifier.ToJValue(),
                    }
                }
            };
        }

        public static IfcObjective CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcObjective(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                (IfcConstraintEnum)IfcAtom.EnumCreator[(int)EnumId.IfcConstraintEnum](parameters[2].ToString()),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalIfcId(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalIfcIdList(),
                (IfcLogicalOperatorEnum)IfcAtom.EnumCreator[(int)EnumId.IfcLogicalOperatorEnum](parameters[8].ToString()),
                (IfcObjectiveEnum)IfcAtom.EnumCreator[(int)EnumId.IfcObjectiveEnum](parameters[9].ToString()),
                parameters[10].ToOptionalString());
        }
        #endregion

    }
}