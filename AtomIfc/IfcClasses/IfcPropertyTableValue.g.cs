
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
    public class IfcPropertyTableValue : IfcSimpleProperty, IEquatable<IfcPropertyTableValue>
    {
        private List<IfcId> _definingValueIds;
        public List<IfcId> DefiningValueIds 
        {
            get { 
                return _definingValueIds; 
            }
            set { 
                _definingValueIds = value;  // optional List<IfcValue>
            }
        }
        private List<IfcId> _definedValueIds;
        public List<IfcId> DefinedValueIds 
        {
            get { 
                return _definedValueIds; 
            }
            set { 
                _definedValueIds = value;  // optional List<IfcValue>
            }
        }
        private string _expression;
        public string Expression 
        {
            get { 
                return _expression; 
            }
            set { 
                _expression = value;  // optional IfcText
            }
        }
        private IfcId _definingUnitId;
        public IfcId DefiningUnitId 
        {
            get { 
                return _definingUnitId; 
            }
            set { 
                _definingUnitId = value;  // optional IfcUnit
            }
        }
        private IfcId _definedUnitId;
        public IfcId DefinedUnitId 
        {
            get { 
                return _definedUnitId; 
            }
            set { 
                _definedUnitId = value;  // optional IfcUnit
            }
        }
        private IfcCurveInterpolationEnum _curveInterpolation;
        public IfcCurveInterpolationEnum CurveInterpolation 
        {
            get { 
                return _curveInterpolation; 
            }
            set { 
                _curveInterpolation = value;  // optional IfcCurveInterpolationEnum?
            }
        }

        public IfcPropertyTableValue(IfcId id, string name, string description, List<IfcId> definingValueIds, List<IfcId> definedValueIds, string expression, IfcId definingUnitId, IfcId definedUnitId, IfcCurveInterpolationEnum curveInterpolation) : base(id, name, description)
        {
            DefiningValueIds = definingValueIds;
            DefinedValueIds = definedValueIds;
            Expression = expression;
            DefiningUnitId = definingUnitId;
            DefinedUnitId = definedUnitId;
            CurveInterpolation = curveInterpolation;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertyTableValue;

        #region Equality

        public bool Equals(IfcPropertyTableValue other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(DefiningValueIds, other.DefiningValueIds))
                return false;
            if(!Utils.CompareList(DefinedValueIds, other.DefinedValueIds))
                return false;
            return base.Equals(other)
                && Expression == other.Expression
                && DefiningUnitId == other.DefiningUnitId
                && DefinedUnitId == other.DefinedUnitId
                && CurveInterpolation == other.CurveInterpolation;
        }

        public override bool Equals(object other) => Equals(other as IfcPropertyTableValue);

        public static bool operator ==(IfcPropertyTableValue one, IfcPropertyTableValue other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertyTableValue one, IfcPropertyTableValue other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(DefiningValueIds)},{Utils.ConvertListToString(DefinedValueIds)},'{Expression}',{DefiningUnitId},{DefinedUnitId},.{CurveInterpolation}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DefiningValueIds!= null)
                DefiningValueIds = DefiningValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(DefinedValueIds!= null)
                DefinedValueIds = DefinedValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(DefiningUnitId!= null && replacementTable.ContainsKey(DefiningUnitId))
                DefiningUnitId = replacementTable[DefiningUnitId];
            if(DefinedUnitId!= null && replacementTable.ContainsKey(DefinedUnitId))
                DefinedUnitId = replacementTable[DefinedUnitId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertyTableValue (newId,Name, Description, DefiningValueIds, DefinedValueIds, Expression, DefiningUnitId, DefinedUnitId, CurveInterpolation);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertyTableValue },
                { "class", nameof(IfcPropertyTableValue) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        DefiningValueIds.ToJArray(),
                        DefinedValueIds.ToJArray(),
                        Expression.ToJValue(),
                        DefiningUnitId.ToJValue(),
                        DefinedUnitId.ToJValue(),
                        CurveInterpolation.ToJValue(),
                    }
                }
            };
        }

        public static IfcPropertyTableValue CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertyTableValue(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcIdList(),
                parameters[3].ToOptionalIfcIdList(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                (IfcCurveInterpolationEnum)IfcAtom.EnumCreator[(int)EnumId.IfcCurveInterpolationEnum](parameters[7].ToString()));
        }
        #endregion

    }
}