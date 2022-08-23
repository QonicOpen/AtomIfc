
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
    public class IfcReinforcingBarType : IfcReinforcingElementType, IEquatable<IfcReinforcingBarType>
    {
        private IfcReinforcingBarTypeEnum _predefinedType;
        public IfcReinforcingBarTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
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
        private double? _barLength;
        public double? BarLength 
        {
            get { 
                return _barLength; 
            }
            set { 
                _barLength = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private IfcReinforcingBarSurfaceEnum _barSurface;
        public IfcReinforcingBarSurfaceEnum BarSurface 
        {
            get { 
                return _barSurface; 
            }
            set { 
                _barSurface = value;  // optional IfcReinforcingBarSurfaceEnum?
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

        public IfcReinforcingBarType(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag, string elementType, IfcReinforcingBarTypeEnum predefinedType, double? nominalDiameter, double? crossSectionArea, double? barLength, IfcReinforcingBarSurfaceEnum barSurface, string bendingShapeCode, List<IfcId> bendingParameterIds) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds, representationMapIds, tag, elementType)
        {
            PredefinedType = predefinedType;
            NominalDiameter = nominalDiameter;
            CrossSectionArea = crossSectionArea;
            BarLength = barLength;
            BarSurface = barSurface;
            BendingShapeCode = bendingShapeCode;
            BendingParameterIds = bendingParameterIds;
        }

        public override ClassId GetClassId() => ClassId.IfcReinforcingBarType;

        #region Equality

        public bool Equals(IfcReinforcingBarType other)
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
                && NominalDiameter == other.NominalDiameter
                && CrossSectionArea == other.CrossSectionArea
                && BarLength == other.BarLength
                && BarSurface == other.BarSurface
                && BendingShapeCode == other.BendingShapeCode;
        }

        public override bool Equals(object other) => Equals(other as IfcReinforcingBarType);

        public static bool operator ==(IfcReinforcingBarType one, IfcReinforcingBarType other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcReinforcingBarType one, IfcReinforcingBarType other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}','{ElementType}',.{PredefinedType}.,{NominalDiameter},{CrossSectionArea},{BarLength},.{BarSurface}.,'{BendingShapeCode}',{Utils.ConvertListToString(BendingParameterIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BendingParameterIds!= null)
                BendingParameterIds = BendingParameterIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcReinforcingBarType (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag, ElementType, PredefinedType, NominalDiameter, CrossSectionArea, BarLength, BarSurface, BendingShapeCode, BendingParameterIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcReinforcingBarType },
                { "class", nameof(IfcReinforcingBarType) },
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
                        NominalDiameter.ToJValue(),
                        CrossSectionArea.ToJValue(),
                        BarLength.ToJValue(),
                        BarSurface.ToJValue(),
                        BendingShapeCode.ToJValue(),
                        BendingParameterIds.ToJArray(),
                    }
                }
            };
        }

        public static new IfcReinforcingBarType CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcReinforcingBarType(
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
                (IfcReinforcingBarTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcReinforcingBarTypeEnum](parameters[9].ToString()),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalDouble(),
                parameters[12].ToOptionalDouble(),
                (IfcReinforcingBarSurfaceEnum)IfcAtom.EnumCreator[(int)EnumId.IfcReinforcingBarSurfaceEnum](parameters[13].ToString()),
                parameters[14].ToOptionalString(),
                parameters[15].ToOptionalIfcIdList());
        }
        #endregion

    }
}