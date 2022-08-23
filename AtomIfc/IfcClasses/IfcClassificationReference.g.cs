
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
    public class IfcClassificationReference : IfcExternalReference, IEquatable<IfcClassificationReference>, IIfcClassificationReferenceSelect, IIfcClassificationSelect
    {
        private IfcId _referencedSourceId;
        public IfcId ReferencedSourceId 
        {
            get { 
                return _referencedSourceId; 
            }
            set { 
                _referencedSourceId = value;  // optional IfcClassificationReferenceSelect
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
        private string _sort;
        public string Sort 
        {
            get { 
                return _sort; 
            }
            set { 
                _sort = value;  // optional IfcIdentifier
            }
        }

        public IfcClassificationReference(IfcId id, string location, string identification, string name, IfcId referencedSourceId, string description, string sort) : base(id, location, identification, name)
        {
            ReferencedSourceId = referencedSourceId;
            Description = description;
            Sort = sort;
        }

        public override ClassId GetClassId() => ClassId.IfcClassificationReference;

        #region Equality

        public bool Equals(IfcClassificationReference other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ReferencedSourceId == other.ReferencedSourceId
                && Description == other.Description
                && Sort == other.Sort;
        }

        public override bool Equals(object other) => Equals(other as IfcClassificationReference);

        public static bool operator ==(IfcClassificationReference one, IfcClassificationReference other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcClassificationReference one, IfcClassificationReference other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Location}','{Identification}','{Name}',{ReferencedSourceId},'{Description}','{Sort}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ReferencedSourceId!= null && replacementTable.ContainsKey(ReferencedSourceId))
                ReferencedSourceId = replacementTable[ReferencedSourceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcClassificationReference (newId,Location, Identification, Name, ReferencedSourceId, Description, Sort);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcClassificationReference },
                { "class", nameof(IfcClassificationReference) },
                { "parameters" , new JArray
                    {
                        Location.ToJValue(),
                        Identification.ToJValue(),
                        Name.ToJValue(),
                        ReferencedSourceId.ToJValue(),
                        Description.ToJValue(),
                        Sort.ToJValue(),
                    }
                }
            };
        }

        public static IfcClassificationReference CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcClassificationReference(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString());
        }
        #endregion

    }
}