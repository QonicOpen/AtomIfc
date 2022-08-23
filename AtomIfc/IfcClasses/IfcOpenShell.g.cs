
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
    public class IfcOpenShell : IfcConnectedFaceSet, IEquatable<IfcOpenShell>, IIfcShell
    {
        public IfcOpenShell(IfcId id, List<IfcId> cfsFaceIds) : base(id, cfsFaceIds)
        {
        }

        public override ClassId GetClassId() => ClassId.IfcOpenShell;

        #region Equality

        public bool Equals(IfcOpenShell other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other);
        }

        public override bool Equals(object other) => Equals(other as IfcOpenShell);

        public static bool operator ==(IfcOpenShell one, IfcOpenShell other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcOpenShell one, IfcOpenShell other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({Utils.ConvertListToString(CfsFaceIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcOpenShell (newId,CfsFaceIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcOpenShell },
                { "class", nameof(IfcOpenShell) },
                { "parameters" , new JArray
                    {
                        CfsFaceIds.ToJArray(),
                    }
                }
            };
        }

        public static new IfcOpenShell CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcOpenShell(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcIdList());
        }
        #endregion

    }
}