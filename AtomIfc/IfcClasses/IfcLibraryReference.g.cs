
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
    public class IfcLibraryReference : IfcExternalReference, IEquatable<IfcLibraryReference>, IIfcLibrarySelect
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
        private IfcId _languageId;
        public IfcId LanguageId 
        {
            get { 
                return _languageId; 
            }
            set { 
                _languageId = value;  // optional IfcLanguageId
            }
        }
        private IfcId _referencedLibraryId;
        public IfcId ReferencedLibraryId 
        {
            get { 
                return _referencedLibraryId; 
            }
            set { 
                _referencedLibraryId = value;  // optional IfcLibraryInformation
            }
        }

        public IfcLibraryReference(IfcId id, string location, string identification, string name, string description, IfcId languageId, IfcId referencedLibraryId) : base(id, location, identification, name)
        {
            Description = description;
            LanguageId = languageId;
            ReferencedLibraryId = referencedLibraryId;
        }

        public override ClassId GetClassId() => ClassId.IfcLibraryReference;

        #region Equality

        public bool Equals(IfcLibraryReference other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Description == other.Description
                && LanguageId == other.LanguageId
                && ReferencedLibraryId == other.ReferencedLibraryId;
        }

        public override bool Equals(object other) => Equals(other as IfcLibraryReference);

        public static bool operator ==(IfcLibraryReference one, IfcLibraryReference other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLibraryReference one, IfcLibraryReference other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Location}','{Identification}','{Name}','{Description}',{LanguageId},{ReferencedLibraryId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(LanguageId!= null && replacementTable.ContainsKey(LanguageId))
                LanguageId = replacementTable[LanguageId];
            if(ReferencedLibraryId!= null && replacementTable.ContainsKey(ReferencedLibraryId))
                ReferencedLibraryId = replacementTable[ReferencedLibraryId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLibraryReference (newId,Location, Identification, Name, Description, LanguageId, ReferencedLibraryId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLibraryReference },
                { "class", nameof(IfcLibraryReference) },
                { "parameters" , new JArray
                    {
                        Location.ToJValue(),
                        Identification.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        LanguageId.ToJValue(),
                        ReferencedLibraryId.ToJValue(),
                    }
                }
            };
        }

        public static IfcLibraryReference CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLibraryReference(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalIfcId(),
                parameters[5].ToOptionalIfcId());
        }
        #endregion

    }
}