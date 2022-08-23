
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
    public class IfcReinforcingBar : IfcReinforcingElement, IEquatable<IfcReinforcingBar>
    {
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
        private IfcReinforcingBarTypeEnum _predefinedType;
        public IfcReinforcingBarTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcReinforcingBarTypeEnum?
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

        public IfcReinforcingBar(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, string steelGrade, double? nominalDiameter, double? crossSectionArea, double? barLength, IfcReinforcingBarTypeEnum predefinedType, IfcReinforcingBarSurfaceEnum barSurface) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag, steelGrade)
        {
            NominalDiameter = nominalDiameter;
            CrossSectionArea = crossSectionArea;
            BarLength = barLength;
            PredefinedType = predefinedType;
            BarSurface = barSurface;
        }

        public override ClassId GetClassId() => ClassId.IfcReinforcingBar;

        #region Equality

        public bool Equals(IfcReinforcingBar other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && NominalDiameter == other.NominalDiameter
                && CrossSectionArea == other.CrossSectionArea
                && BarLength == other.BarLength
                && PredefinedType == other.PredefinedType
                && BarSurface == other.BarSurface;
        }

        public override bool Equals(object other) => Equals(other as IfcReinforcingBar);

        public static bool operator ==(IfcReinforcingBar one, IfcReinforcingBar other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcReinforcingBar one, IfcReinforcingBar other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}','{SteelGrade}',{NominalDiameter},{CrossSectionArea},{BarLength},.{PredefinedType}.,.{BarSurface}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcReinforcingBar (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, SteelGrade, NominalDiameter, CrossSectionArea, BarLength, PredefinedType, BarSurface);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcReinforcingBar },
                { "class", nameof(IfcReinforcingBar) },
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
                        NominalDiameter.ToJValue(),
                        CrossSectionArea.ToJValue(),
                        BarLength.ToJValue(),
                        PredefinedType.ToJValue(),
                        BarSurface.ToJValue(),
                    }
                }
            };
        }

        public static IfcReinforcingBar CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcReinforcingBar(
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
                (IfcReinforcingBarTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcReinforcingBarTypeEnum](parameters[12].ToString()),
                (IfcReinforcingBarSurfaceEnum)IfcAtom.EnumCreator[(int)EnumId.IfcReinforcingBarSurfaceEnum](parameters[13].ToString()));
        }
        #endregion

    }
}