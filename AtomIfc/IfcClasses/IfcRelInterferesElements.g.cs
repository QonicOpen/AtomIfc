
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
    public class IfcRelInterferesElements : IfcRelConnects, IEquatable<IfcRelInterferesElements>
    {
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
        private IfcId _interferenceGeometryId;
        public IfcId InterferenceGeometryId 
        {
            get { 
                return _interferenceGeometryId; 
            }
            set { 
                _interferenceGeometryId = value;  // optional IfcConnectionGeometry
            }
        }
        private string _interferenceType;
        public string InterferenceType 
        {
            get { 
                return _interferenceType; 
            }
            set { 
                _interferenceType = value;  // optional IfcIdentifier
            }
        }
        private bool? _impliedOrder;
        public bool? ImpliedOrder 
        {
            get { 
                return _impliedOrder; 
            }
            set { 
                _impliedOrder = value;
            }
        }

        public IfcRelInterferesElements(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingElementId, IfcId relatedElementId, IfcId interferenceGeometryId, string interferenceType, bool? impliedOrder) : base(id, ownerHistoryId, name, description)
        {
            RelatingElementId = relatingElementId;
            RelatedElementId = relatedElementId;
            InterferenceGeometryId = interferenceGeometryId;
            InterferenceType = interferenceType;
            ImpliedOrder = impliedOrder;
        }

        public override ClassId GetClassId() => ClassId.IfcRelInterferesElements;

        #region Equality

        public bool Equals(IfcRelInterferesElements other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingElementId == other.RelatingElementId
                && RelatedElementId == other.RelatedElementId
                && InterferenceGeometryId == other.InterferenceGeometryId
                && InterferenceType == other.InterferenceType
                && ImpliedOrder == other.ImpliedOrder;
        }

        public override bool Equals(object other) => Equals(other as IfcRelInterferesElements);

        public static bool operator ==(IfcRelInterferesElements one, IfcRelInterferesElements other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelInterferesElements one, IfcRelInterferesElements other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingElementId},{RelatedElementId},{InterferenceGeometryId},'{InterferenceType}',{(ImpliedOrder == null? ".U." : ImpliedOrder)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingElementId!= null && replacementTable.ContainsKey(RelatingElementId))
                RelatingElementId = replacementTable[RelatingElementId];
            if(RelatedElementId!= null && replacementTable.ContainsKey(RelatedElementId))
                RelatedElementId = replacementTable[RelatedElementId];
            if(InterferenceGeometryId!= null && replacementTable.ContainsKey(InterferenceGeometryId))
                InterferenceGeometryId = replacementTable[InterferenceGeometryId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelInterferesElements (newId,OwnerHistoryId, Name, Description, RelatingElementId, RelatedElementId, InterferenceGeometryId, InterferenceType, ImpliedOrder);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelInterferesElements },
                { "class", nameof(IfcRelInterferesElements) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingElementId.ToJValue(),
                        RelatedElementId.ToJValue(),
                        InterferenceGeometryId.ToJValue(),
                        InterferenceType.ToJValue(),
                        ImpliedOrder.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelInterferesElements CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelInterferesElements(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalBool());
        }
        #endregion

    }
}