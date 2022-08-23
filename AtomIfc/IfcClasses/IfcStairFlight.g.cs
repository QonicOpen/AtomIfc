
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
    public class IfcStairFlight : IfcBuildingElement, IEquatable<IfcStairFlight>
    {
        private int? _numberOfRiser;
        public int? NumberOfRiser 
        {
            get { 
                return _numberOfRiser; 
            }
            set { 
                _numberOfRiser = value;  // optional int?
            }
        }
        private int? _numberOfTreads;
        public int? NumberOfTreads 
        {
            get { 
                return _numberOfTreads; 
            }
            set { 
                _numberOfTreads = value;  // optional int?
            }
        }
        private double? _riserHeight;
        public double? RiserHeight 
        {
            get { 
                return _riserHeight; 
            }
            set { 
                _riserHeight = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _treadLength;
        public double? TreadLength 
        {
            get { 
                return _treadLength; 
            }
            set { 
                _treadLength = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private IfcStairFlightTypeEnum _predefinedType;
        public IfcStairFlightTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcStairFlightTypeEnum?
            }
        }

        public IfcStairFlight(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, int? numberOfRiser, int? numberOfTreads, double? riserHeight, double? treadLength, IfcStairFlightTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag)
        {
            NumberOfRiser = numberOfRiser;
            NumberOfTreads = numberOfTreads;
            RiserHeight = riserHeight;
            TreadLength = treadLength;
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcStairFlight;

        #region Equality

        public bool Equals(IfcStairFlight other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && NumberOfRiser == other.NumberOfRiser
                && NumberOfTreads == other.NumberOfTreads
                && RiserHeight == other.RiserHeight
                && TreadLength == other.TreadLength
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcStairFlight);

        public static bool operator ==(IfcStairFlight one, IfcStairFlight other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStairFlight one, IfcStairFlight other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}',{NumberOfRiser},{NumberOfTreads},{RiserHeight},{TreadLength},.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStairFlight (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, NumberOfRiser, NumberOfTreads, RiserHeight, TreadLength, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStairFlight },
                { "class", nameof(IfcStairFlight) },
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
                        NumberOfRiser.ToJValue(),
                        NumberOfTreads.ToJValue(),
                        RiserHeight.ToJValue(),
                        TreadLength.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcStairFlight CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStairFlight(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalInt(),
                parameters[9].ToOptionalInt(),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalDouble(),
                (IfcStairFlightTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcStairFlightTypeEnum](parameters[12].ToString()));
        }
        #endregion

    }
}