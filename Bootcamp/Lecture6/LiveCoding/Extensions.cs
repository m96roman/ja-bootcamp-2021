using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveCoding
{
    public static class Extensions
    {
        public static int ReverseDigits(this int number, string text)
        {
            Console.WriteLine(text);
            return int.Parse(number.ToString().Reverse().ToArray());
        }

        public static string JoinAsString(this ICollection<int> collection, string separator = ",")
        {
            return string.Join(separator, collection);
        }

        public static void Print(this string collection)
        {
            foreach (var c in collection)
            {
                Console.WriteLine(c);
            }
        }
    }
}
