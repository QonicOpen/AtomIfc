
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
    public class IfcShapeRepresentation : IfcShapeModel, IEquatable<IfcShapeRepresentation>
    {
        public IfcShapeRepresentation(IfcId id, IfcId contextOfItemsId, string representationIdentifier, string representationType, List<IfcId> itemIds) : base(id, contextOfItemsId, representationIdentifier, representationType, itemIds)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcShapeRepresentation;

        #region Equality

        public bool Equals(IfcShapeRepresentation other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcShapeRepresentation);

        public static bool operator ==(IfcShapeRepresentation one, IfcShapeRepresentation other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcShapeRepresentation one, IfcShapeRepresentation other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({ContextOfItemsId},'{RepresentationIdentifier}','{RepresentationType}',{Utils.ConvertListToString(ItemIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcShapeRepresentation (newId,ContextOfItemsId, RepresentationIdentifier, RepresentationType, ItemIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcShapeRepresentation },
                { "class", nameof(IfcShapeRepresentation) },
                { "parameters" , new JArray
                    {
                        ContextOfItemsId.ToJValue(),
                        RepresentationIdentifier.ToJValue(),
                        RepresentationType.ToJValue(),
                        ItemIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcShapeRepresentation CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcShapeRepresentation(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcIdList());
        }
        #endregion

    }
}