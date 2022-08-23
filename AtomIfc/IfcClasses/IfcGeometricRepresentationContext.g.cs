
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
    public class IfcGeometricRepresentationContext : IfcRepresentationContext, IEquatable<IfcGeometricRepresentationContext>, IIfcCoordinateReferenceSystemSelect
    {
        private int _coordinateSpaceDimension;
        public int CoordinateSpaceDimension 
        {
            get { 
                return _coordinateSpaceDimension; 
            }
            set { 
                _coordinateSpaceDimension = value;
            }
        }
        private double? _precision;
        public double? Precision 
        {
            get { 
                return _precision; 
            }
            set { 
                _precision = value;  // optional double
            }
        }
        private IfcId _worldCoordinateSystemId;
        public IfcId WorldCoordinateSystemId 
        {
            get { 
                return _worldCoordinateSystemId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("WorldCoordinateSystemId is not allowed to be null"); 
                _worldCoordinateSystemId = value;
            }
        }
        private IfcId _trueNorthId;
        public IfcId TrueNorthId 
        {
            get { 
                return _trueNorthId; 
            }
            set { 
                _trueNorthId = value;  // optional IfcDirection
            }
        }

        public IfcGeometricRepresentationContext(IfcId id, string contextIdentifier, string contextType, int coordinateSpaceDimension, double? precision, IfcId worldCoordinateSystemId, IfcId trueNorthId) : base(id, contextIdentifier, contextType)
        {
            CoordinateSpaceDimension = coordinateSpaceDimension;
            Precision = precision;
            WorldCoordinateSystemId = worldCoordinateSystemId;
            TrueNorthId = trueNorthId;
        }

        public override ClassId GetClassId() => ClassId.IfcGeometricRepresentationContext;

        #region Equality

        public bool Equals(IfcGeometricRepresentationContext other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && CoordinateSpaceDimension == other.CoordinateSpaceDimension
                && Precision == other.Precision
                && WorldCoordinateSystemId == other.WorldCoordinateSystemId
                && TrueNorthId == other.TrueNorthId;
        }

        public override bool Equals(object other) => Equals(other as IfcGeometricRepresentationContext);

        public static bool operator ==(IfcGeometricRepresentationContext one, IfcGeometricRepresentationContext other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcGeometricRepresentationContext one, IfcGeometricRepresentationContext other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{ContextIdentifier}','{ContextType}',{CoordinateSpaceDimension},{Precision},{WorldCoordinateSystemId},{TrueNorthId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(WorldCoordinateSystemId!= null && replacementTable.ContainsKey(WorldCoordinateSystemId))
                WorldCoordinateSystemId = replacementTable[WorldCoordinateSystemId];
            if(TrueNorthId!= null && replacementTable.ContainsKey(TrueNorthId))
                TrueNorthId = replacementTable[TrueNorthId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcGeometricRepresentationContext (newId,ContextIdentifier, ContextType, CoordinateSpaceDimension, Precision, WorldCoordinateSystemId, TrueNorthId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcGeometricRepresentationContext },
                { "class", nameof(IfcGeometricRepresentationContext) },
                { "parameters" , new JArray
                    {
                        ContextIdentifier.ToJValue(),
                        ContextType.ToJValue(),
                        CoordinateSpaceDimension,
                        Precision.ToJValue(),
                        WorldCoordinateSystemId.ToJValue(),
                        TrueNorthId.ToJValue(),
                    }
                }
            };
        }

        public static IfcGeometricRepresentationContext CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcGeometricRepresentationContext(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToInt(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId());
        }
        #endregion

    }
}