
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
    public class IfcRelConnectsElements : IfcRelConnects, IEquatable<IfcRelConnectsElements>
    {
        private IfcId _connectionGeometryId;
        public IfcId ConnectionGeometryId 
        {
            get { 
                return _connectionGeometryId; 
            }
            set { 
                _connectionGeometryId = value;  // optional IfcConnectionGeometry
            }
        }
        private IfcId _relatingElementId;
        public IfcId RelatingElementId 
        {
            get { 
                return _relatingElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingElementId is not allowed to be null"); 
                _relatingElementId = value;
            }
        }
        private IfcId _relatedElementId;
        public IfcId RelatedElementId 
        {
            get { 
                return _relatedElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedElementId is not allowed to be null"); 
                _relatedElementId = value;
            }
        }

        public IfcRelConnectsElements(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId connectionGeometryId, IfcId relatingElementId, IfcId relatedElementId) : base(id, ownerHistoryId, name, description)
        {
            ConnectionGeometryId = connectionGeometryId;
            RelatingElementId = relatingElementId;
            RelatedElementId = relatedElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelConnectsElements;

        #region Equality

        public bool Equals(IfcRelConnectsElements other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ConnectionGeometryId == other.ConnectionGeometryId
                && RelatingElementId == other.RelatingElementId
                && RelatedElementId == other.RelatedElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelConnectsElements);

        public static bool operator ==(IfcRelConnectsElements one, IfcRelConnectsElements other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelConnectsElements one, IfcRelConnectsElements other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{ConnectionGeometryId},{RelatingElementId},{RelatedElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ConnectionGeometryId!= null && replacementTable.ContainsKey(ConnectionGeometryId))
                ConnectionGeometryId = replacementTable[ConnectionGeometryId];
            if(RelatingElementId!= null && replacementTable.ContainsKey(RelatingElementId))
                RelatingElementId = replacementTable[RelatingElementId];
            if(RelatedElementId!= null && replacementTable.ContainsKey(RelatedElementId))
                RelatedElementId = replacementTable[RelatedElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelConnectsElements (newId,OwnerHistoryId, Name, Description, ConnectionGeometryId, RelatingElementId, RelatedElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelConnectsElements },
                { "class", nameof(IfcRelConnectsElements) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ConnectionGeometryId.ToJValue(),
                        RelatingElementId.ToJValue(),
                        RelatedElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelConnectsElements CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelConnectsElements(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToIfcId());
        }
        #endregion

    }
}