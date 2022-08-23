
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
    public class IfcDerivedUnitElement : IfcBase, IEquatable<IfcDerivedUnitElement>
    {
        private IfcId _unitId;
        public IfcId UnitId 
        {
            get { 
                return _unitId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("UnitId is not allowed to be null"); 
                _unitId = value;
            }
        }
        private int _exponent;
        public int Exponent 
        {
            get { 
                return _exponent; 
            }
            set { 
                _exponent = value;
            }
        }

        public IfcDerivedUnitElement(IfcId id, IfcId unitId, int exponent) : base(id)
        {
            UnitId = unitId;
            Exponent = exponent;
        }

        public override ClassId GetClassId() => ClassId.IfcDerivedUnitElement;

        #region Equality

        public bool Equals(IfcDerivedUnitElement other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && UnitId == other.UnitId
                && Exponent == other.Exponent;
        }

        public override bool Equals(object other) => Equals(other as IfcDerivedUnitElement);

        public static bool operator ==(IfcDerivedUnitElement one, IfcDerivedUnitElement other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDerivedUnitElement one, IfcDerivedUnitElement other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({UnitId},{Exponent})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(UnitId!= null && replacementTable.ContainsKey(UnitId))
                UnitId = replacementTable[UnitId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDerivedUnitElement (newId,UnitId, Exponent);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDerivedUnitElement },
                { "class", nameof(IfcDerivedUnitElement) },
                { "parameters" , new JArray
                    {
                        UnitId.ToJValue(),
                        Exponent,
                    }
                }
            };
        }

        public static IfcDerivedUnitElement CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDerivedUnitElement(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToInt());
        }
        #endregion

    }
}