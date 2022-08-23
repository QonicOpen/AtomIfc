
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
    public class IfcAdvancedBrepWithVoids : IfcAdvancedBrep, IEquatable<IfcAdvancedBrepWithVoids>
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

        public IfcAdvancedBrepWithVoids(IfcId id, IfcId outerId, List<IfcId> voidIds) : base(id, outerId)
        {
            VoidIds = voidIds;
        }

        public override ClassId GetClassId() => ClassId.IfcAdvancedBrepWithVoids;

        #region Equality

        public bool Equals(IfcAdvancedBrepWithVoids other)
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

        public override bool Equals(object other) => Equals(other as IfcAdvancedBrepWithVoids);

        public static bool operator ==(IfcAdvancedBrepWithVoids one, IfcAdvancedBrepWithVoids other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcAdvancedBrepWithVoids one, IfcAdvancedBrepWithVoids other) => !(one == other);

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
            return new IfcAdvancedBrepWithVoids (newId,OuterId, VoidIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcAdvancedBrepWithVoids },
                { "class", nameof(IfcAdvancedBrepWithVoids) },
                { "parameters" , new JArray
                    {
                        OuterId.ToJValue(),
                        VoidIds.ToJArray(),
                    }
                }
            };
        }

        public static new IfcAdvancedBrepWithVoids CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcAdvancedBrepWithVoids(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcIdList());
        }
        #endregion

    }
}