
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
    public class IfcColourRgb : IfcColourSpecification, IEquatable<IfcColourRgb>, IIfcColourOrFactor
    {
        private double _red;
        public double Red 
        {
            get { 
                return _red; 
            }
            set { 
                _red = value;
            }
        }
        private double _green;
        public double Green 
        {
            get { 
                return _green; 
            }
            set { 
                _green = value;
            }
        }
        private double _blue;
        public double Blue 
        {
            get { 
                return _blue; 
            }
            set { 
                _blue = value;
            }
        }

        public IfcColourRgb(IfcId id, string name, double red, double green, double blue) : base(id, name)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override ClassId GetClassId() => ClassId.IfcColourRgb;

        #region Equality

        public bool Equals(IfcColourRgb other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Red == other.Red
                && Green == other.Green
                && Blue == other.Blue;
        }

        public override bool Equals(object other) => Equals(other as IfcColourRgb);

        public static bool operator ==(IfcColourRgb one, IfcColourRgb other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcColourRgb one, IfcColourRgb other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{Red},{Green},{Blue})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcColourRgb (newId,Name, Red, Green, Blue);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcColourRgb },
                { "class", nameof(IfcColourRgb) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Red,
                        Green,
                        Blue,
                    }
                }
            };
        }

        public static IfcColourRgb CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcColourRgb(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToDouble(),
                parameters[2].ToDouble(),
                parameters[3].ToDouble());
        }
        #endregion

    }
}