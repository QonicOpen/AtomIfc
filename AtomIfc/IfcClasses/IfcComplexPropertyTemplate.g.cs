
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
    public class IfcComplexPropertyTemplate : IfcPropertyTemplate, IEquatable<IfcComplexPropertyTemplate>
    {
        private string _usageName;
        public string UsageName 
        {
            get { 
                return _usageName; 
            }
            set { 
                _usageName = value;  // optional IfcLabel
            }
        }
        private IfcComplexPropertyTemplateTypeEnum _templateType;
        public IfcComplexPropertyTemplateTypeEnum TemplateType 
        {
            get { 
                return _templateType; 
            }
            set { 
                _templateType = value;  // optional IfcComplexPropertyTemplateTypeEnum?
            }
        }
        private List<IfcId> _propertyTemplateIds;
        public List<IfcId> PropertyTemplateIds 
        {
            get { 
                return _propertyTemplateIds; 
            }
            set { 
                _propertyTemplateIds = value;  // optional List<IfcPropertyTemplate>
            }
        }

        public IfcComplexPropertyTemplate(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string usageName, IfcComplexPropertyTemplateTypeEnum templateType, List<IfcId> propertyTemplateIds) : base(id, globalId, ownerHistoryId, name, description)
        {
            UsageName = usageName;
            TemplateType = templateType;
            PropertyTemplateIds = propertyTemplateIds;
        }

        public override ClassId GetClassId() => ClassId.IfcComplexPropertyTemplate;

        #region Equality

        public bool Equals(IfcComplexPropertyTemplate other)
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
                && UsageName == other.UsageName
                && TemplateType == other.TemplateType;
        }

        public override bool Equals(object other) => Equals(other as IfcComplexPropertyTemplate);

        public static bool operator ==(IfcComplexPropertyTemplate one, IfcComplexPropertyTemplate other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcComplexPropertyTemplate one, IfcComplexPropertyTemplate other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{UsageName}',.{TemplateType}.,{Utils.ConvertListToString(PropertyTemplateIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PropertyTemplateIds!= null)
                PropertyTemplateIds = PropertyTemplateIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcComplexPropertyTemplate (newId,GlobalId, OwnerHistoryId, Name, Description, UsageName, TemplateType, PropertyTemplateIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcComplexPropertyTemplate },
                { "class", nameof(IfcComplexPropertyTemplate) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        UsageName.ToJValue(),
                        TemplateType.ToJValue(),
                        PropertyTemplateIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcComplexPropertyTemplate CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcComplexPropertyTemplate(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                (IfcComplexPropertyTemplateTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcComplexPropertyTemplateTypeEnum](parameters[5].ToString()),
                parameters[6].ToOptionalIfcIdList());
        }
        #endregion

    }
}