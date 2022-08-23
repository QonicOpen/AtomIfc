
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
    public class IfcStructuralLoadConfiguration : IfcStructuralLoad, IEquatable<IfcStructuralLoadConfiguration>
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
        private List<List<double>> _locations;
        public List<List<double>> Locations 
        {
            get { 
                return _locations; 
            }
            set { 
                _locations = value;  // optional List<List<IfcLengthMeasure>>
            }
        }

        public IfcStructuralLoadConfiguration(IfcId id, string name, List<IfcId> valueIds, List<List<double>> locations) : base(id, name)
        {
            ValueIds = valueIds;
            Locations = locations;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralLoadConfiguration;

        #region Equality

        public bool Equals(IfcStructuralLoadConfiguration other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ValueIds, other.ValueIds))
                return false;
            if(!Utils.CompareList(Locations, other.Locations))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralLoadConfiguration);

        public static bool operator ==(IfcStructuralLoadConfiguration one, IfcStructuralLoadConfiguration other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralLoadConfiguration one, IfcStructuralLoadConfiguration other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{Utils.ConvertListToString(ValueIds)},{Utils.ConvertListToString(Locations)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ValueIds!= null)
                ValueIds = ValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralLoadConfiguration (newId,Name, ValueIds, Locations);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralLoadConfiguration },
                { "class", nameof(IfcStructuralLoadConfiguration) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        ValueIds.ToJArray(),
                        Locations.ToJArray(),
                    }
                }
            };
        }

        public static IfcStructuralLoadConfiguration CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralLoadConfiguration(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToIfcIdList(),
                parameters[2].ToOptionalNestedDoubleList());
        }
        #endregion

    }
}