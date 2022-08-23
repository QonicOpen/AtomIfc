
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
    public class IfcPresentationStyleAssignment : IfcBase, IEquatable<IfcPresentationStyleAssignment>, IIfcStyleAssignmentSelect
    {
        private List<IfcId> _styleIds;
        public List<IfcId> StyleIds 
        {
            get { 
                return _styleIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("StyleIds is not allowed to be null"); 
                _styleIds = value;
            }
        }

        public IfcPresentationStyleAssignment(IfcId id, List<IfcId> styleIds) : base(id)
        {
            StyleIds = styleIds;
        }

        public override ClassId GetClassId() => ClassId.IfcPresentationStyleAssignment;

        #region Equality

        public bool Equals(IfcPresentationStyleAssignment other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(StyleIds, other.StyleIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcPresentationStyleAssignment);

        public static bool operator ==(IfcPresentationStyleAssignment one, IfcPresentationStyleAssignment other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPresentationStyleAssignment one, IfcPresentationStyleAssignment other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(StyleIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(StyleIds!= null)
                StyleIds = StyleIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPresentationStyleAssignment (newId,StyleIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPresentationStyleAssignment },
                { "class", nameof(IfcPresentationStyleAssignment) },
                { "parameters" , new JArray
                    {
                        StyleIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcPresentationStyleAssignment CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPresentationStyleAssignment(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}