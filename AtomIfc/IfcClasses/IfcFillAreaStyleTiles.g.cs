
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
    public class IfcFillAreaStyleTiles : IfcGeometricRepresentationItem, IEquatable<IfcFillAreaStyleTiles>, IIfcFillStyleSelect
    {
        private List<IfcId> _tilingPatternIds;
        public List<IfcId> TilingPatternIds 
        {
            get { 
                return _tilingPatternIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TilingPatternIds is not allowed to be null"); 
                _tilingPatternIds = value;
            }
        }
        private List<IfcId> _tileIds;
        public List<IfcId> TileIds 
        {
            get { 
                return _tileIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TileIds is not allowed to be null"); 
                _tileIds = value;
            }
        }
        private double _tilingScale;
        public double TilingScale 
        {
            get { 
                return _tilingScale; 
            }
            set { 
                _tilingScale = value;
            }
        }

        public IfcFillAreaStyleTiles(IfcId id, List<IfcId> tilingPatternIds, List<IfcId> tileIds, double tilingScale) : base(id)
        {
            TilingPatternIds = tilingPatternIds;
            TileIds = tileIds;
            TilingScale = tilingScale;
        }

        public override ClassId GetClassId() => ClassId.IfcFillAreaStyleTiles;

        #region Equality

        public bool Equals(IfcFillAreaStyleTiles other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(TilingPatternIds, other.TilingPatternIds))
                return false;
            if(!Utils.CompareList(TileIds, other.TileIds))
                return false;
            return base.Equals(other)
                && TilingScale == other.TilingScale;
        }

        public override bool Equals(object other) => Equals(other as IfcFillAreaStyleTiles);

        public static bool operator ==(IfcFillAreaStyleTiles one, IfcFillAreaStyleTiles other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFillAreaStyleTiles one, IfcFillAreaStyleTiles other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(TilingPatternIds)},{Utils.ConvertListToString(TileIds)},{TilingScale})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TilingPatternIds!= null)
                TilingPatternIds = TilingPatternIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(TileIds!= null)
                TileIds = TileIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFillAreaStyleTiles (newId,TilingPatternIds, TileIds, TilingScale);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFillAreaStyleTiles },
                { "class", nameof(IfcFillAreaStyleTiles) },
                { "parameters" , new JArray
                    {
                        TilingPatternIds.ToJArray(),
                        TileIds.ToJArray(),
                        TilingScale,
                    }
                }
            };
        }

        public static IfcFillAreaStyleTiles CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFillAreaStyleTiles(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToIfcIdList(),
                parameters[2].ToDouble());
        }
        #endregion

    }
}