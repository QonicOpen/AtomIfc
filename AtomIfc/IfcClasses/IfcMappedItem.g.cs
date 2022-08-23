
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
    public class IfcMappedItem : IfcRepresentationItem, IEquatable<IfcMappedItem>
    {
        private IfcId _mappingSourceId;
        public IfcId MappingSourceId 
        {
            get { 
                return _mappingSourceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MappingSourceId is not allowed to be null"); 
                _mappingSourceId = value;
            }
        }
        private IfcId _mappingTargetId;
        public IfcId MappingTargetId 
        {
            get { 
                return _mappingTargetId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MappingTargetId is not allowed to be null"); 
                _mappingTargetId = value;
            }
        }

        public IfcMappedItem(IfcId id, IfcId mappingSourceId, IfcId mappingTargetId) : base(id)
        {
            MappingSourceId = mappingSourceId;
            MappingTargetId = mappingTargetId;
        }

        public override ClassId GetClassId() => ClassId.IfcMappedItem;

        #region Equality

        public bool Equals(IfcMappedItem other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && MappingSourceId == other.MappingSourceId
                && MappingTargetId == other.MappingTargetId;
        }

        public override bool Equals(object other) => Equals(other as IfcMappedItem);

        public static bool operator ==(IfcMappedItem one, IfcMappedItem other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMappedItem one, IfcMappedItem other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({MappingSourceId},{MappingTargetId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MappingSourceId!= null && replacementTable.ContainsKey(MappingSourceId))
                MappingSourceId = replacementTable[MappingSourceId];
            if(MappingTargetId!= null && replacementTable.ContainsKey(MappingTargetId))
                MappingTargetId = replacementTable[MappingTargetId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMappedItem (newId,MappingSourceId, MappingTargetId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMappedItem },
                { "class", nameof(IfcMappedItem) },
                { "parameters" , new JArray
                    {
                        MappingSourceId.ToJValue(),
                        MappingTargetId.ToJValue(),
                    }
                }
            };
        }

        public static IfcMappedItem CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMappedItem(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId());
        }
        #endregion

    }
}