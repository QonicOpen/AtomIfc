
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
    public class IfcMaterialLayerWithOffsets : IfcMaterialLayer, IEquatable<IfcMaterialLayerWithOffsets>
    {
        private IfcLayerSetDirectionEnum _offsetDirection;
        public IfcLayerSetDirectionEnum OffsetDirection 
        {
            get { 
                return _offsetDirection; 
            }
            set { 
                _offsetDirection = value;
            }
        }
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

        public IfcMaterialLayerWithOffsets(IfcId id, IfcId materialId, double layerThickness, IfcId isVentilatedId, string name, string description, string category, double? priority, IfcLayerSetDirectionEnum offsetDirection, List<double> offsetValues) : base(id, materialId, layerThickness, isVentilatedId, name, description, category, priority)
        {
            OffsetDirection = offsetDirection;
            OffsetValues = offsetValues;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialLayerWithOffsets;

        #region Equality

        public bool Equals(IfcMaterialLayerWithOffsets other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(OffsetValues, other.OffsetValues))
                return false;
            return base.Equals(other)
                && OffsetDirection == other.OffsetDirection;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialLayerWithOffsets);

        public static bool operator ==(IfcMaterialLayerWithOffsets one, IfcMaterialLayerWithOffsets other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialLayerWithOffsets one, IfcMaterialLayerWithOffsets other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({MaterialId},{LayerThickness},{IsVentilatedId},'{Name}','{Description}','{Category}',{Priority},.{OffsetDirection}.,{Utils.ConvertListToString(OffsetValues)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialLayerWithOffsets (newId,MaterialId, LayerThickness, IsVentilatedId, Name, Description, Category, Priority, OffsetDirection, OffsetValues);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialLayerWithOffsets },
                { "class", nameof(IfcMaterialLayerWithOffsets) },
                { "parameters" , new JArray
                    {
                        MaterialId.ToJValue(),
                        LayerThickness,
                        IsVentilatedId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        Category.ToJValue(),
                        Priority.ToJValue(),
                        OffsetDirection.ToJValue(),
                        OffsetValues.ToJArray(),
                    }
                }
            };
        }

        public static new IfcMaterialLayerWithOffsets CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialLayerWithOffsets(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalDouble(),
                (IfcLayerSetDirectionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcLayerSetDirectionEnum](parameters[7].ToString()),
                parameters[8].ToDoubleList());
        }
        #endregion

    }
}