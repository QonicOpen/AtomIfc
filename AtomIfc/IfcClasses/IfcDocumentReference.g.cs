
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
    public class IfcDocumentReference : IfcExternalReference, IEquatable<IfcDocumentReference>, IIfcDocumentSelect
    {
        private string _description;
        public string Description 
        {
            get { 
                return _description; 
            }
            set { 
                _description = value;  // optional IfcText
            }
        }
        private IfcId _referencedDocumentId;
        public IfcId ReferencedDocumentId 
        {
            get { 
                return _referencedDocumentId; 
            }
            set { 
                _referencedDocumentId = value;  // optional IfcDocumentInformation
            }
        }

        public IfcDocumentReference(IfcId id, string location, string identification, string name, string description, IfcId referencedDocumentId) : base(id, location, identification, name)
        {
            Description = description;
            ReferencedDocumentId = referencedDocumentId;
        }

        public override ClassId GetClassId() => ClassId.IfcDocumentReference;

        #region Equality

        public bool Equals(IfcDocumentReference other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Description == other.Description
                && ReferencedDocumentId == other.ReferencedDocumentId;
        }

        public override bool Equals(object other) => Equals(other as IfcDocumentReference);

        public static bool operator ==(IfcDocumentReference one, IfcDocumentReference other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDocumentReference one, IfcDocumentReference other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Location}','{Identification}','{Name}','{Description}',{ReferencedDocumentId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ReferencedDocumentId!= null && replacementTable.ContainsKey(ReferencedDocumentId))
                ReferencedDocumentId = replacementTable[ReferencedDocumentId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDocumentReference (newId,Location, Identification, Name, Description, ReferencedDocumentId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDocumentReference },
                { "class", nameof(IfcDocumentReference) },
                { "parameters" , new JArray
                    {
                        Location.ToJValue(),
                        Identification.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ReferencedDocumentId.ToJValue(),
                    }
                }
            };
        }

        public static IfcDocumentReference CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDocumentReference(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalIfcId());
        }
        #endregion

    }
}