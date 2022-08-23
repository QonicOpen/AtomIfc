
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
    public class IfcMirroredProfileDef : IfcDerivedProfileDef, IEquatable<IfcMirroredProfileDef>
    {
        public IfcMirroredProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId parentProfileId, IfcId operatorId, string label) : base(id, profileType, profileName, parentProfileId, operatorId, label)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcMirroredProfileDef;

        #region Equality

        public bool Equals(IfcMirroredProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcMirroredProfileDef);

        public static bool operator ==(IfcMirroredProfileDef one, IfcMirroredProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMirroredProfileDef one, IfcMirroredProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{ParentProfileId},{OperatorId},'{Label}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMirroredProfileDef (newId,ProfileType, ProfileName, ParentProfileId, OperatorId, Label);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMirroredProfileDef },
                { "class", nameof(IfcMirroredProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        ParentProfileId.ToJValue(),
                        OperatorId.ToJValue(),
                        Label.ToJValue(),
                    }
                }
            };
        }

        public static new IfcMirroredProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMirroredProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcId(),
                parameters[3].ToIfcId(),
                parameters[4].ToOptionalString());
        }
        #endregion

    }
}