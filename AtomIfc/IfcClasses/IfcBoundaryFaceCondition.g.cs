
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
    public class IfcBoundaryFaceCondition : IfcBoundaryCondition, IEquatable<IfcBoundaryFaceCondition>
    {
        private IfcId _translationalStiffnessByAreaXId;
        public IfcId TranslationalStiffnessByAreaXId 
        {
            get { 
                return _translationalStiffnessByAreaXId; 
            }
            set { 
                _translationalStiffnessByAreaXId = value;  // optional IfcModulusOfSubgradeReactionSelect
            }
        }
        private IfcId _translationalStiffnessByAreaYId;
        public IfcId TranslationalStiffnessByAreaYId 
        {
            get { 
                return _translationalStiffnessByAreaYId; 
            }
            set { 
                _translationalStiffnessByAreaYId = value;  // optional IfcModulusOfSubgradeReactionSelect
            }
        }
        private IfcId _translationalStiffnessByAreaZId;
        public IfcId TranslationalStiffnessByAreaZId 
        {
            get { 
                return _translationalStiffnessByAreaZId; 
            }
            set { 
                _translationalStiffnessByAreaZId = value;  // optional IfcModulusOfSubgradeReactionSelect
            }
        }

        public IfcBoundaryFaceCondition(IfcId id, string name, IfcId translationalStiffnessByAreaXId, IfcId translationalStiffnessByAreaYId, IfcId translationalStiffnessByAreaZId) : base(id, name)
        {
            TranslationalStiffnessByAreaXId = translationalStiffnessByAreaXId;
            TranslationalStiffnessByAreaYId = translationalStiffnessByAreaYId;
            TranslationalStiffnessByAreaZId = translationalStiffnessByAreaZId;
        }

        public override ClassId GetClassId() => ClassId.IfcBoundaryFaceCondition;

        #region Equality

        public bool Equals(IfcBoundaryFaceCondition other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TranslationalStiffnessByAreaXId == other.TranslationalStiffnessByAreaXId
                && TranslationalStiffnessByAreaYId == other.TranslationalStiffnessByAreaYId
                && TranslationalStiffnessByAreaZId == other.TranslationalStiffnessByAreaZId;
        }

        public override bool Equals(object other) => Equals(other as IfcBoundaryFaceCondition);

        public static bool operator ==(IfcBoundaryFaceCondition one, IfcBoundaryFaceCondition other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBoundaryFaceCondition one, IfcBoundaryFaceCondition other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{TranslationalStiffnessByAreaXId},{TranslationalStiffnessByAreaYId},{TranslationalStiffnessByAreaZId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TranslationalStiffnessByAreaXId!= null && replacementTable.ContainsKey(TranslationalStiffnessByAreaXId))
                TranslationalStiffnessByAreaXId = replacementTable[TranslationalStiffnessByAreaXId];
            if(TranslationalStiffnessByAreaYId!= null && replacementTable.ContainsKey(TranslationalStiffnessByAreaYId))
                TranslationalStiffnessByAreaYId = replacementTable[TranslationalStiffnessByAreaYId];
            if(TranslationalStiffnessByAreaZId!= null && replacementTable.ContainsKey(TranslationalStiffnessByAreaZId))
                TranslationalStiffnessByAreaZId = replacementTable[TranslationalStiffnessByAreaZId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBoundaryFaceCondition (newId,Name, TranslationalStiffnessByAreaXId, TranslationalStiffnessByAreaYId, TranslationalStiffnessByAreaZId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBoundaryFaceCondition },
                { "class", nameof(IfcBoundaryFaceCondition) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        TranslationalStiffnessByAreaXId.ToJValue(),
                        TranslationalStiffnessByAreaYId.ToJValue(),
                        TranslationalStiffnessByAreaZId.ToJValue(),
                    }
                }
            };
        }

        public static IfcBoundaryFaceCondition CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBoundaryFaceCondition(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalIfcId());
        }
        #endregion

    }
}