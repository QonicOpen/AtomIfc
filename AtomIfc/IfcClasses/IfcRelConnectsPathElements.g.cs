
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
    public class IfcRelConnectsPathElements : IfcRelConnectsElements, IEquatable<IfcRelConnectsPathElements>
    {
        private List<double> _relatingPriorities;
        public List<double> RelatingPriorities 
        {
            get { 
                return _relatingPriorities; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatingPriorities is not allowed to be null"); 
                _relatingPriorities = value;
            }
        }
        private List<double> _relatedPriorities;
        public List<double> RelatedPriorities 
        {
            get { 
                return _relatedPriorities; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("RelatedPriorities is not allowed to be null"); 
                _relatedPriorities = value;
            }
        }
        private IfcConnectionTypeEnum _relatedConnectionType;
        public IfcConnectionTypeEnum RelatedConnectionType 
        {
            get { 
                return _relatedConnectionType; 
            }
            set { 
                _relatedConnectionType = value;
            }
        }
        private IfcConnectionTypeEnum _relatingConnectionType;
        public IfcConnectionTypeEnum RelatingConnectionType 
        {
            get { 
                return _relatingConnectionType; 
            }
            set { 
                _relatingConnectionType = value;
            }
        }

        public IfcRelConnectsPathElements(IfcId id, IfcId ownerHistoryId, string name, string description, IfcId connectionGeometryId, IfcId relatingElementId, IfcId relatedElementId, List<double> relatingPriorities, List<double> relatedPriorities, IfcConnectionTypeEnum relatedConnectionType, IfcConnectionTypeEnum relatingConnectionType) : base(id, ownerHistoryId, name, description, connectionGeometryId, relatingElementId, relatedElementId)
        {
            RelatingPriorities = relatingPriorities;
            RelatedPriorities = relatedPriorities;
            RelatedConnectionType = relatedConnectionType;
            RelatingConnectionType = relatingConnectionType;
        }

        public override ClassId GetClassId() => ClassId.IfcRelConnectsPathElements;

        #region Equality

        public bool Equals(IfcRelConnectsPathElements other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(RelatingPriorities, other.RelatingPriorities))
                return false;
            if(!Utils.CompareList(RelatedPriorities, other.RelatedPriorities))
                return false;
            return base.Equals(other)
                && RelatedConnectionType == other.RelatedConnectionType
                && RelatingConnectionType == other.RelatingConnectionType;
        }

        public override bool Equals(object other) => Equals(other as IfcRelConnectsPathElements);

        public static bool operator ==(IfcRelConnectsPathElements one, IfcRelConnectsPathElements other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcRelConnectsPathElements one, IfcRelConnectsPathElements other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({OwnerHistoryId},'{Name}','{Description}',{ConnectionGeometryId},{RelatingElementId},{RelatedElementId},{Utils.ConvertListToString(RelatingPriorities)},{Utils.ConvertListToString(RelatedPriorities)},.{RelatedConnectionType}.,.{RelatingConnectionType}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcRelConnectsPathElements (newId,OwnerHistoryId, Name, Description, ConnectionGeometryId, RelatingElementId, RelatedElementId, RelatingPriorities, RelatedPriorities, RelatedConnectionType, RelatingConnectionType);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcRelConnectsPathElements },
                { "class", nameof(IfcRelConnectsPathElements) },
                { "parameters" , new JArray
                    {
                        OwnerHistoryId.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        ConnectionGeometryId.ToJValue(),
                        RelatingElementId.ToJValue(),
                        RelatedElementId.ToJValue(),
                        RelatingPriorities.ToJArray(),
                        RelatedPriorities.ToJArray(),
                        RelatedConnectionType.ToJValue(),
                        RelatingConnectionType.ToJValue(),
                    }
                }
            };
        }

        public static new IfcRelConnectsPathElements CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcRelConnectsPathElements(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalIfcId(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToIfcId(),
                parameters[5].ToIfcId(),
                parameters[6].ToDoubleList(),
                parameters[7].ToDoubleList(),
                (IfcConnectionTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcConnectionTypeEnum](parameters[8].ToString()),
                (IfcConnectionTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcConnectionTypeEnum](parameters[9].ToString()));
        }
        #endregion

    }
}