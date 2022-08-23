
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
    public class IfcSurfaceStyle : IfcPresentationStyle, IEquatable<IfcSurfaceStyle>, IIfcPresentationStyleSelect
    {
        private IfcSurfaceSide _side;
        public IfcSurfaceSide Side 
        {
            get { 
                return _side; 
            }
            set { 
                _side = value;
            }
        }
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

        public IfcSurfaceStyle(IfcId id, string name, IfcSurfaceSide side, List<IfcId> styleIds) : base(id, name)
        {
            Side = side;
            StyleIds = styleIds;
        }

        public override ClassId GetClassId() => ClassId.IfcSurfaceStyle;

        #region Equality

        public bool Equals(IfcSurfaceStyle other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(StyleIds, other.StyleIds))
                return false;
            return base.Equals(other)
                && Side == other.Side;
        }

        public override bool Equals(object other) => Equals(other as IfcSurfaceStyle);

        public static bool operator ==(IfcSurfaceStyle one, IfcSurfaceStyle other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSurfaceStyle one, IfcSurfaceStyle other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',.{Side}.,{Utils.ConvertListToString(StyleIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(StyleIds!= null)
                StyleIds = StyleIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSurfaceStyle (newId,Name, Side, StyleIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSurfaceStyle },
                { "class", nameof(IfcSurfaceStyle) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Side.ToJValue(),
                        StyleIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcSurfaceStyle CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSurfaceStyle(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                (IfcSurfaceSide)IfcAtom.EnumCreator[(int)EnumId.IfcSurfaceSide](parameters[1].ToString()),
                parameters[2].ToIfcIdList());
        }
        #endregion

    }
}