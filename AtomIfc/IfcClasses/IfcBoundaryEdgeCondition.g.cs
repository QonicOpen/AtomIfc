
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
    public class IfcBoundaryEdgeCondition : IfcBoundaryCondition, IEquatable<IfcBoundaryEdgeCondition>
    {
        private IfcId _translationalStiffnessByLengthXId;
        public IfcId TranslationalStiffnessByLengthXId 
        {
            get { 
                return _translationalStiffnessByLengthXId; 
            }
            set { 
                _translationalStiffnessByLengthXId = value;  // optional IfcModulusOfTranslationalSubgradeReactionSelect
            }
        }
        private IfcId _translationalStiffnessByLengthYId;
        public IfcId TranslationalStiffnessByLengthYId 
        {
            get { 
                return _translationalStiffnessByLengthYId; 
            }
            set { 
                _translationalStiffnessByLengthYId = value;  // optional IfcModulusOfTranslationalSubgradeReactionSelect
            }
        }
        private IfcId _translationalStiffnessByLengthZId;
        public IfcId TranslationalStiffnessByLengthZId 
        {
            get { 
                return _translationalStiffnessByLengthZId; 
            }
            set { 
                _translationalStiffnessByLengthZId = value;  // optional IfcModulusOfTranslationalSubgradeReactionSelect
            }
        }
        private IfcId _rotationalStiffnessByLengthXId;
        public IfcId RotationalStiffnessByLengthXId 
        {
            get { 
                return _rotationalStiffnessByLengthXId; 
            }
            set { 
                _rotationalStiffnessByLengthXId = value;  // optional IfcModulusOfRotationalSubgradeReactionSelect
            }
        }
        private IfcId _rotationalStiffnessByLengthYId;
        public IfcId RotationalStiffnessByLengthYId 
        {
            get { 
                return _rotationalStiffnessByLengthYId; 
            }
            set { 
                _rotationalStiffnessByLengthYId = value;  // optional IfcModulusOfRotationalSubgradeReactionSelect
            }
        }
        private IfcId _rotationalStiffnessByLengthZId;
        public IfcId RotationalStiffnessByLengthZId 
        {
            get { 
                return _rotationalStiffnessByLengthZId; 
            }
            set { 
                _rotationalStiffnessByLengthZId = value;  // optional IfcModulusOfRotationalSubgradeReactionSelect
            }
        }

        public IfcBoundaryEdgeCondition(IfcId id, string name, IfcId translationalStiffnessByLengthXId, IfcId translationalStiffnessByLengthYId, IfcId translationalStiffnessByLengthZId, IfcId rotationalStiffnessByLengthXId, IfcId rotationalStiffnessByLengthYId, IfcId rotationalStiffnessByLengthZId) : base(id, name)
        {
            TranslationalStiffnessByLengthXId = translationalStiffnessByLengthXId;
            TranslationalStiffnessByLengthYId = translationalStiffnessByLengthYId;
            TranslationalStiffnessByLengthZId = translationalStiffnessByLengthZId;
            RotationalStiffnessByLengthXId = rotationalStiffnessByLengthXId;
            RotationalStiffnessByLengthYId = rotationalStiffnessByLengthYId;
            RotationalStiffnessByLengthZId = rotationalStiffnessByLengthZId;
        }

        public override ClassId GetClassId() => ClassId.IfcBoundaryEdgeCondition;

        #region Equality

        public bool Equals(IfcBoundaryEdgeCondition other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TranslationalStiffnessByLengthXId == other.TranslationalStiffnessByLengthXId
                && TranslationalStiffnessByLengthYId == other.TranslationalStiffnessByLengthYId
                && TranslationalStiffnessByLengthZId == other.TranslationalStiffnessByLengthZId
                && RotationalStiffnessByLengthXId == other.RotationalStiffnessByLengthXId
                && RotationalStiffnessByLengthYId == other.RotationalStiffnessByLengthYId
                && RotationalStiffnessByLengthZId == other.RotationalStiffnessByLengthZId;
        }

        public override bool Equals(object other) => Equals(other as IfcBoundaryEdgeCondition);

        public static bool operator ==(IfcBoundaryEdgeCondition one, IfcBoundaryEdgeCondition other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBoundaryEdgeCondition one, IfcBoundaryEdgeCondition other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{TranslationalStiffnessByLengthXId},{TranslationalStiffnessByLengthYId},{TranslationalStiffnessByLengthZId},{RotationalStiffnessByLengthXId},{RotationalStiffnessByLengthYId},{RotationalStiffnessByLengthZId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TranslationalStiffnessByLengthXId!= null && replacementTable.ContainsKey(TranslationalStiffnessByLengthXId))
                TranslationalStiffnessByLengthXId = replacementTable[TranslationalStiffnessByLengthXId];
            if(TranslationalStiffnessByLengthYId!= null && replacementTable.ContainsKey(TranslationalStiffnessByLengthYId))
                TranslationalStiffnessByLengthYId = replacementTable[TranslationalStiffnessByLengthYId];
            if(TranslationalStiffnessByLengthZId!= null && replacementTable.ContainsKey(TranslationalStiffnessByLengthZId))
                TranslationalStiffnessByLengthZId = replacementTable[TranslationalStiffnessByLengthZId];
            if(RotationalStiffnessByLengthXId!= null && replacementTable.ContainsKey(RotationalStiffnessByLengthXId))
                RotationalStiffnessByLengthXId = replacementTable[RotationalStiffnessByLengthXId];
            if(RotationalStiffnessByLengthYId!= null && replacementTable.ContainsKey(RotationalStiffnessByLengthYId))
                RotationalStiffnessByLengthYId = replacementTable[RotationalStiffnessByLengthYId];
            if(RotationalStiffnessByLengthZId!= null && replacementTable.ContainsKey(RotationalStiffnessByLengthZId))
                RotationalStiffnessByLengthZId = replacementTable[RotationalStiffnessByLengthZId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBoundaryEdgeCondition (newId,Name, TranslationalStiffnessByLengthXId, TranslationalStiffnessByLengthYId, TranslationalStiffnessByLengthZId, RotationalStiffnessByLengthXId, RotationalStiffnessByLengthYId, RotationalStiffnessByLengthZId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBoundaryEdgeCondition },
                { "class", nameof(IfcBoundaryEdgeCondition) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        TranslationalStiffnessByLengthXId.ToJValue(),
                        TranslationalStiffnessByLengthYId.ToJValue(),
                        TranslationalStiffnessByLengthZId.ToJValue(),
                        RotationalStiffnessByLengthXId.ToJValue(),
                        RotationalStiffnessByLengthYId.ToJValue(),
                        RotationalStiffnessByLengthZId.ToJValue(),
                    }
                }
            };
        }

        public static IfcBoundaryEdgeCondition CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBoundaryEdgeCondition(
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