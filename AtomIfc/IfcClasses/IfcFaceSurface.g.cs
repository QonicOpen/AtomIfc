
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
    public class IfcFaceSurface : IfcFace, IEquatable<IfcFaceSurface>, IIfcSurfaceOrFaceSurface
    {
        private IfcId _faceSurfaceId;
        public IfcId FaceSurfaceId 
        {
            get { 
                return _faceSurfaceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("FaceSurfaceId is not allowed to be null"); 
                _faceSurfaceId = value;
            }
        }
        private bool _sameSense;
        public bool SameSense 
        {
            get { 
                return _sameSense; 
            }
            set { 
                _sameSense = value;
            }
        }

        public IfcFaceSurface(IfcId id, List<IfcId> boundIds, IfcId faceSurfaceId, bool sameSense) : base(id, boundIds)
        {
            FaceSurfaceId = faceSurfaceId;
            SameSense = sameSense;
        }

        public override ClassId GetClassId() => ClassId.IfcFaceSurface;

        #region Equality

        public bool Equals(IfcFaceSurface other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && FaceSurfaceId == other.FaceSurfaceId
                && SameSense == other.SameSense;
        }

        public override bool Equals(object other) => Equals(other as IfcFaceSurface);

        public static bool operator ==(IfcFaceSurface one, IfcFaceSurface other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFaceSurface one, IfcFaceSurface other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(BoundIds)},{FaceSurfaceId},{SameSense})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(FaceSurfaceId!= null && replacementTable.ContainsKey(FaceSurfaceId))
                FaceSurfaceId = replacementTable[FaceSurfaceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFaceSurface (newId,BoundIds, FaceSurfaceId, SameSense);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFaceSurface },
                { "class", nameof(IfcFaceSurface) },
                { "parameters" , new JArray
                    {
                        BoundIds.ToJArray(),
                        FaceSurfaceId.ToJValue(),
                        SameSense,
                    }
                }
            };
        }

        public static new IfcFaceSurface CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFaceSurface(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToIfcId(),
                parameters[2].ToBool());
        }
        #endregion

    }
}