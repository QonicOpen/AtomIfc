
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
    public class IfcReparametrisedCompositeCurveSegment : IfcCompositeCurveSegment, IEquatable<IfcReparametrisedCompositeCurveSegment>
    {
        private double _paramLength;
        public double ParamLength 
        {
            get { 
                return _paramLength; 
            }
            set { 
                _paramLength = value;
            }
        }

        public IfcReparametrisedCompositeCurveSegment(IfcId id, IfcTransitionCode transition, bool sameSense, IfcId parentCurveId, double paramLength) : base(id, transition, sameSense, parentCurveId)
        {
            ParamLength = paramLength;
        }

        public override ClassId GetClassId() => ClassId.IfcReparametrisedCompositeCurveSegment;

        #region Equality

        public bool Equals(IfcReparametrisedCompositeCurveSegment other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ParamLength == other.ParamLength;
        }

        public override bool Equals(object other) => Equals(other as IfcReparametrisedCompositeCurveSegment);

        public static bool operator ==(IfcReparametrisedCompositeCurveSegment one, IfcReparametrisedCompositeCurveSegment other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcReparametrisedCompositeCurveSegment one, IfcReparametrisedCompositeCurveSegment other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{Transition}.,{SameSense},{ParentCurveId},{ParamLength})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcReparametrisedCompositeCurveSegment (newId,Transition, SameSense, ParentCurveId, ParamLength);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcReparametrisedCompositeCurveSegment },
                { "class", nameof(IfcReparametrisedCompositeCurveSegment) },
                { "parameters" , new JArray
                    {
                        Transition.ToJValue(),
                        SameSense,
                        ParentCurveId.ToJValue(),
                        ParamLength,
                    }
                }
            };
        }

        public static new IfcReparametrisedCompositeCurveSegment CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcReparametrisedCompositeCurveSegment(
                jObject["id"].ToIfcId(),
                (IfcTransitionCode)IfcAtom.EnumCreator[(int)EnumId.IfcTransitionCode](parameters[0].ToString()),
                parameters[1].ToBool(),
                parameters[2].ToIfcId(),
                parameters[3].ToDouble());
        }
        #endregion

    }
}