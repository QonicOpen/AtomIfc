
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
    public class IfcProxy : IfcProduct, IEquatable<IfcProxy>
    {
        private IfcObjectTypeEnum _proxyType;
        public IfcObjectTypeEnum ProxyType 
        {
            get { 
                return _proxyType; 
            }
            set { 
                _proxyType = value;
            }
        }
        private string _tag;
        public string Tag 
        {
            get { 
                return _tag; 
            }
            set { 
                _tag = value;  // optional IfcLabel
            }
        }

        public IfcProxy(IfcId id, string globalId, IfcId ownerHistoryId, string name, string description, string objectType, IfcId objectPlacementId, IfcId representationId, IfcObjectTypeEnum proxyType, string tag) : base(id, globalId, ownerHistoryId, name, description, objectType, objectPlacementId, representationId)
        {
            ProxyType = proxyType;
            Tag = tag;
        }

        public override ClassId GetClassId() => ClassId.IfcProxy;

        #region Equality

        public bool Equals(IfcProxy other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ProxyType == other.ProxyType
                && Tag == other.Tag;
        }

        public override bool Equals(object other) => Equals(other as IfcProxy);

        public static bool operator ==(IfcProxy one, IfcProxy other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcProxy one, IfcProxy other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{GlobalId}',{OwnerHistoryId},'{Name}','{Description}','{ObjectType}',{ObjectPlacementId},{RepresentationId},.{ProxyType}.,'{Tag}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcProxy (newId,GlobalId, OwnerHistoryId, Name, Description, ObjectType, ObjectPlacementId, RepresentationId, ProxyType, Tag);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcProxy },
                { "class", nameof(IfcProxy) },
                { "parameters" , new JArray
                    {
                        GlobalId.ToJValue(),
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ObjectType.ToJValue(),
                        ObjectPlacementId.ToJValue(),
                        RepresentationId.ToJValue(),
                        ProxyType.ToJValue(),
                        Tag.ToJValue(),
                    }
                }
            };
        }

        public static IfcProxy CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcProxy(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalIfcId(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToOptionalIfcId(),
                (IfcObjectTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcObjectTypeEnum](parameters[7].ToString()),
                parameters[8].ToOptionalString());
        }
        #endregion

    }
}