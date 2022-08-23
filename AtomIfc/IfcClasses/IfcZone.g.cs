
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
    public class IfcZone : IfcSystem, IEquatable<IfcZone>
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

        public IfcZone(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string longName) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            LongName = longName;
        }

        public override ClassId GetClassId() => ClassId.IfcZone;

        #region Equality

        public bool Equals(IfcZone other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LongName == other.LongName;
        }

        public override bool Equals(object other) => Equals(other as IfcZone);

        public static bool operator ==(IfcZone one, IfcZone other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcZone one, IfcZone other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{LongName}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcZone (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, LongName);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcZone },
                { "class", nameof(IfcZone) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        LongName.ToJValue(),
                    }
                }
            };
        }

        public static new IfcZone CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcZone(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString());
        }
        #endregion

    }
}