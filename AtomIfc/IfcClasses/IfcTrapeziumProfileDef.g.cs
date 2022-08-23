
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
    public class IfcTrapeziumProfileDef : IfcParameterizedProfileDef, IEquatable<IfcTrapeziumProfileDef>
    {
        private double _bottomXDim;
        public double BottomXDim 
        {
            get { 
                return _bottomXDim; 
            }
            set { 
                _bottomXDim = value;
            }
        }
        private double _topXDim;
        public double TopXDim 
        {
            get { 
                return _topXDim; 
            }
            set { 
                _topXDim = value;
            }
        }
        private double _yDim;
        public double YDim 
        {
            get { 
                return _yDim; 
            }
            set { 
                _yDim = value;
            }
        }
        private double _topXOffset;
        public double TopXOffset 
        {
            get { 
                return _topXOffset; 
            }
            set { 
                _topXOffset = value;
            }
        }

        public IfcTrapeziumProfileDef(IfcId id, IfcProfileTypeEnum profileType, string profileName, IfcId positionId, double bottomXDim, double topXDim, double yDim, double topXOffset) : base(id, profileType, profileName, positionId)
        {
            BottomXDim = bottomXDim;
            TopXDim = topXDim;
            YDim = yDim;
            TopXOffset = topXOffset;
        }

        public override ClassId GetClassId() => ClassId.IfcTrapeziumProfileDef;

        #region Equality

        public bool Equals(IfcTrapeziumProfileDef other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && BottomXDim == other.BottomXDim
                && TopXDim == other.TopXDim
                && YDim == other.YDim
                && TopXOffset == other.TopXOffset;
        }

        public override bool Equals(object other) => Equals(other as IfcTrapeziumProfileDef);

        public static bool operator ==(IfcTrapeziumProfileDef one, IfcTrapeziumProfileDef other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTrapeziumProfileDef one, IfcTrapeziumProfileDef other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{ProfileType}.,'{ProfileName}',{PositionId},{BottomXDim},{TopXDim},{YDim},{TopXOffset})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTrapeziumProfileDef (newId,ProfileType, ProfileName, PositionId, BottomXDim, TopXDim, YDim, TopXOffset);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTrapeziumProfileDef },
                { "class", nameof(IfcTrapeziumProfileDef) },
                { "parameters" , new JArray
                    {
                        ProfileType.ToJValue(),
                        ProfileName.ToJValue(),
                        PositionId.ToJValue(),
                        BottomXDim,
                        TopXDim,
                        YDim,
                        TopXOffset,
                    }
                }
            };
        }

        public static new IfcTrapeziumProfileDef CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTrapeziumProfileDef(
                jObject["id"].ToIfcId(),
                (IfcProfileTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcProfileTypeEnum](parameters[0].ToString()),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToDouble(),
                parameters[4].ToDouble(),
                parameters[5].ToDouble(),
                parameters[6].ToDouble());
        }
        #endregion

    }
}