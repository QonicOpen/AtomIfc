
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
    public class IfcPerformanceHistory : IfcControl, IEquatable<IfcPerformanceHistory>
    {
        private string _lifeCyclePhase;
        public string LifeCyclePhase 
        {
            get { 
                return _lifeCyclePhase; 
            }
            set { 
                _lifeCyclePhase = value;
            }
        }
        private IfcPerformanceHistoryTypeEnum _predefinedType;
        public IfcPerformanceHistoryTypeEnum PredefinedType 
        {
            get { 
                return _predefinedType; 
            }
            set { 
                _predefinedType = value;  // optional IfcPerformanceHistoryTypeEnum?
            }
        }

        public IfcPerformanceHistory(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, string identification, string lifeCyclePhase, IfcPerformanceHistoryTypeEnum predefinedType) : base(id, globalId, ownerHistoryId, name, description, objectType, identification)
        {
            LifeCyclePhase = lifeCyclePhase;
            PredefinedType = predefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcPerformanceHistory;

        #region Equality

        public bool Equals(IfcPerformanceHistory other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LifeCyclePhase == other.LifeCyclePhase
                && PredefinedType == other.PredefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcPerformanceHistory);

        public static bool operator ==(IfcPerformanceHistory one, IfcPerformanceHistory other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPerformanceHistory one, IfcPerformanceHistory other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}','{Identification}','{LifeCyclePhase}',.{PredefinedType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPerformanceHistory (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, Identification, LifeCyclePhase, PredefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPerformanceHistory },
                { "class", nameof(IfcPerformanceHistory) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        Identification.ToJValue(),
                        LifeCyclePhase.ToJValue(),
                        PredefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcPerformanceHistory CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPerformanceHistory(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToString(),
                (IfcPerformanceHistoryTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcPerformanceHistoryTypeEnum](parameters[7].ToString()));
        }
        #endregion

    }
}