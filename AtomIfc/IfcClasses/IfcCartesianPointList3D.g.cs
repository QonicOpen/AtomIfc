
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
    public class IfcCartesianPointList3D : IfcCartesianPointList, IEquatable<IfcCartesianPointList3D>
    {
        private List<List<double>> _coordList;
        public List<List<double>> CoordList 
        {
            get { 
                return _coordList; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("CoordList is not allowed to be null"); 
                _coordList = value;
            }
        }

        public IfcCartesianPointList3D(IfcId id, List<List<double>> coordList) : base(id)
        {
            CoordList = coordList;
        }

        public override ClassId GetClassId() => ClassId.IfcCartesianPointList3D;

        #region Equality

        public bool Equals(IfcCartesianPointList3D other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(CoordList, other.CoordList))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcCartesianPointList3D);

        public static bool operator ==(IfcCartesianPointList3D one, IfcCartesianPointList3D other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCartesianPointList3D one, IfcCartesianPointList3D other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(CoordList)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCartesianPointList3D (newId,CoordList);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCartesianPointList3D },
                { "class", nameof(IfcCartesianPointList3D) },
                { "parameters" , new JArray
                    {
                        CoordList.ToJArray(),
                    }
                }
            };
        }

        public static IfcCartesianPointList3D CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCartesianPointList3D(
                jObject["id"].ToIfcId(),
                parameters[0].ToNestedDoubleList());
        }
        #endregion

    }
}