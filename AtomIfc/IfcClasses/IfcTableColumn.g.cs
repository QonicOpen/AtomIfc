
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
    public class IfcTableColumn : IfcBase, IEquatable<IfcTableColumn>
    {
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
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;  // optional IfcLabel
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
        private IfcId _unitId;
        public IfcId UnitId 
        {
            get { 
                return _unitId; 
            }
            set { 
                _unitId = value;  // optional IfcUnit
            }
        }
        private IfcId _referencePathId;
        public IfcId ReferencePathId 
        {
            get { 
                return _referencePathId; 
            }
            set { 
                _referencePathId = value;  // optional IfcReference
            }
        }

        public IfcTableColumn(IfcId id, string identifier, string name, string description, IfcId unitId, IfcId referencePathId) : base(id)
        {
            Identifier = identifier;
            Name = name;
            Description = description;
            UnitId = unitId;
            ReferencePathId = referencePathId;
        }

        public override ClassId GetClassId() => ClassId.IfcTableColumn;

        #region Equality

        public bool Equals(IfcTableColumn other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && Identifier == other.Identifier
                && Name == other.Name
                && Description == other.Description
                && UnitId == other.UnitId
                && ReferencePathId == other.ReferencePathId;
        }

        public override bool Equals(object other) => Equals(other as IfcTableColumn);

        public static bool operator ==(IfcTableColumn one, IfcTableColumn other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTableColumn one, IfcTableColumn other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Identifier}','{Name}','{Description}',{UnitId},{ReferencePathId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(UnitId!= null && replacementTable.ContainsKey(UnitId))
                UnitId = replacementTable[UnitId];
            if(ReferencePathId!= null && replacementTable.ContainsKey(ReferencePathId))
                ReferencePathId = replacementTable[ReferencePathId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTableColumn (newId,Identifier, Name, Description, UnitId, ReferencePathId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTableColumn },
                { "class", nameof(IfcTableColumn) },
                { "parameters" , new JArray
                    {
                        Identifier.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        UnitId.ToJValue(),
                        ReferencePathId.ToJValue(),
                    }
                }
            };
        }

        public static IfcTableColumn CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTableColumn(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalIfcId(),
                parameters[4].ToOptionalIfcId());
        }
        #endregion

    }
}