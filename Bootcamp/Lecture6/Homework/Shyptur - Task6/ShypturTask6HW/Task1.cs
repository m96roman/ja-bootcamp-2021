using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask6HW
{
    class Task1
    {
        public void task1()
        {
            List<int> list = new List<int>() { 1, 2, 3, 5, 0 };
            List<string> list1 = new List<string>() { "Afs", "sfaf", "sfaf" };
            var a = list.Filter(FilterCollecions);
            var b = list1.Filter(str1 => char.IsUpper(str1[0]));
            var c = list1.MapFilter(str => str.Length);

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("____________________");
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
        }
        public static bool FilterCollecions(int s)
        {
            return s > 0;
        } 
    }
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
