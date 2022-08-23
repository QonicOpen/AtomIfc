
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
    public class IfcConnectionVolumeGeometry : IfcConnectionGeometry, IEquatable<IfcConnectionVolumeGeometry>
    {
        private IfcId _volumeOnRelatingElementId;
        public IfcId VolumeOnRelatingElementId 
        {
            get { 
                return _volumeOnRelatingElementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("VolumeOnRelatingElementId is not allowed to be null"); 
                _volumeOnRelatingElementId = value;
            }
        }
        private IfcId _volumeOnRelatedElementId;
        public IfcId VolumeOnRelatedElementId 
        {
            get { 
                return _volumeOnRelatedElementId; 
            }
            set { 
                _volumeOnRelatedElementId = value;  // optional IfcSolidOrShell
            }
        }

        public IfcConnectionVolumeGeometry(IfcId id, IfcId volumeOnRelatingElementId, IfcId volumeOnRelatedElementId) : base(id)
        {
            VolumeOnRelatingElementId = volumeOnRelatingElementId;
            VolumeOnRelatedElementId = volumeOnRelatedElementId;
        }

        public override ClassId GetClassId() => ClassId.IfcConnectionVolumeGeometry;

        #region Equality

        public bool Equals(IfcConnectionVolumeGeometry other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && VolumeOnRelatingElementId == other.VolumeOnRelatingElementId
                && VolumeOnRelatedElementId == other.VolumeOnRelatedElementId;
        }

        public override bool Equals(object other) => Equals(other as IfcConnectionVolumeGeometry);

        public static bool operator ==(IfcConnectionVolumeGeometry one, IfcConnectionVolumeGeometry other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConnectionVolumeGeometry one, IfcConnectionVolumeGeometry other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({VolumeOnRelatingElementId},{VolumeOnRelatedElementId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(VolumeOnRelatingElementId!= null && replacementTable.ContainsKey(VolumeOnRelatingElementId))
                VolumeOnRelatingElementId = replacementTable[VolumeOnRelatingElementId];
            if(VolumeOnRelatedElementId!= null && replacementTable.ContainsKey(VolumeOnRelatedElementId))
                VolumeOnRelatedElementId = replacementTable[VolumeOnRelatedElementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcConnectionVolumeGeometry (newId,VolumeOnRelatingElementId, VolumeOnRelatedElementId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcConnectionVolumeGeometry },
                { "class", nameof(IfcConnectionVolumeGeometry) },
                { "parameters" , new JArray
                    {
                        VolumeOnRelatingElementId.ToJValue(),
                        VolumeOnRelatedElementId.ToJValue(),
                    }
                }
            };
        }

        public static IfcConnectionVolumeGeometry CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcConnectionVolumeGeometry(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcId());
        }
        #endregion

    }
}