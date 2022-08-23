
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
    public class IfcMaterialList : IfcBase, IEquatable<IfcMaterialList>, IIfcMaterialSelect
    {
        private List<IfcId> _materialIds;
        public List<IfcId> MaterialIds 
        {
            get { 
                return _materialIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MaterialIds is not allowed to be null"); 
                _materialIds = value;
            }
        }

        public IfcMaterialList(IfcId id, List<IfcId> materialIds) : base(id)
        {
            MaterialIds = materialIds;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialList;

        #region Equality

        public bool Equals(IfcMaterialList other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(MaterialIds, other.MaterialIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialList);

        public static bool operator ==(IfcMaterialList one, IfcMaterialList other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialList one, IfcMaterialList other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(MaterialIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MaterialIds!= null)
                MaterialIds = MaterialIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialList (newId,MaterialIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialList },
                { "class", nameof(IfcMaterialList) },
                { "parameters" , new JArray
                    {
                        MaterialIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcMaterialList CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialList(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}