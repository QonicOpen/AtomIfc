
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
    public class IfcReinforcementDefinitionProperties : IfcPreDefinedPropertySet, IEquatable<IfcReinforcementDefinitionProperties>
    {
        private string _definitionType;
        public string DefinitionType 
        {
            get { 
                return _definitionType; 
            }
            set { 
                _definitionType = value;  // optional IfcLabel
            }
        }
        private List<IfcId> _reinforcementSectionDefinitionIds;
        public List<IfcId> ReinforcementSectionDefinitionIds 
        {
            get { 
                return _reinforcementSectionDefinitionIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ReinforcementSectionDefinitionIds is not allowed to be null"); 
                _reinforcementSectionDefinitionIds = value;
            }
        }

        public IfcReinforcementDefinitionProperties(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string definitionType, List<IfcId> reinforcementSectionDefinitionIds) : base(id, globalId, ownerHistoryId, name, description)
        {
            DefinitionType = definitionType;
            ReinforcementSectionDefinitionIds = reinforcementSectionDefinitionIds;
        }

        public override ClassId GetClassId() => ClassId.IfcReinforcementDefinitionProperties;

        #region Equality

        public bool Equals(IfcReinforcementDefinitionProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ReinforcementSectionDefinitionIds, other.ReinforcementSectionDefinitionIds))
                return false;
            return base.Equals(other)
                && DefinitionType == other.DefinitionType;
        }

        public override bool Equals(object other) => Equals(other as IfcReinforcementDefinitionProperties);

        public static bool operator ==(IfcReinforcementDefinitionProperties one, IfcReinforcementDefinitionProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcReinforcementDefinitionProperties one, IfcReinforcementDefinitionProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{DefinitionType}',{Utils.ConvertListToString(ReinforcementSectionDefinitionIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ReinforcementSectionDefinitionIds!= null)
                ReinforcementSectionDefinitionIds = ReinforcementSectionDefinitionIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcReinforcementDefinitionProperties (newId,GlobalId, OwnerHistoryId, Name, Description, DefinitionType, ReinforcementSectionDefinitionIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcReinforcementDefinitionProperties },
                { "class", nameof(IfcReinforcementDefinitionProperties) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        DefinitionType.ToJValue(),
                        ReinforcementSectionDefinitionIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcReinforcementDefinitionProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcReinforcementDefinitionProperties(
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