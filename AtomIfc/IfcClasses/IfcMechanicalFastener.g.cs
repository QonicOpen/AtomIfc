
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
    public class IfcMechanicalFastener : IfcElementComponent, IEquatable<IfcMechanicalFastener>
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
        private double? _nominalLength;
        public double? NominalLength 
        {
            get { 
                return _nominalLength; 
            }
            set { 
                _nominalLength = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private IfcMechanicalFastenerTypeEnum _predefinedType;
        public IfcMechanicalFastenerTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcMechanicalFastenerTypeEnum?
            }
        }

        public IfcMechanicalFastener(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, double? nominalDiameter, double? nominalLength, IfcMechanicalFastenerTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag)
        {
            NominalDiameter = nominalDiameter;
            NominalLength = nominalLength;
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcMechanicalFastener;

        #region Equality

        public bool Equals(IfcMechanicalFastener other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && NominalDiameter == other.NominalDiameter
                && NominalLength == other.NominalLength
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcMechanicalFastener);

        public static bool operator ==(IfcMechanicalFastener one, IfcMechanicalFastener other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMechanicalFastener one, IfcMechanicalFastener other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}',{NominalDiameter},{NominalLength},.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMechanicalFastener (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, NominalDiameter, NominalLength, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMechanicalFastener },
                { "class", nameof(IfcMechanicalFastener) },
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
                        NominalDiameter.ToJValue(),
                        NominalLength.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcMechanicalFastener CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMechanicalFastener(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalDouble(),
                parameters[9].ToOptionalDouble(),
                (IfcMechanicalFastenerTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcMechanicalFastenerTypeEnum](parameters[10].ToString()));
        }
        #endregion

    }
}