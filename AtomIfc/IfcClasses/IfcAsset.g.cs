
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
    public class IfcAsset : IfcGroup, IEquatable<IfcAsset>
    {
        private string _identification;
        public string Identification 
        {
            get { 
                return _identification; 
            }
            set { 
                _identification = value;  // optional IfcIdentifier
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
        private IfcId _totalReplacementCostId;
        public IfcId TotalReplacementCostId 
        {
            get { 
                return _totalReplacementCostId; 
            }
            set { 
                _totalReplacementCostId = value;  // optional IfcCostValue
            }
        }
        private IfcId _ownerId;
        public IfcId OwnerId 
        {
            get { 
                return _ownerId; 
            }
            set { 
                _ownerId = value;  // optional IfcActorSelect
            }
        }
        private IfcId _userId;
        public IfcId UserId 
        {
            get { 
                return _userId; 
            }
            set { 
                _userId = value;  // optional IfcActorSelect
            }
        }
        private IfcId _responsiblePersonId;
        public IfcId ResponsiblePersonId 
        {
            get { 
                return _responsiblePersonId; 
            }
            set { 
                _responsiblePersonId = value;  // optional IfcPerson
            }
        }
        private string _incorporationDate;
        public string IncorporationDate 
        {
            get { 
                return _incorporationDate; 
            }
            set { 
                _incorporationDate = value;  // optional IfcDate
            }
        }
        private IfcId _depreciatedValueId;
        public IfcId DepreciatedValueId 
        {
            get { 
                return _depreciatedValueId; 
            }
            set { 
                _depreciatedValueId = value;  // optional IfcCostValue
            }
        }

        public IfcAsset(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, IfcId originalValueId, IfcId currentValueId, IfcId totalReplacementCostId, IfcId ownerId, IfcId userId, IfcId responsiblePersonId, string incorporationDate, IfcId depreciatedValueId) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            Identification = identification;
            OriginalValueId = originalValueId;
            CurrentValueId = currentValueId;
            TotalReplacementCostId = totalReplacementCostId;
            OwnerId = ownerId;
            UserId = userId;
            ResponsiblePersonId = responsiblePersonId;
            IncorporationDate = incorporationDate;
            DepreciatedValueId = depreciatedValueId;
        }

        public override ClassId GetClassId() => ClassId.IfcAsset;

        #region Equality

        public bool Equals(IfcAsset other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Identification == other.Identification
                && OriginalValueId == other.OriginalValueId
                && CurrentValueId == other.CurrentValueId
                && TotalReplacementCostId == other.TotalReplacementCostId
                && OwnerId == other.OwnerId
                && UserId == other.UserId
                && ResponsiblePersonId == other.ResponsiblePersonId
                && IncorporationDate == other.IncorporationDate
                && DepreciatedValueId == other.DepreciatedValueId;
        }

        public override bool Equals(object other) => Equals(other as IfcAsset);

        public static bool operator ==(IfcAsset one, IfcAsset other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcAsset one, IfcAsset other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{Identification}',{OriginalValueId},{CurrentValueId},{TotalReplacementCostId},{OwnerId},{UserId},{ResponsiblePersonId},'{IncorporationDate}',{DepreciatedValueId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(OriginalValueId!= null && replacementTable.ContainsKey(OriginalValueId))
                OriginalValueId = replacementTable[OriginalValueId];
            if(CurrentValueId!= null && replacementTable.ContainsKey(CurrentValueId))
                CurrentValueId = replacementTable[CurrentValueId];
            if(TotalReplacementCostId!= null && replacementTable.ContainsKey(TotalReplacementCostId))
                TotalReplacementCostId = replacementTable[TotalReplacementCostId];
            if(OwnerId!= null && replacementTable.ContainsKey(OwnerId))
                OwnerId = replacementTable[OwnerId];
            if(UserId!= null && replacementTable.ContainsKey(UserId))
                UserId = replacementTable[UserId];
            if(ResponsiblePersonId!= null && replacementTable.ContainsKey(ResponsiblePersonId))
                ResponsiblePersonId = replacementTable[ResponsiblePersonId];
            if(DepreciatedValueId!= null && replacementTable.ContainsKey(DepreciatedValueId))
                DepreciatedValueId = replacementTable[DepreciatedValueId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcAsset (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, Identification, OriginalValueId, CurrentValueId, TotalReplacementCostId, OwnerId, UserId, ResponsiblePersonId, IncorporationDate, DepreciatedValueId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcAsset },
                { "class", nameof(IfcAsset) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        Identification.ToJValue(),
                        OriginalValueId.ToJValue(),
                        CurrentValueId.ToJValue(),
                        TotalReplacementCostId.ToJValue(),
                        OwnerId.ToJValue(),
                        UserId.ToJValue(),
                        ResponsiblePersonId.ToJValue(),
                        IncorporationDate.ToJValue(),
                        DepreciatedValueId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcAsset CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcAsset(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalIfcId(),
                parameters[8].ToOptionalIfcId(),
                parameters[9].ToOptionalIfcId(),
                parameters[10].ToOptionalIfcId(),
                parameters[11].ToOptionalIfcId(),
                parameters[12].ToOptionalString(),
                parameters[13].ToOptionalIfcId());
        }
        #endregion

    }
}