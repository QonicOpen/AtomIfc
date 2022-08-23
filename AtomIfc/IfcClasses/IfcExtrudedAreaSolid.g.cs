
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
    public class IfcExtrudedAreaSolid : IfcSweptAreaSolid, IEquatable<IfcExtrudedAreaSolid>
    {
        private IfcId _extrudedDirectionId;
        public IfcId ExtrudedDirectionId 
        {
            get { 
                return _extrudedDirectionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ExtrudedDirectionId is not allowed to be null"); 
                _extrudedDirectionId = value;
            }
        }
        private double _depth;
        public double Depth 
        {
            get { 
                return _depth; 
            }
            set { 
                _depth = value;
            }
        }

        public IfcExtrudedAreaSolid(IfcId id, IfcId sweptAreaId, IfcId positionId, IfcId extrudedDirectionId, double depth) : base(id, sweptAreaId, positionId)
        {
            ExtrudedDirectionId = extrudedDirectionId;
            Depth = depth;
        }

        public override ClassId GetClassId() => ClassId.IfcExtrudedAreaSolid;

        #region Equality

        public bool Equals(IfcExtrudedAreaSolid other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ExtrudedDirectionId == other.ExtrudedDirectionId
                && Depth == other.Depth;
        }

        public override bool Equals(object other) => Equals(other as IfcExtrudedAreaSolid);

        public static bool operator ==(IfcExtrudedAreaSolid one, IfcExtrudedAreaSolid other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcExtrudedAreaSolid one, IfcExtrudedAreaSolid other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SweptAreaId},{PositionId},{ExtrudedDirectionId},{Depth})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ExtrudedDirectionId!= null && replacementTable.ContainsKey(ExtrudedDirectionId))
                ExtrudedDirectionId = replacementTable[ExtrudedDirectionId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcExtrudedAreaSolid (newId,SweptAreaId, PositionId, ExtrudedDirectionId, Depth);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcExtrudedAreaSolid },
                { "class", nameof(IfcExtrudedAreaSolid) },
                { "parameters" , new JArray
                    {
                        SweptAreaId.ToJValue(),
                        PositionId.ToJValue(),
                        ExtrudedDirectionId.ToJValue(),
                        Depth,
                    }
                }
            };
        }

        public static IfcExtrudedAreaSolid CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcExtrudedAreaSolid(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToDouble());
        }
        #endregion

    }
}