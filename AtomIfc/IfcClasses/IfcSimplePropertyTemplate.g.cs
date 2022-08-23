
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
    public class IfcSimplePropertyTemplate : IfcPropertyTemplate, IEquatable<IfcSimplePropertyTemplate>
    {
        private IfcSimplePropertyTemplateTypeEnum _templateType;
        public IfcSimplePropertyTemplateTypeEnum TemplateType 
        {
            get { 
                return _templateType; 
            }
            set { 
                _templateType = value;  // optional IfcSimplePropertyTemplateTypeEnum?
            }
        }
        private string _primaryMeasureType;
        public string PrimaryMeasureType 
        {
            get { 
                return _primaryMeasureType; 
            }
            set { 
                _primaryMeasureType = value;  // optional IfcLabel
            }
        }
        private string _secondaryMeasureType;
        public string SecondaryMeasureType 
        {
            get { 
                return _secondaryMeasureType; 
            }
            set { 
                _secondaryMeasureType = value;  // optional IfcLabel
            }
        }
        private IfcId _enumeratorsId;
        public IfcId EnumeratorsId 
        {
            get { 
                return _enumeratorsId; 
            }
            set { 
                _enumeratorsId = value;  // optional IfcPropertyEnumeration
            }
        }
        private IfcId _primaryUnitId;
        public IfcId PrimaryUnitId 
        {
            get { 
                return _primaryUnitId; 
            }
            set { 
                _primaryUnitId = value;  // optional IfcUnit
            }
        }
        private IfcId _secondaryUnitId;
        public IfcId SecondaryUnitId 
        {
            get { 
                return _secondaryUnitId; 
            }
            set { 
                _secondaryUnitId = value;  // optional IfcUnit
            }
        }
        private string _expression;
        public string Expression 
        {
            get { 
                return _expression; 
            }
            set { 
                _expression = value;  // optional IfcLabel
            }
        }
        private IfcStateEnum _accessState;
        public IfcStateEnum AccessState 
        {
            get { 
                return _accessState; 
            }
            set { 
                _accessState = value;  // optional IfcStateEnum?
            }
        }

        public IfcSimplePropertyTemplate(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, IfcSimplePropertyTemplateTypeEnum templateType, string primaryMeasureType, string secondaryMeasureType, IfcId enumeratorsId, IfcId primaryUnitId, IfcId secondaryUnitId, string expression, IfcStateEnum accessState) : base(id, globalId, ownerHistoryId, name, description)
        {
            TemplateType = templateType;
            PrimaryMeasureType = primaryMeasureType;
            SecondaryMeasureType = secondaryMeasureType;
            EnumeratorsId = enumeratorsId;
            PrimaryUnitId = primaryUnitId;
            SecondaryUnitId = secondaryUnitId;
            Expression = expression;
            AccessState = accessState;
        }

        public override ClassId GetClassId() => ClassId.IfcSimplePropertyTemplate;

        #region Equality

        public bool Equals(IfcSimplePropertyTemplate other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TemplateType == other.TemplateType
                && PrimaryMeasureType == other.PrimaryMeasureType
                && SecondaryMeasureType == other.SecondaryMeasureType
                && EnumeratorsId == other.EnumeratorsId
                && PrimaryUnitId == other.PrimaryUnitId
                && SecondaryUnitId == other.SecondaryUnitId
                && Expression == other.Expression
                && AccessState == other.AccessState;
        }

        public override bool Equals(object other) => Equals(other as IfcSimplePropertyTemplate);

        public static bool operator ==(IfcSimplePropertyTemplate one, IfcSimplePropertyTemplate other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSimplePropertyTemplate one, IfcSimplePropertyTemplate other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}',.{TemplateType}.,'{PrimaryMeasureType}','{SecondaryMeasureType}',{EnumeratorsId},{PrimaryUnitId},{SecondaryUnitId},'{Expression}',.{AccessState}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EnumeratorsId!= null && replacementTable.ContainsKey(EnumeratorsId))
                EnumeratorsId = replacementTable[EnumeratorsId];
            if(PrimaryUnitId!= null && replacementTable.ContainsKey(PrimaryUnitId))
                PrimaryUnitId = replacementTable[PrimaryUnitId];
            if(SecondaryUnitId!= null && replacementTable.ContainsKey(SecondaryUnitId))
                SecondaryUnitId = replacementTable[SecondaryUnitId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSimplePropertyTemplate (newId,GlobalId, OwnerHistoryId, Name, Description, TemplateType, PrimaryMeasureType, SecondaryMeasureType, EnumeratorsId, PrimaryUnitId, SecondaryUnitId, Expression, AccessState);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSimplePropertyTemplate },
                { "class", nameof(IfcSimplePropertyTemplate) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        TemplateType.ToJValue(),
                        PrimaryMeasureType.ToJValue(),
                        SecondaryMeasureType.ToJValue(),
                        EnumeratorsId.ToJValue(),
                        PrimaryUnitId.ToJValue(),
                        SecondaryUnitId.ToJValue(),
                        Expression.ToJValue(),
                        AccessState.ToJValue(),
                    }
                }
            };
        }

        public static IfcSimplePropertyTemplate CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSimplePropertyTemplate(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                (IfcSimplePropertyTemplateTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcSimplePropertyTemplateTypeEnum](parameters[4].ToString()),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalIfcId(),
                parameters[8].ToOptionalIfcId(),
                parameters[9].ToOptionalIfcId(),
                parameters[10].ToOptionalString(),
                (IfcStateEnum)IfcAtom.EnumCreator[(int)EnumId.IfcStateEnum](parameters[11].ToString()));
        }
        #endregion

    }
}