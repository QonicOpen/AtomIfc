
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
    public class IfcDirection : IfcGeometricRepresentationItem, IEquatable<IfcDirection>, IIfcGridPlacementDirectionSelect, IIfcVectorOrDirection
    {
        private List<double> _directionRatios;
        public List<double> DirectionRatios 
        {
            get { 
                return _directionRatios; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("DirectionRatios is not allowed to be null"); 
                _directionRatios = value;
            }
        }

        public IfcDirection(IfcId id, List<double> directionRatios) : base(id)
        {
            DirectionRatios = directionRatios;
        }

        public override ClassId GetClassId() => ClassId.IfcDirection;

        #region Equality

        public bool Equals(IfcDirection other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(DirectionRatios, other.DirectionRatios))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcDirection);

        public static bool operator ==(IfcDirection one, IfcDirection other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDirection one, IfcDirection other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(DirectionRatios)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDirection (newId,DirectionRatios);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDirection },
                { "class", nameof(IfcDirection) },
                { "parameters" , new JArray
                    {
                        DirectionRatios.ToJArray(),
                    }
                }
            };
        }

        public static IfcDirection CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDirection(
                jObject["id"].ToIfcId(),
                parameters[0].ToDoubleList());
        }
        #endregion

    }
}