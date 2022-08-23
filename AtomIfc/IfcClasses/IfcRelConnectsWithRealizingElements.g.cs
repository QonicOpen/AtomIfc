
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
    public class IfcRelConnectsWithRealizingElements : IfcRelConnectsElements, IEquatable<IfcRelConnectsWithRealizingElements>
    {
        private List<IfcId> _realizingElementIds;
        public List<IfcId> RealizingElementIds 
        {
            get { 
                return _realizingElementIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RealizingElementIds is not allowed to be null"); 
                _realizingElementIds = value;
            }
        }
        private string _connectionType;
        public string ConnectionType 
        {
            get { 
                return _connectionType; 
            }
            set { 
                _connectionType = value;  // optional IfcLabel
            }
        }

        public IfcRelConnectsWithRealizingElements(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId connectionGeometryId, IfcId relatingElementId, IfcId relatedElementId, List<IfcId> realizingElementIds, string connectionType) : base(id, ownerHistoryId, name, description, connectionGeometryId, relatingElementId, relatedElementId)
        {
            RealizingElementIds = realizingElementIds;
            ConnectionType = connectionType;
        }

        public override ClassId GetClassId() => ClassId.IfcRelConnectsWithRealizingElements;

        #region Equality

        public bool Equals(IfcRelConnectsWithRealizingElements other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RealizingElementIds, other.RealizingElementIds))
                return false;
            return base.Equals(other)
                && ConnectionType == other.ConnectionType;
        }

        public override bool Equals(object other) => Equals(other as IfcRelConnectsWithRealizingElements);

        public static bool operator ==(IfcRelConnectsWithRealizingElements one, IfcRelConnectsWithRealizingElements other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelConnectsWithRealizingElements one, IfcRelConnectsWithRealizingElements other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{ConnectionGeometryId},{RelatingElementId},{RelatedElementId},{Utils.ConvertListToString(RealizingElementIds)},'{ConnectionType}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RealizingElementIds!= null)
                RealizingElementIds = RealizingElementIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelConnectsWithRealizingElements (newId,OwnerHistoryId, Name, Description, ConnectionGeometryId, RelatingElementId, RelatedElementId, RealizingElementIds, ConnectionType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelConnectsWithRealizingElements },
                { "class", nameof(IfcRelConnectsWithRealizingElements) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ConnectionGeometryId.ToJValue(),
                        RelatingElementId.ToJValue(),
                        RelatedElementId.ToJValue(),
                        RealizingElementIds.ToJArray(),
                        ConnectionType.ToJValue(),
                    }
                }
            };
        }

        public static new IfcRelConnectsWithRealizingElements CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelConnectsWithRealizingElements(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToIfcId(),
                parameters[6].ToIfcIdList(),
                parameters[7].ToOptionalString());
        }
        #endregion

    }
}