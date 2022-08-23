
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
    public class IfcConnectionPointGeometry : IfcConnectionGeometry, IEquatable<IfcConnectionPointGeometry>
    {
        private IfcId _pointOnRelatingElementId;
        public IfcId PointOnRelatingElementId 
        {
            get { 
                return _pointOnRelatingElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PointOnRelatingElementId is not allowed to be null"); 
                _pointOnRelatingElementId = value;
            }
        }
        private IfcId _pointOnRelatedElementId;
        public IfcId PointOnRelatedElementId 
        {
            get { 
                return _pointOnRelatedElementId; 
            }
            set { 
                _pointOnRelatedElementId = value;  // optional IfcPointOrVertexPoint
            }
        }

        public IfcConnectionPointGeometry(IfcId id, IfcId pointOnRelatingElementId, IfcId pointOnRelatedElementId) : base(id)
        {
            PointOnRelatingElementId = pointOnRelatingElementId;
            PointOnRelatedElementId = pointOnRelatedElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcConnectionPointGeometry;

        #region Equality

        public bool Equals(IfcConnectionPointGeometry other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PointOnRelatingElementId == other.PointOnRelatingElementId
                && PointOnRelatedElementId == other.PointOnRelatedElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcConnectionPointGeometry);

        public static bool operator ==(IfcConnectionPointGeometry one, IfcConnectionPointGeometry other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConnectionPointGeometry one, IfcConnectionPointGeometry other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PointOnRelatingElementId},{PointOnRelatedElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PointOnRelatingElementId!= null && replacementTable.ContainsKey(PointOnRelatingElementId))
                PointOnRelatingElementId = replacementTable[PointOnRelatingElementId];
            if(PointOnRelatedElementId!= null && replacementTable.ContainsKey(PointOnRelatedElementId))
                PointOnRelatedElementId = replacementTable[PointOnRelatedElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcConnectionPointGeometry (newId,PointOnRelatingElementId, PointOnRelatedElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcConnectionPointGeometry },
                { "class", nameof(IfcConnectionPointGeometry) },
                { "parameters" , new JArray
                    {
                        PointOnRelatingElementId.ToJValue(),
                        PointOnRelatedElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcConnectionPointGeometry CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcConnectionPointGeometry(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId());
        }
        #endregion

    }
}