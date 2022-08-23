
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
    public class IfcComplexProperty : IfcProperty, IEquatable<IfcComplexProperty>
    {
        private string _usageName;
        public string UsageName 
        {
            get { 
                return _usageName; 
            }
            set { 
                _usageName = value;
            }
        }
        private List<IfcId> _propertyIds;
        public List<IfcId> PropertyIds 
        {
            get { 
                return _propertyIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PropertyIds is not allowed to be null"); 
                _propertyIds = value;
            }
        }

        public IfcComplexProperty(IfcId id, string name, string description, string usageName, List<IfcId> propertyIds) : base(id, name, description)
        {
            UsageName = usageName;
            PropertyIds = propertyIds;
        }

        public override ClassId GetClassId() => ClassId.IfcComplexProperty;

        #region Equality

        public bool Equals(IfcComplexProperty other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(PropertyIds, other.PropertyIds))
                return false;
            return base.Equals(other)
                && UsageName == other.UsageName;
        }

        public override bool Equals(object other) => Equals(other as IfcComplexProperty);

        public static bool operator ==(IfcComplexProperty one, IfcComplexProperty other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcComplexProperty one, IfcComplexProperty other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}','{UsageName}',{Utils.ConvertListToString(PropertyIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PropertyIds!= null)
                PropertyIds = PropertyIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcComplexProperty (newId,Name, Description, UsageName, PropertyIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcComplexProperty },
                { "class", nameof(IfcComplexProperty) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        UsageName.ToJValue(),
                        PropertyIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcComplexProperty CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcComplexProperty(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToString(),
                parameters[3].ToIfcIdList());
        }
        #endregion

    }
}