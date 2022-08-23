
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
    public class IfcAnnotationFillArea : IfcGeometricRepresentationItem, IEquatable<IfcAnnotationFillArea>
    {
        private IfcId _outerBoundaryId;
        public IfcId OuterBoundaryId 
        {
            get { 
                return _outerBoundaryId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("OuterBoundaryId is not allowed to be null"); 
                _outerBoundaryId = value;
            }
        }
        private List<IfcId> _innerBoundaryIds;
        public List<IfcId> InnerBoundaryIds 
        {
            get { 
                return _innerBoundaryIds; 
            }
            set { 
                _innerBoundaryIds = value;  // optional List<IfcCurve>
            }
        }

        public IfcAnnotationFillArea(IfcId id, IfcId outerBoundaryId, List<IfcId> innerBoundaryIds) : base(id)
        {
            OuterBoundaryId = outerBoundaryId;
            InnerBoundaryIds = innerBoundaryIds;
        }

        public override ClassId GetClassId() => ClassId.IfcAnnotationFillArea;

        #region Equality

        public bool Equals(IfcAnnotationFillArea other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(InnerBoundaryIds, other.InnerBoundaryIds))
                return false;
            return base.Equals(other)
                && OuterBoundaryId == other.OuterBoundaryId;
        }

        public override bool Equals(object other) => Equals(other as IfcAnnotationFillArea);

        public static bool operator ==(IfcAnnotationFillArea one, IfcAnnotationFillArea other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcAnnotationFillArea one, IfcAnnotationFillArea other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OuterBoundaryId},{Utils.ConvertListToString(InnerBoundaryIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(OuterBoundaryId!= null && replacementTable.ContainsKey(OuterBoundaryId))
                OuterBoundaryId = replacementTable[OuterBoundaryId];
            if(InnerBoundaryIds!= null)
                InnerBoundaryIds = InnerBoundaryIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcAnnotationFillArea (newId,OuterBoundaryId, InnerBoundaryIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcAnnotationFillArea },
                { "class", nameof(IfcAnnotationFillArea) },
                { "parameters" , new JArray
                    {
                        OuterBoundaryId.ToJValue(),
                        InnerBoundaryIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcAnnotationFillArea CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcAnnotationFillArea(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToOptionalIfcIdList());
        }
        #endregion

    }
}