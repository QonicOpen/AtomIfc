
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
    public class IfcPolygonalFaceSet : IfcTessellatedFaceSet, IEquatable<IfcPolygonalFaceSet>
    {
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
        private List<IfcId> _faceIds;
        public List<IfcId> FaceIds 
        {
            get { 
                return _faceIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("FaceIds is not allowed to be null"); 
                _faceIds = value;
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

        public IfcPolygonalFaceSet(IfcId id, IfcId coordinatesId, bool? closed, List<IfcId> faceIds, List<int> pnIndex) : base(id, coordinatesId)
        {
            Closed = closed;
            FaceIds = faceIds;
            PnIndex = pnIndex;
        }

        public override ClassId GetClassId() => ClassId.IfcPolygonalFaceSet;

        #region Equality

        public bool Equals(IfcPolygonalFaceSet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(FaceIds, other.FaceIds))
                return false;
            if(!Utils.CompareList(PnIndex, other.PnIndex))
                return false;
            return base.Equals(other)
                && Closed == other.Closed;
        }

        public override bool Equals(object other) => Equals(other as IfcPolygonalFaceSet);

        public static bool operator ==(IfcPolygonalFaceSet one, IfcPolygonalFaceSet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPolygonalFaceSet one, IfcPolygonalFaceSet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({CoordinatesId},{(Closed == null? ".U." : Closed)},{Utils.ConvertListToString(FaceIds)},{Utils.ConvertListToString(PnIndex)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(FaceIds!= null)
                FaceIds = FaceIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPolygonalFaceSet (newId,CoordinatesId, Closed, FaceIds, PnIndex);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPolygonalFaceSet },
                { "class", nameof(IfcPolygonalFaceSet) },
                { "parameters" , new JArray
                    {
                        CoordinatesId.ToJValue(),
                        Closed.ToJValue(),
                        FaceIds.ToJArray(),
                        PnIndex.ToJArray(),
                    }
                }
            };
        }

        public static IfcPolygonalFaceSet CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPolygonalFaceSet(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalBool(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToOptionalIntList());
        }
        #endregion

    }
}