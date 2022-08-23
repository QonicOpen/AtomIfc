
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
    public class IfcCompositeProfileDef : IfcProfileDef, IEquatable<IfcCompositeProfileDef>
    {
        private List<IfcId> _profileIds;
        public List<IfcId> ProfileIds 
        {
            get { 
                return _profileIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ProfileIds is not allowed to be null"); 
                _profileIds = value;
            }
        }
        private string _label;
        public string Label 
        {
            get { 
                return _label; 
            }
            set { 
                _label = value;  // optional IfcLabel
            }
        }

        public IfcCompositeProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, List<IfcId> profileIds, string label) : base(id, profileType, profileName)
        {
            ProfileIds = profileIds;
            Label = label;
        }

        public override ClassId GetClassId() => ClassId.IfcCompositeProfileDef;

        #region Equality

        public bool Equals(IfcCompositeProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ProfileIds, other.ProfileIds))
                return false;
            return base.Equals(other)
                && Label == other.Label;
        }

        public override bool Equals(object other) => Equals(other as IfcCompositeProfileDef);

        public static bool operator ==(IfcCompositeProfileDef one, IfcCompositeProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCompositeProfileDef one, IfcCompositeProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{Utils.ConvertListToString(ProfileIds)},'{Label}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ProfileIds!= null)
                ProfileIds = ProfileIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCompositeProfileDef (newId,ProfileType, ProfileName, ProfileIds, Label);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCompositeProfileDef },
                { "class", nameof(IfcCompositeProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        ProfileIds.ToJArray(),
                        Label.ToJValue(),
                    }
                }
            };
        }

        public static new IfcCompositeProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCompositeProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToOptionalString());
        }
        #endregion

    }
}