
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
    public class IfcSurfaceStyleWithTextures : IfcPresentationItem, IEquatable<IfcSurfaceStyleWithTextures>, IIfcSurfaceStyleElementSelect
    {
        private List<IfcId> _textureIds;
        public List<IfcId> TextureIds 
        {
            get { 
                return _textureIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TextureIds is not allowed to be null"); 
                _textureIds = value;
            }
        }

        public IfcSurfaceStyleWithTextures(IfcId id, List<IfcId> textureIds) : base(id)
        {
            TextureIds = textureIds;
        }

        public override ClassId GetClassId() => ClassId.IfcSurfaceStyleWithTextures;

        #region Equality

        public bool Equals(IfcSurfaceStyleWithTextures other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(TextureIds, other.TextureIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcSurfaceStyleWithTextures);

        public static bool operator ==(IfcSurfaceStyleWithTextures one, IfcSurfaceStyleWithTextures other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSurfaceStyleWithTextures one, IfcSurfaceStyleWithTextures other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(TextureIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TextureIds!= null)
                TextureIds = TextureIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSurfaceStyleWithTextures (newId,TextureIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSurfaceStyleWithTextures },
                { "class", nameof(IfcSurfaceStyleWithTextures) },
                { "parameters" , new JArray
                    {
                        TextureIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcSurfaceStyleWithTextures CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSurfaceStyleWithTextures(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}