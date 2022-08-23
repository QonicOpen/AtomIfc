
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
    public class IfcTypeProduct : IfcTypeObject, IEquatable<IfcTypeProduct>, IIfcProductSelect
    {
        private List<IfcId> _representationMapIds;
        public List<IfcId> RepresentationMapIds 
        {
            get { 
                return _representationMapIds; 
            }
            set { 
                _representationMapIds = value;  // optional List<IfcRepresentationMap>
            }
        }
        private string _tag;
        public string Tag 
        {
            get { 
                return _tag; 
            }
            set { 
                _tag = value;  // optional IfcLabel
            }
        }

        public IfcTypeProduct(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string applicableOccurrence, List<IfcId> propertySetIds, List<IfcId> representationMapIds, string tag) : base(id, globalId, ownerHistoryId, name, description, applicableOccurrence, propertySetIds)
        {
            RepresentationMapIds = representationMapIds;
            Tag = tag;
        }

        public override ClassId GetClassId() => ClassId.IfcTypeProduct;

        #region Equality

        public bool Equals(IfcTypeProduct other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RepresentationMapIds, other.RepresentationMapIds))
                return false;
            return base.Equals(other)
                && Tag == other.Tag;
        }

        public override bool Equals(object other) => Equals(other as IfcTypeProduct);

        public static bool operator ==(IfcTypeProduct one, IfcTypeProduct other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTypeProduct one, IfcTypeProduct other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ApplicableOccurrence}',{Utils.ConvertListToString(PropertySetIds)},{Utils.ConvertListToString(RepresentationMapIds)},'{Tag}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RepresentationMapIds!= null)
                RepresentationMapIds = RepresentationMapIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTypeProduct (newId,GlobalId, OwnerHistoryId, Name, Description, ApplicableOccurrence, PropertySetIds, RepresentationMapIds, Tag);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTypeProduct },
                { "class", nameof(IfcTypeProduct) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ApplicableOccurrence.ToJValue(),
                        PropertySetIds.ToJArray(),
                        RepresentationMapIds.ToJArray(),
                        Tag.ToJValue(),
                    }
                }
            };
        }

        public static new IfcTypeProduct CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTypeProduct(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcIdList(),
                parameters[6].ToOptionalIfcIdList(),
                parameters[7].ToOptionalString());
        }
        #endregion

    }
}