
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
    public class IfcRelConnectsPorts : IfcRelConnects, IEquatable<IfcRelConnectsPorts>
    {
        private IfcId _relatingPortId;
        public IfcId RelatingPortId 
        {
            get { 
                return _relatingPortId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingPortId is not allowed to be null"); 
                _relatingPortId = value;
            }
        }
        private IfcId _relatedPortId;
        public IfcId RelatedPortId 
        {
            get { 
                return _relatedPortId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedPortId is not allowed to be null"); 
                _relatedPortId = value;
            }
        }
        private IfcId _realizingElementId;
        public IfcId RealizingElementId 
        {
            get { 
                return _realizingElementId; 
            }
            set { 
                _realizingElementId = value;  // optional IfcElement
            }
        }

        public IfcRelConnectsPorts(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingPortId, IfcId relatedPortId, IfcId realizingElementId) : base(id, ownerHistoryId, name, description)
        {
            RelatingPortId = relatingPortId;
            RelatedPortId = relatedPortId;
            RealizingElementId = realizingElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelConnectsPorts;

        #region Equality

        public bool Equals(IfcRelConnectsPorts other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingPortId == other.RelatingPortId
                && RelatedPortId == other.RelatedPortId
                && RealizingElementId == other.RealizingElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelConnectsPorts);

        public static bool operator ==(IfcRelConnectsPorts one, IfcRelConnectsPorts other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelConnectsPorts one, IfcRelConnectsPorts other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingPortId},{RelatedPortId},{RealizingElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingPortId!= null && replacementTable.ContainsKey(RelatingPortId))
                RelatingPortId = replacementTable[RelatingPortId];
            if(RelatedPortId!= null && replacementTable.ContainsKey(RelatedPortId))
                RelatedPortId = replacementTable[RelatedPortId];
            if(RealizingElementId!= null && replacementTable.ContainsKey(RealizingElementId))
                RealizingElementId = replacementTable[RealizingElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelConnectsPorts (newId,OwnerHistoryId, Name, Description, RelatingPortId, RelatedPortId, RealizingElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelConnectsPorts },
                { "class", nameof(IfcRelConnectsPorts) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingPortId.ToJValue(),
                        RelatedPortId.ToJValue(),
                        RealizingElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelConnectsPorts CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelConnectsPorts(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId());
        }
        #endregion

    }
}