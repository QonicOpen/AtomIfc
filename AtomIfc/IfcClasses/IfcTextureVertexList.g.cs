
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
    public class IfcTextureVertexList : IfcPresentationItem, IEquatable<IfcTextureVertexList>
    {
        private List<List<double>> _texCoordsList;
        public List<List<double>> TexCoordsList 
        {
            get { 
                return _texCoordsList; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TexCoordsList is not allowed to be null"); 
                _texCoordsList = value;
            }
        }

        public IfcTextureVertexList(IfcId id, List<List<double>> texCoordsList) : base(id)
        {
            TexCoordsList = texCoordsList;
        }

        public override ClassId GetClassId() => ClassId.IfcTextureVertexList;

        #region Equality

        public bool Equals(IfcTextureVertexList other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(TexCoordsList, other.TexCoordsList))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcTextureVertexList);

        public static bool operator ==(IfcTextureVertexList one, IfcTextureVertexList other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTextureVertexList one, IfcTextureVertexList other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(TexCoordsList)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTextureVertexList (newId,TexCoordsList);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTextureVertexList },
                { "class", nameof(IfcTextureVertexList) },
                { "parameters" , new JArray
                    {
                        TexCoordsList.ToJArray(),
                    }
                }
            };
        }

        public static IfcTextureVertexList CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTextureVertexList(
                jObject["id"].ToIfcId(),
                parameters[0].ToNestedDoubleList());
        }
        #endregion

    }
}