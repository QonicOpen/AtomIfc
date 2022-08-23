
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
    public class IfcLibraryInformation : IfcExternalInformation, IEquatable<IfcLibraryInformation>, IIfcLibrarySelect
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;
            }
        }
        private string _version;
        public string Version 
        {
            get { 
                return _version; 
            }
            set { 
                _version = value;  // optional IfcLabel
            }
        }
        private IfcId _publisherId;
        public IfcId PublisherId 
        {
            get { 
                return _publisherId; 
            }
            set { 
                _publisherId = value;  // optional IfcActorSelect
            }
        }
        private string _versionDate;
        public string VersionDate 
        {
            get { 
                return _versionDate; 
            }
            set { 
                _versionDate = value;  // optional IfcDateTime
            }
        }
        private string _location;
        public string Location 
        {
            get { 
                return _location; 
            }
            set { 
                _location = value;  // optional IfcURIReference
            }
        }
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

        public IfcLibraryInformation(IfcId id, string name, string version, IfcId publisherId, string versionDate, string location, string description) : base(id)
        {
            Name = name;
            Version = version;
            PublisherId = publisherId;
            VersionDate = versionDate;
            Location = location;
            Description = description;
        }

        public override ClassId GetClassId() => ClassId.IfcLibraryInformation;

        #region Equality

        public bool Equals(IfcLibraryInformation other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Version == other.Version
                && PublisherId == other.PublisherId
                && VersionDate == other.VersionDate
                && Location == other.Location
                && Description == other.Description;
        }

        public override bool Equals(object other) => Equals(other as IfcLibraryInformation);

        public static bool operator ==(IfcLibraryInformation one, IfcLibraryInformation other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLibraryInformation one, IfcLibraryInformation other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Version}',{PublisherId},'{VersionDate}','{Location}','{Description}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PublisherId!= null && replacementTable.ContainsKey(PublisherId))
                PublisherId = replacementTable[PublisherId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLibraryInformation (newId,Name, Version, PublisherId, VersionDate, Location, Description);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLibraryInformation },
                { "class", nameof(IfcLibraryInformation) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Version.ToJValue(),
                        PublisherId.ToJValue(),
                        VersionDate.ToJValue(),
                        Location.ToJValue(),
                        Description.ToJValue(),
                    }
                }
            };
        }

        public static IfcLibraryInformation CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLibraryInformation(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString());
        }
        #endregion

    }
}