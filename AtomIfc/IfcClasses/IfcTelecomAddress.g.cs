
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
    public class IfcTelecomAddress : IfcAddress, IEquatable<IfcTelecomAddress>
    {
        private List<string> _telephoneNumbers;
        public List<string> TelephoneNumbers 
        {
            get { 
                return _telephoneNumbers; 
            }
            set { 
                _telephoneNumbers = value;  // optional List<IfcLabel>
            }
        }
        private List<string> _facsimileNumbers;
        public List<string> FacsimileNumbers 
        {
            get { 
                return _facsimileNumbers; 
            }
            set { 
                _facsimileNumbers = value;  // optional List<IfcLabel>
            }
        }
        private string _pagerNumber;
        public string PagerNumber 
        {
            get { 
                return _pagerNumber; 
            }
            set { 
                _pagerNumber = value;  // optional IfcLabel
            }
        }
        private List<string> _electronicMailAddresses;
        public List<string> ElectronicMailAddresses 
        {
            get { 
                return _electronicMailAddresses; 
            }
            set { 
                _electronicMailAddresses = value;  // optional List<IfcLabel>
            }
        }
        private string _wWWHomePageURL;
        public string WWWHomePageURL 
        {
            get { 
                return _wWWHomePageURL; 
            }
            set { 
                _wWWHomePageURL = value;  // optional IfcURIReference
            }
        }
        private List<string> _messagingIDs;
        public List<string> MessagingIDs 
        {
            get { 
                return _messagingIDs; 
            }
            set { 
                _messagingIDs = value;  // optional List<IfcURIReference>
            }
        }

        public IfcTelecomAddress(IfcId id, IfcAddressTypeEnum purpose, string description, string userDefinedPurpose, List<string> telephoneNumbers, List<string> facsimileNumbers, string pagerNumber, List<string> electronicMailAddresses, string wWWHomePageURL, List<string> messagingIDs) : base(id, purpose, description, userDefinedPurpose)
        {
            TelephoneNumbers = telephoneNumbers;
            FacsimileNumbers = facsimileNumbers;
            PagerNumber = pagerNumber;
            ElectronicMailAddresses = electronicMailAddresses;
            WWWHomePageURL = wWWHomePageURL;
            MessagingIDs = messagingIDs;
        }

        public override ClassId GetClassId() => ClassId.IfcTelecomAddress;

        #region Equality

        public bool Equals(IfcTelecomAddress other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(TelephoneNumbers, other.TelephoneNumbers))
                return false;
            if(!Utils.CompareList(FacsimileNumbers, other.FacsimileNumbers))
                return false;
            if(!Utils.CompareList(ElectronicMailAddresses, other.ElectronicMailAddresses))
                return false;
            if(!Utils.CompareList(MessagingIDs, other.MessagingIDs))
                return false;
            return base.Equals(other)
                && PagerNumber == other.PagerNumber
                && WWWHomePageURL == other.WWWHomePageURL;
        }

        public override bool Equals(object other) => Equals(other as IfcTelecomAddress);

        public static bool operator ==(IfcTelecomAddress one, IfcTelecomAddress other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTelecomAddress one, IfcTelecomAddress other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{Purpose}.,'{Description}','{UserDefinedPurpose}',{TelephoneNumbers.ToJArray()},{FacsimileNumbers.ToJArray()},'{PagerNumber}',{ElectronicMailAddresses.ToJArray()},'{WWWHomePageURL}',{MessagingIDs.ToJArray()})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTelecomAddress (newId,Purpose, Description, UserDefinedPurpose, TelephoneNumbers, FacsimileNumbers, PagerNumber, ElectronicMailAddresses, WWWHomePageURL, MessagingIDs);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTelecomAddress },
                { "class", nameof(IfcTelecomAddress) },
                { "parameters" , new JArray
                    {
                        Purpose.ToJValue(),
                        Description.ToJValue(),
                        UserDefinedPurpose.ToJValue(),
                        TelephoneNumbers.ToJArray(),
                        FacsimileNumbers.ToJArray(),
                        PagerNumber.ToJValue(),
                        ElectronicMailAddresses.ToJArray(),
                        WWWHomePageURL.ToJValue(),
                        MessagingIDs.ToJArray(),
                    }
                }
            };
        }

        public static IfcTelecomAddress CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTelecomAddress(
                jObject["id"].ToIfcId(),
                (IfcAddressTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcAddressTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalStringList(),
                parameters[4].ToOptionalStringList(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalStringList(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalStringList());
        }
        #endregion

    }
}