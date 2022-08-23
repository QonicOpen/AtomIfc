/*
    Copyright (c) 2022 Qonic
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace Ifc
{
    public static class JsonExtensions
    {
        #region from Json

        public static IfcId ToIfcId(this JToken token) => IfcId.FromString(token.ToString());

        public static IfcId ToOptionalIfcId(this JToken token) => token.Type == JTokenType.Null ? null : token.ToIfcId();

        public static string ToOptionalString(this JToken token) => token.Type == JTokenType.Null ? null : token.ToString();

        public static double ToDouble(this JToken token) => (double)token;

        public static double? ToOptionalDouble(this JToken token) => token.Type == JTokenType.Null ? null : token.ToDouble();

        public static int ToInt(this JToken token) => (int)token;

        public static int? ToOptionalInt(this JToken token) => token.Type == JTokenType.Null ? null : token.ToInt();

        public static bool ToBool(this JToken token) => (bool)token;

        public static bool? ToOptionalBool(this JToken token) => token.Type == JTokenType.Null ? null : token.ToBool();

        public static byte[] ToByteArray(this JToken token) => (byte[])token;

        public static Enum ToEnum(this JToken token, EnumId enumId)
        {
            string value = token.ToString();
            if (value.First() != '.' || value.Last() != '.')
                throw new ArgumentException($"Input parameter { value } is not a valid IFC Enum value.");
            value = value.Substring(1, value.Length - 2).ToUpper();

            return IfcAtom.EnumCreator[(int)enumId](value);
        }

        public static List<IfcId> ToIfcIdList(this JToken token)
        {
            return
                (token as JArray)
                .Where(x => x.Type != JTokenType.Null)  // according to EXPRESS elements inside list/set should not be null
                .Select(x => x.ToIfcId())
                .ToList();
            
        }

        public static List<IfcId> ToOptionalIfcIdList(this JToken token)
        {
            return token.Type == JTokenType.Null ? null : token.ToIfcIdList();
        }

        public static List<string> ToStringList(this JToken token)
        {
            return
                (token as JArray)
                .Where(x => x.Type != JTokenType.Null)  // according to EXPRESS elements inside list/set should not be null
                .Select(x => x.ToString())
                .ToList();
          
        }

        public static List<string> ToOptionalStringList(this JToken token)
        {
            return token.Type == JTokenType.Null ? null : token.ToStringList();
        }

        public static List<int> ToIntList(this JToken token)
        {
            return new List<int>(
                (token as JArray)
                .Select(x => x.ToInt())
                .ToArray()
            );
        }

        public static List<int> ToOptionalIntList(this JToken token)
        {
            return token.Type == JTokenType.Null ? null : token.ToIntList();
        }

        public static List<double> ToDoubleList(this JToken token)
        {
            return new List<double>(
                (token as JArray)
                .Select(x => x.ToDouble())
                .ToArray()
            );
        }

        public static List<double> ToOptionalDoubleList(this JToken token)
        {
            return token.Type == JTokenType.Null ? null : token.ToDoubleList();
        }

        public static List<byte[]> ToByteArrayList(this JToken token)
        {
            return new List<byte[]>(
                (token as JArray)
                .Where(x => x.Type != JTokenType.Null)  // according to EXPRESS elements inside list/set should not be null
                .Select(x => x.ToByteArray())
                .ToArray()
            );
        }

        public static List<List<IfcId>> ToNestedIfcIdList(this JToken token)
        {
            return
                (token as JArray)
                .Where(x => x.Type != JTokenType.Null)  // according to EXPRESS elements inside list/set should not be null
                .Select(x => x.ToIfcIdList())
                .ToList();
            
        }

        public static List<List<IfcId>> ToOptionalNestedIfcIdList(this JToken token)
        {
            return token.Type == JTokenType.Null? null: token.ToNestedIfcIdList();
        }

        public static List<List<int>> ToNestedIntList(this JToken token)
        {
            return new List<List<int>>(
                (token as JArray)
                .Where(x => x.Type != JTokenType.Null)  // according to EXPRESS elements inside list/set should not be null
                .Select(x => x.ToIntList())
                .ToArray()
            );
        }

        public static List<List<int>> ToOptionalNestedIntList(this JToken token)
        {
            return token.Type == JTokenType.Null ? null : token.ToNestedIntList();
        }

        public static List<List<double>> ToNestedDoubleList(this JToken token)
        {
            return new List<List<double>>(
                (token as JArray)
                .Where(x => x.Type != JTokenType.Null)  // according to EXPRESS elements inside list/set should not be null
                .Select(x => x.ToDoubleList())
                .ToArray()
            );
        }

        public static List<List<double>> ToOptionalNestedDoubleList(this JToken token)
        {
            return token.Type == JTokenType.Null ? null : token.ToNestedDoubleList();
        }
        #endregion

        #region to Json

        public static JValue ToJValue(this string s) => new JValue(s);
        public static JValue ToJValue(this int? i) => new JValue(i);
        public static JValue ToJValue(this double? d) => new JValue(d);
        public static JValue ToJValue(this bool? b) => new JValue(b);
        public static JValue ToJValue(this byte[] a) => new JValue(a);

        public static JValue ToJValue(this IfcId id) => new JValue((string)id);

        public static JValue ToJValue(this Enum ifcEnum)
        {
            if (Convert.ToInt32(ifcEnum) == 0)
                return null;
            else
                return new JValue("." + ifcEnum.ToString() + ".");
        }

        public static JArray ToJArray(this IEnumerable<IfcId> list) => list is null ? null : JArray.FromObject(list?.Select(x => (string)x));
        public static JArray ToJArray(this IEnumerable<string> list) => list is null ? null : JArray.FromObject(list);
        public static JArray ToJArray(this IEnumerable<int> list) => list is null ? null : JArray.FromObject(list);
        public static JArray ToJArray(this IEnumerable<int?> list) => list is null ? null : JArray.FromObject(list);
        public static JArray ToJArray(this IEnumerable<double> list) => list is null ? null : JArray.FromObject(list);
        public static JArray ToJArray(this IEnumerable<double?> list) => list is null ? null : JArray.FromObject(list);
        public static JArray ToJArray(this IEnumerable<byte[]> list) => list is null ? null : JArray.FromObject(list);

        public static JArray ToJArray(this IEnumerable<IEnumerable<IfcId>> list) => list is null ? null : JArray.FromObject(list.Select(x => x.ToJArray()));
        public static JArray ToJArray(this IEnumerable<IEnumerable<int>> list) => list is null ? null : JArray.FromObject(list.Select(x => x.ToJArray()));
        public static JArray ToJArray(this IEnumerable<IEnumerable<int?>> list) => list is null ? null : JArray.FromObject(list.Select(x => x.ToJArray()));
        public static JArray ToJArray(this IEnumerable<IEnumerable<double>> list) => list is null ? null : JArray.FromObject(list.Select(x => x.ToJArray()));
        public static JArray ToJArray(this IEnumerable<IEnumerable<double?>> list) => list is null ? null : JArray.FromObject(list.Select(x => x.ToJArray()));
        #endregion
    }
}
