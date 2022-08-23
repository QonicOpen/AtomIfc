
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
    public class IfcPhysicalComplexQuantity : IfcPhysicalQuantity, IEquatable<IfcPhysicalComplexQuantity>
    {
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
        private string _discrimination;
        public string Discrimination 
        {
            get { 
                return _discrimination; 
            }
            set { 
                _discrimination = value;
            }
        }
        private string _quality;
        public string Quality 
        {
            get { 
                return _quality; 
            }
            set { 
                _quality = value;  // optional IfcLabel
            }
        }
        private string _usage;
        public string Usage 
        {
            get { 
                return _usage; 
            }
            set { 
                _usage = value;  // optional IfcLabel
            }
        }

        public IfcPhysicalComplexQuantity(IfcId id, string name, string description, List<IfcId> quantityIds, string discrimination, string quality, string usage) : base(id, name, description)
        {
            QuantityIds = quantityIds;
            Discrimination = discrimination;
            Quality = quality;
            Usage = usage;
        }

        public override ClassId GetClassId() => ClassId.IfcPhysicalComplexQuantity;

        #region Equality

        public bool Equals(IfcPhysicalComplexQuantity other)
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
                && Discrimination == other.Discrimination
                && Quality == other.Quality
                && Usage == other.Usage;
        }

        public override bool Equals(object other) => Equals(other as IfcPhysicalComplexQuantity);

        public static bool operator ==(IfcPhysicalComplexQuantity one, IfcPhysicalComplexQuantity other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPhysicalComplexQuantity one, IfcPhysicalComplexQuantity other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(QuantityIds)},'{Discrimination}','{Quality}','{Usage}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(QuantityIds!= null)
                QuantityIds = QuantityIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPhysicalComplexQuantity (newId,Name, Description, QuantityIds, Discrimination, Quality, Usage);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPhysicalComplexQuantity },
                { "class", nameof(IfcPhysicalComplexQuantity) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        QuantityIds.ToJArray(),
                        Discrimination.ToJValue(),
                        Quality.ToJValue(),
                        Usage.ToJValue(),
                    }
                }
            };
        }

        public static IfcPhysicalComplexQuantity CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPhysicalComplexQuantity(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString());
        }
        #endregion

    }
}