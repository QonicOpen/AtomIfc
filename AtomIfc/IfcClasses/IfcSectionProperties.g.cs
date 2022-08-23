
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
    public class IfcSectionProperties : IfcPreDefinedProperties, IEquatable<IfcSectionProperties>
    {
        private IfcSectionTypeEnum _sectionType;
        public IfcSectionTypeEnum SectionType 
        {
            get { 
                return _sectionType; 
            }
            set { 
                _sectionType = value;
            }
        }
        private IfcId _startProfileId;
        public IfcId StartProfileId 
        {
            get { 
                return _startProfileId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("StartProfileId is not allowed to be null"); 
                _startProfileId = value;
            }
        }
        private IfcId _endProfileId;
        public IfcId EndProfileId 
        {
            get { 
                return _endProfileId; 
            }
            set { 
                _endProfileId = value;  // optional IfcProfileDef
            }
        }

        public IfcSectionProperties(IfcId id, IfcSectionTypeEnum sectionType, IfcId startProfileId, IfcId endProfileId) : base(id)
        {
            SectionType = sectionType;
            StartProfileId = startProfileId;
            EndProfileId = endProfileId;
        }

        public override ClassId GetClassId() => ClassId.IfcSectionProperties;

        #region Equality

        public bool Equals(IfcSectionProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && SectionType == other.SectionType
                && StartProfileId == other.StartProfileId
                && EndProfileId == other.EndProfileId;
        }

        public override bool Equals(object other) => Equals(other as IfcSectionProperties);

        public static bool operator ==(IfcSectionProperties one, IfcSectionProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSectionProperties one, IfcSectionProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}(.{SectionType}.,{StartProfileId},{EndProfileId})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(StartProfileId!= null && replacementTable.ContainsKey(StartProfileId))
                StartProfileId = replacementTable[StartProfileId];
            if(EndProfileId!= null && replacementTable.ContainsKey(EndProfileId))
                EndProfileId = replacementTable[EndProfileId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSectionProperties (newId,SectionType, StartProfileId, EndProfileId);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSectionProperties },
                { "class", nameof(IfcSectionProperties) },
                { "parameters" , new JArray
                    {
                        SectionType.ToJValue(),
                        StartProfileId.ToJValue(),
                        EndProfileId.ToJValue(),
                    }
                }
            };
        }

        public static IfcSectionProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSectionProperties(
                jObject["id"].ToIfcId(),
                (IfcSectionTypeEnum)IfcAtom.EnumCreator[(int)EnumId.IfcSectionTypeEnum](parameters[0].ToString()),
                parameters[1].ToIfcId(),
                parameters[2].ToOptionalIfcId());
        }
        #endregion

    }
}