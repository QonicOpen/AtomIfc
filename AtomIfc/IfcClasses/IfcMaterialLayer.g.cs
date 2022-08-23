
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
    public class IfcMaterialLayer : IfcMaterialDefinition, IEquatable<IfcMaterialLayer>
    {
        private IfcId _materialId;
        public IfcId MaterialId 
        {
            get { 
                return _materialId; 
            }
            set { 
                _materialId = value;  // optional IfcMaterial
            }
        }
        private double _layerThickness;
        public double LayerThickness 
        {
            get { 
                return _layerThickness; 
            }
            set { 
                _layerThickness = value;
            }
        }
        private IfcId _isVentilatedId;
        public IfcId IsVentilatedId 
        {
            get { 
                return _isVentilatedId; 
            }
            set { 
                _isVentilatedId = value;  // optional IfcLogical
            }
        }
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
        private double? _priority;
        public double? Priority 
        {
            get { 
                return _priority; 
            }
            set { 
                _priority = value;  // optional IfcNormalisedRatioMeasure
            }
        }

        public IfcMaterialLayer(IfcId id, IfcId materialId, double layerThickness, IfcId isVentilatedId, string name, string description, string category, double? priority) : base(id)
        {
            MaterialId = materialId;
            LayerThickness = layerThickness;
            IsVentilatedId = isVentilatedId;
            Name = name;
            Description = description;
            Category = category;
            Priority = priority;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialLayer;

        #region Equality

        public bool Equals(IfcMaterialLayer other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && MaterialId == other.MaterialId
                && LayerThickness == other.LayerThickness
                && IsVentilatedId == other.IsVentilatedId
                && Name == other.Name
                && Description == other.Description
                && Category == other.Category
                && Priority == other.Priority;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialLayer);

        public static bool operator ==(IfcMaterialLayer one, IfcMaterialLayer other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialLayer one, IfcMaterialLayer other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({MaterialId},{LayerThickness},{IsVentilatedId},'{Name}','{Description}','{Category}',{Priority})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MaterialId!= null && replacementTable.ContainsKey(MaterialId))
                MaterialId = replacementTable[MaterialId];
            if(IsVentilatedId!= null && replacementTable.ContainsKey(IsVentilatedId))
                IsVentilatedId = replacementTable[IsVentilatedId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialLayer (newId,MaterialId, LayerThickness, IsVentilatedId, Name, Description, Category, Priority);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialLayer },
                { "class", nameof(IfcMaterialLayer) },
                { "parameters" , new JArray
                    {
                        MaterialId.ToJValue(),
                        LayerThickness,
                        IsVentilatedId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        Category.ToJValue(),
                        Priority.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialLayer CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialLayer(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalDouble());
        }
        #endregion

    }
}