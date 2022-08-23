
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
    public class IfcElementAssembly : IfcElement, IEquatable<IfcElementAssembly>
    {
        private IfcAssemblyPlaceEnum _assemblyPlace;
        public IfcAssemblyPlaceEnum AssemblyPlace 
        {
            get { 
                return _assemblyPlace; 
            }
            set { 
                _assemblyPlace = value;  // optional IfcAssemblyPlaceEnum?
            }
        }
        private IfcElementAssemblyTypeEnum _predefinedType;
        public IfcElementAssemblyTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcElementAssemblyTypeEnum?
            }
        }

        public IfcElementAssembly(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, string tag, IfcAssemblyPlaceEnum assemblyPlace, IfcElementAssemblyTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, tag)
        {
            AssemblyPlace = assemblyPlace;
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcElementAssembly;

        #region Equality

        public bool Equals(IfcElementAssembly other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && AssemblyPlace == other.AssemblyPlace
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcElementAssembly);

        public static bool operator ==(IfcElementAssembly one, IfcElementAssembly other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcElementAssembly one, IfcElementAssembly other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},'{Tag}',.{AssemblyPlace}.,.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcElementAssembly (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, Tag, AssemblyPlace, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcElementAssembly },
                { "class", nameof(IfcElementAssembly) },
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
                        AssemblyPlace.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcElementAssembly CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcElementAssembly(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalString(),
                (IfcAssemblyPlaceEnum)IfcAtom.EnumCreator[(int)EnumId.IfcAssemblyPlaceEnum](parameters[8].ToString()),
                (IfcElementAssemblyTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcElementAssemblyTypeEnum](parameters[9].ToString()));
        }
        #endregion

    }
}