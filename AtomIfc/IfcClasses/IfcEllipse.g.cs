
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
    public class IfcEllipse : IfcConic, IEquatable<IfcEllipse>
    {
        private double _semiAxis1;
        public double SemiAxis1 
        {
            get { 
                return _semiAxis1; 
            }
            set { 
                _semiAxis1 = value;
            }
        }
        private double _semiAxis2;
        public double SemiAxis2 
        {
            get { 
                return _semiAxis2; 
            }
            set { 
                _semiAxis2 = value;
            }
        }

        public IfcEllipse(IfcId id, IfcId positionId, double semiAxis1, double semiAxis2) : base(id, positionId)
        {
            SemiAxis1 = semiAxis1;
            SemiAxis2 = semiAxis2;
        }

        public override ClassId GetClassId() => ClassId.IfcEllipse;

        #region Equality

        public bool Equals(IfcEllipse other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && SemiAxis1 == other.SemiAxis1
                && SemiAxis2 == other.SemiAxis2;
        }

        public override bool Equals(object other) => Equals(other as IfcEllipse);

        public static bool operator ==(IfcEllipse one, IfcEllipse other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcEllipse one, IfcEllipse other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PositionId},{SemiAxis1},{SemiAxis2})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcEllipse (newId,PositionId, SemiAxis1, SemiAxis2);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcEllipse },
                { "class", nameof(IfcEllipse) },
                { "parameters" , new JArray
                    {
                        PositionId.ToJValue(),
                        SemiAxis1,
                        SemiAxis2,
                    }
                }
            };
        }

        public static IfcEllipse CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcEllipse(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToDouble());
        }
        #endregion

    }
}