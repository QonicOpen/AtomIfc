
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
    public class IfcFillAreaStyleHatching : IfcGeometricRepresentationItem, IEquatable<IfcFillAreaStyleHatching>, IIfcFillStyleSelect
    {
        private IfcId _hatchLineAppearanceId;
        public IfcId HatchLineAppearanceId 
        {
            get { 
                return _hatchLineAppearanceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("HatchLineAppearanceId is not allowed to be null"); 
                _hatchLineAppearanceId = value;
            }
        }
        private IfcId _startOfNextHatchLineId;
        public IfcId StartOfNextHatchLineId 
        {
            get { 
                return _startOfNextHatchLineId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("StartOfNextHatchLineId is not allowed to be null"); 
                _startOfNextHatchLineId = value;
            }
        }
        private IfcId _pointOfReferenceHatchLineId;
        public IfcId PointOfReferenceHatchLineId 
        {
            get { 
                return _pointOfReferenceHatchLineId; 
            }
            set { 
                _pointOfReferenceHatchLineId = value;  // optional IfcCartesianPoint
            }
        }
        private IfcId _patternStartId;
        public IfcId PatternStartId 
        {
            get { 
                return _patternStartId; 
            }
            set { 
                _patternStartId = value;  // optional IfcCartesianPoint
            }
        }
        private double _hatchLineAngle;
        public double HatchLineAngle 
        {
            get { 
                return _hatchLineAngle; 
            }
            set { 
                _hatchLineAngle = value;
            }
        }

        public IfcFillAreaStyleHatching(IfcId id, IfcId hatchLineAppearanceId, IfcId startOfNextHatchLineId, IfcId pointOfReferenceHatchLineId, IfcId patternStartId, double hatchLineAngle) : base(id)
        {
            HatchLineAppearanceId = hatchLineAppearanceId;
            StartOfNextHatchLineId = startOfNextHatchLineId;
            PointOfReferenceHatchLineId = pointOfReferenceHatchLineId;
            PatternStartId = patternStartId;
            HatchLineAngle = hatchLineAngle;
        }

        public override ClassId GetClassId() => ClassId.IfcFillAreaStyleHatching;

        #region Equality

        public bool Equals(IfcFillAreaStyleHatching other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && HatchLineAppearanceId == other.HatchLineAppearanceId
                && StartOfNextHatchLineId == other.StartOfNextHatchLineId
                && PointOfReferenceHatchLineId == other.PointOfReferenceHatchLineId
                && PatternStartId == other.PatternStartId
                && HatchLineAngle == other.HatchLineAngle;
        }

        public override bool Equals(object other) => Equals(other as IfcFillAreaStyleHatching);

        public static bool operator ==(IfcFillAreaStyleHatching one, IfcFillAreaStyleHatching other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFillAreaStyleHatching one, IfcFillAreaStyleHatching other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({HatchLineAppearanceId},{StartOfNextHatchLineId},{PointOfReferenceHatchLineId},{PatternStartId},{HatchLineAngle})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(HatchLineAppearanceId!= null && replacementTable.ContainsKey(HatchLineAppearanceId))
                HatchLineAppearanceId = replacementTable[HatchLineAppearanceId];
            if(StartOfNextHatchLineId!= null && replacementTable.ContainsKey(StartOfNextHatchLineId))
                StartOfNextHatchLineId = replacementTable[StartOfNextHatchLineId];
            if(PointOfReferenceHatchLineId!= null && replacementTable.ContainsKey(PointOfReferenceHatchLineId))
                PointOfReferenceHatchLineId = replacementTable[PointOfReferenceHatchLineId];
            if(PatternStartId!= null && replacementTable.ContainsKey(PatternStartId))
                PatternStartId = replacementTable[PatternStartId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFillAreaStyleHatching (newId,HatchLineAppearanceId, StartOfNextHatchLineId, PointOfReferenceHatchLineId, PatternStartId, HatchLineAngle);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFillAreaStyleHatching },
                { "class", nameof(IfcFillAreaStyleHatching) },
                { "parameters" , new JArray
                    {
                        HatchLineAppearanceId.ToJValue(),
                        StartOfNextHatchLineId.ToJValue(),
                        PointOfReferenceHatchLineId.ToJValue(),
                        PatternStartId.ToJValue(),
                        HatchLineAngle,
                    }
                }
            };
        }

        public static IfcFillAreaStyleHatching CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFillAreaStyleHatching(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId(),
                parameters[2].ToOptionalIfcId(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToDouble());
        }
        #endregion

    }
}