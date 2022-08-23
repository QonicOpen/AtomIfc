
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
    public class IfcMaterialLayerSet : IfcMaterialDefinition, IEquatable<IfcMaterialLayerSet>
    {
        private List<IfcId> _materialLayerIds;
        public List<IfcId> MaterialLayerIds 
        {
            get { 
                return _materialLayerIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MaterialLayerIds is not allowed to be null"); 
                _materialLayerIds = value;
            }
        }
        private string _layerSetName;
        public string LayerSetName 
        {
            get { 
                return _layerSetName; 
            }
            set { 
                _layerSetName = value;  // optional IfcLabel
            }
        }
        private string _description;
        public string Description 
        {
            get { 
                return _description; 
            }
            set { 
                _description = value;  // optional IfcText
            }
        }

        public IfcMaterialLayerSet(IfcId id, List<IfcId> materialLayerIds, string layerSetName, string description) : base(id)
        {
            MaterialLayerIds = materialLayerIds;
            LayerSetName = layerSetName;
            Description = description;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialLayerSet;

        #region Equality

        public bool Equals(IfcMaterialLayerSet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(MaterialLayerIds, other.MaterialLayerIds))
                return false;
            return base.Equals(other)
                && LayerSetName == other.LayerSetName
                && Description == other.Description;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialLayerSet);

        public static bool operator ==(IfcMaterialLayerSet one, IfcMaterialLayerSet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialLayerSet one, IfcMaterialLayerSet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(MaterialLayerIds)},'{LayerSetName}','{Description}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MaterialLayerIds!= null)
                MaterialLayerIds = MaterialLayerIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialLayerSet (newId,MaterialLayerIds, LayerSetName, Description);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialLayerSet },
                { "class", nameof(IfcMaterialLayerSet) },
                { "parameters" , new JArray
                    {
                        MaterialLayerIds.ToJArray(),
                        LayerSetName.ToJValue(),
                        Description.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialLayerSet CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialLayerSet(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString());
        }
        #endregion

    }
}