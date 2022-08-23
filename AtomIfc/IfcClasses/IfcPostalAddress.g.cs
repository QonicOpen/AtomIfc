
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
    public class IfcPostalAddress : IfcAddress, IEquatable<IfcPostalAddress>
    {
        private string _internalLocation;
        public string InternalLocation 
        {
            get { 
                return _internalLocation; 
            }
            set { 
                _internalLocation = value;  // optional IfcLabel
            }
        }
        private List<string> _addressLines;
        public List<string> AddressLines 
        {
            get { 
                return _addressLines; 
            }
            set { 
                _addressLines = value;  // optional List<IfcLabel>
            }
        }
        private string _postalBox;
        public string PostalBox 
        {
            get { 
                return _postalBox; 
            }
            set { 
                _postalBox = value;  // optional IfcLabel
            }
        }
        private string _town;
        public string Town 
        {
            get { 
                return _town; 
            }
            set { 
                _town = value;  // optional IfcLabel
            }
        }
        private string _region;
        public string Region 
        {
            get { 
                return _region; 
            }
            set { 
                _region = value;  // optional IfcLabel
            }
        }
        private string _postalCode;
        public string PostalCode 
        {
            get { 
                return _postalCode; 
            }
            set { 
                _postalCode = value;  // optional IfcLabel
            }
        }
        private string _country;
        public string Country 
        {
            get { 
                return _country; 
            }
            set { 
                _country = value;  // optional IfcLabel
            }
        }

        public IfcPostalAddress(IfcId id, IfcAddressTypeEnum purpose, string description, string userDefinedPurpose, string internalLocation, List<string> addressLines, string postalBox, string town, string region, string postalCode, string country) : base(id, purpose, description, userDefinedPurpose)
        {
            InternalLocation = internalLocation;
            AddressLines = addressLines;
            PostalBox = postalBox;
            Town = town;
            Region = region;
            PostalCode = postalCode;
            Country = country;
        }

        public override ClassId GetClassId() => ClassId.IfcPostalAddress;

        #region Equality

        public bool Equals(IfcPostalAddress other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(AddressLines, other.AddressLines))
                return false;
            return base.Equals(other)
                && InternalLocation == other.InternalLocation
                && PostalBox == other.PostalBox
                && Town == other.Town
                && Region == other.Region
                && PostalCode == other.PostalCode
                && Country == other.Country;
        }

        public override bool Equals(object other) => Equals(other as IfcPostalAddress);

        public static bool operator ==(IfcPostalAddress one, IfcPostalAddress other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPostalAddress one, IfcPostalAddress other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{Purpose}.,'{Description}','{UserDefinedPurpose}','{InternalLocation}',{AddressLines.ToJArray()},'{PostalBox}','{Town}','{Region}','{PostalCode}','{Country}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPostalAddress (newId,Purpose, Description, UserDefinedPurpose, InternalLocation, AddressLines, PostalBox, Town, Region, PostalCode, Country);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPostalAddress },
                { "class", nameof(IfcPostalAddress) },
                { "parameters" , new JArray
                    {
                        Purpose.ToJValue(),
                        Description.ToJValue(),
                        UserDefinedPurpose.ToJValue(),
                        InternalLocation.ToJValue(),
                        AddressLines.ToJArray(),
                        PostalBox.ToJValue(),
                        Town.ToJValue(),
                        Region.ToJValue(),
                        PostalCode.ToJValue(),
                        Country.ToJValue(),
                    }
                }
            };
        }

        public static IfcPostalAddress CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPostalAddress(
                jObject["id"].ToIfcId(),
                (IfcAddressTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcAddressTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalStringList(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString(),
                parameters[9].ToOptionalString());
        }
        #endregion

    }
}