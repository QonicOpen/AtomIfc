
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
    public class IfcMaterialProfileSetUsageTapering : IfcMaterialProfileSetUsage, IEquatable<IfcMaterialProfileSetUsageTapering>
    {
        private IfcId _forProfileEndSetId;
        public IfcId ForProfileEndSetId 
        {
            get { 
                return _forProfileEndSetId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ForProfileEndSetId is not allowed to be null"); 
                _forProfileEndSetId = value;
            }
        }
        private int? _cardinalEndPoint;
        public int? CardinalEndPoint 
        {
            get { 
                return _cardinalEndPoint; 
            }
            set { 
                _cardinalEndPoint = value;  // optional IfcCardinalPointReference
            }
        }

        public IfcMaterialProfileSetUsageTapering(IfcId id, IfcId forProfileSetId, int? cardinalPoint, double? referenceExtent, IfcId forProfileEndSetId, int? cardinalEndPoint) : base(id, forProfileSetId, cardinalPoint, referenceExtent)
        {
            ForProfileEndSetId = forProfileEndSetId;
            CardinalEndPoint = cardinalEndPoint;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialProfileSetUsageTapering;

        #region Equality

        public bool Equals(IfcMaterialProfileSetUsageTapering other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ForProfileEndSetId == other.ForProfileEndSetId
                && CardinalEndPoint == other.CardinalEndPoint;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialProfileSetUsageTapering);

        public static bool operator ==(IfcMaterialProfileSetUsageTapering one, IfcMaterialProfileSetUsageTapering other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialProfileSetUsageTapering one, IfcMaterialProfileSetUsageTapering other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({ForProfileSetId},{CardinalPoint},{ReferenceExtent},{ForProfileEndSetId},{CardinalEndPoint})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ForProfileEndSetId!= null && replacementTable.ContainsKey(ForProfileEndSetId))
                ForProfileEndSetId = replacementTable[ForProfileEndSetId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialProfileSetUsageTapering (newId,ForProfileSetId, CardinalPoint, ReferenceExtent, ForProfileEndSetId, CardinalEndPoint);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialProfileSetUsageTapering },
                { "class", nameof(IfcMaterialProfileSetUsageTapering) },
                { "parameters" , new JArray
                    {
                        ForProfileSetId.ToJValue(),
                        CardinalPoint.ToJValue(),
                        ReferenceExtent.ToJValue(),
                        ForProfileEndSetId.ToJValue(),
                        CardinalEndPoint.ToJValue(),
                    }
                }
            };
        }

        public static new IfcMaterialProfileSetUsageTapering CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialProfileSetUsageTapering(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalInt(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToIfcId(),
                parameters[4].ToOptionalInt());
        }
        #endregion

    }
}