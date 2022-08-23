
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
    public class IfcMaterialLayerSetUsage : IfcMaterialUsageDefinition, IEquatable<IfcMaterialLayerSetUsage>
    {
        private IfcId _forLayerSetId;
        public IfcId ForLayerSetId 
        {
            get { 
                return _forLayerSetId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ForLayerSetId is not allowed to be null"); 
                _forLayerSetId = value;
            }
        }
        private IfcLayerSetDirectionEnum _layerSetDirection;
        public IfcLayerSetDirectionEnum LayerSetDirection 
        {
            get { 
                return _layerSetDirection; 
            }
            set { 
                _layerSetDirection = value;
            }
        }
        private IfcDirectionSenseEnum _directionSense;
        public IfcDirectionSenseEnum DirectionSense 
        {
            get { 
                return _directionSense; 
            }
            set { 
                _directionSense = value;
            }
        }
        private double _offsetFromReferenceLine;
        public double OffsetFromReferenceLine 
        {
            get { 
                return _offsetFromReferenceLine; 
            }
            set { 
                _offsetFromReferenceLine = value;
            }
        }
        private double? _referenceExtent;
        public double? ReferenceExtent 
        {
            get { 
                return _referenceExtent; 
            }
            set { 
                _referenceExtent = value;  // optional IfcPositiveLengthMeasure
            }
        }

        public IfcMaterialLayerSetUsage(IfcId id, IfcId forLayerSetId, IfcLayerSetDirectionEnum layerSetDirection, IfcDirectionSenseEnum directionSense, double offsetFromReferenceLine, double? referenceExtent) : base(id)
        {
            ForLayerSetId = forLayerSetId;
            LayerSetDirection = layerSetDirection;
            DirectionSense = directionSense;
            OffsetFromReferenceLine = offsetFromReferenceLine;
            ReferenceExtent = referenceExtent;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialLayerSetUsage;

        #region Equality

        public bool Equals(IfcMaterialLayerSetUsage other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ForLayerSetId == other.ForLayerSetId
                && LayerSetDirection == other.LayerSetDirection
                && DirectionSense == other.DirectionSense
                && OffsetFromReferenceLine == other.OffsetFromReferenceLine
                && ReferenceExtent == other.ReferenceExtent;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialLayerSetUsage);

        public static bool operator ==(IfcMaterialLayerSetUsage one, IfcMaterialLayerSetUsage other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialLayerSetUsage one, IfcMaterialLayerSetUsage other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({ForLayerSetId},.{LayerSetDirection}.,.{DirectionSense}.,{OffsetFromReferenceLine},{ReferenceExtent})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ForLayerSetId!= null && replacementTable.ContainsKey(ForLayerSetId))
                ForLayerSetId = replacementTable[ForLayerSetId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialLayerSetUsage (newId,ForLayerSetId, LayerSetDirection, DirectionSense, OffsetFromReferenceLine, ReferenceExtent);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialLayerSetUsage },
                { "class", nameof(IfcMaterialLayerSetUsage) },
                { "parameters" , new JArray
                    {
                        ForLayerSetId.ToJValue(),
                        LayerSetDirection.ToJValue(),
                        DirectionSense.ToJValue(),
                        OffsetFromReferenceLine,
                        ReferenceExtent.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialLayerSetUsage CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialLayerSetUsage(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                (IfcLayerSetDirectionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcLayerSetDirectionEnum](parameters[1].ToString()),
                (IfcDirectionSenseEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDirectionSenseEnum](parameters[2].ToString()),
                parameters[3].ToDouble(),
                parameters[4].ToOptionalDouble());
        }
        #endregion

    }
}