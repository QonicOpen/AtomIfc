
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
    public class IfcUnitAssignment : IfcBase, IEquatable<IfcUnitAssignment>
    {
        private List<IfcId> _unitIds;
        public List<IfcId> UnitIds 
        {
            get { 
                return _unitIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("UnitIds is not allowed to be null"); 
                _unitIds = value;
            }
        }

        public IfcUnitAssignment(IfcId id, List<IfcId> unitIds) : base(id)
        {
            UnitIds = unitIds;
        }

        public override ClassId GetClassId() => ClassId.IfcUnitAssignment;

        #region Equality

        public bool Equals(IfcUnitAssignment other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(UnitIds, other.UnitIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcUnitAssignment);

        public static bool operator ==(IfcUnitAssignment one, IfcUnitAssignment other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcUnitAssignment one, IfcUnitAssignment other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(UnitIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(UnitIds!= null)
                UnitIds = UnitIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcUnitAssignment (newId,UnitIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcUnitAssignment },
                { "class", nameof(IfcUnitAssignment) },
                { "parameters" , new JArray
                    {
                        UnitIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcUnitAssignment CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcUnitAssignment(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}