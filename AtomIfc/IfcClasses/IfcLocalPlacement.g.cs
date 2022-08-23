
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
    public class IfcLocalPlacement : IfcObjectPlacement, IEquatable<IfcLocalPlacement>
    {
        private IfcId _placementRelToId;
        public IfcId PlacementRelToId 
        {
            get { 
                return _placementRelToId; 
            }
            set { 
                _placementRelToId = value;  // optional IfcObjectPlacement
            }
        }
        private IfcId _relativePlacementId;
        public IfcId RelativePlacementId 
        {
            get { 
                return _relativePlacementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelativePlacementId is not allowed to be null"); 
                _relativePlacementId = value;
            }
        }

        public IfcLocalPlacement(IfcId id, IfcId placementRelToId, IfcId relativePlacementId) : base(id)
        {
            PlacementRelToId = placementRelToId;
            RelativePlacementId = relativePlacementId;
        }

        public override ClassId GetClassId() => ClassId.IfcLocalPlacement;

        #region Equality

        public bool Equals(IfcLocalPlacement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PlacementRelToId == other.PlacementRelToId
                && RelativePlacementId == other.RelativePlacementId;
        }

        public override bool Equals(object other) => Equals(other as IfcLocalPlacement);

        public static bool operator ==(IfcLocalPlacement one, IfcLocalPlacement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLocalPlacement one, IfcLocalPlacement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PlacementRelToId},{RelativePlacementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PlacementRelToId!= null && replacementTable.ContainsKey(PlacementRelToId))
                PlacementRelToId = replacementTable[PlacementRelToId];
            if(RelativePlacementId!= null && replacementTable.ContainsKey(RelativePlacementId))
                RelativePlacementId = replacementTable[RelativePlacementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLocalPlacement (newId,PlacementRelToId, RelativePlacementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLocalPlacement },
                { "class", nameof(IfcLocalPlacement) },
                { "parameters" , new JArray
                    {
                        PlacementRelToId.ToJValue(),
                        RelativePlacementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcLocalPlacement CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLocalPlacement(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToIfcId());
        }
        #endregion

    }
}