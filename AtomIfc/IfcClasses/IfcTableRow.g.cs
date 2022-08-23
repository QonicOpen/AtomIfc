
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
    public class IfcTableRow : IfcBase, IEquatable<IfcTableRow>
    {
        private List<IfcId> _rowCellIds;
        public List<IfcId> RowCellIds 
        {
            get { 
                return _rowCellIds; 
            }
            set { 
                _rowCellIds = value;  // optional List<IfcValue>
            }
        }
        private bool? _isHeading;
        public bool? IsHeading 
        {
            get { 
                return _isHeading; 
            }
            set { 
                _isHeading = value;  // optional bool
            }
        }

        public IfcTableRow(IfcId id, List<IfcId> rowCellIds, bool? isHeading) : base(id)
        {
            RowCellIds = rowCellIds;
            IsHeading = isHeading;
        }

        public override ClassId GetClassId() => ClassId.IfcTableRow;

        #region Equality

        public bool Equals(IfcTableRow other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RowCellIds, other.RowCellIds))
                return false;
            return base.Equals(other)
                && IsHeading == other.IsHeading;
        }

        public override bool Equals(object other) => Equals(other as IfcTableRow);

        public static bool operator ==(IfcTableRow one, IfcTableRow other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTableRow one, IfcTableRow other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(RowCellIds)},{(IsHeading == null? ".U." : IsHeading)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RowCellIds!= null)
                RowCellIds = RowCellIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTableRow (newId,RowCellIds, IsHeading);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTableRow },
                { "class", nameof(IfcTableRow) },
                { "parameters" , new JArray
                    {
                        RowCellIds.ToJArray(),
                        IsHeading.ToJValue(),
                    }
                }
            };
        }

        public static IfcTableRow CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTableRow(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcIdList(),
                parameters[1].ToOptionalBool());
        }
        #endregion

    }
}