
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
    public class IfcBooleanResult : IfcGeometricRepresentationItem, IEquatable<IfcBooleanResult>, IIfcBooleanOperand, IIfcCsgSelect
    {
        private IfcBooleanOperator _operator;
        public IfcBooleanOperator Operator 
        {
            get { 
                return _operator; 
            }
            set { 
                _operator = value;
            }
        }
        private IfcId _firstOperandId;
        public IfcId FirstOperandId 
        {
            get { 
                return _firstOperandId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("FirstOperandId is not allowed to be null"); 
                _firstOperandId = value;
            }
        }
        private IfcId _secondOperandId;
        public IfcId SecondOperandId 
        {
            get { 
                return _secondOperandId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SecondOperandId is not allowed to be null"); 
                _secondOperandId = value;
            }
        }

        public IfcBooleanResult(IfcId id, IfcBooleanOperator operatorr, IfcId firstOperandId, IfcId secondOperandId) : base(id)
        {
            Operator = operatorr;
            FirstOperandId = firstOperandId;
            SecondOperandId = secondOperandId;
        }

        public override ClassId GetClassId() => ClassId.IfcBooleanResult;

        #region Equality

        public bool Equals(IfcBooleanResult other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Operator == other.Operator
                && FirstOperandId == other.FirstOperandId
                && SecondOperandId == other.SecondOperandId;
        }

        public override bool Equals(object other) => Equals(other as IfcBooleanResult);

        public static bool operator ==(IfcBooleanResult one, IfcBooleanResult other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBooleanResult one, IfcBooleanResult other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{Operator}.,{FirstOperandId},{SecondOperandId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(FirstOperandId!= null && replacementTable.ContainsKey(FirstOperandId))
                FirstOperandId = replacementTable[FirstOperandId];
            if(SecondOperandId!= null && replacementTable.ContainsKey(SecondOperandId))
                SecondOperandId = replacementTable[SecondOperandId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBooleanResult (newId,Operator, FirstOperandId, SecondOperandId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBooleanResult },
                { "class", nameof(IfcBooleanResult) },
                { "parameters" , new JArray
                    {
                        Operator.ToJValue(),
                        FirstOperandId.ToJValue(),
                        SecondOperandId.ToJValue(),
                    }
                }
            };
        }

        public static IfcBooleanResult CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBooleanResult(
                jObject["id"].ToIfcId(),
                (IfcBooleanOperator)IfcAtom.EnumCreator[(int)EnumId.IfcBooleanOperator](parameters[0].ToString()),
                parameters[1].ToIfcId(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}