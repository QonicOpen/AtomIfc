
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
    public class IfcProjectedCRS : IfcCoordinateReferenceSystem, IEquatable<IfcProjectedCRS>
    {
        private string _mapProjection;
        public string MapProjection 
        {
            get { 
                return _mapProjection; 
            }
            set { 
                _mapProjection = value;  // optional IfcIdentifier
            }
        }
        private string _mapZone;
        public string MapZone 
        {
            get { 
                return _mapZone; 
            }
            set { 
                _mapZone = value;  // optional IfcIdentifier
            }
        }
        private IfcId _mapUnitId;
        public IfcId MapUnitId 
        {
            get { 
                return _mapUnitId; 
            }
            set { 
                _mapUnitId = value;  // optional IfcNamedUnit
            }
        }

        public IfcProjectedCRS(IfcId id, string name, string description, string geodeticDatum, string verticalDatum, string mapProjection, string mapZone, IfcId mapUnitId) : base(id, name, description, geodeticDatum, verticalDatum)
        {
            MapProjection = mapProjection;
            MapZone = mapZone;
            MapUnitId = mapUnitId;
        }

        public override ClassId GetClassId() => ClassId.IfcProjectedCRS;

        #region Equality

        public bool Equals(IfcProjectedCRS other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && MapProjection == other.MapProjection
                && MapZone == other.MapZone
                && MapUnitId == other.MapUnitId;
        }

        public override bool Equals(object other) => Equals(other as IfcProjectedCRS);

        public static bool operator ==(IfcProjectedCRS one, IfcProjectedCRS other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcProjectedCRS one, IfcProjectedCRS other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}','{GeodeticDatum}','{VerticalDatum}','{MapProjection}','{MapZone}',{MapUnitId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MapUnitId!= null && replacementTable.ContainsKey(MapUnitId))
                MapUnitId = replacementTable[MapUnitId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcProjectedCRS (newId,Name, Description, GeodeticDatum, VerticalDatum, MapProjection, MapZone, MapUnitId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcProjectedCRS },
                { "class", nameof(IfcProjectedCRS) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        GeodeticDatum.ToJValue(),
                        VerticalDatum.ToJValue(),
                        MapProjection.ToJValue(),
                        MapZone.ToJValue(),
                        MapUnitId.ToJValue(),
                    }
                }
            };
        }

        public static IfcProjectedCRS CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcProjectedCRS(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalIfcId());
        }
        #endregion

    }
}