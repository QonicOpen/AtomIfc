
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
    public class IfcMaterialProfileWithOffsets : IfcMaterialProfile, IEquatable<IfcMaterialProfileWithOffsets>
    {
        private List<double> _offsetValues;
        public List<double> OffsetValues 
        {
            get { 
                return _offsetValues; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OffsetValues is not allowed to be null"); 
                _offsetValues = value;
            }
        }

        public IfcMaterialProfileWithOffsets(IfcId id, string name, string description, IfcId materialId, IfcId profileId, double? priority, string category, List<double> offsetValues) : base(id, name, description, materialId, profileId, priority, category)
        {
            OffsetValues = offsetValues;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialProfileWithOffsets;

        #region Equality

        public bool Equals(IfcMaterialProfileWithOffsets other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(OffsetValues, other.OffsetValues))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialProfileWithOffsets);

        public static bool operator ==(IfcMaterialProfileWithOffsets one, IfcMaterialProfileWithOffsets other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialProfileWithOffsets one, IfcMaterialProfileWithOffsets other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{MaterialId},{ProfileId},{Priority},'{Category}',{Utils.ConvertListToString(OffsetValues)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialProfileWithOffsets (newId,Name, Description, MaterialId, ProfileId, Priority, Category, OffsetValues);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialProfileWithOffsets },
                { "class", nameof(IfcMaterialProfileWithOffsets) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        MaterialId.ToJValue(),
                        ProfileId.ToJValue(),
                        Priority.ToJValue(),
                        Category.ToJValue(),
                        OffsetValues.ToJArray(),
                    }
                }
            };
        }

        public static new IfcMaterialProfileWithOffsets CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialProfileWithOffsets(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToIfcId(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToOptionalString(),
                parameters[6].ToDoubleList());
        }
        #endregion

    }
}