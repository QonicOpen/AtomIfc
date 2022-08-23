
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
    public class IfcConnectedFaceSet : IfcTopologicalRepresentationItem, IEquatable<IfcConnectedFaceSet>
    {
        private List<IfcId> _cfsFaceIds;
        public List<IfcId> CfsFaceIds 
        {
            get { 
                return _cfsFaceIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("CfsFaceIds is not allowed to be null"); 
                _cfsFaceIds = value;
            }
        }

        public IfcConnectedFaceSet(IfcId id, List<IfcId> cfsFaceIds) : base(id)
        {
            CfsFaceIds = cfsFaceIds;
        }

        public override ClassId GetClassId() => ClassId.IfcConnectedFaceSet;

        #region Equality

        public bool Equals(IfcConnectedFaceSet other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(CfsFaceIds, other.CfsFaceIds))
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcConnectedFaceSet);

        public static bool operator ==(IfcConnectedFaceSet one, IfcConnectedFaceSet other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcConnectedFaceSet one, IfcConnectedFaceSet other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(CfsFaceIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CfsFaceIds!= null)
                CfsFaceIds = CfsFaceIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcConnectedFaceSet (newId,CfsFaceIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcConnectedFaceSet },
                { "class", nameof(IfcConnectedFaceSet) },
                { "parameters" , new JArray
                    {
                        CfsFaceIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcConnectedFaceSet CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcConnectedFaceSet(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}