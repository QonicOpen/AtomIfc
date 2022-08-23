
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
    public class IfcRelSpaceBoundary2ndLevel : IfcRelSpaceBoundary1stLevel, IEquatable<IfcRelSpaceBoundary2ndLevel>
    {
        private IfcId _correspondingBoundaryId;
        public IfcId CorrespondingBoundaryId 
        {
            get { 
                return _correspondingBoundaryId; 
            }
            set { 
                _correspondingBoundaryId = value;  // optional IfcRelSpaceBoundary2ndLevel
            }
        }

        public IfcRelSpaceBoundary2ndLevel(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingSpaceId, IfcId relatedBuildingElementId, IfcId connectionGeometryId, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary, IfcInternalOrExternalEnum internalOrExternalBoundary, IfcId parentBoundaryId, IfcId correspondingBoundaryId) : base(id, ownerHistoryId, name, description, relatingSpaceId, relatedBuildingElementId, connectionGeometryId, physicalOrVirtualBoundary, internalOrExternalBoundary, parentBoundaryId)
        {
            CorrespondingBoundaryId = correspondingBoundaryId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelSpaceBoundary2ndLevel;

        #region Equality

        public bool Equals(IfcRelSpaceBoundary2ndLevel other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && CorrespondingBoundaryId == other.CorrespondingBoundaryId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelSpaceBoundary2ndLevel);

        public static bool operator ==(IfcRelSpaceBoundary2ndLevel one, IfcRelSpaceBoundary2ndLevel other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelSpaceBoundary2ndLevel one, IfcRelSpaceBoundary2ndLevel other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingSpaceId},{RelatedBuildingElementId},{ConnectionGeometryId},.{PhysicalOrVirtualBoundary}.,.{InternalOrExternalBoundary}.,{ParentBoundaryId},{CorrespondingBoundaryId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CorrespondingBoundaryId!= null && replacementTable.ContainsKey(CorrespondingBoundaryId))
                CorrespondingBoundaryId = replacementTable[CorrespondingBoundaryId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelSpaceBoundary2ndLevel (newId,OwnerHistoryId, Name, Description, RelatingSpaceId, RelatedBuildingElementId, ConnectionGeometryId, PhysicalOrVirtualBoundary, InternalOrExternalBoundary, ParentBoundaryId, CorrespondingBoundaryId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelSpaceBoundary2ndLevel },
                { "class", nameof(IfcRelSpaceBoundary2ndLevel) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        RelatingSpaceId.ToJValue(),
                        RelatedBuildingElementId.ToJValue(),
                        ConnectionGeometryId.ToJValue(),
                        PhysicalOrVirtualBoundary.ToJValue(),
                        InternalOrExternalBoundary.ToJValue(),
                        ParentBoundaryId.ToJValue(),
                        CorrespondingBoundaryId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcRelSpaceBoundary2ndLevel CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelSpaceBoundary2ndLevel(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId(),
                (IfcPhysicalOrVirtualEnum)IfcAtom.EnumCreator[(int)EnumId.IfcPhysicalOrVirtualEnum](parameters[6].ToString()),
                (IfcInternalOrExternalEnum)IfcAtom.EnumCreator[(int)EnumId.IfcInternalOrExternalEnum](parameters[7].ToString()),
                parameters[8].ToOptionalIfcId(),
                parameters[9].ToOptionalIfcId());
        }
        #endregion

    }
}