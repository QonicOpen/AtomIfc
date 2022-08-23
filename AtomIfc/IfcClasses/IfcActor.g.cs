
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
    public class IfcActor : IfcObject, IEquatable<IfcActor>
    {
        private IfcId _theActorId;
        public IfcId TheActorId 
        {
            get { 
                return _theActorId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TheActorId is not allowed to be null"); 
                _theActorId = value;
            }
        }

        public IfcActor(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId theActorId) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            TheActorId = theActorId;
        }

        public override ClassId GetClassId() => ClassId.IfcActor;

        #region Equality

        public bool Equals(IfcActor other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TheActorId == other.TheActorId;
        }

        public override bool Equals(object other) => Equals(other as IfcActor);

        public static bool operator ==(IfcActor one, IfcActor other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcActor one, IfcActor other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{TheActorId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TheActorId!= null && replacementTable.ContainsKey(TheActorId))
                TheActorId = replacementTable[TheActorId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcActor (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, TheActorId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcActor },
                { "class", nameof(IfcActor) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        TheActorId.ToJValue(),
                    }
                }
            };
        }

        public static IfcActor CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcActor(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToIfcId());
        }
        #endregion

    }
}