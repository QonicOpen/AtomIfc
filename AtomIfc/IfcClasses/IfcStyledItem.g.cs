
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
    public class IfcStyledItem : IfcRepresentationItem, IEquatable<IfcStyledItem>
    {
        private IfcId _itemId;
        public IfcId ItemId 
        {
            get { 
                return _itemId; 
            }
            set { 
                _itemId = value;  // optional IfcRepresentationItem
            }
        }
        private List<IfcId> _styleIds;
        public List<IfcId> StyleIds 
        {
            get { 
                return _styleIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("StyleIds is not allowed to be null"); 
                _styleIds = value;
            }
        }
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;  // optional IfcLabel
            }
        }

        public IfcStyledItem(IfcId id, IfcId itemId, List<IfcId> styleIds, string name) : base(id)
        {
            ItemId = itemId;
            StyleIds = styleIds;
            Name = name;
        }

        public override ClassId GetClassId() => ClassId.IfcStyledItem;

        #region Equality

        public bool Equals(IfcStyledItem other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(StyleIds, other.StyleIds))
                return false;
            return base.Equals(other)
                && ItemId == other.ItemId
                && Name == other.Name;
        }

        public override bool Equals(object other) => Equals(other as IfcStyledItem);

        public static bool operator ==(IfcStyledItem one, IfcStyledItem other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStyledItem one, IfcStyledItem other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({ItemId},{Utils.ConvertListToString(StyleIds)},'{Name}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ItemId!= null && replacementTable.ContainsKey(ItemId))
                ItemId = replacementTable[ItemId];
            if(StyleIds!= null)
                StyleIds = StyleIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStyledItem (newId,ItemId, StyleIds, Name);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStyledItem },
                { "class", nameof(IfcStyledItem) },
                { "parameters" , new JArray
                    {
                        ItemId.ToJValue(),
                        StyleIds.ToJArray(),
                        Name.ToJValue(),
                    }
                }
            };
        }

        public static IfcStyledItem CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStyledItem(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToIfcIdList(),
                parameters[2].ToOptionalString());
        }
        #endregion

    }
}