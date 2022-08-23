
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
    public class IfcBoundingBox : IfcGeometricRepresentationItem, IEquatable<IfcBoundingBox>
    {
        private IfcId _cornerId;
        public IfcId CornerId 
        {
            get { 
                return _cornerId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("CornerId is not allowed to be null"); 
                _cornerId = value;
            }
        }
        private double _xDim;
        public double XDim 
        {
            get { 
                return _xDim; 
            }
            set { 
                _xDim = value;
            }
        }
        private double _yDim;
        public double YDim 
        {
            get { 
                return _yDim; 
            }
            set { 
                _yDim = value;
            }
        }
        private double _zDim;
        public double ZDim 
        {
            get { 
                return _zDim; 
            }
            set { 
                _zDim = value;
            }
        }

        public IfcBoundingBox(IfcId id, IfcId cornerId, double xDim, double yDim, double zDim) : base(id)
        {
            CornerId = cornerId;
            XDim = xDim;
            YDim = yDim;
            ZDim = zDim;
        }

        public override ClassId GetClassId() => ClassId.IfcBoundingBox;

        #region Equality

        public bool Equals(IfcBoundingBox other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && CornerId == other.CornerId
                && XDim == other.XDim
                && YDim == other.YDim
                && ZDim == other.ZDim;
        }

        public override bool Equals(object other) => Equals(other as IfcBoundingBox);

        public static bool operator ==(IfcBoundingBox one, IfcBoundingBox other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcBoundingBox one, IfcBoundingBox other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({CornerId},{XDim},{YDim},{ZDim})";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(CornerId!= null && replacementTable.ContainsKey(CornerId))
                CornerId = replacementTable[CornerId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcBoundingBox (newId,CornerId, XDim, YDim, ZDim);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcBoundingBox },
                { "class", nameof(IfcBoundingBox) },
                { "parameters" , new JArray
                    {
                        CornerId.ToJValue(),
                        XDim,
                        YDim,
                        ZDim,
                    }
                }
            };
        }

        public static IfcBoundingBox CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcBoundingBox(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToDouble(),
                parameters[2].ToDouble(),
                parameters[3].ToDouble());
        }
        #endregion

    }
}