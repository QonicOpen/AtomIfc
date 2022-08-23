
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
    public class IfcAxis2Placement3D : IfcPlacement, IEquatable<IfcAxis2Placement3D>, IIfcAxis2Placement
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
        private IfcId _refDirectionId;
        public IfcId RefDirectionId 
        {
            get { 
                return _refDirectionId; 
            }
            set { 
                _refDirectionId = value;  // optional IfcDirection
            }
        }

        public IfcAxis2Placement3D(IfcId id, IfcId locationId, IfcId axisId, IfcId refDirectionId) : base(id, locationId)
        {
            AxisId = axisId;
            RefDirectionId = refDirectionId;
        }

        public override ClassId GetClassId() => ClassId.IfcAxis2Placement3D;

        #region Equality

        public bool Equals(IfcAxis2Placement3D other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && AxisId == other.AxisId
                && RefDirectionId == other.RefDirectionId;
        }

        public override bool Equals(object other) => Equals(other as IfcAxis2Placement3D);

        public static bool operator ==(IfcAxis2Placement3D one, IfcAxis2Placement3D other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcAxis2Placement3D one, IfcAxis2Placement3D other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({LocationId},{AxisId},{RefDirectionId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(AxisId!= null && replacementTable.ContainsKey(AxisId))
                AxisId = replacementTable[AxisId];
            if(RefDirectionId!= null && replacementTable.ContainsKey(RefDirectionId))
                RefDirectionId = replacementTable[RefDirectionId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcAxis2Placement3D (newId,LocationId, AxisId, RefDirectionId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcAxis2Placement3D },
                { "class", nameof(IfcAxis2Placement3D) },
                { "parameters" , new JArray
                    {
                        LocationId.ToJValue(),
                        AxisId.ToJValue(),
                        RefDirectionId.ToJValue(),
                    }
                }
            };
        }

        public static IfcAxis2Placement3D CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcAxis2Placement3D(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalIfcId());
        }
        #endregion

    }
}