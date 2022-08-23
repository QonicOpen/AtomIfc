
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
    public class IfcPresentationLayerWithStyle : IfcPresentationLayerAssignment, IEquatable<IfcPresentationLayerWithStyle>
    {
        private bool? _layerOn;
        public bool? LayerOn 
        {
            get { 
                return _layerOn; 
            }
            set { 
                _layerOn = value;
            }
        }
        private bool? _layerFrozen;
        public bool? LayerFrozen 
        {
            get { 
                return _layerFrozen; 
            }
            set { 
                _layerFrozen = value;
            }
        }
        private bool? _layerBlocked;
        public bool? LayerBlocked 
        {
            get { 
                return _layerBlocked; 
            }
            set { 
                _layerBlocked = value;
            }
        }
        private List<IfcId> _layerStyleIds;
        public List<IfcId> LayerStyleIds 
        {
            get { 
                return _layerStyleIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("LayerStyleIds is not allowed to be null"); 
                _layerStyleIds = value;
            }
        }

        public IfcPresentationLayerWithStyle(IfcId id, string name, string description, List<IfcId> assignedItemIds, string identifier, bool? layerOn, bool? layerFrozen, bool? layerBlocked, List<IfcId> layerStyleIds) : base(id, name, description, assignedItemIds, identifier)
        {
            LayerOn = layerOn;
            LayerFrozen = layerFrozen;
            LayerBlocked = layerBlocked;
            LayerStyleIds = layerStyleIds;
        }

        public override ClassId GetClassId() => ClassId.IfcPresentationLayerWithStyle;

        #region Equality

        public bool Equals(IfcPresentationLayerWithStyle other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(LayerStyleIds, other.LayerStyleIds))
                return false;
            return base.Equals(other)
                && LayerOn == other.LayerOn
                && LayerFrozen == other.LayerFrozen
                && LayerBlocked == other.LayerBlocked;
        }

        public override bool Equals(object other) => Equals(other as IfcPresentationLayerWithStyle);

        public static bool operator ==(IfcPresentationLayerWithStyle one, IfcPresentationLayerWithStyle other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPresentationLayerWithStyle one, IfcPresentationLayerWithStyle other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(AssignedItemIds)},'{Identifier}',{(LayerOn == null? ".U." : LayerOn)},{(LayerFrozen == null? ".U." : LayerFrozen)},{(LayerBlocked == null? ".U." : LayerBlocked)},{Utils.ConvertListToString(LayerStyleIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(LayerStyleIds!= null)
                LayerStyleIds = LayerStyleIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPresentationLayerWithStyle (newId,Name, Description, AssignedItemIds, Identifier, LayerOn, LayerFrozen, LayerBlocked, LayerStyleIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPresentationLayerWithStyle },
                { "class", nameof(IfcPresentationLayerWithStyle) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        AssignedItemIds.ToJArray(),
                        Identifier.ToJValue(),
                        LayerOn.ToJValue(),
                        LayerFrozen.ToJValue(),
                        LayerBlocked.ToJValue(),
                        LayerStyleIds.ToJArray(),
                    }
                }
            };
        }

        public static new IfcPresentationLayerWithStyle CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPresentationLayerWithStyle(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalBool(),
                parameters[5].ToOptionalBool(),
                parameters[6].ToOptionalBool(),
                parameters[7].ToIfcIdList());
        }
        #endregion

    }
}