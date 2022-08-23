
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
    public class IfcVertexLoop : IfcLoop, IEquatable<IfcVertexLoop>
    {
        private IfcId _loopVertexId;
        public IfcId LoopVertexId 
        {
            get { 
                return _loopVertexId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("LoopVertexId is not allowed to be null"); 
                _loopVertexId = value;
            }
        }

        public IfcVertexLoop(IfcId id, IfcId loopVertexId) : base(id)
        {
            LoopVertexId = loopVertexId;
        }

        public override ClassId GetClassId() => ClassId.IfcVertexLoop;

        #region Equality

        public bool Equals(IfcVertexLoop other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && LoopVertexId == other.LoopVertexId;
        }

        public override bool Equals(object other) => Equals(other as IfcVertexLoop);

        public static bool operator ==(IfcVertexLoop one, IfcVertexLoop other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcVertexLoop one, IfcVertexLoop other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({LoopVertexId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(LoopVertexId!= null && replacementTable.ContainsKey(LoopVertexId))
                LoopVertexId = replacementTable[LoopVertexId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcVertexLoop (newId,LoopVertexId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcVertexLoop },
                { "class", nameof(IfcVertexLoop) },
                { "parameters" , new JArray
                    {
                        LoopVertexId.ToJValue(),
                    }
                }
            };
        }

        public static new IfcVertexLoop CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcVertexLoop(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId());
        }
        #endregion

    }
}