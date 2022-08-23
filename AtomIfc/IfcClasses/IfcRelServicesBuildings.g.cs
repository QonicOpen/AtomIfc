
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
    public class IfcRelServicesBuildings : IfcRelConnects, IEquatable<IfcRelServicesBuildings>
    {
        private IfcId _relatingSystemId;
        public IfcId RelatingSystemId 
        {
            get { 
                return _relatingSystemId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingSystemId is not allowed to be null"); 
                _relatingSystemId = value;
            }
        }
        private List<IfcId> _relatedBuildingIds;
        public List<IfcId> RelatedBuildingIds 
        {
            get { 
                return _relatedBuildingIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedBuildingIds is not allowed to be null"); 
                _relatedBuildingIds = value;
            }
        }

        public IfcRelServicesBuildings(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingSystemId, List<IfcId> relatedBuildingIds) : base(id, ownerHistoryId, name, description)
        {
            RelatingSystemId = relatingSystemId;
            RelatedBuildingIds = relatedBuildingIds;
        }

        public override ClassId GetClassId() => ClassId.IfcRelServicesBuildings;

        #region Equality

        public bool Equals(IfcRelServicesBuildings other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatedBuildingIds, other.RelatedBuildingIds))
                return false;
            return base.Equals(other)
                && RelatingSystemId == other.RelatingSystemId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelServicesBuildings);

        public static bool operator ==(IfcRelServicesBuildings one, IfcRelServicesBuildings other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelServicesBuildings one, IfcRelServicesBuildings other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingSystemId},{Utils.ConvertListToString(RelatedBuildingIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingSystemId!= null && replacementTable.ContainsKey(RelatingSystemId))
                RelatingSystemId = replacementTable[RelatingSystemId];
            if(RelatedBuildingIds!= null)
                RelatedBuildingIds = RelatedBuildingIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelServicesBuildings (newId,OwnerHistoryId, Name, Description, RelatingSystemId, RelatedBuildingIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelServicesBuildings },
                { "class", nameof(IfcRelServicesBuildings) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingSystemId.ToJValue(),
                        RelatedBuildingIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcRelServicesBuildings CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelServicesBuildings(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcIdList());
        }
        #endregion

    }
}