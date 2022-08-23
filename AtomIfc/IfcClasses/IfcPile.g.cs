
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
    public class IfcPile : IfcBuildingElement, IEquatable<IfcPile>
    {
        private IfcPileTypeEnum _predefinedType;
        public IfcPileTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcPileTypeEnum?
            }
        }
        private IfcPileConstructionEnum _constructionType;
        public IfcPileConstructionEnum ConstructionType 
        {
            get { 
                return _constructionType; 
            }
            set { 
                _constructionType = value;  // optional IfcPileConstructionEnum?
            }
        }

        public IfcPile(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, IfcPileTypeEnum predefinedType, IfcPileConstructionEnum constructionType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag)
        {
            PredefinedType = predefinedType;
            ConstructionType = constructionType;
        }

        public override ClassId GetClassId() => ClassId.IfcPile;

        #region Equality

        public bool Equals(IfcPile other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && ConstructionType == other.ConstructionType;
        }

        public override bool Equals(object other) => Equals(other as IfcPile);

        public static bool operator ==(IfcPile one, IfcPile other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPile one, IfcPile other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}',.{PredefinedType}.,.{ConstructionType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPile (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, PredefinedType, ConstructionType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPile },
                { "class", nameof(IfcPile) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        Tag.ToJValue(),
                        PredefinedType.ToJValue(),
                        ConstructionType.ToJValue(),
                    }
                }
            };
        }

        public static IfcPile CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPile(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalString(),
                (IfcPileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcPileTypeEnum](parameters[8].ToString()),
                (IfcPileConstructionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcPileConstructionEnum](parameters[9].ToString()));
        }
        #endregion

    }
}