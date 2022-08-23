
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
    public class IfcPropertyEnumeratedValue : IfcSimpleProperty, IEquatable<IfcPropertyEnumeratedValue>
    {
        private List<IfcId> _enumerationValueIds;
        public List<IfcId> EnumerationValueIds 
        {
            get { 
                return _enumerationValueIds; 
            }
            set { 
                _enumerationValueIds = value;  // optional List<IfcValue>
            }
        }
        private IfcId _enumerationReferenceId;
        public IfcId EnumerationReferenceId 
        {
            get { 
                return _enumerationReferenceId; 
            }
            set { 
                _enumerationReferenceId = value;  // optional IfcPropertyEnumeration
            }
        }

        public IfcPropertyEnumeratedValue(IfcId id, string name, string description, List<IfcId> enumerationValueIds, IfcId enumerationReferenceId) : base(id, name, description)
        {
            EnumerationValueIds = enumerationValueIds;
            EnumerationReferenceId = enumerationReferenceId;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertyEnumeratedValue;

        #region Equality

        public bool Equals(IfcPropertyEnumeratedValue other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(EnumerationValueIds, other.EnumerationValueIds))
                return false;
            return base.Equals(other)
                && EnumerationReferenceId == other.EnumerationReferenceId;
        }

        public override bool Equals(object other) => Equals(other as IfcPropertyEnumeratedValue);

        public static bool operator ==(IfcPropertyEnumeratedValue one, IfcPropertyEnumeratedValue other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertyEnumeratedValue one, IfcPropertyEnumeratedValue other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(EnumerationValueIds)},{EnumerationReferenceId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EnumerationValueIds!= null)
                EnumerationValueIds = EnumerationValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(EnumerationReferenceId!= null && replacementTable.ContainsKey(EnumerationReferenceId))
                EnumerationReferenceId = replacementTable[EnumerationReferenceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertyEnumeratedValue (newId,Name, Description, EnumerationValueIds, EnumerationReferenceId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertyEnumeratedValue },
                { "class", nameof(IfcPropertyEnumeratedValue) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        EnumerationValueIds.ToJArray(),
                        EnumerationReferenceId.ToJValue(),
                    }
                }
            };
        }

        public static IfcPropertyEnumeratedValue CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertyEnumeratedValue(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcIdList(),
                parameters[3].ToOptionalIfcId());
        }
        #endregion

    }
}