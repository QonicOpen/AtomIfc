
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
    public class IfcFacetedBrepWithVoids : IfcFacetedBrep, IEquatable<IfcFacetedBrepWithVoids>
    {
        private List<IfcId> _voidIds;
        public List<IfcId> VoidIds 
        {
            get { 
                return _voidIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("VoidIds is not allowed to be null"); 
                _voidIds = value;
            }
        }

        public IfcFacetedBrepWithVoids(IfcId id, IfcId outerId, List<IfcId> voidIds) : base(id, outerId)
        {
            VoidIds = voidIds;
        }

        public override ClassId GetClassId() => ClassId.IfcFacetedBrepWithVoids;

        #region Equality

        public bool Equals(IfcFacetedBrepWithVoids other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(VoidIds, other.VoidIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcFacetedBrepWithVoids);

        public static bool operator ==(IfcFacetedBrepWithVoids one, IfcFacetedBrepWithVoids other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFacetedBrepWithVoids one, IfcFacetedBrepWithVoids other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OuterId},{Utils.ConvertListToString(VoidIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(VoidIds!= null)
                VoidIds = VoidIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFacetedBrepWithVoids (newId,OuterId, VoidIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFacetedBrepWithVoids },
                { "class", nameof(IfcFacetedBrepWithVoids) },
                { "parameters" , new JArray
                    {
                        OuterId.ToJValue(),
                        VoidIds.ToJArray(),
                    }
                }
            };
        }

        public static new IfcFacetedBrepWithVoids CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFacetedBrepWithVoids(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcIdList());
        }
        #endregion

    }
}