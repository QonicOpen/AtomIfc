
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
    public class IfcFace : IfcTopologicalRepresentationItem, IEquatable<IfcFace>
    {
        private List<IfcId> _boundIds;
        public List<IfcId> BoundIds 
        {
            get { 
                return _boundIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("BoundIds is not allowed to be null"); 
                _boundIds = value;
            }
        }

        public IfcFace(IfcId id, List<IfcId> boundIds) : base(id)
        {
            BoundIds = boundIds;
        }

        public override ClassId GetClassId() => ClassId.IfcFace;

        #region Equality

        public bool Equals(IfcFace other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(BoundIds, other.BoundIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcFace);

        public static bool operator ==(IfcFace one, IfcFace other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFace one, IfcFace other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(BoundIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BoundIds!= null)
                BoundIds = BoundIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFace (newId,BoundIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFace },
                { "class", nameof(IfcFace) },
                { "parameters" , new JArray
                    {
                        BoundIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcFace CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFace(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}