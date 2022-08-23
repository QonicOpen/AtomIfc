
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
    public class IfcMaterialDefinitionRepresentation : IfcProductRepresentation, IEquatable<IfcMaterialDefinitionRepresentation>
    {
        private IfcId _representedMaterialId;
        public IfcId RepresentedMaterialId 
        {
            get { 
                return _representedMaterialId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RepresentedMaterialId is not allowed to be null"); 
                _representedMaterialId = value;
            }
        }

        public IfcMaterialDefinitionRepresentation(IfcId id, string name, string description, List<IfcId> representationIds, IfcId representedMaterialId) : base(id, name, description, representationIds)
        {
            RepresentedMaterialId = representedMaterialId;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialDefinitionRepresentation;

        #region Equality

        public bool Equals(IfcMaterialDefinitionRepresentation other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RepresentedMaterialId == other.RepresentedMaterialId;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialDefinitionRepresentation);

        public static bool operator ==(IfcMaterialDefinitionRepresentation one, IfcMaterialDefinitionRepresentation other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialDefinitionRepresentation one, IfcMaterialDefinitionRepresentation other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(RepresentationIds)},{RepresentedMaterialId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RepresentedMaterialId!= null && replacementTable.ContainsKey(RepresentedMaterialId))
                RepresentedMaterialId = replacementTable[RepresentedMaterialId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialDefinitionRepresentation (newId,Name, Description, RepresentationIds, RepresentedMaterialId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialDefinitionRepresentation },
                { "class", nameof(IfcMaterialDefinitionRepresentation) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RepresentationIds.ToJArray(),
                        RepresentedMaterialId.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialDefinitionRepresentation CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialDefinitionRepresentation(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToIfcId());
        }
        #endregion

    }
}