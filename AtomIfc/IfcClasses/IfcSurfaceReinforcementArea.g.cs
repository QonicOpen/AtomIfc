
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
    public class IfcSurfaceReinforcementArea : IfcStructuralLoadOrResult, IEquatable<IfcSurfaceReinforcementArea>
    {
        private List<double> _surfaceReinforcement1;
        public List<double> SurfaceReinforcement1 
        {
            get { 
                return _surfaceReinforcement1; 
            }
            set { 
                _surfaceReinforcement1 = value;  // optional List<IfcLengthMeasure>
            }
        }
        private List<double> _surfaceReinforcement2;
        public List<double> SurfaceReinforcement2 
        {
            get { 
                return _surfaceReinforcement2; 
            }
            set { 
                _surfaceReinforcement2 = value;  // optional List<IfcLengthMeasure>
            }
        }
        private double? _shearReinforcement;
        public double? ShearReinforcement 
        {
            get { 
                return _shearReinforcement; 
            }
            set { 
                _shearReinforcement = value;  // optional IfcRatioMeasure
            }
        }

        public IfcSurfaceReinforcementArea(IfcId id, string name, List<double> surfaceReinforcement1, List<double> surfaceReinforcement2, double? shearReinforcement) : base(id, name)
        {
            SurfaceReinforcement1 = surfaceReinforcement1;
            SurfaceReinforcement2 = surfaceReinforcement2;
            ShearReinforcement = shearReinforcement;
        }

        public override ClassId GetClassId() => ClassId.IfcSurfaceReinforcementArea;

        #region Equality

        public bool Equals(IfcSurfaceReinforcementArea other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(SurfaceReinforcement1, other.SurfaceReinforcement1))
                return false;
            if(!Utils.CompareList(SurfaceReinforcement2, other.SurfaceReinforcement2))
                return false;
            return base.Equals(other)
                && ShearReinforcement == other.ShearReinforcement;
        }

        public override bool Equals(object other) => Equals(other as IfcSurfaceReinforcementArea);

        public static bool operator ==(IfcSurfaceReinforcementArea one, IfcSurfaceReinforcementArea other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSurfaceReinforcementArea one, IfcSurfaceReinforcementArea other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{Utils.ConvertListToString(SurfaceReinforcement1)},{Utils.ConvertListToString(SurfaceReinforcement2)},{ShearReinforcement})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSurfaceReinforcementArea (newId,Name, SurfaceReinforcement1, SurfaceReinforcement2, ShearReinforcement);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSurfaceReinforcementArea },
                { "class", nameof(IfcSurfaceReinforcementArea) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        SurfaceReinforcement1.ToJArray(),
                        SurfaceReinforcement2.ToJArray(),
                        ShearReinforcement.ToJValue(),
                    }
                }
            };
        }

        public static IfcSurfaceReinforcementArea CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSurfaceReinforcementArea(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalDoubleList(),
                parameters[2].ToOptionalDoubleList(),
                parameters[3].ToOptionalDouble());
        }
        #endregion

    }
}