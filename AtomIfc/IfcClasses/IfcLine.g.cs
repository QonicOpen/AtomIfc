
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
    public class IfcLine : IfcCurve, IEquatable<IfcLine>
    {
        private IfcId _pntId;
        public IfcId PntId 
        {
            get { 
                return _pntId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("PntId is not allowed to be null"); 
                _pntId = value;
            }
        }
        private IfcId _dirId;
        public IfcId DirId 
        {
            get { 
                return _dirId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("DirId is not allowed to be null"); 
                _dirId = value;
            }
        }

        public IfcLine(IfcId id, IfcId pntId, IfcId dirId) : base(id)
        {
            PntId = pntId;
            DirId = dirId;
        }

        public override ClassId GetClassId() => ClassId.IfcLine;

        #region Equality

        public bool Equals(IfcLine other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && PntId == other.PntId
                && DirId == other.DirId;
        }

        public override bool Equals(object other) => Equals(other as IfcLine);

        public static bool operator ==(IfcLine one, IfcLine other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcLine one, IfcLine other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({PntId},{DirId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(PntId!= null && replacementTable.ContainsKey(PntId))
                PntId = replacementTable[PntId];
            if(DirId!= null && replacementTable.ContainsKey(DirId))
                DirId = replacementTable[DirId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcLine (newId,PntId, DirId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcLine },
                { "class", nameof(IfcLine) },
                { "parameters" , new JArray
                    {
                        PntId.ToJValue(),
                        DirId.ToJValue(),
                    }
                }
            };
        }

        public static IfcLine CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcLine(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcId());
        }
        #endregion

    }
}