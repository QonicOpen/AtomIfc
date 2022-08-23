
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
    public class IfcWindow : IfcBuildingElement, IEquatable<IfcWindow>
    {
        private double? _overallHeight;
        public double? OverallHeight 
        {
            get { 
                return _overallHeight; 
            }
            set { 
                _overallHeight = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _overallWidth;
        public double? OverallWidth 
        {
            get { 
                return _overallWidth; 
            }
            set { 
                _overallWidth = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private IfcWindowTypeEnum _predefinedType;
        public IfcWindowTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcWindowTypeEnum?
            }
        }
        private IfcWindowTypePartitioningEnum _partitioningType;
        public IfcWindowTypePartitioningEnum PartitioningType 
        {
            get { 
                return _partitioningType; 
            }
            set { 
                _partitioningType = value;  // optional IfcWindowTypePartitioningEnum?
            }
        }
        private string _userDefinedPartitioningType;
        public string UserDefinedPartitioningType 
        {
            get { 
                return _userDefinedPartitioningType; 
            }
            set { 
                _userDefinedPartitioningType = value;  // optional IfcLabel
            }
        }

        public IfcWindow(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, double? overallHeight, double? overallWidth, IfcWindowTypeEnum predefinedType, IfcWindowTypePartitioningEnum partitioningType, string userDefinedPartitioningType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag)
        {
            OverallHeight = overallHeight;
            OverallWidth = overallWidth;
            PredefinedType = predefinedType;
            PartitioningType = partitioningType;
            UserDefinedPartitioningType = userDefinedPartitioningType;
        }

        public override ClassId GetClassId() => ClassId.IfcWindow;

        #region Equality

        public bool Equals(IfcWindow other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && OverallHeight == other.OverallHeight
                && OverallWidth == other.OverallWidth
                && PredefinedType == other.PredefinedType
                && PartitioningType == other.PartitioningType
                && UserDefinedPartitioningType == other.UserDefinedPartitioningType;
        }

        public override bool Equals(object other) => Equals(other as IfcWindow);

        public static bool operator ==(IfcWindow one, IfcWindow other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcWindow one, IfcWindow other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}',{OverallHeight},{OverallWidth},.{PredefinedType}.,.{PartitioningType}.,'{UserDefinedPartitioningType}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcWindow (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, OverallHeight, OverallWidth, PredefinedType, PartitioningType, UserDefinedPartitioningType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcWindow },
                { "class", nameof(IfcWindow) },
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
                        OverallHeight.ToJValue(),
                        OverallWidth.ToJValue(),
                        PredefinedType.ToJValue(),
                        PartitioningType.ToJValue(),
                        UserDefinedPartitioningType.ToJValue(),
                    }
                }
            };
        }

        public static IfcWindow CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcWindow(
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
                (IfcWindowTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcWindowTypeEnum](parameters[10].ToString()),
                (IfcWindowTypePartitioningEnum)IfcAtom.EnumCreator[(int)EnumId.IfcWindowTypePartitioningEnum](parameters[11].ToString()),
                parameters[12].ToOptionalString());
        }
        #endregion

    }
}