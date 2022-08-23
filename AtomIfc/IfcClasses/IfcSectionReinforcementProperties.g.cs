
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
    public class IfcSectionReinforcementProperties : IfcPreDefinedProperties, IEquatable<IfcSectionReinforcementProperties>
    {
        private double _longitudinalStartPosition;
        public double LongitudinalStartPosition 
        {
            get { 
                return _longitudinalStartPosition; 
            }
            set { 
                _longitudinalStartPosition = value;
            }
        }
        private double _longitudinalEndPosition;
        public double LongitudinalEndPosition 
        {
            get { 
                return _longitudinalEndPosition; 
            }
            set { 
                _longitudinalEndPosition = value;
            }
        }
        private double? _transversePosition;
        public double? TransversePosition 
        {
            get { 
                return _transversePosition; 
            }
            set { 
                _transversePosition = value;  // optional IfcLengthMeasure
            }
        }
        private IfcReinforcingBarRoleEnum _reinforcementRole;
        public IfcReinforcingBarRoleEnum ReinforcementRole 
        {
            get { 
                return _reinforcementRole; 
            }
            set { 
                _reinforcementRole = value;
            }
        }
        private IfcId _sectionDefinitionId;
        public IfcId SectionDefinitionId 
        {
            get { 
                return _sectionDefinitionId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("SectionDefinitionId is not allowed to be null"); 
                _sectionDefinitionId = value;
            }
        }
        private List<IfcId> _crossSectionReinforcementDefinitionIds;
        public List<IfcId> CrossSectionReinforcementDefinitionIds 
        {
            get { 
                return _crossSectionReinforcementDefinitionIds; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("CrossSectionReinforcementDefinitionIds is not allowed to be null"); 
                _crossSectionReinforcementDefinitionIds = value;
            }
        }

        public IfcSectionReinforcementProperties(IfcId id, double longitudinalStartPosition, double longitudinalEndPosition, double? transversePosition, IfcReinforcingBarRoleEnum reinforcementRole, IfcId sectionDefinitionId, List<IfcId> crossSectionReinforcementDefinitionIds) : base(id)
        {
            LongitudinalStartPosition = longitudinalStartPosition;
            LongitudinalEndPosition = longitudinalEndPosition;
            TransversePosition = transversePosition;
            ReinforcementRole = reinforcementRole;
            SectionDefinitionId = sectionDefinitionId;
            CrossSectionReinforcementDefinitionIds = crossSectionReinforcementDefinitionIds;
        }

        public override ClassId GetClassId() => ClassId.IfcSectionReinforcementProperties;

        #region Equality

        public bool Equals(IfcSectionReinforcementProperties other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(CrossSectionReinforcementDefinitionIds, other.CrossSectionReinforcementDefinitionIds))
                return false;
            return base.Equals(other)
                && LongitudinalStartPosition == other.LongitudinalStartPosition
                && LongitudinalEndPosition == other.LongitudinalEndPosition
                && TransversePosition == other.TransversePosition
                && ReinforcementRole == other.ReinforcementRole
                && SectionDefinitionId == other.SectionDefinitionId;
        }

        public override bool Equals(object other) => Equals(other as IfcSectionReinforcementProperties);

        public static bool operator ==(IfcSectionReinforcementProperties one, IfcSectionReinforcementProperties other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSectionReinforcementProperties one, IfcSectionReinforcementProperties other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({LongitudinalStartPosition},{LongitudinalEndPosition},{TransversePosition},.{ReinforcementRole}.,{SectionDefinitionId},{Utils.ConvertListToString(CrossSectionReinforcementDefinitionIds)})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(SectionDefinitionId!= null && replacementTable.ContainsKey(SectionDefinitionId))
                SectionDefinitionId = replacementTable[SectionDefinitionId];
            if(CrossSectionReinforcementDefinitionIds!= null)
                CrossSectionReinforcementDefinitionIds = CrossSectionReinforcementDefinitionIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcSectionReinforcementProperties (newId,LongitudinalStartPosition, LongitudinalEndPosition, TransversePosition, ReinforcementRole, SectionDefinitionId, CrossSectionReinforcementDefinitionIds);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcSectionReinforcementProperties },
                { "class", nameof(IfcSectionReinforcementProperties) },
                { "parameters" , new JArray
                    {
                        LongitudinalStartPosition,
                        LongitudinalEndPosition,
                        TransversePosition.ToJValue(),
                        ReinforcementRole.ToJValue(),
                        SectionDefinitionId.ToJValue(),
                        CrossSectionReinforcementDefinitionIds.ToJArray(),
                    }
                }
            };
        }

        public static IfcSectionReinforcementProperties CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcSectionReinforcementProperties(
                jObject["id"].ToIfcId(),
                parameters[0].ToDouble(),
                parameters[1].ToDouble(),
                parameters[2].ToOptionalDouble(),
                (IfcReinforcingBarRoleEnum)IfcAtom.EnumCreator[(int)EnumId.IfcReinforcingBarRoleEnum](parameters[3].ToString()),
                parameters[4].ToIfcId(),
                parameters[5].ToIfcIdList());
        }
        #endregion

    }
}