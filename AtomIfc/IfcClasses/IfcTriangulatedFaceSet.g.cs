
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
    public class IfcTriangulatedFaceSet : IfcTessellatedFaceSet, IEquatable<IfcTriangulatedFaceSet>
    {
        private List<double> _normals;
        public List<double> Normals 
        {
            get { 
                return _normals; 
            }
            set { 
                _normals = value;  // optional List<IfcParameterValue>
            }
        }
        private bool? _closed;
        public bool? Closed 
        {
            get { 
                return _closed; 
            }
            set { 
                _closed = value;  // optional bool?
            }
        }
        private List<List<int>> _coordIndex;
        public List<List<int>> CoordIndex 
        {
            get { 
                return _coordIndex; 
            }
            set { 
                _coordIndex = value;  // optional List<List<int>>
            }
        }
        private List<int> _pnIndex;
        public List<int> PnIndex 
        {
            get { 
                return _pnIndex; 
            }
            set { 
                _pnIndex = value;  // optional List<int>
            }
        }

        public IfcTriangulatedFaceSet(IfcId id, IfcId coordinatesId, List<double> normals, bool? closed, List<List<int>> coordIndex, List<int> pnIndex) : base(id, coordinatesId)
        {
            Normals = normals;
            Closed = closed;
            CoordIndex = coordIndex;
            PnIndex = pnIndex;
        }

        public override ClassId GetClassId() => ClassId.IfcTriangulatedFaceSet;

        #region Equality

        public bool Equals(IfcTriangulatedFaceSet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(Normals, other.Normals))
                return false;
            if(!Utils.CompareList(CoordIndex, other.CoordIndex))
                return false;
            if(!Utils.CompareList(PnIndex, other.PnIndex))
                return false;
            return base.Equals(other)
                && Closed == other.Closed;
        }

        public override bool Equals(object other) => Equals(other as IfcTriangulatedFaceSet);

        public static bool operator ==(IfcTriangulatedFaceSet one, IfcTriangulatedFaceSet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTriangulatedFaceSet one, IfcTriangulatedFaceSet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({CoordinatesId},{Utils.ConvertListToString(Normals)},{(Closed == null? ".U." : Closed)},{Utils.ConvertListToString(CoordIndex)},{Utils.ConvertListToString(PnIndex)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTriangulatedFaceSet (newId,CoordinatesId, Normals, Closed, CoordIndex, PnIndex);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTriangulatedFaceSet },
                { "class", nameof(IfcTriangulatedFaceSet) },
                { "parameters" , new JArray
                    {
                        CoordinatesId.ToJValue(),
                        Normals.ToJArray(),
                        Closed.ToJValue(),
                        CoordIndex.ToJArray(),
                        PnIndex.ToJArray(),
                    }
                }
            };
        }

        public static IfcTriangulatedFaceSet CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTriangulatedFaceSet(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalDoubleList(),
                parameters[2].ToOptionalBool(),
                parameters[3].ToOptionalNestedIntList(),
                parameters[4].ToOptionalIntList());
        }
        #endregion

    }
}