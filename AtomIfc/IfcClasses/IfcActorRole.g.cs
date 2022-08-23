
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
    public class IfcActorRole : IfcBase, IEquatable<IfcActorRole>, IIfcResourceObjectSelect
    {
        private IfcRoleEnum _role;
        public IfcRoleEnum Role 
        {
            get { 
                return _role; 
            }
            set { 
                _role = value;
            }
        }
        private string _userDefinedRole;
        public string UserDefinedRole 
        {
            get { 
                return _userDefinedRole; 
            }
            set { 
                _userDefinedRole = value;  // optional IfcLabel
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

        public IfcActorRole(IfcId id, IfcRoleEnum role, string userDefinedRole, string description) : base(id)
        {
            Role = role;
            UserDefinedRole = userDefinedRole;
            Description = description;
        }

        public override ClassId GetClassId() => ClassId.IfcActorRole;

        #region Equality

        public bool Equals(IfcActorRole other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Role == other.Role
                && UserDefinedRole == other.UserDefinedRole
                && Description == other.Description;
        }

        public override bool Equals(object other) => Equals(other as IfcActorRole);

        public static bool operator ==(IfcActorRole one, IfcActorRole other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcActorRole one, IfcActorRole other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{Role}.,'{UserDefinedRole}','{Description}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcActorRole (newId,Role, UserDefinedRole, Description);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcActorRole },
                { "class", nameof(IfcActorRole) },
                { "parameters" , new JArray
                    {
                        Role.ToJValue(),
                        UserDefinedRole.ToJValue(),
                        Description.ToJValue(),
                    }
                }
            };
        }

        public static IfcActorRole CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcActorRole(
                jObject["id"].ToIfcId(),
                (IfcRoleEnum)IfcAtom.EnumCreator[(int)EnumId.IfcRoleEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString());
        }
        #endregion

    }
}