
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
    public class IfcProjectOrder : IfcControl, IEquatable<IfcProjectOrder>
    {
        private IfcProjectOrderTypeEnum _predefinedType;
        public IfcProjectOrderTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcProjectOrderTypeEnum?
            }
        }
        private string _status;
        public string Status 
        {
            get { 
                return _status; 
            }
            set { 
                _status = value;  // optional IfcLabel
            }
        }
        private string _longDescription;
        public string LongDescription 
        {
            get { 
                return _longDescription; 
            }
            set { 
                _longDescription = value;  // optional IfcText
            }
        }

        public IfcProjectOrder(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, IfcProjectOrderTypeEnum predefinedType, string status, string longDescription) : base(id, globalId, ownerHistoryId, name, description, objectType, identification)
        {
            PredefinedType = predefinedType;
            Status = status;
            LongDescription = longDescription;
        }

        public override ClassId GetClassId() => ClassId.IfcProjectOrder;

        #region Equality

        public bool Equals(IfcProjectOrder other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && Status == other.Status
                && LongDescription == other.LongDescription;
        }

        public override bool Equals(object other) => Equals(other as IfcProjectOrder);

        public static bool operator ==(IfcProjectOrder one, IfcProjectOrder other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcProjectOrder one, IfcProjectOrder other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{Identification}',.{PredefinedType}.,'{Status}','{LongDescription}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcProjectOrder (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, Identification, PredefinedType, Status, LongDescription);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcProjectOrder },
                { "class", nameof(IfcProjectOrder) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        Identification.ToJValue(),
                        PredefinedType.ToJValue(),
                        Status.ToJValue(),
                        LongDescription.ToJValue(),
                    }
                }
            };
        }

        public static IfcProjectOrder CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcProjectOrder(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                (IfcProjectOrderTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProjectOrderTypeEnum](parameters[6].ToString()),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalString());
        }
        #endregion

    }
}