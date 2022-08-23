
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
    public class IfcFailureConnectionCondition : IfcStructuralConnectionCondition, IEquatable<IfcFailureConnectionCondition>
    {
        private double? _tensionFailureX;
        public double? TensionFailureX 
        {
            get { 
                return _tensionFailureX; 
            }
            set { 
                _tensionFailureX = value;  // optional IfcForceMeasure
            }
        }
        private double? _tensionFailureY;
        public double? TensionFailureY 
        {
            get { 
                return _tensionFailureY; 
            }
            set { 
                _tensionFailureY = value;  // optional IfcForceMeasure
            }
        }
        private double? _tensionFailureZ;
        public double? TensionFailureZ 
        {
            get { 
                return _tensionFailureZ; 
            }
            set { 
                _tensionFailureZ = value;  // optional IfcForceMeasure
            }
        }
        private double? _compressionFailureX;
        public double? CompressionFailureX 
        {
            get { 
                return _compressionFailureX; 
            }
            set { 
                _compressionFailureX = value;  // optional IfcForceMeasure
            }
        }
        private double? _compressionFailureY;
        public double? CompressionFailureY 
        {
            get { 
                return _compressionFailureY; 
            }
            set { 
                _compressionFailureY = value;  // optional IfcForceMeasure
            }
        }
        private double? _compressionFailureZ;
        public double? CompressionFailureZ 
        {
            get { 
                return _compressionFailureZ; 
            }
            set { 
                _compressionFailureZ = value;  // optional IfcForceMeasure
            }
        }

        public IfcFailureConnectionCondition(IfcId id, string name, double? tensionFailureX, double? tensionFailureY, double? tensionFailureZ, double? compressionFailureX, double? compressionFailureY, double? compressionFailureZ) : base(id, name)
        {
            TensionFailureX = tensionFailureX;
            TensionFailureY = tensionFailureY;
            TensionFailureZ = tensionFailureZ;
            CompressionFailureX = compressionFailureX;
            CompressionFailureY = compressionFailureY;
            CompressionFailureZ = compressionFailureZ;
        }

        public override ClassId GetClassId() => ClassId.IfcFailureConnectionCondition;

        #region Equality

        public bool Equals(IfcFailureConnectionCondition other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TensionFailureX == other.TensionFailureX
                && TensionFailureY == other.TensionFailureY
                && TensionFailureZ == other.TensionFailureZ
                && CompressionFailureX == other.CompressionFailureX
                && CompressionFailureY == other.CompressionFailureY
                && CompressionFailureZ == other.CompressionFailureZ;
        }

        public override bool Equals(object other) => Equals(other as IfcFailureConnectionCondition);

        public static bool operator ==(IfcFailureConnectionCondition one, IfcFailureConnectionCondition other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFailureConnectionCondition one, IfcFailureConnectionCondition other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{TensionFailureX},{TensionFailureY},{TensionFailureZ},{CompressionFailureX},{CompressionFailureY},{CompressionFailureZ})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFailureConnectionCondition (newId,Name, TensionFailureX, TensionFailureY, TensionFailureZ, CompressionFailureX, CompressionFailureY, CompressionFailureZ);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFailureConnectionCondition },
                { "class", nameof(IfcFailureConnectionCondition) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        TensionFailureX.ToJValue(),
                        TensionFailureY.ToJValue(),
                        TensionFailureZ.ToJValue(),
                        CompressionFailureX.ToJValue(),
                        CompressionFailureY.ToJValue(),
                        CompressionFailureZ.ToJValue(),
                    }
                }
            };
        }

        public static IfcFailureConnectionCondition CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFailureConnectionCondition(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalDouble(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalDouble(),
                parameters[5].ToOptionalDouble(),
                parameters[6].ToOptionalDouble());
        }
        #endregion

    }
}