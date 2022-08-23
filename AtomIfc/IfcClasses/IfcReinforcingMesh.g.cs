
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
    public class IfcReinforcingMesh : IfcReinforcingElement, IEquatable<IfcReinforcingMesh>
    {
        private double? _meshLength;
        public double? MeshLength 
        {
            get { 
                return _meshLength; 
            }
            set { 
                _meshLength = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _meshWidth;
        public double? MeshWidth 
        {
            get { 
                return _meshWidth; 
            }
            set { 
                _meshWidth = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _longitudinalBarNominalDiameter;
        public double? LongitudinalBarNominalDiameter 
        {
            get { 
                return _longitudinalBarNominalDiameter; 
            }
            set { 
                _longitudinalBarNominalDiameter = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _transverseBarNominalDiameter;
        public double? TransverseBarNominalDiameter 
        {
            get { 
                return _transverseBarNominalDiameter; 
            }
            set { 
                _transverseBarNominalDiameter = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _longitudinalBarCrossSectionArea;
        public double? LongitudinalBarCrossSectionArea 
        {
            get { 
                return _longitudinalBarCrossSectionArea; 
            }
            set { 
                _longitudinalBarCrossSectionArea = value;  // optional IfcAreaMeasure
            }
        }
        private double? _transverseBarCrossSectionArea;
        public double? TransverseBarCrossSectionArea 
        {
            get { 
                return _transverseBarCrossSectionArea; 
            }
            set { 
                _transverseBarCrossSectionArea = value;  // optional IfcAreaMeasure
            }
        }
        private double? _longitudinalBarSpacing;
        public double? LongitudinalBarSpacing 
        {
            get { 
                return _longitudinalBarSpacing; 
            }
            set { 
                _longitudinalBarSpacing = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _transverseBarSpacing;
        public double? TransverseBarSpacing 
        {
            get { 
                return _transverseBarSpacing; 
            }
            set { 
                _transverseBarSpacing = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private IfcReinforcingMeshTypeEnum _predefinedType;
        public IfcReinforcingMeshTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcReinforcingMeshTypeEnum?
            }
        }

        public IfcReinforcingMesh(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, string steelGrade, double? meshLength, double? meshWidth, double? longitudinalBarNominalDiameter, double? transverseBarNominalDiameter, double? longitudinalBarCrossSectionArea, double? transverseBarCrossSectionArea, double? longitudinalBarSpacing, double? transverseBarSpacing, IfcReinforcingMeshTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag, steelGrade)
        {
            MeshLength = meshLength;
            MeshWidth = meshWidth;
            LongitudinalBarNominalDiameter = longitudinalBarNominalDiameter;
            TransverseBarNominalDiameter = transverseBarNominalDiameter;
            LongitudinalBarCrossSectionArea = longitudinalBarCrossSectionArea;
            TransverseBarCrossSectionArea = transverseBarCrossSectionArea;
            LongitudinalBarSpacing = longitudinalBarSpacing;
            TransverseBarSpacing = transverseBarSpacing;
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcReinforcingMesh;

        #region Equality

        public bool Equals(IfcReinforcingMesh other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && MeshLength == other.MeshLength
                && MeshWidth == other.MeshWidth
                && LongitudinalBarNominalDiameter == other.LongitudinalBarNominalDiameter
                && TransverseBarNominalDiameter == other.TransverseBarNominalDiameter
                && LongitudinalBarCrossSectionArea == other.LongitudinalBarCrossSectionArea
                && TransverseBarCrossSectionArea == other.TransverseBarCrossSectionArea
                && LongitudinalBarSpacing == other.LongitudinalBarSpacing
                && TransverseBarSpacing == other.TransverseBarSpacing
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcReinforcingMesh);

        public static bool operator ==(IfcReinforcingMesh one, IfcReinforcingMesh other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcReinforcingMesh one, IfcReinforcingMesh other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}','{SteelGrade}',{MeshLength},{MeshWidth},{LongitudinalBarNominalDiameter},{TransverseBarNominalDiameter},{LongitudinalBarCrossSectionArea},{TransverseBarCrossSectionArea},{LongitudinalBarSpacing},{TransverseBarSpacing},.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcReinforcingMesh (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, SteelGrade, MeshLength, MeshWidth, LongitudinalBarNominalDiameter, TransverseBarNominalDiameter, LongitudinalBarCrossSectionArea, TransverseBarCrossSectionArea, LongitudinalBarSpacing, TransverseBarSpacing, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcReinforcingMesh },
                { "class", nameof(IfcReinforcingMesh) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        Tag.ToJValue(),
                        SteelGrade.ToJValue(),
                        MeshLength.ToJValue(),
                        MeshWidth.ToJValue(),
                        LongitudinalBarNominalDiameter.ToJValue(),
                        TransverseBarNominalDiameter.ToJValue(),
                        LongitudinalBarCrossSectionArea.ToJValue(),
                        TransverseBarCrossSectionArea.ToJValue(),
                        LongitudinalBarSpacing.ToJValue(),
                        TransverseBarSpacing.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcReinforcingMesh CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcReinforcingMesh(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString(),
                parameters[9].ToOptionalDouble(),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalDouble(),
                parameters[12].ToOptionalDouble(),
                parameters[13].ToOptionalDouble(),
                parameters[14].ToOptionalDouble(),
                parameters[15].ToOptionalDouble(),
                parameters[16].ToOptionalDouble(),
                (IfcReinforcingMeshTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcReinforcingMeshTypeEnum](parameters[17].ToString()));
        }
        #endregion

    }
}