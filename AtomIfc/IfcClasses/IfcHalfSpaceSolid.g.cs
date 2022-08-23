
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
    public class IfcHalfSpaceSolid : IfcGeometricRepresentationItem, IEquatable<IfcHalfSpaceSolid>, IIfcBooleanOperand
    {
        private IfcId _baseSurfaceId;
        public IfcId BaseSurfaceId 
        {
            get { 
                return _baseSurfaceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("BaseSurfaceId is not allowed to be null"); 
                _baseSurfaceId = value;
            }
        }
        private bool _agreementFlag;
        public bool AgreementFlag 
        {
            get { 
                return _agreementFlag; 
            }
            set { 
                _agreementFlag = value;
            }
        }

        public IfcHalfSpaceSolid(IfcId id, IfcId baseSurfaceId, bool agreementFlag) : base(id)
        {
            BaseSurfaceId = baseSurfaceId;
            AgreementFlag = agreementFlag;
        }

        public override ClassId GetClassId() => ClassId.IfcHalfSpaceSolid;

        #region Equality

        public bool Equals(IfcHalfSpaceSolid other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && BaseSurfaceId == other.BaseSurfaceId
                && AgreementFlag == other.AgreementFlag;
        }

        public override bool Equals(object other) => Equals(other as IfcHalfSpaceSolid);

        public static bool operator ==(IfcHalfSpaceSolid one, IfcHalfSpaceSolid other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcHalfSpaceSolid one, IfcHalfSpaceSolid other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BaseSurfaceId},{AgreementFlag})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BaseSurfaceId!= null && replacementTable.ContainsKey(BaseSurfaceId))
                BaseSurfaceId = replacementTable[BaseSurfaceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcHalfSpaceSolid (newId,BaseSurfaceId, AgreementFlag);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcHalfSpaceSolid },
                { "class", nameof(IfcHalfSpaceSolid) },
                { "parameters" , new JArray
                    {
                        BaseSurfaceId.ToJValue(),
                        AgreementFlag,
                    }
                }
            };
        }

        public static IfcHalfSpaceSolid CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcHalfSpaceSolid(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToBool());
        }
        #endregion

    }
}