
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
    public class IfcDerivedUnit : IfcBase, IEquatable<IfcDerivedUnit>, IIfcUnit
    {
        private List<IfcId> _elementIds;
        public List<IfcId> ElementIds 
        {
            get { 
                return _elementIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ElementIds is not allowed to be null"); 
                _elementIds = value;
            }
        }
        private IfcDerivedUnitEnum _unitType;
        public IfcDerivedUnitEnum UnitType 
        {
            get { 
                return _unitType; 
            }
            set { 
                _unitType = value;
            }
        }
        private string _userDefinedType;
        public string UserDefinedType 
        {
            get { 
                return _userDefinedType; 
            }
            set { 
                _userDefinedType = value;  // optional IfcLabel
            }
        }

        public IfcDerivedUnit(IfcId id, List<IfcId> elementIds, IfcDerivedUnitEnum unitType, string userDefinedType) : base(id)
        {
            ElementIds = elementIds;
            UnitType = unitType;
            UserDefinedType = userDefinedType;
        }

        public override ClassId GetClassId() => ClassId.IfcDerivedUnit;

        #region Equality

        public bool Equals(IfcDerivedUnit other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ElementIds, other.ElementIds))
                return false;
            return base.Equals(other)
                && UnitType == other.UnitType
                && UserDefinedType == other.UserDefinedType;
        }

        public override bool Equals(object other) => Equals(other as IfcDerivedUnit);

        public static bool operator ==(IfcDerivedUnit one, IfcDerivedUnit other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDerivedUnit one, IfcDerivedUnit other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(ElementIds)},.{UnitType}.,'{UserDefinedType}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ElementIds!= null)
                ElementIds = ElementIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDerivedUnit (newId,ElementIds, UnitType, UserDefinedType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDerivedUnit },
                { "class", nameof(IfcDerivedUnit) },
                { "parameters" , new JArray
                    {
                        ElementIds.ToJArray(),
                        UnitType.ToJValue(),
                        UserDefinedType.ToJValue(),
                    }
                }
            };
        }

        public static IfcDerivedUnit CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDerivedUnit(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList(),
                (IfcDerivedUnitEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDerivedUnitEnum](parameters[1].ToString()),
                parameters[2].ToOptionalString());
        }
        #endregion

    }
}