
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
    public class IfcDoorLiningProperties : IfcPreDefinedPropertySet, IEquatable<IfcDoorLiningProperties>
    {
        private double? _liningDepth;
        public double? LiningDepth 
        {
            get { 
                return _liningDepth; 
            }
            set { 
                _liningDepth = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _liningThickness;
        public double? LiningThickness 
        {
            get { 
                return _liningThickness; 
            }
            set { 
                _liningThickness = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _thresholdDepth;
        public double? ThresholdDepth 
        {
            get { 
                return _thresholdDepth; 
            }
            set { 
                _thresholdDepth = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _thresholdThickness;
        public double? ThresholdThickness 
        {
            get { 
                return _thresholdThickness; 
            }
            set { 
                _thresholdThickness = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _transomThickness;
        public double? TransomThickness 
        {
            get { 
                return _transomThickness; 
            }
            set { 
                _transomThickness = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _transomOffset;
        public double? TransomOffset 
        {
            get { 
                return _transomOffset; 
            }
            set { 
                _transomOffset = value;  // optional IfcLengthMeasure
            }
        }
        private double? _liningOffset;
        public double? LiningOffset 
        {
            get { 
                return _liningOffset; 
            }
            set { 
                _liningOffset = value;  // optional IfcLengthMeasure
            }
        }
        private double? _thresholdOffset;
        public double? ThresholdOffset 
        {
            get { 
                return _thresholdOffset; 
            }
            set { 
                _thresholdOffset = value;  // optional IfcLengthMeasure
            }
        }
        private double? _casingThickness;
        public double? CasingThickness 
        {
            get { 
                return _casingThickness; 
            }
            set { 
                _casingThickness = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _casingDepth;
        public double? CasingDepth 
        {
            get { 
                return _casingDepth; 
            }
            set { 
                _casingDepth = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private IfcId _shapeAspectStyleId;
        public IfcId ShapeAspectStyleId 
        {
            get { 
                return _shapeAspectStyleId; 
            }
            set { 
                _shapeAspectStyleId = value;  // optional IfcShapeAspect
            }
        }
        private double? _liningToPanelOffsetX;
        public double? LiningToPanelOffsetX 
        {
            get { 
                return _liningToPanelOffsetX; 
            }
            set { 
                _liningToPanelOffsetX = value;  // optional IfcLengthMeasure
            }
        }
        private double? _liningToPanelOffsetY;
        public double? LiningToPanelOffsetY 
        {
            get { 
                return _liningToPanelOffsetY; 
            }
            set { 
                _liningToPanelOffsetY = value;  // optional IfcLengthMeasure
            }
        }

        public IfcDoorLiningProperties(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, double? liningDepth, double? liningThickness, double? thresholdDepth, double? thresholdThickness, double? transomThickness, double? transomOffset, double? liningOffset, double? thresholdOffset, double? casingThickness, double? casingDepth, IfcId shapeAspectStyleId, double? liningToPanelOffsetX, double? liningToPanelOffsetY) : base(id, globalId, ownerHistoryId, name, description)
        {
            LiningDepth = liningDepth;
            LiningThickness = liningThickness;
            ThresholdDepth = thresholdDepth;
            ThresholdThickness = thresholdThickness;
            TransomThickness = transomThickness;
            TransomOffset = transomOffset;
            LiningOffset = liningOffset;
            ThresholdOffset = thresholdOffset;
            CasingThickness = casingThickness;
            CasingDepth = casingDepth;
            ShapeAspectStyleId = shapeAspectStyleId;
            LiningToPanelOffsetX = liningToPanelOffsetX;
            LiningToPanelOffsetY = liningToPanelOffsetY;
        }

        public override ClassId GetClassId() => ClassId.IfcDoorLiningProperties;

        #region Equality

        public bool Equals(IfcDoorLiningProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LiningDepth == other.LiningDepth
                && LiningThickness == other.LiningThickness
                && ThresholdDepth == other.ThresholdDepth
                && ThresholdThickness == other.ThresholdThickness
                && TransomThickness == other.TransomThickness
                && TransomOffset == other.TransomOffset
                && LiningOffset == other.LiningOffset
                && ThresholdOffset == other.ThresholdOffset
                && CasingThickness == other.CasingThickness
                && CasingDepth == other.CasingDepth
                && ShapeAspectStyleId == other.ShapeAspectStyleId
                && LiningToPanelOffsetX == other.LiningToPanelOffsetX
                && LiningToPanelOffsetY == other.LiningToPanelOffsetY;
        }

        public override bool Equals(object other) => Equals(other as IfcDoorLiningProperties);

        public static bool operator ==(IfcDoorLiningProperties one, IfcDoorLiningProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDoorLiningProperties one, IfcDoorLiningProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}',{LiningDepth},{LiningThickness},{ThresholdDepth},{ThresholdThickness},{TransomThickness},{TransomOffset},{LiningOffset},{ThresholdOffset},{CasingThickness},{CasingDepth},{ShapeAspectStyleId},{LiningToPanelOffsetX},{LiningToPanelOffsetY})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ShapeAspectStyleId!= null && replacementTable.ContainsKey(ShapeAspectStyleId))
                ShapeAspectStyleId = replacementTable[ShapeAspectStyleId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDoorLiningProperties (newId,GlobalId, OwnerHistoryId, Name, Description, LiningDepth, LiningThickness, ThresholdDepth, ThresholdThickness, TransomThickness, TransomOffset, LiningOffset, ThresholdOffset, CasingThickness, CasingDepth, ShapeAspectStyleId, LiningToPanelOffsetX, LiningToPanelOffsetY);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDoorLiningProperties },
                { "class", nameof(IfcDoorLiningProperties) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        LiningDepth.ToJValue(),
                        LiningThickness.ToJValue(),
                        ThresholdDepth.ToJValue(),
                        ThresholdThickness.ToJValue(),
                        TransomThickness.ToJValue(),
                        TransomOffset.ToJValue(),
                        LiningOffset.ToJValue(),
                        ThresholdOffset.ToJValue(),
                        CasingThickness.ToJValue(),
                        CasingDepth.ToJValue(),
                        ShapeAspectStyleId.ToJValue(),
                        LiningToPanelOffsetX.ToJValue(),
                        LiningToPanelOffsetY.ToJValue(),
                    }
                }
            };
        }

        public static IfcDoorLiningProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDoorLiningProperties(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToOptionalDouble(),
                parameters[6].ToOptionalDouble(),
                parameters[7].ToOptionalDouble(),
                parameters[8].ToOptionalDouble(),
                parameters[9].ToOptionalDouble(),
                parameters[10].ToOptionalDouble(),
                parameters[11].ToOptionalDouble(),
                parameters[12].ToOptionalDouble(),
                parameters[13].ToOptionalDouble(),
                parameters[14].ToOptionalIfcId(),
                parameters[15].ToOptionalDouble(),
                parameters[16].ToOptionalDouble());
        }
        #endregion

    }
}