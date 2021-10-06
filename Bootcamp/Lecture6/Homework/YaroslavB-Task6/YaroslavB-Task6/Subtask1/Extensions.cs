using System;
using System.Collections.Generic;

namespace YaroslavB_Task6
{
    static class Extensions
    {
        public static ICollection<T> Filter<T>(this ICollection<T> collection, Func<T, bool> func)
        {
            List<T> resultCollection = new List<T>();

            foreach (var item in collection)
            {
                if (func(item))
                {
                    resultCollection.Add(item);
                }
            }

            return (ICollection<T>)resultCollection; ;
        }

        public static ICollection<int> Map(this ICollection<string> collection, Func<string, int> func)
        {
            List<int> list = new List<int>();

            foreach (var item in collection)
            {
                list.Add(func(item));
            }

            return (ICollection<int>)list;
        }

        public static ICollection<outT> Map<inT, outT>(this ICollection<inT> collection, Func<inT, outT> func)
        {
            List<outT> list = new List<outT>();

            foreach (var item in collection)
            {
                list.Add(func(item));
            }

            return (ICollection<outT>)list;
        }
    }
}
