
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
    public class IfcRelAssociatesLibrary : IfcRelAssociates, IEquatable<IfcRelAssociatesLibrary>
    {
        private IfcId _relatingLibraryId;
        public IfcId RelatingLibraryId 
        {
            get { 
                return _relatingLibraryId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingLibraryId is not allowed to be null"); 
                _relatingLibraryId = value;
            }
        }

        public IfcRelAssociatesLibrary(IfcId id, IfcId ownerHistoryId, string name, string description, List<IfcId> relatedObjectIds, IfcId relatingLibraryId) : base(id, ownerHistoryId, name, description, relatedObjectIds)
        {
            RelatingLibraryId = relatingLibraryId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelAssociatesLibrary;

        #region Equality

        public bool Equals(IfcRelAssociatesLibrary other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingLibraryId == other.RelatingLibraryId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelAssociatesLibrary);

        public static bool operator ==(IfcRelAssociatesLibrary one, IfcRelAssociatesLibrary other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelAssociatesLibrary one, IfcRelAssociatesLibrary other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{Utils.ConvertListToString(RelatedObjectIds)},{RelatingLibraryId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingLibraryId!= null && replacementTable.ContainsKey(RelatingLibraryId))
                RelatingLibraryId = replacementTable[RelatingLibraryId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelAssociatesLibrary (newId,OwnerHistoryId, Name, Description, RelatedObjectIds, RelatingLibraryId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelAssociatesLibrary },
                { "class", nameof(IfcRelAssociatesLibrary) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatedObjectIds.ToJArray(),
                        RelatingLibraryId.ToJValue(),
                    }
                }
            };
        }

        public static IfcRelAssociatesLibrary CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelAssociatesLibrary(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcIdList(),
                parameters[4].ToIfcId());
        }
        #endregion

    }
}