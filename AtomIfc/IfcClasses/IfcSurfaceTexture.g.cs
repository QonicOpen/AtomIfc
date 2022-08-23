
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
    public abstract class IfcSurfaceTexture : IfcPresentationItem, IEquatable<IfcSurfaceTexture>
    {
        private bool _repeatS;
        public bool RepeatS 
        {
            get { 
                return _repeatS; 
            }
            set { 
                _repeatS = value;
            }
        }
        private bool _repeatT;
        public bool RepeatT 
        {
            get { 
                return _repeatT; 
            }
            set { 
                _repeatT = value;
            }
        }
        private string _mode;
        public string Mode 
        {
            get { 
                return _mode; 
            }
            set { 
                _mode = value;  // optional IfcIdentifier
            }
        }
        private IfcId _textureTransformId;
        public IfcId TextureTransformId 
        {
            get { 
                return _textureTransformId; 
            }
            set { 
                _textureTransformId = value;  // optional IfcCartesianTransformationOperator2D
            }
        }
        private List<string> _parameter;
        public List<string> Parameter 
        {
            get { 
                return _parameter; 
            }
            set { 
                _parameter = value;  // optional List<IfcIdentifier>
            }
        }

        internal IfcSurfaceTexture(IfcId id, bool repeatS, bool repeatT, string mode, IfcId textureTransformId, List<string> parameter) : base(id)
        {
            RepeatS = repeatS;
            RepeatT = repeatT;
            Mode = mode;
            TextureTransformId = textureTransformId;
            Parameter = parameter;
        }

        #region Equality

        public bool Equals(IfcSurfaceTexture other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(Parameter, other.Parameter))
                return false;
            return base.Equals(other)
                && RepeatS == other.RepeatS
                && RepeatT == other.RepeatT
                && Mode == other.Mode
                && TextureTransformId == other.TextureTransformId;
        }

        public override bool Equals(object other) => Equals(other as IfcSurfaceTexture);

        public static bool operator ==(IfcSurfaceTexture one, IfcSurfaceTexture other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcSurfaceTexture one, IfcSurfaceTexture other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(TextureTransformId!= null && replacementTable.ContainsKey(TextureTransformId))
                TextureTransformId = replacementTable[TextureTransformId];
            base.ReplaceIds(replacementTable);

        }
    }
}