
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
    public class IfcRepresentationMap : IfcBase, IEquatable<IfcRepresentationMap>, IIfcProductRepresentationSelect
    {
        private IfcId _mappingOriginId;
        public IfcId MappingOriginId 
        {
            get { 
                return _mappingOriginId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MappingOriginId is not allowed to be null"); 
                _mappingOriginId = value;
            }
        }
        private IfcId _mappedRepresentationId;
        public IfcId MappedRepresentationId 
        {
            get { 
                return _mappedRepresentationId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MappedRepresentationId is not allowed to be null"); 
                _mappedRepresentationId = value;
            }
        }

        public IfcRepresentationMap(IfcId id, IfcId mappingOriginId, IfcId mappedRepresentationId) : base(id)
        {
            MappingOriginId = mappingOriginId;
            MappedRepresentationId = mappedRepresentationId;
        }

        public override ClassId GetClassId() => ClassId.IfcRepresentationMap;

        #region Equality

        public bool Equals(IfcRepresentationMap other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && MappingOriginId == other.MappingOriginId
                && MappedRepresentationId == other.MappedRepresentationId;
        }

        public override bool Equals(object other) => Equals(other as IfcRepresentationMap);

        public static bool operator ==(IfcRepresentationMap one, IfcRepresentationMap other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRepresentationMap one, IfcRepresentationMap other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({MappingOriginId},{MappedRepresentationId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MappingOriginId!= null && replacementTable.ContainsKey(MappingOriginId))
                MappingOriginId = replacementTable[MappingOriginId];
            if(MappedRepresentationId!= null && replacementTable.ContainsKey(MappedRepresentationId))
                MappedRepresentationId = replacementTable[MappedRepresentationId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRepresentationMap (newId,MappingOriginId, MappedRepresentationId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRepresentationMap },
                { "class", nameof(IfcRepresentationMap) },
                { "parameters" , new JArray
                    {
                        MappingOriginId.ToJValue(),
                        MappedRepresentationId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRepresentationMap CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRepresentationMap(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId());
        }
        #endregion

    }
}