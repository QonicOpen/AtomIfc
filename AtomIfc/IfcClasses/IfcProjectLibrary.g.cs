
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
    public class IfcProjectLibrary : IfcContext, IEquatable<IfcProjectLibrary>
    {
        public IfcProjectLibrary(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string longName, string phase, List<IfcId> representationContextIds, IfcId unitsInContextId) : base(id, globalId, ownerHistoryId, name, description, objectType, longName, phase, representationContextIds, unitsInContextId)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcProjectLibrary;

        #region Equality

        public bool Equals(IfcProjectLibrary other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcProjectLibrary);

        public static bool operator ==(IfcProjectLibrary one, IfcProjectLibrary other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcProjectLibrary one, IfcProjectLibrary other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{LongName}','{Phase}',{Utils.ConvertListToString(RepresentationContextIds)},{UnitsInContextId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcProjectLibrary (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, LongName, Phase, RepresentationContextIds, UnitsInContextId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcProjectLibrary },
                { "class", nameof(IfcProjectLibrary) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        LongName.ToJValue(),
                        Phase.ToJValue(),
                        RepresentationContextIds.ToJArray(),
                        UnitsInContextId.ToJValue(),
                    }
                }
            };
        }

        public static IfcProjectLibrary CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcProjectLibrary(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalIfcIdList(),
                parameters[8].ToOptionalIfcId());
        }
        #endregion

    }
}