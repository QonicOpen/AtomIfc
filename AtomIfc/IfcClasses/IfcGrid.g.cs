
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
    public class IfcGrid : IfcProduct, IEquatable<IfcGrid>
    {
        private List<IfcId> _uAxisIds;
        public List<IfcId> UAxisIds 
        {
            get { 
                return _uAxisIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("UAxisIds is not allowed to be null"); 
                _uAxisIds = value;
            }
        }
        private List<IfcId> _vAxisIds;
        public List<IfcId> VAxisIds 
        {
            get { 
                return _vAxisIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("VAxisIds is not allowed to be null"); 
                _vAxisIds = value;
            }
        }
        private List<IfcId> _wAxisIds;
        public List<IfcId> WAxisIds 
        {
            get { 
                return _wAxisIds; 
            }
            set { 
                _wAxisIds = value;  // optional List<IfcGridAxis>
            }
        }
        private IfcGridTypeEnum _predefinedType;
        public IfcGridTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcGridTypeEnum?
            }
        }

        public IfcGrid(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, List<IfcId> uAxisIds, List<IfcId> vAxisIds, List<IfcId> wAxisIds, IfcGridTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId)
        {
            UAxisIds = uAxisIds;
            VAxisIds = vAxisIds;
            WAxisIds = wAxisIds;
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcGrid;

        #region Equality

        public bool Equals(IfcGrid other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(UAxisIds, other.UAxisIds))
                return false;
            if(!Utils.CompareList(VAxisIds, other.VAxisIds))
                return false;
            if(!Utils.CompareList(WAxisIds, other.WAxisIds))
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcGrid);

        public static bool operator ==(IfcGrid one, IfcGrid other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcGrid one, IfcGrid other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},{Utils.ConvertListToString(UAxisIds)},{Utils.ConvertListToString(VAxisIds)},{Utils.ConvertListToString(WAxisIds)},.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(UAxisIds!= null)
                UAxisIds = UAxisIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(VAxisIds!= null)
                VAxisIds = VAxisIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(WAxisIds!= null)
                WAxisIds = WAxisIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcGrid (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, UAxisIds, VAxisIds, WAxisIds, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcGrid },
                { "class", nameof(IfcGrid) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        UAxisIds.ToJArray(),
                        VAxisIds.ToJArray(),
                        WAxisIds.ToJArray(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcGrid CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcGrid(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToIfcIdList(),
                parameters[8].ToIfcIdList(),
                parameters[9].ToOptionalIfcIdList(),
                (IfcGridTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcGridTypeEnum](parameters[10].ToString()));
        }
        #endregion

    }
}