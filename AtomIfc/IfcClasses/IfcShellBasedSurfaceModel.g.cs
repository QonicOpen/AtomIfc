
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
    public class IfcShellBasedSurfaceModel : IfcGeometricRepresentationItem, IEquatable<IfcShellBasedSurfaceModel>
    {
        private List<IfcId> _sbsmBoundaryIds;
        public List<IfcId> SbsmBoundaryIds 
        {
            get { 
                return _sbsmBoundaryIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SbsmBoundaryIds is not allowed to be null"); 
                _sbsmBoundaryIds = value;
            }
        }

        public IfcShellBasedSurfaceModel(IfcId id, List<IfcId> sbsmBoundaryIds) : base(id)
        {
            SbsmBoundaryIds = sbsmBoundaryIds;
        }

        public override ClassId GetClassId() => ClassId.IfcShellBasedSurfaceModel;

        #region Equality

        public bool Equals(IfcShellBasedSurfaceModel other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(SbsmBoundaryIds, other.SbsmBoundaryIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcShellBasedSurfaceModel);

        public static bool operator ==(IfcShellBasedSurfaceModel one, IfcShellBasedSurfaceModel other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcShellBasedSurfaceModel one, IfcShellBasedSurfaceModel other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(SbsmBoundaryIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(SbsmBoundaryIds!= null)
                SbsmBoundaryIds = SbsmBoundaryIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcShellBasedSurfaceModel (newId,SbsmBoundaryIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcShellBasedSurfaceModel },
                { "class", nameof(IfcShellBasedSurfaceModel) },
                { "parameters" , new JArray
                    {
                        SbsmBoundaryIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcShellBasedSurfaceModel CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcShellBasedSurfaceModel(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}