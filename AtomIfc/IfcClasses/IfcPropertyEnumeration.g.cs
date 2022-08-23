
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
    public class IfcPropertyEnumeration : IfcPropertyAbstraction, IEquatable<IfcPropertyEnumeration>
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;
            }
        }
        private List<IfcId> _enumerationValueIds;
        public List<IfcId> EnumerationValueIds 
        {
            get { 
                return _enumerationValueIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("EnumerationValueIds is not allowed to be null"); 
                _enumerationValueIds = value;
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

        public IfcPropertyEnumeration(IfcId id, string name, List<IfcId> enumerationValueIds, IfcId unitId) : base(id)
        {
            Name = name;
            EnumerationValueIds = enumerationValueIds;
            UnitId = unitId;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertyEnumeration;

        #region Equality

        public bool Equals(IfcPropertyEnumeration other)
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
                && Name == other.Name
                && UnitId == other.UnitId;
        }

        public override bool Equals(object other) => Equals(other as IfcPropertyEnumeration);

        public static bool operator ==(IfcPropertyEnumeration one, IfcPropertyEnumeration other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertyEnumeration one, IfcPropertyEnumeration other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{Utils.ConvertListToString(EnumerationValueIds)},{UnitId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EnumerationValueIds!= null)
                EnumerationValueIds = EnumerationValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(UnitId!= null && replacementTable.ContainsKey(UnitId))
                UnitId = replacementTable[UnitId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertyEnumeration (newId,Name, EnumerationValueIds, UnitId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertyEnumeration },
                { "class", nameof(IfcPropertyEnumeration) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        EnumerationValueIds.ToJArray(),
                        UnitId.ToJValue(),
                    }
                }
            };
        }

        public static IfcPropertyEnumeration CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertyEnumeration(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToIfcIdList(),
                parameters[2].ToOptionalIfcId());
        }
        #endregion

    }
}