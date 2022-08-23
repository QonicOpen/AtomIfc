
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
    public class IfcRelSpaceBoundary1stLevel : IfcRelSpaceBoundary, IEquatable<IfcRelSpaceBoundary1stLevel>
    {
        private IfcId _parentBoundaryId;
        public IfcId ParentBoundaryId 
        {
            get { 
                return _parentBoundaryId; 
            }
            set { 
                _parentBoundaryId = value;  // optional IfcRelSpaceBoundary1stLevel
            }
        }

        public IfcRelSpaceBoundary1stLevel(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingSpaceId, IfcId relatedBuildingElementId, IfcId connectionGeometryId, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary, IfcInternalOrExternalEnum internalOrExternalBoundary, IfcId parentBoundaryId) : base(id, ownerHistoryId, name, description, relatingSpaceId, relatedBuildingElementId, connectionGeometryId, physicalOrVirtualBoundary, internalOrExternalBoundary)
        {
            ParentBoundaryId = parentBoundaryId;
        }

        public override ClassId GetClassId() => ClassId.IfcRelSpaceBoundary1stLevel;

        #region Equality

        public bool Equals(IfcRelSpaceBoundary1stLevel other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ParentBoundaryId == other.ParentBoundaryId;
        }

        public override bool Equals(object other) => Equals(other as IfcRelSpaceBoundary1stLevel);

        public static bool operator ==(IfcRelSpaceBoundary1stLevel one, IfcRelSpaceBoundary1stLevel other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelSpaceBoundary1stLevel one, IfcRelSpaceBoundary1stLevel other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingSpaceId},{RelatedBuildingElementId},{ConnectionGeometryId},.{PhysicalOrVirtualBoundary}.,.{InternalOrExternalBoundary}.,{ParentBoundaryId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ParentBoundaryId!= null && replacementTable.ContainsKey(ParentBoundaryId))
                ParentBoundaryId = replacementTable[ParentBoundaryId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelSpaceBoundary1stLevel (newId,OwnerHistoryId, Name, Description, RelatingSpaceId, RelatedBuildingElementId, ConnectionGeometryId, PhysicalOrVirtualBoundary, InternalOrExternalBoundary, ParentBoundaryId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelSpaceBoundary1stLevel },
                { "class", nameof(IfcRelSpaceBoundary1stLevel) },
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
                    }
                }
            };
        }

        public static new IfcRelSpaceBoundary1stLevel CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelSpaceBoundary1stLevel(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId(),
                (IfcPhysicalOrVirtualEnum)IfcAtom.EnumCreator[(int)EnumId.IfcPhysicalOrVirtualEnum](parameters[6].ToString()),
                (IfcInternalOrExternalEnum)IfcAtom.EnumCreator[(int)EnumId.IfcInternalOrExternalEnum](parameters[7].ToString()),
                parameters[8].ToOptionalIfcId());
        }
        #endregion

    }
}