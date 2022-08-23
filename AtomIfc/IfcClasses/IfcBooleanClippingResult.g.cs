
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
    public class IfcBooleanClippingResult : IfcBooleanResult, IEquatable<IfcBooleanClippingResult>
    {
        public IfcBooleanClippingResult(IfcId id, IfcBooleanOperator operatorr, IfcId firstOperandId, IfcId secondOperandId) : base(id, operatorr, firstOperandId, secondOperandId)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcBooleanClippingResult;

        #region Equality

        public bool Equals(IfcBooleanClippingResult other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcBooleanClippingResult);

        public static bool operator ==(IfcBooleanClippingResult one, IfcBooleanClippingResult other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBooleanClippingResult one, IfcBooleanClippingResult other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{Operator}.,{FirstOperandId},{SecondOperandId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBooleanClippingResult (newId,Operator, FirstOperandId, SecondOperandId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBooleanClippingResult },
                { "class", nameof(IfcBooleanClippingResult) },
                { "parameters" , new JArray
                    {
                        Operator.ToJValue(),
                        FirstOperandId.ToJValue(),
                        SecondOperandId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcBooleanClippingResult CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBooleanClippingResult(
                jObject["id"].ToIfcId(),
                (IfcBooleanOperator)IfcAtom.EnumCreator[(int)EnumId.IfcBooleanOperator](parameters[0].ToString()),
                parameters[1].ToIfcId(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}