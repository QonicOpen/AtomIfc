
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
    public class IfcCostValue : IfcAppliedValue, IEquatable<IfcCostValue>
    {
        public IfcCostValue(IfcId id, string name, string description, IfcId appliedValueId, IfcId unitBasisId, string applicableDate, string fixedUntilDate, string category, string condition, IfcArithmeticOperatorEnum arithmeticOperator, List<IfcId> componentIds) : base(id, name, description, appliedValueId, unitBasisId, applicableDate, fixedUntilDate, category, condition, arithmeticOperator, componentIds)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcCostValue;

        #region Equality

        public bool Equals(IfcCostValue other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcCostValue);

        public static bool operator ==(IfcCostValue one, IfcCostValue other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCostValue one, IfcCostValue other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{AppliedValueId},{UnitBasisId},'{ApplicableDate}','{FixedUntilDate}','{Category}','{Condition}',.{ArithmeticOperator}.,{Utils.ConvertListToString(ComponentIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCostValue (newId,Name, Description, AppliedValueId, UnitBasisId, ApplicableDate, FixedUntilDate, Category, Condition, ArithmeticOperator, ComponentIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCostValue },
                { "class", nameof(IfcCostValue) },
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

        public static new IfcCostValue CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCostValue(
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