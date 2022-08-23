
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
    public class IfcProfileDef : IfcBase, IEquatable<IfcProfileDef>, IIfcResourceObjectSelect
    {
        private IfcProfileTypeEnum _profileType;
        public IfcProfileTypeEnum ProfileType 
        {
            get { 
                return _profileType; 
            }
            set { 
                _profileType = value;
            }
        }
        private string _profileName;
        public string ProfileName 
        {
            get { 
                return _profileName; 
            }
            set { 
                _profileName = value;  // optional IfcLabel
            }
        }

        public IfcProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName) : base(id)
        {
            ProfileType = profileType;
            ProfileName = profileName;
        }

        public override ClassId GetClassId() => ClassId.IfcProfileDef;

        #region Equality

        public bool Equals(IfcProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ProfileType == other.ProfileType
                && ProfileName == other.ProfileName;
        }

        public override bool Equals(object other) => Equals(other as IfcProfileDef);

        public static bool operator ==(IfcProfileDef one, IfcProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcProfileDef one, IfcProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcProfileDef (newId,ProfileType, ProfileName);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcProfileDef },
                { "class", nameof(IfcProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                    }
                }
            };
        }

        public static IfcProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString());
        }
        #endregion

    }
}