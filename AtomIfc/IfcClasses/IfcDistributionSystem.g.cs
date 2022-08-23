
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
    public class IfcDistributionSystem : IfcSystem, IEquatable<IfcDistributionSystem>
    {
        private string _longName;
        public string LongName 
        {
            get { 
                return _longName; 
            }
            set { 
                _longName = value;  // optional IfcLabel
            }
        }
        private IfcDistributionSystemEnum _predefinedType;
        public IfcDistributionSystemEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcDistributionSystemEnum?
            }
        }

        public IfcDistributionSystem(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string longName, IfcDistributionSystemEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            LongName = longName;
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcDistributionSystem;

        #region Equality

        public bool Equals(IfcDistributionSystem other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LongName == other.LongName
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcDistributionSystem);

        public static bool operator ==(IfcDistributionSystem one, IfcDistributionSystem other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDistributionSystem one, IfcDistributionSystem other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{LongName}',.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDistributionSystem (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, LongName, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDistributionSystem },
                { "class", nameof(IfcDistributionSystem) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        LongName.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static new IfcDistributionSystem CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDistributionSystem(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                (IfcDistributionSystemEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDistributionSystemEnum](parameters[6].ToString()));
        }
        #endregion

    }
}