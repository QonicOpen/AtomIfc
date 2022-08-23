
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
    public class IfcMaterialConstituent : IfcMaterialDefinition, IEquatable<IfcMaterialConstituent>
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;  // optional IfcLabel
            }
        }
        private string _description;
        public string Description 
        {
            get { 
                return _description; 
            }
            set { 
                _description = value;  // optional IfcText
            }
        }
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
        private double? _fraction;
        public double? Fraction 
        {
            get { 
                return _fraction; 
            }
            set { 
                _fraction = value;  // optional IfcNormalisedRatioMeasure
            }
        }
        private string _category;
        public string Category 
        {
            get { 
                return _category; 
            }
            set { 
                _category = value;  // optional IfcLabel
            }
        }

        public IfcMaterialConstituent(IfcId id, string name, string description, IfcId materialId, double? fraction, string category) : base(id)
        {
            Name = name;
            Description = description;
            MaterialId = materialId;
            Fraction = fraction;
            Category = category;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialConstituent;

        #region Equality

        public bool Equals(IfcMaterialConstituent other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description
                && MaterialId == other.MaterialId
                && Fraction == other.Fraction
                && Category == other.Category;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialConstituent);

        public static bool operator ==(IfcMaterialConstituent one, IfcMaterialConstituent other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialConstituent one, IfcMaterialConstituent other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{MaterialId},{Fraction},'{Category}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MaterialId!= null && replacementTable.ContainsKey(MaterialId))
                MaterialId = replacementTable[MaterialId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialConstituent (newId,Name, Description, MaterialId, Fraction, Category);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialConstituent },
                { "class", nameof(IfcMaterialConstituent) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        MaterialId.ToJValue(),
                        Fraction.ToJValue(),
                        Category.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialConstituent CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialConstituent(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalString());
        }
        #endregion

    }
}