
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
    public class IfcAxis1Placement : IfcPlacement, IEquatable<IfcAxis1Placement>
    {
        private IfcId _axisId;
        public IfcId AxisId 
        {
            get { 
                return _axisId; 
            }
            set { 
                _axisId = value;  // optional IfcDirection
            }
        }

        public IfcAxis1Placement(IfcId id, IfcId locationId, IfcId axisId) : base(id, locationId)
        {
            AxisId = axisId;
        }

        public override ClassId GetClassId() => ClassId.IfcAxis1Placement;

        #region Equality

        public bool Equals(IfcAxis1Placement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && AxisId == other.AxisId;
        }

        public override bool Equals(object other) => Equals(other as IfcAxis1Placement);

        public static bool operator ==(IfcAxis1Placement one, IfcAxis1Placement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcAxis1Placement one, IfcAxis1Placement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({LocationId},{AxisId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(AxisId!= null && replacementTable.ContainsKey(AxisId))
                AxisId = replacementTable[AxisId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcAxis1Placement (newId,LocationId, AxisId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcAxis1Placement },
                { "class", nameof(IfcAxis1Placement) },
                { "parameters" , new JArray
                    {
                        LocationId.ToJValue(),
                        AxisId.ToJValue(),
                    }
                }
            };
        }

        public static IfcAxis1Placement CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcAxis1Placement(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId());
        }
        #endregion

    }
}