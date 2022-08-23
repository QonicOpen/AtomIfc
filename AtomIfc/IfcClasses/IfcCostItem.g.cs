
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
    public class IfcCostItem : IfcControl, IEquatable<IfcCostItem>
    {
        private IfcCostItemTypeEnum _predefinedType;
        public IfcCostItemTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcCostItemTypeEnum?
            }
        }
        private List<IfcId> _costValueIds;
        public List<IfcId> CostValueIds 
        {
            get { 
                return _costValueIds; 
            }
            set { 
                _costValueIds = value;  // optional List<IfcCostValue>
            }
        }
        private List<IfcId> _costQuantityIds;
        public List<IfcId> CostQuantityIds 
        {
            get { 
                return _costQuantityIds; 
            }
            set { 
                _costQuantityIds = value;  // optional List<IfcPhysicalQuantity>
            }
        }

        public IfcCostItem(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, IfcCostItemTypeEnum predefinedType, List<IfcId> costValueIds, List<IfcId> costQuantityIds) : base(id, globalId, ownerHistoryId, name, description, objectType, identification)
        {
            PredefinedType = predefinedType;
            CostValueIds = costValueIds;
            CostQuantityIds = costQuantityIds;
        }

        public override ClassId GetClassId() => ClassId.IfcCostItem;

        #region Equality

        public bool Equals(IfcCostItem other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(CostValueIds, other.CostValueIds))
                return false;
            if(!Utils.CompareList(CostQuantityIds, other.CostQuantityIds))
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcCostItem);

        public static bool operator ==(IfcCostItem one, IfcCostItem other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCostItem one, IfcCostItem other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{Identification}',.{PredefinedType}.,{Utils.ConvertListToString(CostValueIds)},{Utils.ConvertListToString(CostQuantityIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CostValueIds!= null)
                CostValueIds = CostValueIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(CostQuantityIds!= null)
                CostQuantityIds = CostQuantityIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCostItem (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, Identification, PredefinedType, CostValueIds, CostQuantityIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCostItem },
                { "class", nameof(IfcCostItem) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        Identification.ToJValue(),
                        PredefinedType.ToJValue(),
                        CostValueIds.ToJArray(),
                        CostQuantityIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcCostItem CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCostItem(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                (IfcCostItemTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcCostItemTypeEnum](parameters[6].ToString()),
                parameters[7].ToOptionalIfcIdList(),
                parameters[8].ToOptionalIfcIdList());
        }
        #endregion

    }
}