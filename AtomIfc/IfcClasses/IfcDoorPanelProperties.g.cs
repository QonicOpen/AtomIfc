
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
    public class IfcDoorPanelProperties : IfcPreDefinedPropertySet, IEquatable<IfcDoorPanelProperties>
    {
        private double? _panelDepth;
        public double? PanelDepth 
        {
            get { 
                return _panelDepth; 
            }
            set { 
                _panelDepth = value;  // optional IfcPositiveLengthMeasure
            }
        }
        private IfcDoorPanelOperationEnum _panelOperation;
        public IfcDoorPanelOperationEnum PanelOperation 
        {
            get { 
                return _panelOperation; 
            }
            set { 
                _panelOperation = value;
            }
        }
        private double? _panelWidth;
        public double? PanelWidth 
        {
            get { 
                return _panelWidth; 
            }
            set { 
                _panelWidth = value;  // optional IfcNormalisedRatioMeasure
            }
        }
        private IfcDoorPanelPositionEnum _panelPosition;
        public IfcDoorPanelPositionEnum PanelPosition 
        {
            get { 
                return _panelPosition; 
            }
            set { 
                _panelPosition = value;
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

        public IfcDoorPanelProperties(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, double? panelDepth, IfcDoorPanelOperationEnum panelOperation, double? panelWidth, IfcDoorPanelPositionEnum panelPosition, IfcId shapeAspectStyleId) : base(id, globalId, ownerHistoryId, name, description)
        {
            PanelDepth = panelDepth;
            PanelOperation = panelOperation;
            PanelWidth = panelWidth;
            PanelPosition = panelPosition;
            ShapeAspectStyleId = shapeAspectStyleId;
        }

        public override ClassId GetClassId() => ClassId.IfcDoorPanelProperties;

        #region Equality

        public bool Equals(IfcDoorPanelProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PanelDepth == other.PanelDepth
                && PanelOperation == other.PanelOperation
                && PanelWidth == other.PanelWidth
                && PanelPosition == other.PanelPosition
                && ShapeAspectStyleId == other.ShapeAspectStyleId;
        }

        public override bool Equals(object other) => Equals(other as IfcDoorPanelProperties);

        public static bool operator ==(IfcDoorPanelProperties one, IfcDoorPanelProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDoorPanelProperties one, IfcDoorPanelProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}',{PanelDepth},.{PanelOperation}.,{PanelWidth},.{PanelPosition}.,{ShapeAspectStyleId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ShapeAspectStyleId!= null && replacementTable.ContainsKey(ShapeAspectStyleId))
                ShapeAspectStyleId = replacementTable[ShapeAspectStyleId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDoorPanelProperties (newId,GlobalId, OwnerHistoryId, Name, Description, PanelDepth, PanelOperation, PanelWidth, PanelPosition, ShapeAspectStyleId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDoorPanelProperties },
                { "class", nameof(IfcDoorPanelProperties) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        PanelDepth.ToJValue(),
                        PanelOperation.ToJValue(),
                        PanelWidth.ToJValue(),
                        PanelPosition.ToJValue(),
                        ShapeAspectStyleId.ToJValue(),
                    }
                }
            };
        }

        public static IfcDoorPanelProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDoorPanelProperties(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalDouble(),
                (IfcDoorPanelOperationEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDoorPanelOperationEnum](parameters[5].ToString()),
                parameters[6].ToOptionalDouble(),
                (IfcDoorPanelPositionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDoorPanelPositionEnum](parameters[7].ToString()),
                parameters[8].ToOptionalIfcId());
        }
        #endregion

    }
}