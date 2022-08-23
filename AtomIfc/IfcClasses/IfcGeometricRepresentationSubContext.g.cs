
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
    public class IfcGeometricRepresentationSubContext : IfcGeometricRepresentationContext, IEquatable<IfcGeometricRepresentationSubContext>
    {
        private IfcId _parentContextId;
        public IfcId ParentContextId 
        {
            get { 
                return _parentContextId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ParentContextId is not allowed to be null"); 
                _parentContextId = value;
            }
        }
        private double? _targetScale;
        public double? TargetScale 
        {
            get { 
                return _targetScale; 
            }
            set { 
                _targetScale = value;  // optional IfcPositiveRatioMeasure
            }
        }
        private IfcGeometricProjectionEnum _targetView;
        public IfcGeometricProjectionEnum TargetView 
        {
            get { 
                return _targetView; 
            }
            set { 
                _targetView = value;
            }
        }
        private string _userDefinedTargetView;
        public string UserDefinedTargetView 
        {
            get { 
                return _userDefinedTargetView; 
            }
            set { 
                _userDefinedTargetView = value;  // optional IfcLabel
            }
        }

        public IfcGeometricRepresentationSubContext(IfcId id, string contextIdentifier, string contextType, int coordinateSpaceDimension, double? precision, IfcId worldCoordinateSystemId, IfcId trueNorthId, IfcId parentContextId, double? targetScale, IfcGeometricProjectionEnum targetView, string userDefinedTargetView) : base(id, contextIdentifier, contextType, coordinateSpaceDimension, precision, worldCoordinateSystemId, trueNorthId)
        {
            ParentContextId = parentContextId;
            TargetScale = targetScale;
            TargetView = targetView;
            UserDefinedTargetView = userDefinedTargetView;
        }

        public override ClassId GetClassId() => ClassId.IfcGeometricRepresentationSubContext;

        #region Equality

        public bool Equals(IfcGeometricRepresentationSubContext other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ParentContextId == other.ParentContextId
                && TargetScale == other.TargetScale
                && TargetView == other.TargetView
                && UserDefinedTargetView == other.UserDefinedTargetView;
        }

        public override bool Equals(object other) => Equals(other as IfcGeometricRepresentationSubContext);

        public static bool operator ==(IfcGeometricRepresentationSubContext one, IfcGeometricRepresentationSubContext other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcGeometricRepresentationSubContext one, IfcGeometricRepresentationSubContext other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{ContextIdentifier}','{ContextType}',{CoordinateSpaceDimension},{Precision},{WorldCoordinateSystemId},{TrueNorthId},{ParentContextId},{TargetScale},.{TargetView}.,'{UserDefinedTargetView}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ParentContextId!= null && replacementTable.ContainsKey(ParentContextId))
                ParentContextId = replacementTable[ParentContextId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcGeometricRepresentationSubContext (newId,ContextIdentifier, ContextType, CoordinateSpaceDimension, Precision, WorldCoordinateSystemId, TrueNorthId, ParentContextId, TargetScale, TargetView, UserDefinedTargetView);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcGeometricRepresentationSubContext },
                { "class", nameof(IfcGeometricRepresentationSubContext) },
                { "parameters" , new JArray
                    {
                        ContextIdentifier.ToJValue(),
                        ContextType.ToJValue(),
                        CoordinateSpaceDimension,
                        Precision.ToJValue(),
                        WorldCoordinateSystemId.ToJValue(),
                        TrueNorthId.ToJValue(),
                        ParentContextId.ToJValue(),
                        TargetScale.ToJValue(),
                        TargetView.ToJValue(),
                        UserDefinedTargetView.ToJValue(),
                    }
                }
            };
        }

        public static new IfcGeometricRepresentationSubContext CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcGeometricRepresentationSubContext(
                jObject["id"].ToIfcId(),
                parameters[0].ToOptionalString(),
                parameters[1].ToOptionalString(),
                parameters[2].ToInt(),
                parameters[3].ToOptionalDouble(),
                parameters[4].ToIfcId(),
                parameters[5].ToOptionalIfcId(),
                parameters[6].ToIfcId(),
                parameters[7].ToOptionalDouble(),
                (IfcGeometricProjectionEnum)IfcAtom.EnumCreator[(int)EnumId.IfcGeometricProjectionEnum](parameters[8].ToString()),
                parameters[9].ToOptionalString());
        }
        #endregion

    }
}