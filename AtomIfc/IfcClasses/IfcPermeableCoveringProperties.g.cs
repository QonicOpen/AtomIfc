
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
    public class IfcPermeableCoveringProperties : IfcPreDefinedPropertySet, IEquatable<IfcPermeableCoveringProperties>
    {
        private IfcPermeableCoveringOperationEnum _operationType;
        public IfcPermeableCoveringOperationEnum OperationType 
        {
            get { 
                return _operationType; 
            }
            set { 
                _operationType = value;
            }
        }
        private IfcWindowPanelPositionEnum _panelPosition;
        public IfcWindowPanelPositionEnum PanelPosition 
        {
            get { 
                return _panelPosition; 
            }
            set { 
                _panelPosition = value;
            }
        }
        private double? _frameDepth;
        public double? FrameDepth 
        {
            get { 
                return _frameDepth; 
            }
            set { 
                _frameDepth = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private double? _frameThickness;
        public double? FrameThickness 
        {
            get { 
                return _frameThickness; 
            }
            set { 
                _frameThickness = value;  // optional IfcPositiveLengthMeasure
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

        public IfcPermeableCoveringProperties(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, IfcPermeableCoveringOperationEnum operationType, IfcWindowPanelPositionEnum panelPosition, double? frameDepth, double? frameThickness, IfcId shapeAspectStyleId) : base(id, globalId, ownerHistoryId, name, description)
        {
            OperationType = operationType;
            PanelPosition = panelPosition;
            FrameDepth = frameDepth;
            FrameThickness = frameThickness;
            ShapeAspectStyleId = shapeAspectStyleId;
        }

        public override ClassId GetClassId() => ClassId.IfcPermeableCoveringProperties;

        #region Equality

        public bool Equals(IfcPermeableCoveringProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && OperationType == other.OperationType
                && PanelPosition == other.PanelPosition
                && FrameDepth == other.FrameDepth
                && FrameThickness == other.FrameThickness
                && ShapeAspectStyleId == other.ShapeAspectStyleId;
        }

        public override bool Equals(object other) => Equals(other as IfcPermeableCoveringProperties);

        public static bool operator ==(IfcPermeableCoveringProperties one, IfcPermeableCoveringProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPermeableCoveringProperties one, IfcPermeableCoveringProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}',.{OperationType}.,.{PanelPosition}.,{FrameDepth},{FrameThickness},{ShapeAspectStyleId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ShapeAspectStyleId!= null && replacementTable.ContainsKey(ShapeAspectStyleId))
                ShapeAspectStyleId = replacementTable[ShapeAspectStyleId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPermeableCoveringProperties (newId,GlobalId, OwnerHistoryId, Name, Description, OperationType, PanelPosition, FrameDepth, FrameThickness, ShapeAspectStyleId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPermeableCoveringProperties },
                { "class", nameof(IfcPermeableCoveringProperties) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        OperationType.ToJValue(),
                        PanelPosition.ToJValue(),
                        FrameDepth.ToJValue(),
                        FrameThickness.ToJValue(),
                        ShapeAspectStyleId.ToJValue(),
                    }
                }
            };
        }

        public static IfcPermeableCoveringProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPermeableCoveringProperties(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                (IfcPermeableCoveringOperationEnum)IfcAtom.EnumCreator[(int)EnumId.IfcPermeableCoveringOperationEnum](parameters[4].ToString()),
                (IfcWindowPanelPositionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcWindowPanelPositionEnum](parameters[5].ToString()),
                parameters[6].ToOptionalDouble(),
                parameters[7].ToOptionalDouble(),
                parameters[8].ToOptionalIfcId());
        }
        #endregion

    }
}