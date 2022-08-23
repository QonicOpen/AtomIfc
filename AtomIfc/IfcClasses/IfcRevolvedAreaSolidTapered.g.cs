
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
    public class IfcRevolvedAreaSolidTapered : IfcRevolvedAreaSolid, IEquatable<IfcRevolvedAreaSolidTapered>
    {
        private IfcId _endSweptAreaId;
        public IfcId EndSweptAreaId 
        {
            get { 
                return _endSweptAreaId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("EndSweptAreaId is not allowed to be null"); 
                _endSweptAreaId = value;
            }
        }

        public IfcRevolvedAreaSolidTapered(IfcId id, IfcId sweptAreaId, IfcId positionId, IfcId axisId, double angle, IfcId endSweptAreaId) : base(id, sweptAreaId, positionId, axisId, angle)
        {
            EndSweptAreaId = endSweptAreaId;
        }

        public override ClassId GetClassId() => ClassId.IfcRevolvedAreaSolidTapered;

        #region Equality

        public bool Equals(IfcRevolvedAreaSolidTapered other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && EndSweptAreaId == other.EndSweptAreaId;
        }

        public override bool Equals(object other) => Equals(other as IfcRevolvedAreaSolidTapered);

        public static bool operator ==(IfcRevolvedAreaSolidTapered one, IfcRevolvedAreaSolidTapered other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRevolvedAreaSolidTapered one, IfcRevolvedAreaSolidTapered other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SweptAreaId},{PositionId},{AxisId},{Angle},{EndSweptAreaId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EndSweptAreaId!= null && replacementTable.ContainsKey(EndSweptAreaId))
                EndSweptAreaId = replacementTable[EndSweptAreaId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRevolvedAreaSolidTapered (newId,SweptAreaId, PositionId, AxisId, Angle, EndSweptAreaId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRevolvedAreaSolidTapered },
                { "class", nameof(IfcRevolvedAreaSolidTapered) },
                { "parameters" , new JArray
                    {
                        SweptAreaId.ToJValue(),
                        PositionId.ToJValue(),
                        AxisId.ToJValue(),
                        Angle,
                        EndSweptAreaId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcRevolvedAreaSolidTapered CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRevolvedAreaSolidTapered(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToIfcId());
        }
        #endregion

    }
}