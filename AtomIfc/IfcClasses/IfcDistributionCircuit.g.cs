
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
    public class IfcDistributionCircuit : IfcDistributionSystem, IEquatable<IfcDistributionCircuit>
    {
        public IfcDistributionCircuit(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string longName, IfcDistributionSystemEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, longName, predefinedType)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcDistributionCircuit;

        #region Equality

        public bool Equals(IfcDistributionCircuit other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcDistributionCircuit);

        public static bool operator ==(IfcDistributionCircuit one, IfcDistributionCircuit other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDistributionCircuit one, IfcDistributionCircuit other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{LongName}',.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDistributionCircuit (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, LongName, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDistributionCircuit },
                { "class", nameof(IfcDistributionCircuit) },
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

        public static new IfcDistributionCircuit CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDistributionCircuit(
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