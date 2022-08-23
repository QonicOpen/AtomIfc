/*
    Copyright (c) 2022 Qonic
*/

using System;
using System.Collections.Generic;

using System.Linq;


namespace Ifc
{
    public static class Utils
    {

        public static bool CompareList<T>(List<T> one, List<T> two)
            where T : IEquatable<T>
        {
            if (one == null && two == null)
                return true;
            if ((one == null && two != null) || (one != null && two == null))
                return false;
            if (one.Except(two).Any())
                return false;
            if (two.Except(one).Any())
                return false;
            return true;
        }

        public static bool CompareList<T>(List<List<T>> one, List<List<T>> two)
            where T : IEquatable<T>
        {
            if (one.Count() != two.Count())
                return false;
            else
                for (int i = 0; i < one.Count(); i++)
                {
                    if (!CompareList(one[i], two[i]))
                        return false;
                }
            return true;
        }

        public static bool CompareList<T>(List<T[]> one, List<T[]> two)
           where T : IEquatable<T>
        {
            if (one.Count() != two.Count())
                return false;
            else
            {
                for (int i = 0; i < one.Count(); i++)
                {
                    if (one[i].Except(two[i]).Any())
                        return false;
                    if (two[i].Except(one[i]).Any())
                        return false;
                }
            }
            return true;
        }



        public static string ConvertListToString<T>(List<T> list)
        {
            if (list == null)
                return "()";
            
            return $"({string.Join(',', list)})";
        }
        
        public static string ConvertListToString<T>(List<List<T>> doubleList)
        {
            if (doubleList == null)
                return "(())";
            return $"({string.Join(',', doubleList.Select(list => ConvertListToString(list)))})";
        }
    }
}
