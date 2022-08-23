
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
    public class IfcPlanarBox : IfcPlanarExtent, IEquatable<IfcPlanarBox>
    {
        private IfcId _placementId;
        public IfcId PlacementId 
        {
            get { 
                return _placementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PlacementId is not allowed to be null"); 
                _placementId = value;
            }
        }

        public IfcPlanarBox(IfcId id, double sizeInX, double sizeInY, IfcId placementId) : base(id, sizeInX, sizeInY)
        {
            PlacementId = placementId;
        }

        public override ClassId GetClassId() => ClassId.IfcPlanarBox;

        #region Equality

        public bool Equals(IfcPlanarBox other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PlacementId == other.PlacementId;
        }

        public override bool Equals(object other) => Equals(other as IfcPlanarBox);

        public static bool operator ==(IfcPlanarBox one, IfcPlanarBox other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPlanarBox one, IfcPlanarBox other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SizeInX},{SizeInY},{PlacementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PlacementId!= null && replacementTable.ContainsKey(PlacementId))
                PlacementId = replacementTable[PlacementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPlanarBox (newId,SizeInX, SizeInY, PlacementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPlanarBox },
                { "class", nameof(IfcPlanarBox) },
                { "parameters" , new JArray
                    {
                        SizeInX,
                        SizeInY,
                        PlacementId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcPlanarBox CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPlanarBox(
                jObject["id"].ToIfcId(),
                parameters[0].ToDouble(),
                parameters[1].ToDouble(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}