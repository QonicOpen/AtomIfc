
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
    public class IfcOrganization : IfcBase, IEquatable<IfcOrganization>, IIfcActorSelect, IIfcObjectReferenceSelect, IIfcResourceObjectSelect
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

        public IfcOrganization(IfcId id, string identification, string name, string description, List<IfcId> roleIds, List<IfcId> addressIds) : base(id)
        {
            Identification = identification;
            Name = name;
            Description = description;
            RoleIds = roleIds;
            AddressIds = addressIds;
        }

        public override ClassId GetClassId() => ClassId.IfcOrganization;

        #region Equality

        public bool Equals(IfcOrganization other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RoleIds, other.RoleIds))
                return false;
            if(!Utils.CompareList(AddressIds, other.AddressIds))
                return false;
            return base.Equals(other)
                && Identification == other.Identification
                && Name == other.Name
                && Description == other.Description;
        }

        public override bool Equals(object other) => Equals(other as IfcOrganization);

        public static bool operator ==(IfcOrganization one, IfcOrganization other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcOrganization one, IfcOrganization other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Identification}','{Name}','{Description}',{Utils.ConvertListToString(RoleIds)},{Utils.ConvertListToString(AddressIds)})";
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
            return new IfcOrganization (newId,Identification, Name, Description, RoleIds, AddressIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcOrganization },
                { "class", nameof(IfcOrganization) },
                { "parameters" , new JArray
                    {
                        Identification.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RoleIds.ToJArray(),
                        AddressIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcOrganization CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcOrganization(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcIdList(),
                parameters[4].ToOptionalIfcIdList());
        }
        #endregion

    }
}