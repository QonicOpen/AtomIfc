
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
    public class IfcReference : IfcBase, IEquatable<IfcReference>, IIfcAppliedValueSelect, IIfcMetricValueSelect
    {
        private string _typeIdentifier;
        public string TypeIdentifier 
        {
            get { 
                return _typeIdentifier; 
            }
            set { 
                _typeIdentifier = value;  // optional IfcIdentifier
            }
        }
        private string _attributeIdentifier;
        public string AttributeIdentifier 
        {
            get { 
                return _attributeIdentifier; 
            }
            set { 
                _attributeIdentifier = value;  // optional IfcIdentifier
            }
        }
        private string _instanceName;
        public string InstanceName 
        {
            get { 
                return _instanceName; 
            }
            set { 
                _instanceName = value;  // optional IfcLabel
            }
        }
        private List<int> _listPositions;
        public List<int> ListPositions 
        {
            get { 
                return _listPositions; 
            }
            set { 
                _listPositions = value;  // optional List<int>
            }
        }
        private IfcId _innerReferenceId;
        public IfcId InnerReferenceId 
        {
            get { 
                return _innerReferenceId; 
            }
            set { 
                _innerReferenceId = value;  // optional IfcReference
            }
        }

        public IfcReference(IfcId id, string typeIdentifier, string attributeIdentifier, string instanceName, List<int> listPositions, IfcId innerReferenceId) : base(id)
        {
            TypeIdentifier = typeIdentifier;
            AttributeIdentifier = attributeIdentifier;
            InstanceName = instanceName;
            ListPositions = listPositions;
            InnerReferenceId = innerReferenceId;
        }

        public override ClassId GetClassId() => ClassId.IfcReference;

        #region Equality

        public bool Equals(IfcReference other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(ListPositions, other.ListPositions))
                return false;
            return base.Equals(other)
                && TypeIdentifier == other.TypeIdentifier
                && AttributeIdentifier == other.AttributeIdentifier
                && InstanceName == other.InstanceName
                && InnerReferenceId == other.InnerReferenceId;
        }

        public override bool Equals(object other) => Equals(other as IfcReference);

        public static bool operator ==(IfcReference one, IfcReference other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcReference one, IfcReference other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{TypeIdentifier}','{AttributeIdentifier}','{InstanceName}',{Utils.ConvertListToString(ListPositions)},{InnerReferenceId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(InnerReferenceId!= null && replacementTable.ContainsKey(InnerReferenceId))
                InnerReferenceId = replacementTable[InnerReferenceId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcReference (newId,TypeIdentifier, AttributeIdentifier, InstanceName, ListPositions, InnerReferenceId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcReference },
                { "class", nameof(IfcReference) },
                { "parameters" , new JArray
                    {
                        TypeIdentifier.ToJValue(),
                        AttributeIdentifier.ToJValue(),
                        InstanceName.ToJValue(),
                        ListPositions.ToJArray(),
                        InnerReferenceId.ToJValue(),
                    }
                }
            };
        }

        public static IfcReference CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcReference(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIntList(),
                parameters[4].ToOptionalIfcId());
        }
        #endregion

    }
}