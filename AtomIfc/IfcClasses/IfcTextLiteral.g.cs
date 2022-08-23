
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
    public class IfcTextLiteral : IfcGeometricRepresentationItem, IEquatable<IfcTextLiteral>
    {
        private string _literal;
        public string Literal 
        {
            get { 
                return _literal; 
            }
            set { 
                _literal = value;
            }
        }
        private IfcId _placementId;
        public IfcId PlacementId 
        {
            get { 
                return _placementId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PlacementId is not allowed to be null"); 
                _placementId = value;
            }
        }
        private IfcTextPath _path;
        public IfcTextPath Path 
        {
            get { 
                return _path; 
            }
            set { 
                _path = value;
            }
        }

        public IfcTextLiteral(IfcId id, string literal, IfcId placementId, IfcTextPath path) : base(id)
        {
            Literal = literal;
            PlacementId = placementId;
            Path = path;
        }

        public override ClassId GetClassId() => ClassId.IfcTextLiteral;

        #region Equality

        public bool Equals(IfcTextLiteral other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Literal == other.Literal
                && PlacementId == other.PlacementId
                && Path == other.Path;
        }

        public override bool Equals(object other) => Equals(other as IfcTextLiteral);

        public static bool operator ==(IfcTextLiteral one, IfcTextLiteral other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTextLiteral one, IfcTextLiteral other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Literal}',{PlacementId},.{Path}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PlacementId!= null && replacementTable.ContainsKey(PlacementId))
                PlacementId = replacementTable[PlacementId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTextLiteral (newId,Literal, PlacementId, Path);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTextLiteral },
                { "class", nameof(IfcTextLiteral) },
                { "parameters" , new JArray
                    {
                        Literal.ToJValue(),
                        PlacementId.ToJValue(),
                        Path.ToJValue(),
                    }
                }
            };
        }

        public static IfcTextLiteral CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTextLiteral(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToIfcId(),
                (IfcTextPath)IfcAtom.EnumCreator[(int)EnumId.IfcTextPath](parameters[2].ToString()));
        }
        #endregion

    }
}