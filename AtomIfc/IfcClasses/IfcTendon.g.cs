
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
    public class IfcTendon : IfcReinforcingElement, IEquatable<IfcTendon>
    {
        private IfcTendonTypeEnum _predefinedType;
        public IfcTendonTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcTendonTypeEnum?
            }
        }
        private double? _nominalDiameter;
        public double? NominalDiameter 
        {
            get { 
                return _nominalDiameter; 
            }
            set { 
                _nominalDiameter = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _crossSectionArea;
        public double? CrossSectionArea 
        {
            get { 
                return _crossSectionArea; 
            }
            set { 
                _crossSectionArea = value;  // optional IfcAreaMeasure
            }
        }
        private double? _tensionForce;
        public double? TensionForce 
        {
            get { 
                return _tensionForce; 
            }
            set { 
                _tensionForce = value;  // optional IfcForceMeasure
            }
        }
        private double? _preStress;
        public double? PreStress 
        {
            get { 
                return _preStress; 
            }
            set { 
                _preStress = value;  // optional IfcPressureMeasure
            }
        }
        private double? _frictionCoefficient;
        public double? FrictionCoefficient 
        {
            get { 
                return _frictionCoefficient; 
            }
            set { 
                _frictionCoefficient = value;  // optional IfcNormalisedRatioMeasure
            }
        }
        private double? _anchorageSlip;
        public double? AnchorageSlip 
        {
            get { 
                return _anchorageSlip; 
            }
            set { 
                _anchorageSlip = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _minCurvatureRadius;
        public double? MinCurvatureRadius 
        {
            get { 
                return _minCurvatureRadius; 
            }
            set { 
                _minCurvatureRadius = value;  // optional IfcPositiveLengthMeasure
            }
        }

        public IfcTendon(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, string steelGrade, IfcTendonTypeEnum predefinedType, double? nominalDiameter, double? crossSectionArea, double? tensionForce, double? preStress, double? frictionCoefficient, double? anchorageSlip, double? minCurvatureRadius) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag, steelGrade)
        {
            PredefinedType = predefinedType;
            NominalDiameter = nominalDiameter;
            CrossSectionArea = crossSectionArea;
            TensionForce = tensionForce;
            PreStress = preStress;
            FrictionCoefficient = frictionCoefficient;
            AnchorageSlip = anchorageSlip;
            MinCurvatureRadius = minCurvatureRadius;
        }

        public override ClassId GetClassId() => ClassId.IfcTendon;

        #region Equality

        public bool Equals(IfcTendon other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && NominalDiameter == other.NominalDiameter
                && CrossSectionArea == other.CrossSectionArea
                && TensionForce == other.TensionForce
                && PreStress == other.PreStress
                && FrictionCoefficient == other.FrictionCoefficient
                && AnchorageSlip == other.AnchorageSlip
                && MinCurvatureRadius == other.MinCurvatureRadius;
        }

        public override bool Equals(object other) => Equals(other as IfcTendon);

        public static bool operator ==(IfcTendon one, IfcTendon other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTendon one, IfcTendon other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}','{SteelGrade}',.{PredefinedType}.,{NominalDiameter},{CrossSectionArea},{TensionForce},{PreStress},{FrictionCoefficient},{AnchorageSlip},{MinCurvatureRadius})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTendon (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, SteelGrade, PredefinedType, NominalDiameter, CrossSectionArea, TensionForce, PreStress, FrictionCoefficient, AnchorageSlip, MinCurvatureRadius);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTendon },
                { "class", nameof(IfcTendon) },
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
                        PredefinedType.ToJValue(),
                        NominalDiameter.ToJValue(),
                        CrossSectionArea.ToJValue(),
                        TensionForce.ToJValue(),
                        PreStress.ToJValue(),
                        FrictionCoefficient.ToJValue(),
                        AnchorageSlip.ToJValue(),
                        MinCurvatureRadius.ToJValue(),
                    }
                }
            };
        }

        public static IfcTendon CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTendon(
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
                (IfcTendonTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcTendonTypeEnum](parameters[9].ToString()),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalDouble(),
                parameters[12].ToOptionalDouble(),
                parameters[13].ToOptionalDouble(),
                parameters[14].ToOptionalDouble(),
                parameters[15].ToOptionalDouble(),
                parameters[16].ToOptionalDouble());
        }
        #endregion

    }
}