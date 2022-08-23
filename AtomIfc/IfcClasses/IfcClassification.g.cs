
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
    public class IfcClassification : IfcExternalInformation, IEquatable<IfcClassification>, IIfcClassificationReferenceSelect, IIfcClassificationSelect
    {
        private string _source;
        public string Source 
        {
            get { 
                return _source; 
            }
            set { 
                _source = value;  // optional IfcLabel
            }
        }
        private string _edition;
        public string Edition 
        {
            get { 
                return _edition; 
            }
            set { 
                _edition = value;  // optional IfcLabel
            }
        }
        private string _editionDate;
        public string EditionDate 
        {
            get { 
                return _editionDate; 
            }
            set { 
                _editionDate = value;  // optional IfcDate
            }
        }
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
        private List<string> _referenceTokens;
        public List<string> ReferenceTokens 
        {
            get { 
                return _referenceTokens; 
            }
            set { 
                _referenceTokens = value;  // optional List<IfcIdentifier>
            }
        }

        public IfcClassification(IfcId id, string source, string edition, string editionDate, string name, string description, string location, List<string> referenceTokens) : base(id)
        {
            Source = source;
            Edition = edition;
            EditionDate = editionDate;
            Name = name;
            Description = description;
            Location = location;
            ReferenceTokens = referenceTokens;
        }

        public override ClassId GetClassId() => ClassId.IfcClassification;

        #region Equality

        public bool Equals(IfcClassification other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ReferenceTokens, other.ReferenceTokens))
                return false;
            return base.Equals(other)
                && Source == other.Source
                && Edition == other.Edition
                && EditionDate == other.EditionDate
                && Name == other.Name
                && Description == other.Description
                && Location == other.Location;
        }

        public override bool Equals(object other) => Equals(other as IfcClassification);

        public static bool operator ==(IfcClassification one, IfcClassification other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcClassification one, IfcClassification other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Source}','{Edition}','{EditionDate}','{Name}','{Description}','{Location}',{ReferenceTokens.ToJArray()})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcClassification (newId,Source, Edition, EditionDate, Name, Description, Location, ReferenceTokens);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcClassification },
                { "class", nameof(IfcClassification) },
                { "parameters" , new JArray
                    {
                        Source.ToJValue(),
                        Edition.ToJValue(),
                        EditionDate.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        Location.ToJValue(),
                        ReferenceTokens.ToJArray(),
                    }
                }
            };
        }

        public static IfcClassification CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcClassification(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalStringList());
        }
        #endregion

    }
}