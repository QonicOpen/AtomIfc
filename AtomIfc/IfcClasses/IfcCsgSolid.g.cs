
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
    public class IfcCsgSolid : IfcSolidModel, IEquatable<IfcCsgSolid>
    {
        private IfcId _treeRootExpressionId;
        public IfcId TreeRootExpressionId 
        {
            get { 
                return _treeRootExpressionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("TreeRootExpressionId is not allowed to be null"); 
                _treeRootExpressionId = value;
            }
        }

        public IfcCsgSolid(IfcId id, IfcId treeRootExpressionId) : base(id)
        {
            TreeRootExpressionId = treeRootExpressionId;
        }

        public override ClassId GetClassId() => ClassId.IfcCsgSolid;

        #region Equality

        public bool Equals(IfcCsgSolid other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && TreeRootExpressionId == other.TreeRootExpressionId;
        }

        public override bool Equals(object other) => Equals(other as IfcCsgSolid);

        public static bool operator ==(IfcCsgSolid one, IfcCsgSolid other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcCsgSolid one, IfcCsgSolid other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({TreeRootExpressionId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TreeRootExpressionId!= null && replacementTable.ContainsKey(TreeRootExpressionId))
                TreeRootExpressionId = replacementTable[TreeRootExpressionId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcCsgSolid (newId,TreeRootExpressionId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcCsgSolid },
                { "class", nameof(IfcCsgSolid) },
                { "parameters" , new JArray
                    {
                        TreeRootExpressionId.ToJValue(),
                    }
                }
            };
        }

        public static IfcCsgSolid CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcCsgSolid(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId());
        }
        #endregion

    }
}