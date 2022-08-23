
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
    public class IfcPropertySetDefinitionSet : IfcBase, IEquatable<IfcPropertySetDefinitionSet>, IIfcPropertySetDefinitionSelect
    {
        private List<IfcId> _valueIds;
        public List<IfcId> ValueIds 
        {
            get { 
                return _valueIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ValueIds is not allowed to be null"); 
                _valueIds = value;
            }
        }

        public IfcPropertySetDefinitionSet(IfcId id, List<IfcId> valueIds) : base(id)
        {
            ValueIds = valueIds;
        }

        public override ClassId GetClassId() => ClassId.IfcPropertySetDefinitionSet;

        #region Equality

        public bool Equals(IfcPropertySetDefinitionSet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ValueIds, other.ValueIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcPropertySetDefinitionSet);

        public static bool operator ==(IfcPropertySetDefinitionSet one, IfcPropertySetDefinitionSet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPropertySetDefinitionSet one, IfcPropertySetDefinitionSet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(ValueIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ValueIds!= null)
                ValueIds = ValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPropertySetDefinitionSet (newId,ValueIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPropertySetDefinitionSet },
                { "class", nameof(IfcPropertySetDefinitionSet) },
                { "parameters" , new JArray
                    {
                        ValueIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcPropertySetDefinitionSet CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPropertySetDefinitionSet(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}