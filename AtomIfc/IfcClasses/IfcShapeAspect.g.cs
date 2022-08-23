
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
    public class IfcShapeAspect : IfcBase, IEquatable<IfcShapeAspect>
    {
        private List<IfcId> _shapeRepresentationIds;
        public List<IfcId> ShapeRepresentationIds 
        {
            get { 
                return _shapeRepresentationIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ShapeRepresentationIds is not allowed to be null"); 
                _shapeRepresentationIds = value;
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
        private bool? _productDefinitional;
        public bool? ProductDefinitional 
        {
            get { 
                return _productDefinitional; 
            }
            set { 
                _productDefinitional = value;
            }
        }
        private IfcId _partOfProductDefinitionShapeId;
        public IfcId PartOfProductDefinitionShapeId 
        {
            get { 
                return _partOfProductDefinitionShapeId; 
            }
            set { 
                _partOfProductDefinitionShapeId = value;  // optional IfcProductRepresentationSelect
            }
        }

        public IfcShapeAspect(IfcId id, List<IfcId> shapeRepresentationIds, string name, string description, bool? productDefinitional, IfcId partOfProductDefinitionShapeId) : base(id)
        {
            ShapeRepresentationIds = shapeRepresentationIds;
            Name = name;
            Description = description;
            ProductDefinitional = productDefinitional;
            PartOfProductDefinitionShapeId = partOfProductDefinitionShapeId;
        }

        public override ClassId GetClassId() => ClassId.IfcShapeAspect;

        #region Equality

        public bool Equals(IfcShapeAspect other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ShapeRepresentationIds, other.ShapeRepresentationIds))
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description
                && ProductDefinitional == other.ProductDefinitional
                && PartOfProductDefinitionShapeId == other.PartOfProductDefinitionShapeId;
        }

        public override bool Equals(object other) => Equals(other as IfcShapeAspect);

        public static bool operator ==(IfcShapeAspect one, IfcShapeAspect other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcShapeAspect one, IfcShapeAspect other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(ShapeRepresentationIds)},'{Name}','{Description}',{(ProductDefinitional == null? ".U." : ProductDefinitional)},{PartOfProductDefinitionShapeId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ShapeRepresentationIds!= null)
                ShapeRepresentationIds = ShapeRepresentationIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(PartOfProductDefinitionShapeId!= null && replacementTable.ContainsKey(PartOfProductDefinitionShapeId))
                PartOfProductDefinitionShapeId = replacementTable[PartOfProductDefinitionShapeId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcShapeAspect (newId,ShapeRepresentationIds, Name, Description, ProductDefinitional, PartOfProductDefinitionShapeId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcShapeAspect },
                { "class", nameof(IfcShapeAspect) },
                { "parameters" , new JArray
                    {
                        ShapeRepresentationIds.ToJArray(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ProductDefinitional.ToJValue(),
                        PartOfProductDefinitionShapeId.ToJValue(),
                    }
                }
            };
        }

        public static IfcShapeAspect CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcShapeAspect(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalBool(),
                parameters[4].ToOptionalIfcId());
        }
        #endregion

    }
}