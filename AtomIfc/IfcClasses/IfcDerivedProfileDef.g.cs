
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
    public class IfcDerivedProfileDef : IfcProfileDef, IEquatable<IfcDerivedProfileDef>
    {
        private IfcId _parentProfileId;
        public IfcId ParentProfileId 
        {
            get { 
                return _parentProfileId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ParentProfileId is not allowed to be null"); 
                _parentProfileId = value;
            }
        }
        private IfcId _operatorId;
        public IfcId OperatorId 
        {
            get { 
                return _operatorId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OperatorId is not allowed to be null"); 
                _operatorId = value;
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

        public IfcDerivedProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId parentProfileId, IfcId operatorId, string label) : base(id, profileType, profileName)
        {
            ParentProfileId = parentProfileId;
            OperatorId = operatorId;
            Label = label;
        }

        public override ClassId GetClassId() => ClassId.IfcDerivedProfileDef;

        #region Equality

        public bool Equals(IfcDerivedProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ParentProfileId == other.ParentProfileId
                && OperatorId == other.OperatorId
                && Label == other.Label;
        }

        public override bool Equals(object other) => Equals(other as IfcDerivedProfileDef);

        public static bool operator ==(IfcDerivedProfileDef one, IfcDerivedProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDerivedProfileDef one, IfcDerivedProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{ParentProfileId},{OperatorId},'{Label}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ParentProfileId!= null && replacementTable.ContainsKey(ParentProfileId))
                ParentProfileId = replacementTable[ParentProfileId];
            if(OperatorId!= null && replacementTable.ContainsKey(OperatorId))
                OperatorId = replacementTable[OperatorId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDerivedProfileDef (newId,ProfileType, ProfileName, ParentProfileId, OperatorId, Label);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDerivedProfileDef },
                { "class", nameof(IfcDerivedProfileDef) },
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

        public static new IfcDerivedProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDerivedProfileDef(
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