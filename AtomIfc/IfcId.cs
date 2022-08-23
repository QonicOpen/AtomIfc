/*
    Copyright (c) 2022 Qonic
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifc
{
    public sealed class IfcId : IComparable<int>, IEquatable<IfcId>
    {
        private readonly int _value;

        public IfcId(int id) { _value = id; }

        public static IfcId FromString(string hashTagInt)
        {
          
            if (string.IsNullOrEmpty(hashTagInt))
                return null;
            if (hashTagInt == "-1") // those are the *
                return new IfcId(-1);
            if (hashTagInt.Length < 2 || hashTagInt[0] != '#' || !int.TryParse(hashTagInt.Substring(1), out int id))
                throw new ArgumentException($"{hashTagInt} is not a valid IfcId.");
            return new IfcId(id);
        }

        public static explicit operator int(IfcId id) => id._value;
        public static explicit operator string(IfcId id) => id?.ToString();
        public override string ToString() => $"#{_value}";

        #region Equality

        public bool Equals(IfcId other)
        {
            if (other == null)
                return false;
            return _value == other._value;
        }

        public bool Equals(int n) => _value == n;

        public override bool Equals(object other) => Equals(other as IfcId);

        public static bool operator ==(IfcId one, IfcId other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);

            return one.Equals(other);
        }

        public static bool operator ==(IfcId one, int n)
        {
            if (ReferenceEquals(one, null))
                return false;

            return one.Equals(n);
        }

        public static bool operator !=(IfcId one, IfcId other) => !(one == other);
        public static bool operator !=(IfcId one, int n) => !(one == n);

        public int CompareTo(int other) => _value - other;
        public int CompareTo(IfcId other) => _value - other._value;

        public override int GetHashCode() => _value;

        #endregion

    }
}
