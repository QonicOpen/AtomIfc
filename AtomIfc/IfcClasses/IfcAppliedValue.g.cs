
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
    public class IfcAppliedValue : IfcBase, IEquatable<IfcAppliedValue>, IIfcMetricValueSelect, IIfcObjectReferenceSelect, IIfcResourceObjectSelect
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;  // optional IfcLabel
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
        private IfcId _appliedValueId;
        public IfcId AppliedValueId 
        {
            get { 
                return _appliedValueId; 
            }
            set { 
                _appliedValueId = value;  // optional IfcAppliedValueSelect
            }
        }
        private IfcId _unitBasisId;
        public IfcId UnitBasisId 
        {
            get { 
                return _unitBasisId; 
            }
            set { 
                _unitBasisId = value;  // optional IfcMeasureWithUnit
            }
        }
        private string _applicableDate;
        public string ApplicableDate 
        {
            get { 
                return _applicableDate; 
            }
            set { 
                _applicableDate = value;  // optional IfcDate
            }
        }
        private string _fixedUntilDate;
        public string FixedUntilDate 
        {
            get { 
                return _fixedUntilDate; 
            }
            set { 
                _fixedUntilDate = value;  // optional IfcDate
            }
        }
        private string _category;
        public string Category 
        {
            get { 
                return _category; 
            }
            set { 
                _category = value;  // optional IfcLabel
            }
        }
        private string _condition;
        public string Condition 
        {
            get { 
                return _condition; 
            }
            set { 
                _condition = value;  // optional IfcLabel
            }
        }
        private IfcArithmeticOperatorEnum _arithmeticOperator;
        public IfcArithmeticOperatorEnum ArithmeticOperator 
        {
            get { 
                return _arithmeticOperator; 
            }
            set { 
                _arithmeticOperator = value;  // optional IfcArithmeticOperatorEnum?
            }
        }
        private List<IfcId> _componentIds;
        public List<IfcId> ComponentIds 
        {
            get { 
                return _componentIds; 
            }
            set { 
                _componentIds = value;  // optional List<IfcAppliedValue>
            }
        }

        public IfcAppliedValue(IfcId id, string name, string description, IfcId appliedValueId, IfcId unitBasisId, string applicableDate, string fixedUntilDate, string category, string condition, IfcArithmeticOperatorEnum arithmeticOperator, List<IfcId> componentIds) : base(id)
        {
            Name = name;
            Description = description;
            AppliedValueId = appliedValueId;
            UnitBasisId = unitBasisId;
            ApplicableDate = applicableDate;
            FixedUntilDate = fixedUntilDate;
            Category = category;
            Condition = condition;
            ArithmeticOperator = arithmeticOperator;
            ComponentIds = componentIds;
        }

        public override ClassId GetClassId() => ClassId.IfcAppliedValue;

        #region Equality

        public bool Equals(IfcAppliedValue other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ComponentIds, other.ComponentIds))
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description
                && AppliedValueId == other.AppliedValueId
                && UnitBasisId == other.UnitBasisId
                && ApplicableDate == other.ApplicableDate
                && FixedUntilDate == other.FixedUntilDate
                && Category == other.Category
                && Condition == other.Condition
                && ArithmeticOperator == other.ArithmeticOperator;
        }

        public override bool Equals(object other) => Equals(other as IfcAppliedValue);

        public static bool operator ==(IfcAppliedValue one, IfcAppliedValue other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcAppliedValue one, IfcAppliedValue other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{AppliedValueId},{UnitBasisId},'{ApplicableDate}','{FixedUntilDate}','{Category}','{Condition}',.{ArithmeticOperator}.,{Utils.ConvertListToString(ComponentIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(AppliedValueId!= null && replacementTable.ContainsKey(AppliedValueId))
                AppliedValueId = replacementTable[AppliedValueId];
            if(UnitBasisId!= null && replacementTable.ContainsKey(UnitBasisId))
                UnitBasisId = replacementTable[UnitBasisId];
            if(ComponentIds!= null)
                ComponentIds = ComponentIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcAppliedValue (newId,Name, Description, AppliedValueId, UnitBasisId, ApplicableDate, FixedUntilDate, Category, Condition, ArithmeticOperator, ComponentIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcAppliedValue },
                { "class", nameof(IfcAppliedValue) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        AppliedValueId.ToJValue(),
                        UnitBasisId.ToJValue(),
                        ApplicableDate.ToJValue(),
                        FixedUntilDate.ToJValue(),
                        Category.ToJValue(),
                        Condition.ToJValue(),
                        ArithmeticOperator.ToJValue(),
                        ComponentIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcAppliedValue CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcAppliedValue(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalString(),
                (IfcArithmeticOperatorEnum)IfcAtom.EnumCreator[(int)EnumId.IfcArithmeticOperatorEnum](parameters[8].ToString()),
                parameters[9].ToOptionalIfcIdList());
        }
        #endregion

    }
}