
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
    public class IfcBoundaryNodeConditionWarping : IfcBoundaryNodeCondition, IEquatable<IfcBoundaryNodeConditionWarping>
    {
        private IfcId _warpingStiffnessId;
        public IfcId WarpingStiffnessId 
        {
            get { 
                return _warpingStiffnessId; 
            }
            set { 
                _warpingStiffnessId = value;  // optional IfcWarpingStiffnessSelect
            }
        }

        public IfcBoundaryNodeConditionWarping(IfcId id, string name, IfcId translationalStiffnessXId, IfcId translationalStiffnessYId, IfcId translationalStiffnessZId, IfcId rotationalStiffnessXId, IfcId rotationalStiffnessYId, IfcId rotationalStiffnessZId, IfcId warpingStiffnessId) : base(id, name, translationalStiffnessXId, translationalStiffnessYId, translationalStiffnessZId, rotationalStiffnessXId, rotationalStiffnessYId, rotationalStiffnessZId)
        {
            WarpingStiffnessId = warpingStiffnessId;
        }

        public override ClassId GetClassId() => ClassId.IfcBoundaryNodeConditionWarping;

        #region Equality

        public bool Equals(IfcBoundaryNodeConditionWarping other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && WarpingStiffnessId == other.WarpingStiffnessId;
        }

        public override bool Equals(object other) => Equals(other as IfcBoundaryNodeConditionWarping);

        public static bool operator ==(IfcBoundaryNodeConditionWarping one, IfcBoundaryNodeConditionWarping other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBoundaryNodeConditionWarping one, IfcBoundaryNodeConditionWarping other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{TranslationalStiffnessXId},{TranslationalStiffnessYId},{TranslationalStiffnessZId},{RotationalStiffnessXId},{RotationalStiffnessYId},{RotationalStiffnessZId},{WarpingStiffnessId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(WarpingStiffnessId!= null && replacementTable.ContainsKey(WarpingStiffnessId))
                WarpingStiffnessId = replacementTable[WarpingStiffnessId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBoundaryNodeConditionWarping (newId,Name, TranslationalStiffnessXId, TranslationalStiffnessYId, TranslationalStiffnessZId, RotationalStiffnessXId, RotationalStiffnessYId, RotationalStiffnessZId, WarpingStiffnessId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBoundaryNodeConditionWarping },
                { "class", nameof(IfcBoundaryNodeConditionWarping) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        TranslationalStiffnessXId.ToJValue(),
                        TranslationalStiffnessYId.ToJValue(),
                        TranslationalStiffnessZId.ToJValue(),
                        RotationalStiffnessXId.ToJValue(),
                        RotationalStiffnessYId.ToJValue(),
                        RotationalStiffnessZId.ToJValue(),
                        WarpingStiffnessId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcBoundaryNodeConditionWarping CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBoundaryNodeConditionWarping(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalIfcId(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalIfcId());
        }
        #endregion

    }
}