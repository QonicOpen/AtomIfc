
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
    public class IfcFillAreaStyle : IfcPresentationStyle, IEquatable<IfcFillAreaStyle>, IIfcPresentationStyleSelect
    {
        private List<IfcId> _fillStyleIds;
        public List<IfcId> FillStyleIds 
        {
            get { 
                return _fillStyleIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("FillStyleIds is not allowed to be null"); 
                _fillStyleIds = value;
            }
        }
        private bool? _modelorDraughting;
        public bool? ModelorDraughting 
        {
            get { 
                return _modelorDraughting; 
            }
            set { 
                _modelorDraughting = value;  // optional bool
            }
        }

        public IfcFillAreaStyle(IfcId id, string name, List<IfcId> fillStyleIds, bool? modelorDraughting) : base(id, name)
        {
            FillStyleIds = fillStyleIds;
            ModelorDraughting = modelorDraughting;
        }

        public override ClassId GetClassId() => ClassId.IfcFillAreaStyle;

        #region Equality

        public bool Equals(IfcFillAreaStyle other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(FillStyleIds, other.FillStyleIds))
                return false;
            return base.Equals(other)
                && ModelorDraughting == other.ModelorDraughting;
        }

        public override bool Equals(object other) => Equals(other as IfcFillAreaStyle);

        public static bool operator ==(IfcFillAreaStyle one, IfcFillAreaStyle other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcFillAreaStyle one, IfcFillAreaStyle other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}',{Utils.ConvertListToString(FillStyleIds)},{(ModelorDraughting == null? ".U." : ModelorDraughting)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(FillStyleIds!= null)
                FillStyleIds = FillStyleIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcFillAreaStyle (newId,Name, FillStyleIds, ModelorDraughting);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcFillAreaStyle },
                { "class", nameof(IfcFillAreaStyle) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        FillStyleIds.ToJArray(),
                        ModelorDraughting.ToJValue(),
                    }
                }
            };
        }

        public static IfcFillAreaStyle CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcFillAreaStyle(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToIfcIdList(),
                parameters[2].ToOptionalBool());
        }
        #endregion

    }
}