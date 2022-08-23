
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
    public class IfcPropertyListValue : IfcSimpleProperty, IEquatable<IfcPropertyListValue>
    {
        private List<IfcId> _listValueIds;
        public List<IfcId> ListValueIds 
        {
            get { 
                return _listValueIds; 
            }
            set { 
                _listValueIds = value;  // optional List<IfcValue>
            }
        }
        private IfcId _unitId;
        public IfcId UnitId 
        {
            get { 
                return _unitId; 
            }
            set { 
                _unitId = value;  // optional IfcUnit
            }
        }

        public IfcPropertyListValue(IfcId id, string name, string description, List<IfcId> listValueIds, IfcId unitId) : base(id, name, description)
        {
            ListValueIds = listValueIds;
            UnitId = unitId;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertyListValue;

        #region Equality

        public bool Equals(IfcPropertyListValue other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ListValueIds, other.ListValueIds))
                return false;
            return base.Equals(other)
                && UnitId == other.UnitId;
        }

        public override bool Equals(object other) => Equals(other as IfcPropertyListValue);

        public static bool operator ==(IfcPropertyListValue one, IfcPropertyListValue other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertyListValue one, IfcPropertyListValue other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(ListValueIds)},{UnitId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ListValueIds!= null)
                ListValueIds = ListValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(UnitId!= null && replacementTable.ContainsKey(UnitId))
                UnitId = replacementTable[UnitId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertyListValue (newId,Name, Description, ListValueIds, UnitId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertyListValue },
                { "class", nameof(IfcPropertyListValue) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ListValueIds.ToJArray(),
                        UnitId.ToJValue(),
                    }
                }
            };
        }

        public static IfcPropertyListValue CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertyListValue(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcIdList(),
                parameters[3].ToOptionalIfcId());
        }
        #endregion

    }
}