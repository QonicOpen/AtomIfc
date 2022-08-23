
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
    public class IfcLagTime : IfcSchedulingTime, IEquatable<IfcLagTime>
    {
        private IfcId _lagValueId;
        public IfcId LagValueId 
        {
            get { 
                return _lagValueId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("LagValueId is not allowed to be null"); 
                _lagValueId = value;
            }
        }
        private IfcTaskDurationEnum _durationType;
        public IfcTaskDurationEnum DurationType 
        {
            get { 
                return _durationType; 
            }
            set { 
                _durationType = value;
            }
        }

        public IfcLagTime(IfcId id, string name, IfcDataOriginEnum dataOrigin, string userDefinedDataOrigin, IfcId lagValueId, IfcTaskDurationEnum durationType) : base(id, name, dataOrigin, userDefinedDataOrigin)
        {
            LagValueId = lagValueId;
            DurationType = durationType;
        }

        public override ClassId GetClassId() => ClassId.IfcLagTime;

        #region Equality

        public bool Equals(IfcLagTime other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LagValueId == other.LagValueId
                && DurationType == other.DurationType;
        }

        public override bool Equals(object other) => Equals(other as IfcLagTime);

        public static bool operator ==(IfcLagTime one, IfcLagTime other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLagTime one, IfcLagTime other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',.{DataOrigin}.,'{UserDefinedDataOrigin}',{LagValueId},.{DurationType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(LagValueId!= null && replacementTable.ContainsKey(LagValueId))
                LagValueId = replacementTable[LagValueId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLagTime (newId,Name, DataOrigin, UserDefinedDataOrigin, LagValueId, DurationType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLagTime },
                { "class", nameof(IfcLagTime) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        DataOrigin.ToJValue(),
                        UserDefinedDataOrigin.ToJValue(),
                        LagValueId.ToJValue(),
                        DurationType.ToJValue(),
                    }
                }
            };
        }

        public static IfcLagTime CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLagTime(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                (IfcDataOriginEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDataOriginEnum](parameters[1].ToString()),
                parameters[2].ToOptionalString(),
                parameters[3].ToIfcId(),
                (IfcTaskDurationEnum)IfcAtom.EnumCreator[(int)EnumId.IfcTaskDurationEnum](parameters[4].ToString()));
        }
        #endregion

    }
}