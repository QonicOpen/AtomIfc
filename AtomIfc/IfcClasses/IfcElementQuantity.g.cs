
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
    public class IfcElementQuantity : IfcQuantitySet, IEquatable<IfcElementQuantity>
    {
        private string _methodOfMeasurement;
        public string MethodOfMeasurement 
        {
            get { 
                return _methodOfMeasurement; 
            }
            set { 
                _methodOfMeasurement = value;  // optional IfcLabel
            }
        }
        private List<IfcId> _quantityIds;
        public List<IfcId> QuantityIds 
        {
            get { 
                return _quantityIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("QuantityIds is not allowed to be null"); 
                _quantityIds = value;
            }
        }

        public IfcElementQuantity(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string methodOfMeasurement, List<IfcId> quantityIds) : base(id, globalId, ownerHistoryId, name, description)
        {
            MethodOfMeasurement = methodOfMeasurement;
            QuantityIds = quantityIds;
        }

        public override ClassId GetClassId() => ClassId.IfcElementQuantity;

        #region Equality

        public bool Equals(IfcElementQuantity other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(QuantityIds, other.QuantityIds))
                return false;
            return base.Equals(other)
                && MethodOfMeasurement == other.MethodOfMeasurement;
        }

        public override bool Equals(object other) => Equals(other as IfcElementQuantity);

        public static bool operator ==(IfcElementQuantity one, IfcElementQuantity other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcElementQuantity one, IfcElementQuantity other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{MethodOfMeasurement}',{Utils.ConvertListToString(QuantityIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(QuantityIds!= null)
                QuantityIds = QuantityIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcElementQuantity (newId,GlobalId, OwnerHistoryId, Name, Description, MethodOfMeasurement, QuantityIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcElementQuantity },
                { "class", nameof(IfcElementQuantity) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        MethodOfMeasurement.ToJValue(),
                        QuantityIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcElementQuantity CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcElementQuantity(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToIfcIdList());
        }
        #endregion

    }
}