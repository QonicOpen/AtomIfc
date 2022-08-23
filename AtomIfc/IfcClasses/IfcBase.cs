using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifc
{
    public interface IIfcBase
    {
        public IfcId GetId();
        public JObject ToJson();
    }

    public abstract class IfcBase : IIfcBase
    {
        public readonly IfcId Id;

        internal IfcBase(IfcId id)
        {
            if (id == null)
                throw new ArgumentNullException("IfcId should not be null.");
            Id = id;
        }        
        
        public IfcId GetId() => Id;

        public abstract ClassId GetClassId();


        public virtual void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable) { }


        #region Equality

        private bool EqualsImpl(IfcBase other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other)) 
                return true;
            if (other.GetType() != GetType())
                return false;
            return Id == other.Id;
        }

        public override bool Equals(object other) => EqualsImpl(other as IfcBase);

        public static bool operator ==(IfcBase one, IfcBase other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);

            return one.Equals(other);
        }

        public static bool operator !=(IfcBase one, IfcBase other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public abstract IfcBase Copy(IfcId newId);

        #endregion

        #region Serialization

        public abstract JObject ToJson();


        public abstract string GetDataHash();

      



        #endregion
    }
}
