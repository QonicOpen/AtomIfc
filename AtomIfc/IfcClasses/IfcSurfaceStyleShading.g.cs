
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
    public class IfcSurfaceStyleShading : IfcPresentationItem, IEquatable<IfcSurfaceStyleShading>, IIfcSurfaceStyleElementSelect
    {
        private IfcId _surfaceColourId;
        public IfcId SurfaceColourId 
        {
            get { 
                return _surfaceColourId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SurfaceColourId is not allowed to be null"); 
                _surfaceColourId = value;
            }
        }

        public IfcSurfaceStyleShading(IfcId id, IfcId surfaceColourId) : base(id)
        {
            SurfaceColourId = surfaceColourId;
        }

        public override ClassId GetClassId() => ClassId.IfcSurfaceStyleShading;

        #region Equality

        public bool Equals(IfcSurfaceStyleShading other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && SurfaceColourId == other.SurfaceColourId;
        }

        public override bool Equals(object other) => Equals(other as IfcSurfaceStyleShading);

        public static bool operator ==(IfcSurfaceStyleShading one, IfcSurfaceStyleShading other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSurfaceStyleShading one, IfcSurfaceStyleShading other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SurfaceColourId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(SurfaceColourId!= null && replacementTable.ContainsKey(SurfaceColourId))
                SurfaceColourId = replacementTable[SurfaceColourId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSurfaceStyleShading (newId,SurfaceColourId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSurfaceStyleShading },
                { "class", nameof(IfcSurfaceStyleShading) },
                { "parameters" , new JArray
                    {
                        SurfaceColourId.ToJValue(),
                    }
                }
            };
        }

        public static IfcSurfaceStyleShading CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSurfaceStyleShading(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId());
        }
        #endregion

    }
}