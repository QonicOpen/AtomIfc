
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
    public class IfcDistributionPort : IfcPort, IEquatable<IfcDistributionPort>
    {
        private IfcFlowDirectionEnum _flowDirection;
        public IfcFlowDirectionEnum FlowDirection 
        {
            get { 
                return _flowDirection; 
            }
            set { 
                _flowDirection = value;  // optional IfcFlowDirectionEnum?
            }
        }
        private IfcDistributionPortTypeEnum _predefinedType;
        public IfcDistributionPortTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcDistributionPortTypeEnum?
            }
        }
        private IfcDistributionSystemEnum _systemType;
        public IfcDistributionSystemEnum SystemType 
        {
            get { 
                return _systemType; 
            }
            set { 
                _systemType = value;  // optional IfcDistributionSystemEnum?
            }
        }

        public IfcDistributionPort(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, IfcFlowDirectionEnum flowDirection, IfcDistributionPortTypeEnum predefinedType, IfcDistributionSystemEnum systemType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId)
        {
            FlowDirection = flowDirection;
            PredefinedType = predefinedType;
            SystemType = systemType;
        }

        public override ClassId GetClassId() => ClassId.IfcDistributionPort;

        #region Equality

        public bool Equals(IfcDistributionPort other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && FlowDirection == other.FlowDirection
                && PredefinedType == other.PredefinedType
                && SystemType == other.SystemType;
        }

        public override bool Equals(object other) => Equals(other as IfcDistributionPort);

        public static bool operator ==(IfcDistributionPort one, IfcDistributionPort other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDistributionPort one, IfcDistributionPort other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},.{FlowDirection}.,.{PredefinedType}.,.{SystemType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDistributionPort (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, FlowDirection, PredefinedType, SystemType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDistributionPort },
                { "class", nameof(IfcDistributionPort) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        FlowDirection.ToJValue(),
                        PredefinedType.ToJValue(),
                        SystemType.ToJValue(),
                    }
                }
            };
        }

        public static IfcDistributionPort CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDistributionPort(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                (IfcFlowDirectionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcFlowDirectionEnum](parameters[7].ToString()),
                (IfcDistributionPortTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDistributionPortTypeEnum](parameters[8].ToString()),
                (IfcDistributionSystemEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDistributionSystemEnum](parameters[9].ToString()));
        }
        #endregion

    }
}