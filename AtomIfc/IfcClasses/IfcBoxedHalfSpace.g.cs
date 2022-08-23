
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
    public class IfcBoxedHalfSpace : IfcHalfSpaceSolid, IEquatable<IfcBoxedHalfSpace>
    {
        private IfcId _enclosureId;
        public IfcId EnclosureId 
        {
            get { 
                return _enclosureId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("EnclosureId is not allowed to be null"); 
                _enclosureId = value;
            }
        }

        public IfcBoxedHalfSpace(IfcId id, IfcId baseSurfaceId, bool agreementFlag, IfcId enclosureId) : base(id, baseSurfaceId, agreementFlag)
        {
            EnclosureId = enclosureId;
        }

        public override ClassId GetClassId() => ClassId.IfcBoxedHalfSpace;

        #region Equality

        public bool Equals(IfcBoxedHalfSpace other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && EnclosureId == other.EnclosureId;
        }

        public override bool Equals(object other) => Equals(other as IfcBoxedHalfSpace);

        public static bool operator ==(IfcBoxedHalfSpace one, IfcBoxedHalfSpace other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBoxedHalfSpace one, IfcBoxedHalfSpace other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BaseSurfaceId},{AgreementFlag},{EnclosureId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(EnclosureId!= null && replacementTable.ContainsKey(EnclosureId))
                EnclosureId = replacementTable[EnclosureId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBoxedHalfSpace (newId,BaseSurfaceId, AgreementFlag, EnclosureId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBoxedHalfSpace },
                { "class", nameof(IfcBoxedHalfSpace) },
                { "parameters" , new JArray
                    {
                        BaseSurfaceId.ToJValue(),
                        AgreementFlag,
                        EnclosureId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcBoxedHalfSpace CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBoxedHalfSpace(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToBool(),
                parameters[2].ToIfcId());
        }
        #endregion

    }
}