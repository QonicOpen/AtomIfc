
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
    public class IfcReinforcingMeshType : IfcReinforcingElementType, IEquatable<IfcReinforcingMeshType>
    {
        private IfcReinforcingMeshTypeEnum _predefinedType;
        public IfcReinforcingMeshTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }
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
        private string _bendingShapeCode;
        public string BendingShapeCode 
        {
            get { 
                return _bendingShapeCode; 
            }
            set { 
                _bendingShapeCode = value;  // optional IfcLabel
            }
        }
        private List<IfcId> _bendingParameterIds;
        public List<IfcId> BendingParameterIds 
        {
            get { 
                return _bendingParameterIds; 
            }
            set { 
                _bendingParameterIds = value;  // optional List<IfcBendingParameterSelect>
            }
        }

        public IfcReinforcingMeshType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, string elementType, IfcReinforcingMeshTypeEnum predefinedType, double? meshLength, double? meshWidth, double? longitudinalBarNominalDiameter, double? transverseBarNominalDiameter, double? longitudinalBarCrossSectionArea, double? transverseBarCrossSectionArea, double? longitudinalBarSpacing, double? transverseBarSpacing, string bendingShapeCode, List<IfcId> bendingParameterIds) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag, elementType)
        {
            PredefinedType = predefinedType;
            MeshLength = meshLength;
            MeshWidth = meshWidth;
            LongitudinalBarNominalDiameter = longitudinalBarNominalDiameter;
            TransverseBarNominalDiameter = transverseBarNominalDiameter;
            LongitudinalBarCrossSectionArea = longitudinalBarCrossSectionArea;
            TransverseBarCrossSectionArea = transverseBarCrossSectionArea;
            LongitudinalBarSpacing = longitudinalBarSpacing;
            TransverseBarSpacing = transverseBarSpacing;
            BendingShapeCode = bendingShapeCode;
            BendingParameterIds = bendingParameterIds;
        }

        public override ClassId GetClassId() => ClassId.IfcReinforcingMeshType;

        #region Equality

        public bool Equals(IfcReinforcingMeshType other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(BendingParameterIds, other.BendingParameterIds))
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && MeshLength == other.MeshLength
                && MeshWidth == other.MeshWidth
                && LongitudinalBarNominalDiameter == other.LongitudinalBarNominalDiameter
                && TransverseBarNominalDiameter == other.TransverseBarNominalDiameter
                && LongitudinalBarCrossSectionArea == other.LongitudinalBarCrossSectionArea
                && TransverseBarCrossSectionArea == other.TransverseBarCrossSectionArea
                && LongitudinalBarSpacing == other.LongitudinalBarSpacing
                && TransverseBarSpacing == other.TransverseBarSpacing
                && BendingShapeCode == other.BendingShapeCode;
        }

        public override bool Equals(object other) => Equals(other as IfcReinforcingMeshType);

        public static bool operator ==(IfcReinforcingMeshType one, IfcReinforcingMeshType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcReinforcingMeshType one, IfcReinforcingMeshType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}','{ElementType}',.{PredefinedType}.,{MeshLength},{MeshWidth},{LongitudinalBarNominalDiameter},{TransverseBarNominalDiameter},{LongitudinalBarCrossSectionArea},{TransverseBarCrossSectionArea},{LongitudinalBarSpacing},{TransverseBarSpacing},'{BendingShapeCode}',{Utils.ConvertListToString(BendingParameterIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BendingParameterIds!= null)
                BendingParameterIds = BendingParameterIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcReinforcingMeshType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag, ElementType, PredefinedType, MeshLength, MeshWidth, LongitudinalBarNominalDiameter, TransverseBarNominalDiameter, LongitudinalBarCrossSectionArea, TransverseBarCrossSectionArea, LongitudinalBarSpacing, TransverseBarSpacing, BendingShapeCode, BendingParameterIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcReinforcingMeshType },
                { "class", nameof(IfcReinforcingMeshType) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ApplicableOccurrence.ToJValue(),
                        PropertySetIds.ToJArray(),
                        RepresentationMapIds.ToJArray(),
                        Tag.ToJValue(),
                        ElementType.ToJValue(),
                        PredefinedType.ToJValue(),
                        MeshLength.ToJValue(),
                        MeshWidth.ToJValue(),
                        LongitudinalBarNominalDiameter.ToJValue(),
                        TransverseBarNominalDiameter.ToJValue(),
                        LongitudinalBarCrossSectionArea.ToJValue(),
                        TransverseBarCrossSectionArea.ToJValue(),
                        LongitudinalBarSpacing.ToJValue(),
                        TransverseBarSpacing.ToJValue(),
                        BendingShapeCode.ToJValue(),
                        BendingParameterIds.ToJArray(),
                    }
                }
            };
        }

        public static new IfcReinforcingMeshType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcReinforcingMeshType(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcIdList(),
                parameters[6].ToOptionalIfcIdList(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString(),
                (IfcReinforcingMeshTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcReinforcingMeshTypeEnum](parameters[9].ToString()),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalDouble(),
                parameters[12].ToOptionalDouble(),
                parameters[13].ToOptionalDouble(),
                parameters[14].ToOptionalDouble(),
                parameters[15].ToOptionalDouble(),
                parameters[16].ToOptionalDouble(),
                parameters[17].ToOptionalDouble(),
                parameters[18].ToOptionalString(),
                parameters[19].ToOptionalIfcIdList());
        }
        #endregion

    }
}