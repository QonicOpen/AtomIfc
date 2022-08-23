
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
    public class IfcBoundaryNodeCondition : IfcBoundaryCondition, IEquatable<IfcBoundaryNodeCondition>
    {
        private IfcId _translationalStiffnessXId;
        public IfcId TranslationalStiffnessXId 
        {
            get { 
                return _translationalStiffnessXId; 
            }
            set { 
                _translationalStiffnessXId = value;  // optional IfcTranslationalStiffnessSelect
            }
        }
        private IfcId _translationalStiffnessYId;
        public IfcId TranslationalStiffnessYId 
        {
            get { 
                return _translationalStiffnessYId; 
            }
            set { 
                _translationalStiffnessYId = value;  // optional IfcTranslationalStiffnessSelect
            }
        }
        private IfcId _translationalStiffnessZId;
        public IfcId TranslationalStiffnessZId 
        {
            get { 
                return _translationalStiffnessZId; 
            }
            set { 
                _translationalStiffnessZId = value;  // optional IfcTranslationalStiffnessSelect
            }
        }
        private IfcId _rotationalStiffnessXId;
        public IfcId RotationalStiffnessXId 
        {
            get { 
                return _rotationalStiffnessXId; 
            }
            set { 
                _rotationalStiffnessXId = value;  // optional IfcRotationalStiffnessSelect
            }
        }
        private IfcId _rotationalStiffnessYId;
        public IfcId RotationalStiffnessYId 
        {
            get { 
                return _rotationalStiffnessYId; 
            }
            set { 
                _rotationalStiffnessYId = value;  // optional IfcRotationalStiffnessSelect
            }
        }
        private IfcId _rotationalStiffnessZId;
        public IfcId RotationalStiffnessZId 
        {
            get { 
                return _rotationalStiffnessZId; 
            }
            set { 
                _rotationalStiffnessZId = value;  // optional IfcRotationalStiffnessSelect
            }
        }

        public IfcBoundaryNodeCondition(IfcId id, string name, IfcId translationalStiffnessXId, IfcId translationalStiffnessYId, IfcId translationalStiffnessZId, IfcId rotationalStiffnessXId, IfcId rotationalStiffnessYId, IfcId rotationalStiffnessZId) : base(id, name)
        {
            TranslationalStiffnessXId = translationalStiffnessXId;
            TranslationalStiffnessYId = translationalStiffnessYId;
            TranslationalStiffnessZId = translationalStiffnessZId;
            RotationalStiffnessXId = rotationalStiffnessXId;
            RotationalStiffnessYId = rotationalStiffnessYId;
            RotationalStiffnessZId = rotationalStiffnessZId;
        }

        public override ClassId GetClassId() => ClassId.IfcBoundaryNodeCondition;

        #region Equality

        public bool Equals(IfcBoundaryNodeCondition other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TranslationalStiffnessXId == other.TranslationalStiffnessXId
                && TranslationalStiffnessYId == other.TranslationalStiffnessYId
                && TranslationalStiffnessZId == other.TranslationalStiffnessZId
                && RotationalStiffnessXId == other.RotationalStiffnessXId
                && RotationalStiffnessYId == other.RotationalStiffnessYId
                && RotationalStiffnessZId == other.RotationalStiffnessZId;
        }

        public override bool Equals(object other) => Equals(other as IfcBoundaryNodeCondition);

        public static bool operator ==(IfcBoundaryNodeCondition one, IfcBoundaryNodeCondition other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBoundaryNodeCondition one, IfcBoundaryNodeCondition other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{TranslationalStiffnessXId},{TranslationalStiffnessYId},{TranslationalStiffnessZId},{RotationalStiffnessXId},{RotationalStiffnessYId},{RotationalStiffnessZId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TranslationalStiffnessXId!= null && replacementTable.ContainsKey(TranslationalStiffnessXId))
                TranslationalStiffnessXId = replacementTable[TranslationalStiffnessXId];
            if(TranslationalStiffnessYId!= null && replacementTable.ContainsKey(TranslationalStiffnessYId))
                TranslationalStiffnessYId = replacementTable[TranslationalStiffnessYId];
            if(TranslationalStiffnessZId!= null && replacementTable.ContainsKey(TranslationalStiffnessZId))
                TranslationalStiffnessZId = replacementTable[TranslationalStiffnessZId];
            if(RotationalStiffnessXId!= null && replacementTable.ContainsKey(RotationalStiffnessXId))
                RotationalStiffnessXId = replacementTable[RotationalStiffnessXId];
            if(RotationalStiffnessYId!= null && replacementTable.ContainsKey(RotationalStiffnessYId))
                RotationalStiffnessYId = replacementTable[RotationalStiffnessYId];
            if(RotationalStiffnessZId!= null && replacementTable.ContainsKey(RotationalStiffnessZId))
                RotationalStiffnessZId = replacementTable[RotationalStiffnessZId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBoundaryNodeCondition (newId,Name, TranslationalStiffnessXId, TranslationalStiffnessYId, TranslationalStiffnessZId, RotationalStiffnessXId, RotationalStiffnessYId, RotationalStiffnessZId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBoundaryNodeCondition },
                { "class", nameof(IfcBoundaryNodeCondition) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        TranslationalStiffnessXId.ToJValue(),
                        TranslationalStiffnessYId.ToJValue(),
                        TranslationalStiffnessZId.ToJValue(),
                        RotationalStiffnessXId.ToJValue(),
                        RotationalStiffnessYId.ToJValue(),
                        RotationalStiffnessZId.ToJValue(),
                    }
                }
            };
        }

        public static IfcBoundaryNodeCondition CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBoundaryNodeCondition(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalIfcId(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId());
        }
        #endregion

    }
}