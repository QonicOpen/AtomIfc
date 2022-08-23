
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
    public class IfcPresentationLayerAssignment : IfcBase, IEquatable<IfcPresentationLayerAssignment>
    {
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;
            }
        }
        private string _description;
        public string Description 
        {
            get { 
                return _description; 
            }
            set { 
                _description = value;  // optional IfcText
            }
        }
        private List<IfcId> _assignedItemIds;
        public List<IfcId> AssignedItemIds 
        {
            get { 
                return _assignedItemIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("AssignedItemIds is not allowed to be null"); 
                _assignedItemIds = value;
            }
        }
        private string _identifier;
        public string Identifier 
        {
            get { 
                return _identifier; 
            }
            set { 
                _identifier = value;  // optional IfcIdentifier
            }
        }

        public IfcPresentationLayerAssignment(IfcId id, string name, string description, List<IfcId> assignedItemIds, string identifier) : base(id)
        {
            Name = name;
            Description = description;
            AssignedItemIds = assignedItemIds;
            Identifier = identifier;
        }

        public override ClassId GetClassId() => ClassId.IfcPresentationLayerAssignment;

        #region Equality

        public bool Equals(IfcPresentationLayerAssignment other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(AssignedItemIds, other.AssignedItemIds))
                return false;
            return base.Equals(other)
                && Name == other.Name
                && Description == other.Description
                && Identifier == other.Identifier;
        }

        public override bool Equals(object other) => Equals(other as IfcPresentationLayerAssignment);

        public static bool operator ==(IfcPresentationLayerAssignment one, IfcPresentationLayerAssignment other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcPresentationLayerAssignment one, IfcPresentationLayerAssignment other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Name}','{Description}',{Utils.ConvertListToString(AssignedItemIds)},'{Identifier}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(AssignedItemIds!= null)
                AssignedItemIds = AssignedItemIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcPresentationLayerAssignment (newId,Name, Description, AssignedItemIds, Identifier);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcPresentationLayerAssignment },
                { "class", nameof(IfcPresentationLayerAssignment) },
                { "parameters" , new JArray
                    {
                        Name.ToJValue(),
                        Description.ToJValue(),
                        AssignedItemIds.ToJArray(),
                        Identifier.ToJValue(),
                    }
                }
            };
        }

        public static IfcPresentationLayerAssignment CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcPresentationLayerAssignment(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToOptionalString());
        }
        #endregion

    }
}