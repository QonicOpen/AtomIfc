
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
    public class IfcFaceBound : IfcTopologicalRepresentationItem, IEquatable<IfcFaceBound>
    {
        private IfcId _boundId;
        public IfcId BoundId 
        {
            get { 
                return _boundId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("BoundId is not allowed to be null"); 
                _boundId = value;
            }
        }
        private bool _orientation;
        public bool Orientation 
        {
            get { 
                return _orientation; 
            }
            set { 
                _orientation = value;
            }
        }

        public IfcFaceBound(IfcId id, IfcId boundId, bool orientation) : base(id)
        {
            BoundId = boundId;
            Orientation = orientation;
        }

        public override ClassId GetClassId() => ClassId.IfcFaceBound;

        #region Equality

        public bool Equals(IfcFaceBound other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && BoundId == other.BoundId
                && Orientation == other.Orientation;
        }

        public override bool Equals(object other) => Equals(other as IfcFaceBound);

        public static bool operator ==(IfcFaceBound one, IfcFaceBound other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFaceBound one, IfcFaceBound other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BoundId},{Orientation})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BoundId!= null && replacementTable.ContainsKey(BoundId))
                BoundId = replacementTable[BoundId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFaceBound (newId,BoundId, Orientation);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFaceBound },
                { "class", nameof(IfcFaceBound) },
                { "parameters" , new JArray
                    {
                        BoundId.ToJValue(),
                        Orientation,
                    }
                }
            };
        }

        public static IfcFaceBound CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFaceBound(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToBool());
        }
        #endregion

    }
}