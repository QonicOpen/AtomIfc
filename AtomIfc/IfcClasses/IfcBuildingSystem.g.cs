
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
    public class IfcBuildingSystem : IfcSystem, IEquatable<IfcBuildingSystem>
    {
        private IfcBuildingSystemTypeEnum _predefinedType;
        public IfcBuildingSystemTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcBuildingSystemTypeEnum?
            }
        }

        public IfcBuildingSystem(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcBuildingSystemTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcBuildingSystem;

        #region Equality

        public bool Equals(IfcBuildingSystem other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcBuildingSystem);

        public static bool operator ==(IfcBuildingSystem one, IfcBuildingSystem other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBuildingSystem one, IfcBuildingSystem other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBuildingSystem (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBuildingSystem },
                { "class", nameof(IfcBuildingSystem) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static new IfcBuildingSystem CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBuildingSystem(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                (IfcBuildingSystemTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcBuildingSystemTypeEnum](parameters[5].ToString()));
        }
        #endregion

    }
}