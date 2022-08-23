
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
    public class IfcTextLiteralWithExtent : IfcTextLiteral, IEquatable<IfcTextLiteralWithExtent>
    {
        private IfcId _extentId;
        public IfcId ExtentId 
        {
            get { 
                return _extentId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ExtentId is not allowed to be null"); 
                _extentId = value;
            }
        }
        private IfcId _boxAlignmentId;
        public IfcId BoxAlignmentId 
        {
            get { 
                return _boxAlignmentId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("BoxAlignmentId is not allowed to be null"); 
                _boxAlignmentId = value;
            }
        }

        public IfcTextLiteralWithExtent(IfcId id, string literal, IfcId placementId, IfcTextPath path, IfcId extentId, IfcId boxAlignmentId) : base(id, literal, placementId, path)
        {
            ExtentId = extentId;
            BoxAlignmentId = boxAlignmentId;
        }

        public override ClassId GetClassId() => ClassId.IfcTextLiteralWithExtent;

        #region Equality

        public bool Equals(IfcTextLiteralWithExtent other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ExtentId == other.ExtentId
                && BoxAlignmentId == other.BoxAlignmentId;
        }

        public override bool Equals(object other) => Equals(other as IfcTextLiteralWithExtent);

        public static bool operator ==(IfcTextLiteralWithExtent one, IfcTextLiteralWithExtent other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTextLiteralWithExtent one, IfcTextLiteralWithExtent other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Literal}',{PlacementId},.{Path}.,{ExtentId},{BoxAlignmentId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ExtentId!= null && replacementTable.ContainsKey(ExtentId))
                ExtentId = replacementTable[ExtentId];
            if(BoxAlignmentId!= null && replacementTable.ContainsKey(BoxAlignmentId))
                BoxAlignmentId = replacementTable[BoxAlignmentId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTextLiteralWithExtent (newId,Literal, PlacementId, Path, ExtentId, BoxAlignmentId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTextLiteralWithExtent },
                { "class", nameof(IfcTextLiteralWithExtent) },
                { "parameters" , new JArray
                    {
                        Literal.ToJValue(),
                        PlacementId.ToJValue(),
                        Path.ToJValue(),
                        ExtentId.ToJValue(),
                        BoxAlignmentId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcTextLiteralWithExtent CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTextLiteralWithExtent(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToIfcId(),
                (IfcTextPath)IfcAtom.EnumCreator[(int)EnumId.IfcTextPath](parameters[2].ToString()),
                parameters[3].ToIfcId(),
                parameters[4].ToIfcId());
        }
        #endregion

    }
}