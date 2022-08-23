
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
    public class IfcTrimmedCurve : IfcBoundedCurve, IEquatable<IfcTrimmedCurve>
    {
        private IfcId _basisCurveId;
        public IfcId BasisCurveId 
        {
            get { 
                return _basisCurveId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("BasisCurveId is not allowed to be null"); 
                _basisCurveId = value;
            }
        }
        private List<IfcId> _trim1Ids;
        public List<IfcId> Trim1Ids 
        {
            get { 
                return _trim1Ids; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("Trim1Ids is not allowed to be null"); 
                _trim1Ids = value;
            }
        }
        private List<IfcId> _trim2Ids;
        public List<IfcId> Trim2Ids 
        {
            get { 
                return _trim2Ids; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("Trim2Ids is not allowed to be null"); 
                _trim2Ids = value;
            }
        }
        private bool _senseAgreement;
        public bool SenseAgreement 
        {
            get { 
                return _senseAgreement; 
            }
            set { 
                _senseAgreement = value;
            }
        }
        private IfcTrimmingPreference _masterRepresentation;
        public IfcTrimmingPreference MasterRepresentation 
        {
            get { 
                return _masterRepresentation; 
            }
            set { 
                _masterRepresentation = value;
            }
        }

        public IfcTrimmedCurve(IfcId id, IfcId basisCurveId, List<IfcId> trim1Ids, List<IfcId> trim2Ids, bool senseAgreement, IfcTrimmingPreference masterRepresentation) : base(id)
        {
            BasisCurveId = basisCurveId;
            Trim1Ids = trim1Ids;
            Trim2Ids = trim2Ids;
            SenseAgreement = senseAgreement;
            MasterRepresentation = masterRepresentation;
        }

        public override ClassId GetClassId() => ClassId.IfcTrimmedCurve;

        #region Equality

        public bool Equals(IfcTrimmedCurve other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(Trim1Ids, other.Trim1Ids))
                return false;
            if(!Utils.CompareList(Trim2Ids, other.Trim2Ids))
                return false;
            return base.Equals(other)
                && BasisCurveId == other.BasisCurveId
                && SenseAgreement == other.SenseAgreement
                && MasterRepresentation == other.MasterRepresentation;
        }

        public override bool Equals(object other) => Equals(other as IfcTrimmedCurve);

        public static bool operator ==(IfcTrimmedCurve one, IfcTrimmedCurve other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcTrimmedCurve one, IfcTrimmedCurve other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({BasisCurveId},{Utils.ConvertListToString(Trim1Ids)},{Utils.ConvertListToString(Trim2Ids)},{SenseAgreement},.{MasterRepresentation}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(BasisCurveId!= null && replacementTable.ContainsKey(BasisCurveId))
                BasisCurveId = replacementTable[BasisCurveId];
            if(Trim1Ids!= null)
                Trim1Ids = Trim1Ids.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            if(Trim2Ids!= null)
                Trim2Ids = Trim2Ids.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcTrimmedCurve (newId,BasisCurveId, Trim1Ids, Trim2Ids, SenseAgreement, MasterRepresentation);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcTrimmedCurve },
                { "class", nameof(IfcTrimmedCurve) },
                { "parameters" , new JArray
                    {
                        BasisCurveId.ToJValue(),
                        Trim1Ids.ToJArray(),
                        Trim2Ids.ToJArray(),
                        SenseAgreement,
                        MasterRepresentation.ToJValue(),
                    }
                }
            };
        }

        public static IfcTrimmedCurve CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcTrimmedCurve(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToIfcIdList(),
                parameters[2].ToIfcIdList(),
                parameters[3].ToBool(),
                (IfcTrimmingPreference)IfcAtom.EnumCreator[(int)EnumId.IfcTrimmingPreference](parameters[4].ToString()));
        }
        #endregion

    }
}