
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
    public class IfcStructuralLoadCase : IfcStructuralLoadGroup, IEquatable<IfcStructuralLoadCase>
    {
        private List<double> _selfWeightCoefficients;
        public List<double> SelfWeightCoefficients 
        {
            get { 
                return _selfWeightCoefficients; 
            }
            set { 
                _selfWeightCoefficients = value;  // optional List<IfcRatioMeasure>
            }
        }

        public IfcStructuralLoadCase(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcLoadGroupTypeEnum predefinedType, IfcActionTypeEnum actionType, IfcActionSourceTypeEnum actionSource, double? coefficient, string purpose, List<double> selfWeightCoefficients) : base(id, globalId, ownerHistoryId, name, description, objectType, predefinedType, actionType, actionSource, coefficient, purpose)
        {
            SelfWeightCoefficients = selfWeightCoefficients;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralLoadCase;

        #region Equality

        public bool Equals(IfcStructuralLoadCase other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(SelfWeightCoefficients, other.SelfWeightCoefficients))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralLoadCase);

        public static bool operator ==(IfcStructuralLoadCase one, IfcStructuralLoadCase other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralLoadCase one, IfcStructuralLoadCase other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',.{PredefinedType}.,.{ActionType}.,.{ActionSource}.,{Coefficient},'{Purpose}',{Utils.ConvertListToString(SelfWeightCoefficients)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralLoadCase (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, PredefinedType, ActionType, ActionSource, Coefficient, Purpose, SelfWeightCoefficients);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralLoadCase },
                { "class", nameof(IfcStructuralLoadCase) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        PredefinedType.ToJValue(),
                        ActionType.ToJValue(),
                        ActionSource.ToJValue(),
                        Coefficient.ToJValue(),
                        Purpose.ToJValue(),
                        SelfWeightCoefficients.ToJArray(),
                    }
                }
            };
        }

        public static new IfcStructuralLoadCase CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralLoadCase(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                (IfcLoadGroupTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcLoadGroupTypeEnum](parameters[5].ToString()),
                (IfcActionTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcActionTypeEnum](parameters[6].ToString()),
                (IfcActionSourceTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcActionSourceTypeEnum](parameters[7].ToString()),
                parameters[8].ToOptionalDouble(),
                parameters[9].ToOptionalString(),
                parameters[10].ToOptionalDoubleList());
        }
        #endregion

    }
}