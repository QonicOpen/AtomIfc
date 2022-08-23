
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
    public class IfcVector : IfcGeometricRepresentationItem, IEquatable<IfcVector>, IIfcHatchLineDistanceSelect, IIfcVectorOrDirection
    {
        private IfcId _orientationId;
        public IfcId OrientationId 
        {
            get { 
                return _orientationId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OrientationId is not allowed to be null"); 
                _orientationId = value;
            }
        }
        private double _magnitude;
        public double Magnitude 
        {
            get { 
                return _magnitude; 
            }
            set { 
                _magnitude = value;
            }
        }

        public IfcVector(IfcId id, IfcId orientationId, double magnitude) : base(id)
        {
            OrientationId = orientationId;
            Magnitude = magnitude;
        }

        public override ClassId GetClassId() => ClassId.IfcVector;

        #region Equality

        public bool Equals(IfcVector other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && OrientationId == other.OrientationId
                && Magnitude == other.Magnitude;
        }

        public override bool Equals(object other) => Equals(other as IfcVector);

        public static bool operator ==(IfcVector one, IfcVector other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcVector one, IfcVector other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OrientationId},{Magnitude})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(OrientationId!= null && replacementTable.ContainsKey(OrientationId))
                OrientationId = replacementTable[OrientationId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcVector (newId,OrientationId, Magnitude);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcVector },
                { "class", nameof(IfcVector) },
                { "parameters" , new JArray
                    {
                        OrientationId.ToJValue(),
                        Magnitude,
                    }
                }
            };
        }

        public static IfcVector CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcVector(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble());
        }
        #endregion

    }
}