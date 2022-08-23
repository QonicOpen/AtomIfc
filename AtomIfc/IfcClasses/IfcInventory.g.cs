
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
    public class IfcInventory : IfcGroup, IEquatable<IfcInventory>
    {
        private IfcInventoryTypeEnum _predefinedType;
        public IfcInventoryTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcInventoryTypeEnum?
            }
        }
        private IfcId _jurisdictionId;
        public IfcId JurisdictionId 
        {
            get { 
                return _jurisdictionId; 
            }
            set { 
                _jurisdictionId = value;  // optional IfcActorSelect
            }
        }
        private List<IfcId> _responsiblePersonIds;
        public List<IfcId> ResponsiblePersonIds 
        {
            get { 
                return _responsiblePersonIds; 
            }
            set { 
                _responsiblePersonIds = value;  // optional List<IfcPerson>
            }
        }
        private string _lastUpdateDate;
        public string LastUpdateDate 
        {
            get { 
                return _lastUpdateDate; 
            }
            set { 
                _lastUpdateDate = value;  // optional IfcDate
            }
        }
        private IfcId _currentValueId;
        public IfcId CurrentValueId 
        {
            get { 
                return _currentValueId; 
            }
            set { 
                _currentValueId = value;  // optional IfcCostValue
            }
        }
        private IfcId _originalValueId;
        public IfcId OriginalValueId 
        {
            get { 
                return _originalValueId; 
            }
            set { 
                _originalValueId = value;  // optional IfcCostValue
            }
        }

        public IfcInventory(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcInventoryTypeEnum predefinedType, IfcId jurisdictionId, List<IfcId> responsiblePersonIds, string lastUpdateDate, IfcId currentValueId, IfcId originalValueId) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            PredefinedType = predefinedType;
            JurisdictionId = jurisdictionId;
            ResponsiblePersonIds = responsiblePersonIds;
            LastUpdateDate = lastUpdateDate;
            CurrentValueId = currentValueId;
            OriginalValueId = originalValueId;
        }

        public override ClassId GetClassId() => ClassId.IfcInventory;

        #region Equality

        public bool Equals(IfcInventory other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ResponsiblePersonIds, other.ResponsiblePersonIds))
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && JurisdictionId == other.JurisdictionId
                && LastUpdateDate == other.LastUpdateDate
                && CurrentValueId == other.CurrentValueId
                && OriginalValueId == other.OriginalValueId;
        }

        public override bool Equals(object other) => Equals(other as IfcInventory);

        public static bool operator ==(IfcInventory one, IfcInventory other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcInventory one, IfcInventory other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',.{PredefinedType}.,{JurisdictionId},{Utils.ConvertListToString(ResponsiblePersonIds)},'{LastUpdateDate}',{CurrentValueId},{OriginalValueId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(JurisdictionId!= null && replacementTable.ContainsKey(JurisdictionId))
                JurisdictionId = replacementTable[JurisdictionId];
            if(ResponsiblePersonIds!= null)
                ResponsiblePersonIds = ResponsiblePersonIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(CurrentValueId!= null && replacementTable.ContainsKey(CurrentValueId))
                CurrentValueId = replacementTable[CurrentValueId];
            if(OriginalValueId!= null && replacementTable.ContainsKey(OriginalValueId))
                OriginalValueId = replacementTable[OriginalValueId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcInventory (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, PredefinedType, JurisdictionId, ResponsiblePersonIds, LastUpdateDate, CurrentValueId, OriginalValueId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcInventory },
                { "class", nameof(IfcInventory) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        PredefinedType.ToJValue(),
                        JurisdictionId.ToJValue(),
                        ResponsiblePersonIds.ToJArray(),
                        LastUpdateDate.ToJValue(),
                        CurrentValueId.ToJValue(),
                        OriginalValueId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcInventory CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcInventory(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                (IfcInventoryTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcInventoryTypeEnum](parameters[5].ToString()),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalIfcIdList(),
                parameters[8].ToOptionalString(),
                parameters[9].ToOptionalIfcId(),
                parameters[10].ToOptionalIfcId());
        }
        #endregion

    }
}