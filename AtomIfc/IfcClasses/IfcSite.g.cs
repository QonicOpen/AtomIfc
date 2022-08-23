
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
    public class IfcSite : IfcSpatialStructureElement, IEquatable<IfcSite>
    {
        private List<int> _refLatitude;
        public List<int> RefLatitude 
        {
            get { 
                return _refLatitude; 
            }
            set { 
                _refLatitude = value;  // optional IfcCompoundPlaneAngleMeasure
            }
        }
        private List<int> _refLongitude;
        public List<int> RefLongitude 
        {
            get { 
                return _refLongitude; 
            }
            set { 
                _refLongitude = value;  // optional IfcCompoundPlaneAngleMeasure
            }
        }
        private double? _refElevation;
        public double? RefElevation 
        {
            get { 
                return _refElevation; 
            }
            set { 
                _refElevation = value;  // optional IfcLengthMeasure
            }
        }
        private string _landTitleNumber;
        public string LandTitleNumber 
        {
            get { 
                return _landTitleNumber; 
            }
            set { 
                _landTitleNumber = value;  // optional IfcLabel
            }
        }
        private IfcId _siteAddressId;
        public IfcId SiteAddressId 
        {
            get { 
                return _siteAddressId; 
            }
            set { 
                _siteAddressId = value;  // optional IfcPostalAddress
            }
        }

        public IfcSite(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string longName, IfcElementCompositionEnum compositionType, List<int> refLatitude, List<int> refLongitude, double? refElevation, string landTitleNumber, IfcId siteAddressId) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, longName, compositionType)
        {
            RefLatitude = refLatitude;
            RefLongitude = refLongitude;
            RefElevation = refElevation;
            LandTitleNumber = landTitleNumber;
            SiteAddressId = siteAddressId;
        }

        public override ClassId GetClassId() => ClassId.IfcSite;

        #region Equality

        public bool Equals(IfcSite other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RefLatitude, other.RefLatitude))
                return false;
            if(!Utils.CompareList(RefLongitude, other.RefLongitude))
                return false;
            return base.Equals(other)
                && RefElevation == other.RefElevation
                && LandTitleNumber == other.LandTitleNumber
                && SiteAddressId == other.SiteAddressId;
        }

        public override bool Equals(object other) => Equals(other as IfcSite);

        public static bool operator ==(IfcSite one, IfcSite other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSite one, IfcSite other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{LongName}',.{CompositionType}.,{Utils.ConvertListToString(RefLatitude)},{Utils.ConvertListToString(RefLongitude)},{RefElevation},'{LandTitleNumber}',{SiteAddressId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(SiteAddressId!= null && replacementTable.ContainsKey(SiteAddressId))
                SiteAddressId = replacementTable[SiteAddressId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSite (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, LongName, CompositionType, RefLatitude, RefLongitude, RefElevation, LandTitleNumber, SiteAddressId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSite },
                { "class", nameof(IfcSite) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        LongName.ToJValue(),
                        CompositionType.ToJValue(),
                        RefLatitude.ToJArray(),
                        RefLongitude.ToJArray(),
                        RefElevation.ToJValue(),
                        LandTitleNumber.ToJValue(),
                        SiteAddressId.ToJValue(),
                    }
                }
            };
        }

        public static IfcSite CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSite(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalString(),
                (IfcElementCompositionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcElementCompositionEnum](parameters[8].ToString()),
                parameters[9].ToOptionalIntList(),
                parameters[10].ToOptionalIntList(),
                parameters[11].ToOptionalDouble(),
                parameters[12].ToOptionalString(),
                parameters[13].ToOptionalIfcId());
        }
        #endregion

    }
}