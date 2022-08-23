
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
    public class IfcSectionedSpine : IfcGeometricRepresentationItem, IEquatable<IfcSectionedSpine>
    {
        private IfcId _spineCurveId;
        public IfcId SpineCurveId 
        {
            get { 
                return _spineCurveId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SpineCurveId is not allowed to be null"); 
                _spineCurveId = value;
            }
        }
        private List<IfcId> _crossSectionIds;
        public List<IfcId> CrossSectionIds 
        {
            get { 
                return _crossSectionIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("CrossSectionIds is not allowed to be null"); 
                _crossSectionIds = value;
            }
        }
        private List<IfcId> _crossSectionPositionIds;
        public List<IfcId> CrossSectionPositionIds 
        {
            get { 
                return _crossSectionPositionIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("CrossSectionPositionIds is not allowed to be null"); 
                _crossSectionPositionIds = value;
            }
        }

        public IfcSectionedSpine(IfcId id, IfcId spineCurveId, List<IfcId> crossSectionIds, List<IfcId> crossSectionPositionIds) : base(id)
        {
            SpineCurveId = spineCurveId;
            CrossSectionIds = crossSectionIds;
            CrossSectionPositionIds = crossSectionPositionIds;
        }

        public override ClassId GetClassId() => ClassId.IfcSectionedSpine;

        #region Equality

        public bool Equals(IfcSectionedSpine other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(CrossSectionIds, other.CrossSectionIds))
                return false;
            if(!Utils.CompareList(CrossSectionPositionIds, other.CrossSectionPositionIds))
                return false;
            return base.Equals(other)
                && SpineCurveId == other.SpineCurveId;
        }

        public override bool Equals(object other) => Equals(other as IfcSectionedSpine);

        public static bool operator ==(IfcSectionedSpine one, IfcSectionedSpine other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSectionedSpine one, IfcSectionedSpine other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({SpineCurveId},{Utils.ConvertListToString(CrossSectionIds)},{Utils.ConvertListToString(CrossSectionPositionIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(SpineCurveId!= null && replacementTable.ContainsKey(SpineCurveId))
                SpineCurveId = replacementTable[SpineCurveId];
            if(CrossSectionIds!= null)
                CrossSectionIds = CrossSectionIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(CrossSectionPositionIds!= null)
                CrossSectionPositionIds = CrossSectionPositionIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSectionedSpine (newId,SpineCurveId, CrossSectionIds, CrossSectionPositionIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSectionedSpine },
                { "class", nameof(IfcSectionedSpine) },
                { "parameters" , new JArray
                    {
                        SpineCurveId.ToJValue(),
                        CrossSectionIds.ToJArray(),
                        CrossSectionPositionIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcSectionedSpine CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSectionedSpine(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcIdList(),
                parameters[2].ToIfcIdList());
        }
        #endregion

    }
}