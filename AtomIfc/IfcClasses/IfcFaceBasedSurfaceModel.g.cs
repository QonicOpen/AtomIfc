
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
    public class IfcFaceBasedSurfaceModel : IfcGeometricRepresentationItem, IEquatable<IfcFaceBasedSurfaceModel>, IIfcSurfaceOrFaceSurface
    {
        private List<IfcId> _fbsmFaceIds;
        public List<IfcId> FbsmFaceIds 
        {
            get { 
                return _fbsmFaceIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("FbsmFaceIds is not allowed to be null"); 
                _fbsmFaceIds = value;
            }
        }

        public IfcFaceBasedSurfaceModel(IfcId id, List<IfcId> fbsmFaceIds) : base(id)
        {
            FbsmFaceIds = fbsmFaceIds;
        }

        public override ClassId GetClassId() => ClassId.IfcFaceBasedSurfaceModel;

        #region Equality

        public bool Equals(IfcFaceBasedSurfaceModel other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(FbsmFaceIds, other.FbsmFaceIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcFaceBasedSurfaceModel);

        public static bool operator ==(IfcFaceBasedSurfaceModel one, IfcFaceBasedSurfaceModel other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFaceBasedSurfaceModel one, IfcFaceBasedSurfaceModel other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(FbsmFaceIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(FbsmFaceIds!= null)
                FbsmFaceIds = FbsmFaceIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFaceBasedSurfaceModel (newId,FbsmFaceIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFaceBasedSurfaceModel },
                { "class", nameof(IfcFaceBasedSurfaceModel) },
                { "parameters" , new JArray
                    {
                        FbsmFaceIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcFaceBasedSurfaceModel CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFaceBasedSurfaceModel(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}