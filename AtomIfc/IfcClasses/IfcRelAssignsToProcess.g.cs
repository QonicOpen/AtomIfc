
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
    public class IfcRelAssignsToProcess : IfcRelAssigns, IEquatable<IfcRelAssignsToProcess>
    {
        private IfcId _relatingProcessId;
        public IfcId RelatingProcessId 
        {
            get { 
                return _relatingProcessId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingProcessId is not allowed to be null"); 
                _relatingProcessId = value;
            }
        }
        private IfcId _quantityInProcessId;
        public IfcId QuantityInProcessId 
        {
            get { 
                return _quantityInProcessId; 
            }
            set { 
                _quantityInProcessId = value;  // optional IfcMeasureWithUnit
            }
        }

        public IfcRelAssignsToProcess(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcObjectTypeEnum relatedObjectsType, IfcId relatingProcessId, IfcId quantityInProcessId) : base(id, ownerHistoryId, name, description, relatedObjectIds, relatedObjectsType)
        {
            RelatingProcessId = relatingProcessId;
            QuantityInProcessId = quantityInProcessId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssignsToProcess;

        #region Equality

        public bool Equals(IfcRelAssignsToProcess other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingProcessId == other.RelatingProcessId
                && QuantityInProcessId == other.QuantityInProcessId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssignsToProcess);

        public static bool operator ==(IfcRelAssignsToProcess one, IfcRelAssignsToProcess other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssignsToProcess one, IfcRelAssignsToProcess other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},.{RelatedObjectsType}.,{RelatingProcessId},{QuantityInProcessId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingProcessId!= null && replacementTable.ContainsKey(RelatingProcessId))
                RelatingProcessId = replacementTable[RelatingProcessId];
            if(QuantityInProcessId!= null && replacementTable.ContainsKey(QuantityInProcessId))
                QuantityInProcessId = replacementTable[QuantityInProcessId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssignsToProcess (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatedObjectsType, RelatingProcessId, QuantityInProcessId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssignsToProcess },
                { "class", nameof(IfcRelAssignsToProcess) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatedObjectsType.ToJValue(),
                        RelatingProcessId.ToJValue(),
                        QuantityInProcessId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssignsToProcess CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssignsToProcess(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcIdList(),
                (IfcObjectTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcObjectTypeEnum](parameters[4].ToString()),
                parameters[5].ToIfcId(),
                parameters[6].ToOptionalIfcId());
        }
        #endregion

    }
}