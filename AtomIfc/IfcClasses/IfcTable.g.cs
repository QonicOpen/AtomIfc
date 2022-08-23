
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
    public class IfcTable : IfcBase, IEquatable<IfcTable>, IIfcMetricValueSelect, IIfcObjectReferenceSelect
    {
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
        private List<IfcId> _rowIds;
        public List<IfcId> RowIds 
        {
            get { 
                return _rowIds; 
            }
            set { 
                _rowIds = value;  // optional List<IfcTableRow>
            }
        }
        private List<IfcId> _columnIds;
        public List<IfcId> ColumnIds 
        {
            get { 
                return _columnIds; 
            }
            set { 
                _columnIds = value;  // optional List<IfcTableColumn>
            }
        }

        public IfcTable(IfcId id, string name, List<IfcId> rowIds, List<IfcId> columnIds) : base(id)
        {
            Name = name;
            RowIds = rowIds;
            ColumnIds = columnIds;
        }

        public override ClassId GetClassId() => ClassId.IfcTable;

        #region Equality

        public bool Equals(IfcTable other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RowIds, other.RowIds))
                return false;
            if(!Utils.CompareList(ColumnIds, other.ColumnIds))
                return false;
            return base.Equals(other)
                && Name == other.Name;
        }

        public override bool Equals(object other) => Equals(other as IfcTable);

        public static bool operator ==(IfcTable one, IfcTable other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTable one, IfcTable other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{Utils.ConvertListToString(RowIds)},{Utils.ConvertListToString(ColumnIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RowIds!= null)
                RowIds = RowIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(ColumnIds!= null)
                ColumnIds = ColumnIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTable (newId,Name, RowIds, ColumnIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTable },
                { "class", nameof(IfcTable) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        RowIds.ToJArray(),
                        ColumnIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcTable CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTable(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalIfcIdList(),
                parameters[2].ToOptionalIfcIdList());
        }
        #endregion

    }
}