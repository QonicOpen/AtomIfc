
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
    public class IfcCartesianPoint : IfcPoint, IEquatable<IfcCartesianPoint>, IIfcTrimmingSelect
    {
        private List<double> _coordinates;
        public List<double> Coordinates 
        {
            get { 
                return _coordinates; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("Coordinates is not allowed to be null"); 
                _coordinates = value;
            }
        }

        public IfcCartesianPoint(IfcId id, List<double> coordinates) : base(id)
        {
            Coordinates = coordinates;
        }

        public override ClassId GetClassId() => ClassId.IfcCartesianPoint;

        #region Equality

        public bool Equals(IfcCartesianPoint other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(Coordinates, other.Coordinates))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcCartesianPoint);

        public static bool operator ==(IfcCartesianPoint one, IfcCartesianPoint other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCartesianPoint one, IfcCartesianPoint other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(Coordinates)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCartesianPoint (newId,Coordinates);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCartesianPoint },
                { "class", nameof(IfcCartesianPoint) },
                { "parameters" , new JArray
                    {
                        Coordinates.ToJArray(),
                    }
                }
            };
        }

        public static IfcCartesianPoint CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCartesianPoint(
                jObject["id"].ToIfcId(),
                parameters[0].ToDoubleList());
        }
        #endregion

    }
}