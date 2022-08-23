
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
    public class IfcStructuralAnalysisModel : IfcSystem, IEquatable<IfcStructuralAnalysisModel>
    {
        private IfcAnalysisModelTypeEnum _predefinedType;
        public IfcAnalysisModelTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;
            }
        }
        private IfcId _orientationOf2DPlaneId;
        public IfcId OrientationOf2DPlaneId 
        {
            get { 
                return _orientationOf2DPlaneId; 
            }
            set { 
                _orientationOf2DPlaneId = value;  // optional IfcAxis2Placement3D
            }
        }
        private List<IfcId> _loadedByIds;
        public List<IfcId> LoadedByIds 
        {
            get { 
                return _loadedByIds; 
            }
            set { 
                _loadedByIds = value;  // optional List<IfcStructuralLoadGroup>
            }
        }
        private List<IfcId> _resultIds;
        public List<IfcId> ResultIds 
        {
            get { 
                return _resultIds; 
            }
            set { 
                _resultIds = value;  // optional List<IfcStructuralResultGroup>
            }
        }
        private IfcId _sharedPlacementId;
        public IfcId SharedPlacementId 
        {
            get { 
                return _sharedPlacementId; 
            }
            set { 
                _sharedPlacementId = value;  // optional IfcObjectPlacement
            }
        }

        public IfcStructuralAnalysisModel(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcAnalysisModelTypeEnum predefinedType, IfcId orientationOf2DPlaneId, List<IfcId> loadedByIds, List<IfcId> resultIds, IfcId sharedPlacementId) : base(id, globalId, ownerHistoryId, name, description, objectType)
        {
            PredefinedType = predefinedType;
            OrientationOf2DPlaneId = orientationOf2DPlaneId;
            LoadedByIds = loadedByIds;
            ResultIds = resultIds;
            SharedPlacementId = sharedPlacementId;
        }

        public override ClassId GetClassId() => ClassId.IfcStructuralAnalysisModel;

        #region Equality

        public bool Equals(IfcStructuralAnalysisModel other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(LoadedByIds, other.LoadedByIds))
                return false;
            if(!Utils.CompareList(ResultIds, other.ResultIds))
                return false;
            return base.Equals(other)
                && PredefinedType == other.PredefinedType
                && OrientationOf2DPlaneId == other.OrientationOf2DPlaneId
                && SharedPlacementId == other.SharedPlacementId;
        }

        public override bool Equals(object other) => Equals(other as IfcStructuralAnalysisModel);

        public static bool operator ==(IfcStructuralAnalysisModel one, IfcStructuralAnalysisModel other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcStructuralAnalysisModel one, IfcStructuralAnalysisModel other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',.{PredefinedType}.,{OrientationOf2DPlaneId},{Utils.ConvertListToString(LoadedByIds)},{Utils.ConvertListToString(ResultIds)},{SharedPlacementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(OrientationOf2DPlaneId!= null && replacementTable.ContainsKey(OrientationOf2DPlaneId))
                OrientationOf2DPlaneId = replacementTable[OrientationOf2DPlaneId];
            if(LoadedByIds!= null)
                LoadedByIds = LoadedByIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(ResultIds!= null)
                ResultIds = ResultIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(SharedPlacementId!= null && replacementTable.ContainsKey(SharedPlacementId))
                SharedPlacementId = replacementTable[SharedPlacementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcStructuralAnalysisModel (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, PredefinedType, OrientationOf2DPlaneId, LoadedByIds, ResultIds, SharedPlacementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcStructuralAnalysisModel },
                { "class", nameof(IfcStructuralAnalysisModel) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        PredefinedType.ToJValue(),
                        OrientationOf2DPlaneId.ToJValue(),
                        LoadedByIds.ToJArray(),
                        ResultIds.ToJArray(),
                        SharedPlacementId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcStructuralAnalysisModel CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcStructuralAnalysisModel(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                (IfcAnalysisModelTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcAnalysisModelTypeEnum](parameters[5].ToString()),
                parameters[6].ToOptionalIfcId(),
                parameters[7].ToOptionalIfcIdList(),
                parameters[8].ToOptionalIfcIdList(),
                parameters[9].ToOptionalIfcId());
        }
        #endregion

    }
}