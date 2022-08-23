
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
    public class IfcSpace : IfcSpatialStructureElement, IEquatable<IfcSpace>, IIfcSpaceBoundarySelect
    {
        private IfcSpaceTypeEnum _predefinedType;
        public IfcSpaceTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcSpaceTypeEnum?
            }
        }
        private double? _elevationWithFlooring;
        public double? ElevationWithFlooring 
        {
            get { 
                return _elevationWithFlooring; 
            }
            set { 
                _elevationWithFlooring = value;  // optional IfcLengthMeasure
            }
        }

        public IfcSpace(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string longName, IfcElementCompositionEnum compositionType, IfcSpaceTypeEnum predefinedType, double? elevationWithFlooring) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, longName, compositionType)
        {
            PredefinedType = predefinedType;
            ElevationWithFlooring = elevationWithFlooring;
        }

        public override ClassId GetClassId() => ClassId.IfcSpace;

        #region Equality

        public bool Equals(IfcSpace other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && ElevationWithFlooring == other.ElevationWithFlooring;
        }

        public override bool Equals(object other) => Equals(other as IfcSpace);

        public static bool operator ==(IfcSpace one, IfcSpace other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSpace one, IfcSpace other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{LongName}',.{CompositionType}.,.{PredefinedType}.,{ElevationWithFlooring})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSpace (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, LongName, CompositionType, PredefinedType, ElevationWithFlooring);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSpace },
                { "class", nameof(IfcSpace) },
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
                        PredefinedType.ToJValue(),
                        ElevationWithFlooring.ToJValue(),
                    }
                }
            };
        }

        public static IfcSpace CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSpace(
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
                (IfcSpaceTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcSpaceTypeEnum](parameters[9].ToString()),
                parameters[10].ToOptionalDouble());
        }
        #endregion

    }
}