
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
    public class IfcExtrudedAreaSolidTapered : IfcExtrudedAreaSolid, IEquatable<IfcExtrudedAreaSolidTapered>
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

        public IfcExtrudedAreaSolidTapered(IfcId id, IfcId sweptAreaId, IfcId positionId, IfcId extrudedDirectionId, double depth, IfcId endSweptAreaId) : base(id, sweptAreaId, positionId, extrudedDirectionId, depth)
        {
            EndSweptAreaId = endSweptAreaId;
        }

        public override ClassId GetClassId() => ClassId.IfcExtrudedAreaSolidTapered;

        #region Equality

        public bool Equals(IfcExtrudedAreaSolidTapered other)
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

        public override bool Equals(object other) => Equals(other as IfcExtrudedAreaSolidTapered);

        public static bool operator ==(IfcExtrudedAreaSolidTapered one, IfcExtrudedAreaSolidTapered other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcExtrudedAreaSolidTapered one, IfcExtrudedAreaSolidTapered other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SweptAreaId},{PositionId},{ExtrudedDirectionId},{Depth},{EndSweptAreaId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EndSweptAreaId!= null && replacementTable.ContainsKey(EndSweptAreaId))
                EndSweptAreaId = replacementTable[EndSweptAreaId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcExtrudedAreaSolidTapered (newId,SweptAreaId, PositionId, ExtrudedDirectionId, Depth, EndSweptAreaId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcExtrudedAreaSolidTapered },
                { "class", nameof(IfcExtrudedAreaSolidTapered) },
                { "parameters" , new JArray
                    {
                        SweptAreaId.ToJValue(),
                        PositionId.ToJValue(),
                        ExtrudedDirectionId.ToJValue(),
                        Depth,
                        EndSweptAreaId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcExtrudedAreaSolidTapered CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcExtrudedAreaSolidTapered(
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