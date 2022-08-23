
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
    public class IfcMaterialProfileSetUsage : IfcMaterialUsageDefinition, IEquatable<IfcMaterialProfileSetUsage>
    {
        private IfcId _forProfileSetId;
        public IfcId ForProfileSetId 
        {
            get { 
                return _forProfileSetId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ForProfileSetId is not allowed to be null"); 
                _forProfileSetId = value;
            }
        }
        private int? _cardinalPoint;
        public int? CardinalPoint 
        {
            get { 
                return _cardinalPoint; 
            }
            set { 
                _cardinalPoint = value;  // optional IfcCardinalPointReference
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

        public IfcMaterialProfileSetUsage(IfcId id, IfcId forProfileSetId, int? cardinalPoint, double? referenceExtent) : base(id)
        {
            ForProfileSetId = forProfileSetId;
            CardinalPoint = cardinalPoint;
            ReferenceExtent = referenceExtent;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialProfileSetUsage;

        #region Equality

        public bool Equals(IfcMaterialProfileSetUsage other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ForProfileSetId == other.ForProfileSetId
                && CardinalPoint == other.CardinalPoint
                && ReferenceExtent == other.ReferenceExtent;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialProfileSetUsage);

        public static bool operator ==(IfcMaterialProfileSetUsage one, IfcMaterialProfileSetUsage other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialProfileSetUsage one, IfcMaterialProfileSetUsage other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({ForProfileSetId},{CardinalPoint},{ReferenceExtent})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ForProfileSetId!= null && replacementTable.ContainsKey(ForProfileSetId))
                ForProfileSetId = replacementTable[ForProfileSetId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialProfileSetUsage (newId,ForProfileSetId, CardinalPoint, ReferenceExtent);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialProfileSetUsage },
                { "class", nameof(IfcMaterialProfileSetUsage) },
                { "parameters" , new JArray
                    {
                        ForProfileSetId.ToJValue(),
                        CardinalPoint.ToJValue(),
                        ReferenceExtent.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialProfileSetUsage CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialProfileSetUsage(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalInt(),
                parameters[2].ToOptionalDouble());
        }
        #endregion

    }
}