
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
    public class IfcRectangularTrimmedSurface : IfcBoundedSurface, IEquatable<IfcRectangularTrimmedSurface>
    {
        private IfcId _basisSurfaceId;
        public IfcId BasisSurfaceId 
        {
            get { 
                return _basisSurfaceId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("BasisSurfaceId is not allowed to be null"); 
                _basisSurfaceId = value;
            }
        }
        private double _u1;
        public double U1 
        {
            get { 
                return _u1; 
            }
            set { 
                _u1 = value;
            }
        }
        private double _v1;
        public double V1 
        {
            get { 
                return _v1; 
            }
            set { 
                _v1 = value;
            }
        }
        private double _u2;
        public double U2 
        {
            get { 
                return _u2; 
            }
            set { 
                _u2 = value;
            }
        }
        private double _v2;
        public double V2 
        {
            get { 
                return _v2; 
            }
            set { 
                _v2 = value;
            }
        }
        private bool _usense;
        public bool Usense 
        {
            get { 
                return _usense; 
            }
            set { 
                _usense = value;
            }
        }
        private bool _vsense;
        public bool Vsense 
        {
            get { 
                return _vsense; 
            }
            set { 
                _vsense = value;
            }
        }

        public IfcRectangularTrimmedSurface(IfcId id, IfcId basisSurfaceId, double u1, double v1, double u2, double v2, bool usense, bool vsense) : base(id)
        {
            BasisSurfaceId = basisSurfaceId;
            U1 = u1;
            V1 = v1;
            U2 = u2;
            V2 = v2;
            Usense = usense;
            Vsense = vsense;
        }

        public override ClassId GetClassId() => ClassId.IfcRectangularTrimmedSurface;

        #region Equality

        public bool Equals(IfcRectangularTrimmedSurface other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && BasisSurfaceId == other.BasisSurfaceId
                && U1 == other.U1
                && V1 == other.V1
                && U2 == other.U2
                && V2 == other.V2
                && Usense == other.Usense
                && Vsense == other.Vsense;
        }

        public override bool Equals(object other) => Equals(other as IfcRectangularTrimmedSurface);

        public static bool operator ==(IfcRectangularTrimmedSurface one, IfcRectangularTrimmedSurface other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRectangularTrimmedSurface one, IfcRectangularTrimmedSurface other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BasisSurfaceId},{U1},{V1},{U2},{V2},{Usense},{Vsense})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BasisSurfaceId!= null && replacementTable.ContainsKey(BasisSurfaceId))
                BasisSurfaceId = replacementTable[BasisSurfaceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRectangularTrimmedSurface (newId,BasisSurfaceId, U1, V1, U2, V2, Usense, Vsense);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRectangularTrimmedSurface },
                { "class", nameof(IfcRectangularTrimmedSurface) },
                { "parameters" , new JArray
                    {
                        BasisSurfaceId.ToJValue(),
                        U1,
                        V1,
                        U2,
                        V2,
                        Usense,
                        Vsense,
                    }
                }
            };
        }

        public static IfcRectangularTrimmedSurface CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRectangularTrimmedSurface(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToDouble(),
                parameters[3].ToDouble(),
                parameters[4].ToDouble(),
                parameters[5].ToBool(),
                parameters[6].ToBool());
        }
        #endregion

    }
}