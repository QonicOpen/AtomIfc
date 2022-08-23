
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
    public class IfcBuildingStorey : IfcSpatialStructureElement, IEquatable<IfcBuildingStorey>
    {
        private double? _elevation;
        public double? Elevation 
        {
            get { 
                return _elevation; 
            }
            set { 
                _elevation = value;  // optional IfcLengthMeasure
            }
        }

        public IfcBuildingStorey(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string longName, IfcElementCompositionEnum compositionType, double? elevation) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, longName, compositionType)
        {
            Elevation = elevation;
        }

        public override ClassId GetClassId() => ClassId.IfcBuildingStorey;

        #region Equality

        public bool Equals(IfcBuildingStorey other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Elevation == other.Elevation;
        }

        public override bool Equals(object other) => Equals(other as IfcBuildingStorey);

        public static bool operator ==(IfcBuildingStorey one, IfcBuildingStorey other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBuildingStorey one, IfcBuildingStorey other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{LongName}',.{CompositionType}.,{Elevation})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBuildingStorey (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, LongName, CompositionType, Elevation);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBuildingStorey },
                { "class", nameof(IfcBuildingStorey) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        LongName.ToJValue(),
                        CompositionType.ToJValue(),
                        Elevation.ToJValue(),
                    }
                }
            };
        }

        public static IfcBuildingStorey CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBuildingStorey(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalString(),
                (IfcElementCompositionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcElementCompositionEnum](parameters[8].ToString()),
                parameters[9].ToOptionalDouble());
        }
        #endregion

    }
}