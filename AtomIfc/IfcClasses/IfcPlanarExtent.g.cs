
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
    public class IfcPlanarExtent : IfcGeometricRepresentationItem, IEquatable<IfcPlanarExtent>
    {
        private double _sizeInX;
        public double SizeInX 
        {
            get { 
                return _sizeInX; 
            }
            set { 
                _sizeInX = value;
            }
        }
        private double _sizeInY;
        public double SizeInY 
        {
            get { 
                return _sizeInY; 
            }
            set { 
                _sizeInY = value;
            }
        }

        public IfcPlanarExtent(IfcId id, double sizeInX, double sizeInY) : base(id)
        {
            SizeInX = sizeInX;
            SizeInY = sizeInY;
        }

        public override ClassId GetClassId() => ClassId.IfcPlanarExtent;

        #region Equality

        public bool Equals(IfcPlanarExtent other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && SizeInX == other.SizeInX
                && SizeInY == other.SizeInY;
        }

        public override bool Equals(object other) => Equals(other as IfcPlanarExtent);

        public static bool operator ==(IfcPlanarExtent one, IfcPlanarExtent other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPlanarExtent one, IfcPlanarExtent other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SizeInX},{SizeInY})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPlanarExtent (newId,SizeInX, SizeInY);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPlanarExtent },
                { "class", nameof(IfcPlanarExtent) },
                { "parameters" , new JArray
                    {
                        SizeInX,
                        SizeInY,
                    }
                }
            };
        }

        public static IfcPlanarExtent CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPlanarExtent(
                jObject["id"].ToIfcId(),
                parameters[0].ToDouble(),
                parameters[1].ToDouble());
        }
        #endregion

    }
}