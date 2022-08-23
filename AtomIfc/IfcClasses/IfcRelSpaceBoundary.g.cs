
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
    public class IfcRelSpaceBoundary : IfcRelConnects, IEquatable<IfcRelSpaceBoundary>
    {
        private IfcId _relatingSpaceId;
        public IfcId RelatingSpaceId 
        {
            get { 
                return _relatingSpaceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingSpaceId is not allowed to be null"); 
                _relatingSpaceId = value;
            }
        }
        private IfcId _relatedBuildingElementId;
        public IfcId RelatedBuildingElementId 
        {
            get { 
                return _relatedBuildingElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedBuildingElementId is not allowed to be null"); 
                _relatedBuildingElementId = value;
            }
        }
        private IfcId _connectionGeometryId;
        public IfcId ConnectionGeometryId 
        {
            get { 
                return _connectionGeometryId; 
            }
            set { 
                _connectionGeometryId = value;  // optional IfcConnectionGeometry
            }
        }
        private IfcPhysicalOrVirtualEnum _physicalOrVirtualBoundary;
        public IfcPhysicalOrVirtualEnum PhysicalOrVirtualBoundary 
        {
            get { 
                return _physicalOrVirtualBoundary; 
            }
            set { 
                _physicalOrVirtualBoundary = value;
            }
        }
        private IfcInternalOrExternalEnum _internalOrExternalBoundary;
        public IfcInternalOrExternalEnum InternalOrExternalBoundary 
        {
            get { 
                return _internalOrExternalBoundary; 
            }
            set { 
                _internalOrExternalBoundary = value;
            }
        }

        public IfcRelSpaceBoundary(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId relatingSpaceId, IfcId relatedBuildingElementId, IfcId connectionGeometryId, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary, IfcInternalOrExternalEnum internalOrExternalBoundary) : base(id, ownerHistoryId, name, description)
        {
            RelatingSpaceId = relatingSpaceId;
            RelatedBuildingElementId = relatedBuildingElementId;
            ConnectionGeometryId = connectionGeometryId;
            PhysicalOrVirtualBoundary = physicalOrVirtualBoundary;
            InternalOrExternalBoundary = internalOrExternalBoundary;
        }

        public override ClassId GetClassId() => ClassId.IfcRelSpaceBoundary;

        #region Equality

        public bool Equals(IfcRelSpaceBoundary other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && RelatingSpaceId == other.RelatingSpaceId
                && RelatedBuildingElementId == other.RelatedBuildingElementId
                && ConnectionGeometryId == other.ConnectionGeometryId
                && PhysicalOrVirtualBoundary == other.PhysicalOrVirtualBoundary
                && InternalOrExternalBoundary == other.InternalOrExternalBoundary;
        }

        public override bool Equals(object other) => Equals(other as IfcRelSpaceBoundary);

        public static bool operator ==(IfcRelSpaceBoundary one, IfcRelSpaceBoundary other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelSpaceBoundary one, IfcRelSpaceBoundary other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{RelatingSpaceId},{RelatedBuildingElementId},{ConnectionGeometryId},.{PhysicalOrVirtualBoundary}.,.{InternalOrExternalBoundary}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(RelatingSpaceId!= null && replacementTable.ContainsKey(RelatingSpaceId))
                RelatingSpaceId = replacementTable[RelatingSpaceId];
            if(RelatedBuildingElementId!= null && replacementTable.ContainsKey(RelatedBuildingElementId))
                RelatedBuildingElementId = replacementTable[RelatedBuildingElementId];
            if(ConnectionGeometryId!= null && replacementTable.ContainsKey(ConnectionGeometryId))
                ConnectionGeometryId = replacementTable[ConnectionGeometryId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelSpaceBoundary (newId,OwnerHistoryId, Name, Description, RelatingSpaceId, RelatedBuildingElementId, ConnectionGeometryId, PhysicalOrVirtualBoundary, InternalOrExternalBoundary);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelSpaceBoundary },
                { "class", nameof(IfcRelSpaceBoundary) },
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
                    }
                }
            };
        }

        public static IfcRelSpaceBoundary CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelSpaceBoundary(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId(),
                (IfcPhysicalOrVirtualEnum)IfcAtom.EnumCreator[(int)EnumId.IfcPhysicalOrVirtualEnum](parameters[6].ToString()),
                (IfcInternalOrExternalEnum)IfcAtom.EnumCreator[(int)EnumId.IfcInternalOrExternalEnum](parameters[7].ToString()));
        }
        #endregion

    }
}