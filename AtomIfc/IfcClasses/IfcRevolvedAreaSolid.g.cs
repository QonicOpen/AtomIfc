
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
    public class IfcRevolvedAreaSolid : IfcSweptAreaSolid, IEquatable<IfcRevolvedAreaSolid>
    {
        private IfcId _axisId;
        public IfcId AxisId 
        {
            get { 
                return _axisId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("AxisId is not allowed to be null"); 
                _axisId = value;
            }
        }
        private double _angle;
        public double Angle 
        {
            get { 
                return _angle; 
            }
            set { 
                _angle = value;
            }
        }

        public IfcRevolvedAreaSolid(IfcId id, IfcId sweptAreaId, IfcId positionId, IfcId axisId, double angle) : base(id, sweptAreaId, positionId)
        {
            AxisId = axisId;
            Angle = angle;
        }

        public override ClassId GetClassId() => ClassId.IfcRevolvedAreaSolid;

        #region Equality

        public bool Equals(IfcRevolvedAreaSolid other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && AxisId == other.AxisId
                && Angle == other.Angle;
        }

        public override bool Equals(object other) => Equals(other as IfcRevolvedAreaSolid);

        public static bool operator ==(IfcRevolvedAreaSolid one, IfcRevolvedAreaSolid other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRevolvedAreaSolid one, IfcRevolvedAreaSolid other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SweptAreaId},{PositionId},{AxisId},{Angle})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(AxisId!= null && replacementTable.ContainsKey(AxisId))
                AxisId = replacementTable[AxisId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRevolvedAreaSolid (newId,SweptAreaId, PositionId, AxisId, Angle);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRevolvedAreaSolid },
                { "class", nameof(IfcRevolvedAreaSolid) },
                { "parameters" , new JArray
                    {
                        SweptAreaId.ToJValue(),
                        PositionId.ToJValue(),
                        AxisId.ToJValue(),
                        Angle,
                    }
                }
            };
        }

        public static IfcRevolvedAreaSolid CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRevolvedAreaSolid(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToDouble());
        }
        #endregion

    }
}