
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
    public class IfcAxis2Placement2D : IfcPlacement, IEquatable<IfcAxis2Placement2D>, IIfcAxis2Placement
    {
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

        public IfcAxis2Placement2D(IfcId id, IfcId locationId, IfcId refDirectionId) : base(id, locationId)
        {
            RefDirectionId = refDirectionId;
        }

        public override ClassId GetClassId() => ClassId.IfcAxis2Placement2D;

        #region Equality

        public bool Equals(IfcAxis2Placement2D other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RefDirectionId == other.RefDirectionId;
        }

        public override bool Equals(object other) => Equals(other as IfcAxis2Placement2D);

        public static bool operator ==(IfcAxis2Placement2D one, IfcAxis2Placement2D other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcAxis2Placement2D one, IfcAxis2Placement2D other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({LocationId},{RefDirectionId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RefDirectionId!= null && replacementTable.ContainsKey(RefDirectionId))
                RefDirectionId = replacementTable[RefDirectionId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcAxis2Placement2D (newId,LocationId, RefDirectionId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcAxis2Placement2D },
                { "class", nameof(IfcAxis2Placement2D) },
                { "parameters" , new JArray
                    {
                        LocationId.ToJValue(),
                        RefDirectionId.ToJValue(),
                    }
                }
            };
        }

        public static IfcAxis2Placement2D CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcAxis2Placement2D(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId());
        }
        #endregion

    }
}