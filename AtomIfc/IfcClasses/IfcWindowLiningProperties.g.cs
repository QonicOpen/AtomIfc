
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
    public class IfcWindowLiningProperties : IfcPreDefinedPropertySet, IEquatable<IfcWindowLiningProperties>
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
        private double? _mullionThickness;
        public double? MullionThickness 
        {
            get { 
                return _mullionThickness; 
            }
            set { 
                _mullionThickness = value;  // optional IfcNonNegativeLengthMeasure
            }
        }
        private double? _firstTransomOffset;
        public double? FirstTransomOffset 
        {
            get { 
                return _firstTransomOffset; 
            }
            set { 
                _firstTransomOffset = value;  // optional IfcNormalisedRatioMeasure
            }
        }
        private double? _secondTransomOffset;
        public double? SecondTransomOffset 
        {
            get { 
                return _secondTransomOffset; 
            }
            set { 
                _secondTransomOffset = value;  // optional IfcNormalisedRatioMeasure
            }
        }
        private double? _firstMullionOffset;
        public double? FirstMullionOffset 
        {
            get { 
                return _firstMullionOffset; 
            }
            set { 
                _firstMullionOffset = value;  // optional IfcNormalisedRatioMeasure
            }
        }
        private double? _secondMullionOffset;
        public double? SecondMullionOffset 
        {
            get { 
                return _secondMullionOffset; 
            }
            set { 
                _secondMullionOffset = value;  // optional IfcNormalisedRatioMeasure
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

        public IfcWindowLiningProperties(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, double? liningDepth, double? liningThickness, double? transomThickness, double? mullionThickness, double? firstTransomOffset, double? secondTransomOffset, double? firstMullionOffset, double? secondMullionOffset, IfcId shapeAspectStyleId, double? liningOffset, double? liningToPanelOffsetX, double? liningToPanelOffsetY) : base(id, globalId, ownerHistoryId, name, description)
        {
            LiningDepth = liningDepth;
            LiningThickness = liningThickness;
            TransomThickness = transomThickness;
            MullionThickness = mullionThickness;
            FirstTransomOffset = firstTransomOffset;
            SecondTransomOffset = secondTransomOffset;
            FirstMullionOffset = firstMullionOffset;
            SecondMullionOffset = secondMullionOffset;
            ShapeAspectStyleId = shapeAspectStyleId;
            LiningOffset = liningOffset;
            LiningToPanelOffsetX = liningToPanelOffsetX;
            LiningToPanelOffsetY = liningToPanelOffsetY;
        }

        public override ClassId GetClassId() => ClassId.IfcWindowLiningProperties;

        #region Equality

        public bool Equals(IfcWindowLiningProperties other)
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
                && TransomThickness == other.TransomThickness
                && MullionThickness == other.MullionThickness
                && FirstTransomOffset == other.FirstTransomOffset
                && SecondTransomOffset == other.SecondTransomOffset
                && FirstMullionOffset == other.FirstMullionOffset
                && SecondMullionOffset == other.SecondMullionOffset
                && ShapeAspectStyleId == other.ShapeAspectStyleId
                && LiningOffset == other.LiningOffset
                && LiningToPanelOffsetX == other.LiningToPanelOffsetX
                && LiningToPanelOffsetY == other.LiningToPanelOffsetY;
        }

        public override bool Equals(object other) => Equals(other as IfcWindowLiningProperties);

        public static bool operator ==(IfcWindowLiningProperties one, IfcWindowLiningProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcWindowLiningProperties one, IfcWindowLiningProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}',{LiningDepth},{LiningThickness},{TransomThickness},{MullionThickness},{FirstTransomOffset},{SecondTransomOffset},{FirstMullionOffset},{SecondMullionOffset},{ShapeAspectStyleId},{LiningOffset},{LiningToPanelOffsetX},{LiningToPanelOffsetY})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ShapeAspectStyleId!= null && replacementTable.ContainsKey(ShapeAspectStyleId))
                ShapeAspectStyleId = replacementTable[ShapeAspectStyleId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcWindowLiningProperties (newId,GlobalId, OwnerHistoryId, Name, Description, LiningDepth, LiningThickness, TransomThickness, MullionThickness, FirstTransomOffset, SecondTransomOffset, FirstMullionOffset, SecondMullionOffset, ShapeAspectStyleId, LiningOffset, LiningToPanelOffsetX, LiningToPanelOffsetY);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcWindowLiningProperties },
                { "class", nameof(IfcWindowLiningProperties) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        LiningDepth.ToJValue(),
                        LiningThickness.ToJValue(),
                        TransomThickness.ToJValue(),
                        MullionThickness.ToJValue(),
                        FirstTransomOffset.ToJValue(),
                        SecondTransomOffset.ToJValue(),
                        FirstMullionOffset.ToJValue(),
                        SecondMullionOffset.ToJValue(),
                        ShapeAspectStyleId.ToJValue(),
                        LiningOffset.ToJValue(),
                        LiningToPanelOffsetX.ToJValue(),
                        LiningToPanelOffsetY.ToJValue(),
                    }
                }
            };
        }

        public static IfcWindowLiningProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcWindowLiningProperties(
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
                parameters[12].ToOptionalIfcId(),
                parameters[13].ToOptionalDouble(),
                parameters[14].ToOptionalDouble(),
                parameters[15].ToOptionalDouble());
        }
        #endregion

    }
}