
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
    public class IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator, IEquatable<IfcCartesianTransformationOperator3D>
    {
        private IfcId _axis3Id;
        public IfcId Axis3Id 
        {
            get { 
                return _axis3Id; 
            }
            set { 
                _axis3Id = value;  // optional IfcDirection
            }
        }

        public IfcCartesianTransformationOperator3D(IfcId id, IfcId axis1Id, IfcId axis2Id, IfcId localOriginId, double? scale, IfcId axis3Id) : base(id, axis1Id, axis2Id, localOriginId, scale)
        {
            Axis3Id = axis3Id;
        }

        public override ClassId GetClassId() => ClassId.IfcCartesianTransformationOperator3D;

        #region Equality

        public bool Equals(IfcCartesianTransformationOperator3D other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Axis3Id == other.Axis3Id;
        }

        public override bool Equals(object other) => Equals(other as IfcCartesianTransformationOperator3D);

        public static bool operator ==(IfcCartesianTransformationOperator3D one, IfcCartesianTransformationOperator3D other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCartesianTransformationOperator3D one, IfcCartesianTransformationOperator3D other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Axis1Id},{Axis2Id},{LocalOriginId},{Scale},{Axis3Id})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(Axis3Id!= null && replacementTable.ContainsKey(Axis3Id))
                Axis3Id = replacementTable[Axis3Id];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCartesianTransformationOperator3D (newId,Axis1Id, Axis2Id, LocalOriginId, Scale, Axis3Id);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCartesianTransformationOperator3D },
                { "class", nameof(IfcCartesianTransformationOperator3D) },
                { "parameters" , new JArray
                    {
                        Axis1Id.ToJValue(),
                        Axis2Id.ToJValue(),
                        LocalOriginId.ToJValue(),
                        Scale.ToJValue(),
                        Axis3Id.ToJValue(),
                    }
                }
            };
        }

        public static IfcCartesianTransformationOperator3D CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCartesianTransformationOperator3D(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToIfcId(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToOptionalIfcId());
        }
        #endregion

    }
}