using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask6HW
{
    public static class MyExtension
    {
        public static ICollection<T> Filter<T>(this ICollection<T> collection, Predicate<T> filterCollection)
        {
            List<T> list = new List<T>();
            foreach (var item in collection)
            {
                if (filterCollection(item))
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public static ICollection<int> MapFilter(this ICollection<string> collection, Func<string, int> filterCollection)
        {
            List<int> newlis = new List<int>();
            foreach (var item in collection)
            {
                newlis.Add(filterCollection(item));
            }

            return newlis;
        }
    }
}
