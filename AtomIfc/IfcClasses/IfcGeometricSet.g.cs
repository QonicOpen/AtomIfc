
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
    public class IfcGeometricSet : IfcGeometricRepresentationItem, IEquatable<IfcGeometricSet>
    {
        private List<IfcId> _elementIds;
        public List<IfcId> ElementIds 
        {
            get { 
                return _elementIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ElementIds is not allowed to be null"); 
                _elementIds = value;
            }
        }

        public IfcGeometricSet(IfcId id, List<IfcId> elementIds) : base(id)
        {
            ElementIds = elementIds;
        }

        public override ClassId GetClassId() => ClassId.IfcGeometricSet;

        #region Equality

        public bool Equals(IfcGeometricSet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ElementIds, other.ElementIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcGeometricSet);

        public static bool operator ==(IfcGeometricSet one, IfcGeometricSet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcGeometricSet one, IfcGeometricSet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(ElementIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ElementIds!= null)
                ElementIds = ElementIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcGeometricSet (newId,ElementIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcGeometricSet },
                { "class", nameof(IfcGeometricSet) },
                { "parameters" , new JArray
                    {
                        ElementIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcGeometricSet CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcGeometricSet(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}