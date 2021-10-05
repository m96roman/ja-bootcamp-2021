using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace Task1.Extensions
{
    public static class CustomExtensions
    {
        /*
        public static string[] Filter(this string[] collection, Func<string, bool> funct)
        {
            return collection.Where(it => funct(it)).ToArray();
        }
        */

        /*
        public static int Map(this string[] collection)
        {
            return collection.Length;
        }
        */

        public static int Map<T>(this T[] collection)
        {
            return collection.Length;
        }

        public static T[] Filter<T>(this T[] collection, Func<T, bool> funct)
        {
            return collection.Where(it => funct(it)).ToArray();
        }
    }
}
