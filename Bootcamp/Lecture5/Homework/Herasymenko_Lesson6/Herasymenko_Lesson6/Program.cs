using System;
using System.Collections.Generic;
using System.Linq;

namespace Herasymenko_Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<string>{"A client", "b server", "C server-js", "d client", "E server-dd"};

            var filteredCollection = collection.LetsFilter<string>();

            var mappedCollection = filteredCollection.Map<int>();

            foreach (var item in mappedCollection)
            {
                Console.WriteLine(item);
            }
        }
    }

    static class Extension
    {
        public static ICollection<T> LetsFilter<T>(this ICollection<string> collection)
        {
            var filteredList = new List<string>();

            foreach (var item in collection)
            {
                if (char.IsUpper(item[0]))
                {
                    filteredList.Add(item);
                }
            }

            return (ICollection<T>)filteredList;
        }

        public static ICollection<T> Map<T>(this ICollection<string> collection)
        {
            var mappedList = new List<int>();

            foreach (var item in collection)
            {
                mappedList.Add(item.Length);
            }

            return (ICollection<T>)mappedList; 
        }
    }
}
