
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
    public class IfcTextureCoordinateGenerator : IfcTextureCoordinate, IEquatable<IfcTextureCoordinateGenerator>
    {
        private string _mode;
        public string Mode 
        {
            get { 
                return _mode; 
            }
            set { 
                _mode = value;
            }
        }
        private List<double> _parameter;
        public List<double> Parameter 
        {
            get { 
                return _parameter; 
            }
            set { 
                _parameter = value;  // optional List<IfcReal>
            }
        }

        public IfcTextureCoordinateGenerator(IfcId id, List<IfcId> mapIds, string mode, List<double> parameter) : base(id, mapIds)
        {
            Mode = mode;
            Parameter = parameter;
        }

        public override ClassId GetClassId() => ClassId.IfcTextureCoordinateGenerator;

        #region Equality

        public bool Equals(IfcTextureCoordinateGenerator other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(Parameter, other.Parameter))
                return false;
            return base.Equals(other)
                && Mode == other.Mode;
        }

        public override bool Equals(object other) => Equals(other as IfcTextureCoordinateGenerator);

        public static bool operator ==(IfcTextureCoordinateGenerator one, IfcTextureCoordinateGenerator other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTextureCoordinateGenerator one, IfcTextureCoordinateGenerator other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(MapIds)},'{Mode}',{Utils.ConvertListToString(Parameter)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTextureCoordinateGenerator (newId,MapIds, Mode, Parameter);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTextureCoordinateGenerator },
                { "class", nameof(IfcTextureCoordinateGenerator) },
                { "parameters" , new JArray
                    {
                        MapIds.ToJArray(),
                        Mode.ToJValue(),
                        Parameter.ToJArray(),
                    }
                }
            };
        }

        public static IfcTextureCoordinateGenerator CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTextureCoordinateGenerator(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                parameters[1].ToString(),
                parameters[2].ToOptionalDoubleList());
        }
        #endregion

    }
}