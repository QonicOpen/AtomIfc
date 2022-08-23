
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
    public class IfcMaterialProperties : IfcExtendedProperties, IEquatable<IfcMaterialProperties>
    {
        private IfcId _materialId;
        public IfcId MaterialId 
        {
            get { 
                return _materialId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MaterialId is not allowed to be null"); 
                _materialId = value;
            }
        }

        public IfcMaterialProperties(IfcId id, string name, string description, List<IfcId> propertyIds, IfcId materialId) : base(id, name, description, propertyIds)
        {
            MaterialId = materialId;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialProperties;

        #region Equality

        public bool Equals(IfcMaterialProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && MaterialId == other.MaterialId;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialProperties);

        public static bool operator ==(IfcMaterialProperties one, IfcMaterialProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialProperties one, IfcMaterialProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(PropertyIds)},{MaterialId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MaterialId!= null && replacementTable.ContainsKey(MaterialId))
                MaterialId = replacementTable[MaterialId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialProperties (newId,Name, Description, PropertyIds, MaterialId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialProperties },
                { "class", nameof(IfcMaterialProperties) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        PropertyIds.ToJArray(),
                        MaterialId.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialProperties(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToIfcId());
        }
        #endregion

    }
}