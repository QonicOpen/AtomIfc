
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
    public class IfcStructuralLoadGroup : IfcGroup, IEquatable<IfcStructuralLoadGroup>
    {
        private IfcLoadGroupTypeEnum _predefinedType;
        public IfcLoadGroupTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }
        private IfcActionTypeEnum _actionType;
        public IfcActionTypeEnum ActionType 
        {
            get { 
                return _actionType; 
            }
            set { 
                _actionType = value;
            }
        }
        private IfcActionSourceTypeEnum _actionSource;
        public IfcActionSourceTypeEnum ActionSource 
        {
            get { 
                return _actionSource; 
            }
            set { 
                _actionSource = value;
            }
        }
        private double? _coefficient;
        public double? Coefficient 
        {
            get { 
                return _coefficient; 
            }
            set { 
                _coefficient = value;  // optional IfcRatioMeasure
            }
        }
        private string _purpose;
        public string Purpose 
        {
            get { 
                return _purpose; 
            }
            set { 
                _purpose = value;  // optional IfcLabel
            }
        }

        public IfcStructuralLoadGroup(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcLoadGroupTypeEnum predefinedType, IfcActionTypeEnum actionType, IfcActionSourceTypeEnum actionSource, double? coefficient, string purpose) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            PredefinedType = predefinedType;
            ActionType = actionType;
            ActionSource = actionSource;
            Coefficient = coefficient;
            Purpose = purpose;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralLoadGroup;

        #region Equality

        public bool Equals(IfcStructuralLoadGroup other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && ActionType == other.ActionType
                && ActionSource == other.ActionSource
                && Coefficient == other.Coefficient
                && Purpose == other.Purpose;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralLoadGroup);

        public static bool operator ==(IfcStructuralLoadGroup one, IfcStructuralLoadGroup other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralLoadGroup one, IfcStructuralLoadGroup other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',.{PredefinedType}.,.{ActionType}.,.{ActionSource}.,{Coefficient},'{Purpose}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralLoadGroup (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, PredefinedType, ActionType, ActionSource, Coefficient, Purpose);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralLoadGroup },
                { "class", nameof(IfcStructuralLoadGroup) },
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
                    }
                }
            };
        }

        public static new IfcStructuralLoadGroup CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralLoadGroup(
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
                parameters[9].ToOptionalString());
        }
        #endregion

    }
}