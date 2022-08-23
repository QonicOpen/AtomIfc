
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
    public class IfcStructuralResultGroup : IfcGroup, IEquatable<IfcStructuralResultGroup>
    {
        private IfcAnalysisTheoryTypeEnum _theoryType;
        public IfcAnalysisTheoryTypeEnum TheoryType 
        {
            get { 
                return _theoryType; 
            }
            set { 
                _theoryType = value;
            }
        }
        private IfcId _resultForLoadGroupId;
        public IfcId ResultForLoadGroupId 
        {
            get { 
                return _resultForLoadGroupId; 
            }
            set { 
                _resultForLoadGroupId = value;  // optional IfcStructuralLoadGroup
            }
        }
        private bool _isLinear;
        public bool IsLinear 
        {
            get { 
                return _isLinear; 
            }
            set { 
                _isLinear = value;
            }
        }

        public IfcStructuralResultGroup(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcAnalysisTheoryTypeEnum theoryType, IfcId resultForLoadGroupId, bool isLinear) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            TheoryType = theoryType;
            ResultForLoadGroupId = resultForLoadGroupId;
            IsLinear = isLinear;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralResultGroup;

        #region Equality

        public bool Equals(IfcStructuralResultGroup other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TheoryType == other.TheoryType
                && ResultForLoadGroupId == other.ResultForLoadGroupId
                && IsLinear == other.IsLinear;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralResultGroup);

        public static bool operator ==(IfcStructuralResultGroup one, IfcStructuralResultGroup other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralResultGroup one, IfcStructuralResultGroup other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',.{TheoryType}.,{ResultForLoadGroupId},{IsLinear})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ResultForLoadGroupId!= null && replacementTable.ContainsKey(ResultForLoadGroupId))
                ResultForLoadGroupId = replacementTable[ResultForLoadGroupId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralResultGroup (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, TheoryType, ResultForLoadGroupId, IsLinear);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralResultGroup },
                { "class", nameof(IfcStructuralResultGroup) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        TheoryType.ToJValue(),
                        ResultForLoadGroupId.ToJValue(),
                        IsLinear,
                    }
                }
            };
        }

        public static new IfcStructuralResultGroup CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralResultGroup(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                (IfcAnalysisTheoryTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcAnalysisTheoryTypeEnum](parameters[5].ToString()),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToBool());
        }
        #endregion

    }
}