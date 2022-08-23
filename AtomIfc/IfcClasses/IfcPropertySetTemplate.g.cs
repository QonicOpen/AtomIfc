
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
    public class IfcPropertySetTemplate : IfcPropertyTemplateDefinition, IEquatable<IfcPropertySetTemplate>
    {
        private IfcPropertySetTemplateTypeEnum _templateType;
        public IfcPropertySetTemplateTypeEnum TemplateType 
        {
            get { 
                return _templateType; 
            }
            set { 
                _templateType = value;  // optional IfcPropertySetTemplateTypeEnum?
            }
        }
        private string _applicableEntity;
        public string ApplicableEntity 
        {
            get { 
                return _applicableEntity; 
            }
            set { 
                _applicableEntity = value;  // optional IfcIdentifier
            }
        }
        private List<IfcId> _propertyTemplateIds;
        public List<IfcId> PropertyTemplateIds 
        {
            get { 
                return _propertyTemplateIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PropertyTemplateIds is not allowed to be null"); 
                _propertyTemplateIds = value;
            }
        }

        public IfcPropertySetTemplate(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, IfcPropertySetTemplateTypeEnum templateType, string applicableEntity, List<IfcId> propertyTemplateIds) : base(id, globalId, ownerHistoryId, name, description)
        {
            TemplateType = templateType;
            ApplicableEntity = applicableEntity;
            PropertyTemplateIds = propertyTemplateIds;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertySetTemplate;

        #region Equality

        public bool Equals(IfcPropertySetTemplate other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(PropertyTemplateIds, other.PropertyTemplateIds))
                return false;
            return base.Equals(other)
                && TemplateType == other.TemplateType
                && ApplicableEntity == other.ApplicableEntity;
        }

        public override bool Equals(object other) => Equals(other as IfcPropertySetTemplate);

        public static bool operator ==(IfcPropertySetTemplate one, IfcPropertySetTemplate other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertySetTemplate one, IfcPropertySetTemplate other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}',.{TemplateType}.,'{ApplicableEntity}',{Utils.ConvertListToString(PropertyTemplateIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PropertyTemplateIds!= null)
                PropertyTemplateIds = PropertyTemplateIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertySetTemplate (newId,GlobalId, OwnerHistoryId, Name, Description, TemplateType, ApplicableEntity, PropertyTemplateIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertySetTemplate },
                { "class", nameof(IfcPropertySetTemplate) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        TemplateType.ToJValue(),
                        ApplicableEntity.ToJValue(),
                        PropertyTemplateIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcPropertySetTemplate CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertySetTemplate(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                (IfcPropertySetTemplateTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcPropertySetTemplateTypeEnum](parameters[4].ToString()),
                parameters[5].ToOptionalString(),
                parameters[6].ToIfcIdList());
        }
        #endregion

    }
}