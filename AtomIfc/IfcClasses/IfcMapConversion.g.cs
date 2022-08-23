
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
    public class IfcMapConversion : IfcCoordinateOperation, IEquatable<IfcMapConversion>
    {
        private double _eastings;
        public double Eastings 
        {
            get { 
                return _eastings; 
            }
            set { 
                _eastings = value;
            }
        }
        private double _northings;
        public double Northings 
        {
            get { 
                return _northings; 
            }
            set { 
                _northings = value;
            }
        }
        private double _orthogonalHeight;
        public double OrthogonalHeight 
        {
            get { 
                return _orthogonalHeight; 
            }
            set { 
                _orthogonalHeight = value;
            }
        }
        private double? _xAxisAbscissa;
        public double? XAxisAbscissa 
        {
            get { 
                return _xAxisAbscissa; 
            }
            set { 
                _xAxisAbscissa = value;  // optional IfcReal
            }
        }
        private double? _xAxisOrdinate;
        public double? XAxisOrdinate 
        {
            get { 
                return _xAxisOrdinate; 
            }
            set { 
                _xAxisOrdinate = value;  // optional IfcReal
            }
        }
        private double? _scale;
        public double? Scale 
        {
            get { 
                return _scale; 
            }
            set { 
                _scale = value;  // optional IfcReal
            }
        }

        public IfcMapConversion(IfcId id, IfcId sourceCRSId, IfcId targetCRSId, double eastings, double northings, double orthogonalHeight, double? xAxisAbscissa, double? xAxisOrdinate, double? scale) : base(id, sourceCRSId, targetCRSId)
        {
            Eastings = eastings;
            Northings = northings;
            OrthogonalHeight = orthogonalHeight;
            XAxisAbscissa = xAxisAbscissa;
            XAxisOrdinate = xAxisOrdinate;
            Scale = scale;
        }

        public override ClassId GetClassId() => ClassId.IfcMapConversion;

        #region Equality

        public bool Equals(IfcMapConversion other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Eastings == other.Eastings
                && Northings == other.Northings
                && OrthogonalHeight == other.OrthogonalHeight
                && XAxisAbscissa == other.XAxisAbscissa
                && XAxisOrdinate == other.XAxisOrdinate
                && Scale == other.Scale;
        }

        public override bool Equals(object other) => Equals(other as IfcMapConversion);

        public static bool operator ==(IfcMapConversion one, IfcMapConversion other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcMapConversion one, IfcMapConversion other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SourceCRSId},{TargetCRSId},{Eastings},{Northings},{OrthogonalHeight},{XAxisAbscissa},{XAxisOrdinate},{Scale})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcMapConversion (newId,SourceCRSId, TargetCRSId, Eastings, Northings, OrthogonalHeight, XAxisAbscissa, XAxisOrdinate, Scale);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcMapConversion },
                { "class", nameof(IfcMapConversion) },
                { "parameters" , new JArray
                    {
                        SourceCRSId.ToJValue(),
                        TargetCRSId.ToJValue(),
                        Eastings,
                        Northings,
                        OrthogonalHeight,
                        XAxisAbscissa.ToJValue(),
                        XAxisOrdinate.ToJValue(),
                        Scale.ToJValue(),
                    }
                }
            };
        }

        public static IfcMapConversion CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcMapConversion(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId(),
                parameters[2].ToDouble(),
                parameters[3].ToDouble(),
                parameters[4].ToDouble(),
                parameters[5].ToOptionalDouble(),
                parameters[6].ToOptionalDouble(),
                parameters[7].ToOptionalDouble());
        }
        #endregion

    }
}