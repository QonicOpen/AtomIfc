
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
    public class IfcConnectionSurfaceGeometry : IfcConnectionGeometry, IEquatable<IfcConnectionSurfaceGeometry>
    {
        private IfcId _surfaceOnRelatingElementId;
        public IfcId SurfaceOnRelatingElementId 
        {
            get { 
                return _surfaceOnRelatingElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SurfaceOnRelatingElementId is not allowed to be null"); 
                _surfaceOnRelatingElementId = value;
            }
        }
        private IfcId _surfaceOnRelatedElementId;
        public IfcId SurfaceOnRelatedElementId 
        {
            get { 
                return _surfaceOnRelatedElementId; 
            }
            set { 
                _surfaceOnRelatedElementId = value;  // optional IfcSurfaceOrFaceSurface
            }
        }

        public IfcConnectionSurfaceGeometry(IfcId id, IfcId surfaceOnRelatingElementId, IfcId surfaceOnRelatedElementId) : base(id)
        {
            SurfaceOnRelatingElementId = surfaceOnRelatingElementId;
            SurfaceOnRelatedElementId = surfaceOnRelatedElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcConnectionSurfaceGeometry;

        #region Equality

        public bool Equals(IfcConnectionSurfaceGeometry other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && SurfaceOnRelatingElementId == other.SurfaceOnRelatingElementId
                && SurfaceOnRelatedElementId == other.SurfaceOnRelatedElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcConnectionSurfaceGeometry);

        public static bool operator ==(IfcConnectionSurfaceGeometry one, IfcConnectionSurfaceGeometry other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConnectionSurfaceGeometry one, IfcConnectionSurfaceGeometry other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SurfaceOnRelatingElementId},{SurfaceOnRelatedElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(SurfaceOnRelatingElementId!= null && replacementTable.ContainsKey(SurfaceOnRelatingElementId))
                SurfaceOnRelatingElementId = replacementTable[SurfaceOnRelatingElementId];
            if(SurfaceOnRelatedElementId!= null && replacementTable.ContainsKey(SurfaceOnRelatedElementId))
                SurfaceOnRelatedElementId = replacementTable[SurfaceOnRelatedElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcConnectionSurfaceGeometry (newId,SurfaceOnRelatingElementId, SurfaceOnRelatedElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcConnectionSurfaceGeometry },
                { "class", nameof(IfcConnectionSurfaceGeometry) },
                { "parameters" , new JArray
                    {
                        SurfaceOnRelatingElementId.ToJValue(),
                        SurfaceOnRelatedElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcConnectionSurfaceGeometry CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcConnectionSurfaceGeometry(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId());
        }
        #endregion

    }
}