
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
    public class IfcMaterialClassificationRelationship : IfcBase, IEquatable<IfcMaterialClassificationRelationship>
    {
        private List<IfcId> _materialClassificationIds;
        public List<IfcId> MaterialClassificationIds 
        {
            get { 
                return _materialClassificationIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("MaterialClassificationIds is not allowed to be null"); 
                _materialClassificationIds = value;
            }
        }
        private IfcId _classifiedMaterialId;
        public IfcId ClassifiedMaterialId 
        {
            get { 
                return _classifiedMaterialId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ClassifiedMaterialId is not allowed to be null"); 
                _classifiedMaterialId = value;
            }
        }

        public IfcMaterialClassificationRelationship(IfcId id, List<IfcId> materialClassificationIds, IfcId classifiedMaterialId) : base(id)
        {
            MaterialClassificationIds = materialClassificationIds;
            ClassifiedMaterialId = classifiedMaterialId;
        }

        public override ClassId GetClassId() => ClassId.IfcMaterialClassificationRelationship;

        #region Equality

        public bool Equals(IfcMaterialClassificationRelationship other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(MaterialClassificationIds, other.MaterialClassificationIds))
                return false;
            return base.Equals(other)
                && ClassifiedMaterialId == other.ClassifiedMaterialId;
        }

        public override bool Equals(object other) => Equals(other as IfcMaterialClassificationRelationship);

        public static bool operator ==(IfcMaterialClassificationRelationship one, IfcMaterialClassificationRelationship other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMaterialClassificationRelationship one, IfcMaterialClassificationRelationship other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(MaterialClassificationIds)},{ClassifiedMaterialId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(MaterialClassificationIds!= null)
                MaterialClassificationIds = MaterialClassificationIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(ClassifiedMaterialId!= null && replacementTable.ContainsKey(ClassifiedMaterialId))
                ClassifiedMaterialId = replacementTable[ClassifiedMaterialId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMaterialClassificationRelationship (newId,MaterialClassificationIds, ClassifiedMaterialId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMaterialClassificationRelationship },
                { "class", nameof(IfcMaterialClassificationRelationship) },
                { "parameters" , new JArray
                    {
                        MaterialClassificationIds.ToJArray(),
                        ClassifiedMaterialId.ToJValue(),
                    }
                }
            };
        }

        public static IfcMaterialClassificationRelationship CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMaterialClassificationRelationship(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToIfcId());
        }
        #endregion

    }
}