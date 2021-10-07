using System;
using System.Collections.Generic;
using System.Linq;

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

        public static R[] Map<T, R>(this T[] collection, Func<T, R> mapper)
        {
            var result = new List<R>();

            foreach(var item in collection)
            {
                result.Add(mapper(item));
            }

            return result.ToArray();
        }

        public static T[] Filter<T>(this T[] collection, Func<T, bool> funct)
        {
            return collection.Where(it => funct(it)).ToArray();
        }
    }
}
