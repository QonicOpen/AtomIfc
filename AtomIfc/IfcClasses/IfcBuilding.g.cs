
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
    public class IfcBuilding : IfcSpatialStructureElement, IEquatable<IfcBuilding>
    {
        private double? _elevationOfRefHeight;
        public double? ElevationOfRefHeight 
        {
            get { 
                return _elevationOfRefHeight; 
            }
            set { 
                _elevationOfRefHeight = value;  // optional IfcLengthMeasure
            }
        }
        private double? _elevationOfTerrain;
        public double? ElevationOfTerrain 
        {
            get { 
                return _elevationOfTerrain; 
            }
            set { 
                _elevationOfTerrain = value;  // optional IfcLengthMeasure
            }
        }
        private IfcId _buildingAddressId;
        public IfcId BuildingAddressId 
        {
            get { 
                return _buildingAddressId; 
            }
            set { 
                _buildingAddressId = value;  // optional IfcPostalAddress
            }
        }

        public IfcBuilding(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string longName, IfcElementCompositionEnum compositionType, double? elevationOfRefHeight, double? elevationOfTerrain, IfcId buildingAddressId) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, longName, compositionType)
        {
            ElevationOfRefHeight = elevationOfRefHeight;
            ElevationOfTerrain = elevationOfTerrain;
            BuildingAddressId = buildingAddressId;
        }

        public override ClassId GetClassId() => ClassId.IfcBuilding;

        #region Equality

        public bool Equals(IfcBuilding other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ElevationOfRefHeight == other.ElevationOfRefHeight
                && ElevationOfTerrain == other.ElevationOfTerrain
                && BuildingAddressId == other.BuildingAddressId;
        }

        public override bool Equals(object other) => Equals(other as IfcBuilding);

        public static bool operator ==(IfcBuilding one, IfcBuilding other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBuilding one, IfcBuilding other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{LongName}',.{CompositionType}.,{ElevationOfRefHeight},{ElevationOfTerrain},{BuildingAddressId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BuildingAddressId!= null && replacementTable.ContainsKey(BuildingAddressId))
                BuildingAddressId = replacementTable[BuildingAddressId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBuilding (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, LongName, CompositionType, ElevationOfRefHeight, ElevationOfTerrain, BuildingAddressId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBuilding },
                { "class", nameof(IfcBuilding) },
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
                        ElevationOfRefHeight.ToJValue(),
                        ElevationOfTerrain.ToJValue(),
                        BuildingAddressId.ToJValue(),
                    }
                }
            };
        }

        public static IfcBuilding CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBuilding(
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
                parameters[9].ToOptionalDouble(),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalIfcId());
        }
        #endregion

    }
}