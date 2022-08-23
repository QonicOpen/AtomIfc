
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
    public class IfcPersonAndOrganization : IfcBase, IEquatable<IfcPersonAndOrganization>, IIfcActorSelect, IIfcObjectReferenceSelect, IIfcResourceObjectSelect
    {
        private IfcId _thePersonId;
        public IfcId ThePersonId 
        {
            get { 
                return _thePersonId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ThePersonId is not allowed to be null"); 
                _thePersonId = value;
            }
        }
        private IfcId _theOrganizationId;
        public IfcId TheOrganizationId 
        {
            get { 
                return _theOrganizationId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TheOrganizationId is not allowed to be null"); 
                _theOrganizationId = value;
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

        public IfcPersonAndOrganization(IfcId id, IfcId thePersonId, IfcId theOrganizationId, List<IfcId> roleIds) : base(id)
        {
            ThePersonId = thePersonId;
            TheOrganizationId = theOrganizationId;
            RoleIds = roleIds;
        }

        public override ClassId GetClassId() => ClassId.IfcPersonAndOrganization;

        #region Equality

        public bool Equals(IfcPersonAndOrganization other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RoleIds, other.RoleIds))
                return false;
            return base.Equals(other)
                && ThePersonId == other.ThePersonId
                && TheOrganizationId == other.TheOrganizationId;
        }

        public override bool Equals(object other) => Equals(other as IfcPersonAndOrganization);

        public static bool operator ==(IfcPersonAndOrganization one, IfcPersonAndOrganization other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPersonAndOrganization one, IfcPersonAndOrganization other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({ThePersonId},{TheOrganizationId},{Utils.ConvertListToString(RoleIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ThePersonId!= null && replacementTable.ContainsKey(ThePersonId))
                ThePersonId = replacementTable[ThePersonId];
            if(TheOrganizationId!= null && replacementTable.ContainsKey(TheOrganizationId))
                TheOrganizationId = replacementTable[TheOrganizationId];
            if(RoleIds!= null)
                RoleIds = RoleIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPersonAndOrganization (newId,ThePersonId, TheOrganizationId, RoleIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPersonAndOrganization },
                { "class", nameof(IfcPersonAndOrganization) },
                { "parameters" , new JArray
                    {
                        ThePersonId.ToJValue(),
                        TheOrganizationId.ToJValue(),
                        RoleIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcPersonAndOrganization CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPersonAndOrganization(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId(),
                parameters[2].ToOptionalIfcIdList());
        }
        #endregion

    }
}