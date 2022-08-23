
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
    public class IfcSlippageConnectionCondition : IfcStructuralConnectionCondition, IEquatable<IfcSlippageConnectionCondition>
    {
        private double? _slippageX;
        public double? SlippageX 
        {
            get { 
                return _slippageX; 
            }
            set { 
                _slippageX = value;  // optional IfcLengthMeasure
            }
        }
        private double? _slippageY;
        public double? SlippageY 
        {
            get { 
                return _slippageY; 
            }
            set { 
                _slippageY = value;  // optional IfcLengthMeasure
            }
        }
        private double? _slippageZ;
        public double? SlippageZ 
        {
            get { 
                return _slippageZ; 
            }
            set { 
                _slippageZ = value;  // optional IfcLengthMeasure
            }
        }

        public IfcSlippageConnectionCondition(IfcId id, string name, double? slippageX, double? slippageY, double? slippageZ) : base(id, name)
        {
            SlippageX = slippageX;
            SlippageY = slippageY;
            SlippageZ = slippageZ;
        }

        public override ClassId GetClassId() => ClassId.IfcSlippageConnectionCondition;

        #region Equality

        public bool Equals(IfcSlippageConnectionCondition other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && SlippageX == other.SlippageX
                && SlippageY == other.SlippageY
                && SlippageZ == other.SlippageZ;
        }

        public override bool Equals(object other) => Equals(other as IfcSlippageConnectionCondition);

        public static bool operator ==(IfcSlippageConnectionCondition one, IfcSlippageConnectionCondition other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSlippageConnectionCondition one, IfcSlippageConnectionCondition other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{SlippageX},{SlippageY},{SlippageZ})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSlippageConnectionCondition (newId,Name, SlippageX, SlippageY, SlippageZ);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSlippageConnectionCondition },
                { "class", nameof(IfcSlippageConnectionCondition) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        SlippageX.ToJValue(),
                        SlippageY.ToJValue(),
                        SlippageZ.ToJValue(),
                    }
                }
            };
        }

        public static IfcSlippageConnectionCondition CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSlippageConnectionCondition(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalDouble(),
                parameters[2].ToOptionalDouble(),
                parameters[3].ToOptionalDouble());
        }
        #endregion

    }
}