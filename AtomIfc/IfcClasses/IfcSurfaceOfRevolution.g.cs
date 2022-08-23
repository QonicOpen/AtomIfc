
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
    public class IfcSurfaceOfRevolution : IfcSweptSurface, IEquatable<IfcSurfaceOfRevolution>
    {
        private IfcId _axisPositionId;
        public IfcId AxisPositionId 
        {
            get { 
                return _axisPositionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("AxisPositionId is not allowed to be null"); 
                _axisPositionId = value;
            }
        }

        public IfcSurfaceOfRevolution(IfcId id, IfcId sweptCurveId, IfcId positionId, IfcId axisPositionId) : base(id, sweptCurveId, positionId)
        {
            AxisPositionId = axisPositionId;
        }

        public override ClassId GetClassId() => ClassId.IfcSurfaceOfRevolution;

        #region Equality

        public bool Equals(IfcSurfaceOfRevolution other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && AxisPositionId == other.AxisPositionId;
        }

        public override bool Equals(object other) => Equals(other as IfcSurfaceOfRevolution);

        public static bool operator ==(IfcSurfaceOfRevolution one, IfcSurfaceOfRevolution other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSurfaceOfRevolution one, IfcSurfaceOfRevolution other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SweptCurveId},{PositionId},{AxisPositionId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(AxisPositionId!= null && replacementTable.ContainsKey(AxisPositionId))
                AxisPositionId = replacementTable[AxisPositionId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSurfaceOfRevolution (newId,SweptCurveId, PositionId, AxisPositionId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSurfaceOfRevolution },
                { "class", nameof(IfcSurfaceOfRevolution) },
                { "parameters" , new JArray
                    {
                        SweptCurveId.ToJValue(),
                        PositionId.ToJValue(),
                        AxisPositionId.ToJValue(),
                    }
                }
            };
        }

        public static IfcSurfaceOfRevolution CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSurfaceOfRevolution(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}