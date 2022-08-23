
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
    public class IfcStructuralSurfaceAction : IfcStructuralAction, IEquatable<IfcStructuralSurfaceAction>
    {
        private IfcProjectedOrTrueLengthEnum _projectedOrTrue;
        public IfcProjectedOrTrueLengthEnum ProjectedOrTrue 
        {
            get { 
                return _projectedOrTrue; 
            }
            set { 
                _projectedOrTrue = value;  // optional IfcProjectedOrTrueLengthEnum?
            }
        }
        private IfcStructuralSurfaceActivityTypeEnum _predefinedType;
        public IfcStructuralSurfaceActivityTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }

        public IfcStructuralSurfaceAction(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, IfcId appliedLoadId, IfcGlobalOrLocalEnum globalOrLocal, bool? destabilizingLoad, IfcProjectedOrTrueLengthEnum projectedOrTrue, IfcStructuralSurfaceActivityTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId, appliedLoadId, globalOrLocal, destabilizingLoad)
        {
            ProjectedOrTrue = projectedOrTrue;
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralSurfaceAction;

        #region Equality

        public bool Equals(IfcStructuralSurfaceAction other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ProjectedOrTrue == other.ProjectedOrTrue
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralSurfaceAction);

        public static bool operator ==(IfcStructuralSurfaceAction one, IfcStructuralSurfaceAction other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralSurfaceAction one, IfcStructuralSurfaceAction other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},{AppliedLoadId},.{GlobalOrLocal}.,{(DestabilizingLoad == null? ".U." : DestabilizingLoad)},.{ProjectedOrTrue}.,.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralSurfaceAction (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, AppliedLoadId, GlobalOrLocal, DestabilizingLoad, ProjectedOrTrue, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralSurfaceAction },
                { "class", nameof(IfcStructuralSurfaceAction) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        AppliedLoadId.ToJValue(),
                        GlobalOrLocal.ToJValue(),
                        DestabilizingLoad.ToJValue(),
                        ProjectedOrTrue.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcStructuralSurfaceAction CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralSurfaceAction(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToIfcId(),
                (IfcGlobalOrLocalEnum)IfcAtom.EnumCreator[(int)EnumId.IfcGlobalOrLocalEnum](parameters[8].ToString()),
                parameters[9].ToOptionalBool(),
                (IfcProjectedOrTrueLengthEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProjectedOrTrueLengthEnum](parameters[10].ToString()),
                (IfcStructuralSurfaceActivityTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcStructuralSurfaceActivityTypeEnum](parameters[11].ToString()));
        }
        #endregion

    }
}