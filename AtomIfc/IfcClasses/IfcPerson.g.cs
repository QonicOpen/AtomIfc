
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
    public class IfcPerson : IfcBase, IEquatable<IfcPerson>, IIfcActorSelect, IIfcObjectReferenceSelect, IIfcResourceObjectSelect
    {
        private string _identification;
        public string Identification 
        {
            get { 
                return _identification; 
            }
            set { 
                _identification = value;  // optional IfcIdentifier
            }
        }
        private string _familyName;
        public string FamilyName 
        {
            get { 
                return _familyName; 
            }
            set { 
                _familyName = value;  // optional IfcLabel
            }
        }
        private string _givenName;
        public string GivenName 
        {
            get { 
                return _givenName; 
            }
            set { 
                _givenName = value;  // optional IfcLabel
            }
        }
        private List<string> _middleNames;
        public List<string> MiddleNames 
        {
            get { 
                return _middleNames; 
            }
            set { 
                _middleNames = value;  // optional List<IfcLabel>
            }
        }
        private List<string> _prefixTitles;
        public List<string> PrefixTitles 
        {
            get { 
                return _prefixTitles; 
            }
            set { 
                _prefixTitles = value;  // optional List<IfcLabel>
            }
        }
        private List<string> _suffixTitles;
        public List<string> SuffixTitles 
        {
            get { 
                return _suffixTitles; 
            }
            set { 
                _suffixTitles = value;  // optional List<IfcLabel>
            }
        }
        private List<IfcId> _roleIds;
        public List<IfcId> RoleIds 
        {
            get { 
                return _roleIds; 
            }
            set { 
                _roleIds = value;  // optional List<IfcActorRole>
            }
        }
        private List<IfcId> _addressIds;
        public List<IfcId> AddressIds 
        {
            get { 
                return _addressIds; 
            }
            set { 
                _addressIds = value;  // optional List<IfcAddress>
            }
        }

        public IfcPerson(IfcId id, string identification, string familyName, string givenName, List<string> middleNames, List<string> prefixTitles, List<string> suffixTitles, List<IfcId> roleIds, List<IfcId> addressIds) : base(id)
        {
            Identification = identification;
            FamilyName = familyName;
            GivenName = givenName;
            MiddleNames = middleNames;
            PrefixTitles = prefixTitles;
            SuffixTitles = suffixTitles;
            RoleIds = roleIds;
            AddressIds = addressIds;
        }

        public override ClassId GetClassId() => ClassId.IfcPerson;

        #region Equality

        public bool Equals(IfcPerson other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(MiddleNames, other.MiddleNames))
                return false;
            if(!Utils.CompareList(PrefixTitles, other.PrefixTitles))
                return false;
            if(!Utils.CompareList(SuffixTitles, other.SuffixTitles))
                return false;
            if(!Utils.CompareList(RoleIds, other.RoleIds))
                return false;
            if(!Utils.CompareList(AddressIds, other.AddressIds))
                return false;
            return base.Equals(other)
                && Identification == other.Identification
                && FamilyName == other.FamilyName
                && GivenName == other.GivenName;
        }

        public override bool Equals(object other) => Equals(other as IfcPerson);

        public static bool operator ==(IfcPerson one, IfcPerson other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPerson one, IfcPerson other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Identification}','{FamilyName}','{GivenName}',{MiddleNames.ToJArray()},{PrefixTitles.ToJArray()},{SuffixTitles.ToJArray()},{Utils.ConvertListToString(RoleIds)},{Utils.ConvertListToString(AddressIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RoleIds!= null)
                RoleIds = RoleIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(AddressIds!= null)
                AddressIds = AddressIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPerson (newId,Identification, FamilyName, GivenName, MiddleNames, PrefixTitles, SuffixTitles, RoleIds, AddressIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPerson },
                { "class", nameof(IfcPerson) },
                { "parameters" , new JArray
                    {
                        Identification.ToJValue(),
                        FamilyName.ToJValue(),
                        GivenName.ToJValue(),
                        MiddleNames.ToJArray(),
                        PrefixTitles.ToJArray(),
                        SuffixTitles.ToJArray(),
                        RoleIds.ToJArray(),
                        AddressIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcPerson CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPerson(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalStringList(),
                parameters[4].ToOptionalStringList(),
                parameters[5].ToOptionalStringList(),
                parameters[6].ToOptionalIfcIdList(),
                parameters[7].ToOptionalIfcIdList());
        }
        #endregion

    }
}