
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
    public class IfcCompositeCurveSegment : IfcGeometricRepresentationItem, IEquatable<IfcCompositeCurveSegment>
    {
        private IfcTransitionCode _transition;
        public IfcTransitionCode Transition 
        {
            get { 
                return _transition; 
            }
            set { 
                _transition = value;
            }
        }
        private bool _sameSense;
        public bool SameSense 
        {
            get { 
                return _sameSense; 
            }
            set { 
                _sameSense = value;
            }
        }
        private IfcId _parentCurveId;
        public IfcId ParentCurveId 
        {
            get { 
                return _parentCurveId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ParentCurveId is not allowed to be null"); 
                _parentCurveId = value;
            }
        }

        public IfcCompositeCurveSegment(IfcId id, IfcTransitionCode transition, bool sameSense, IfcId parentCurveId) : base(id)
        {
            Transition = transition;
            SameSense = sameSense;
            ParentCurveId = parentCurveId;
        }

        public override ClassId GetClassId() => ClassId.IfcCompositeCurveSegment;

        #region Equality

        public bool Equals(IfcCompositeCurveSegment other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Transition == other.Transition
                && SameSense == other.SameSense
                && ParentCurveId == other.ParentCurveId;
        }

        public override bool Equals(object other) => Equals(other as IfcCompositeCurveSegment);

        public static bool operator ==(IfcCompositeCurveSegment one, IfcCompositeCurveSegment other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCompositeCurveSegment one, IfcCompositeCurveSegment other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{Transition}.,{SameSense},{ParentCurveId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ParentCurveId!= null && replacementTable.ContainsKey(ParentCurveId))
                ParentCurveId = replacementTable[ParentCurveId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCompositeCurveSegment (newId,Transition, SameSense, ParentCurveId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCompositeCurveSegment },
                { "class", nameof(IfcCompositeCurveSegment) },
                { "parameters" , new JArray
                    {
                        Transition.ToJValue(),
                        SameSense,
                        ParentCurveId.ToJValue(),
                    }
                }
            };
        }

        public static IfcCompositeCurveSegment CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCompositeCurveSegment(
                jObject["id"].ToIfcId(),
                (IfcTransitionCode)IfcAtom.EnumCreator[(int)EnumId.IfcTransitionCode](parameters[0].ToString()),
                parameters[1].ToBool(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}