using System;
using System.Collections;
using System.Collections.Generic;

namespace MRoshko_Task6
{
    static class Program
    {
        static void Main(string[] args)
        {
            Task1();


        }
        public static void Task1()
        {

            MyFilterDelegate<string> del = MyFilter;

            MyMapDeledate<string> delMap = MyMap;

            var myColection = new List<string>();
            myColection.Add("Hello World");
            myColection.Add("hello World");
            myColection.Add("1");
            myColection.Add("2");



            var result = myColection.Filter(del);
            var result2 = myColection.Map(delMap);
            foreach (var iteam in result2)
            {
                Console.Write($"{iteam}\n");
            }
            foreach (var iteam in result)
            {
                Console.Write($"{iteam}\n");
            }

            MyMapDeledate<int> delMap2 = MyMap;
            var myColection1 = new List<int>() { 1, 2, 3, 4, 5, 6, 213 };
            foreach (var iteam in myColection1.Map(delMap2))
            {
                Console.Write($"{iteam}\n");
            }
        }

        public static bool MyFilter<T>(T filter)
        {

            return Char.IsLower(filter.ToString(), 0);

        }

        public static bool MyMap<T>(T param)
        {
            var result = int.TryParse(param.ToString(),out var r);
            return result; 
        }

        public static ICollection<T> Filter<T>(this ICollection<T> collection, MyFilterDelegate<T> myFilterDelegat)
        {
            var result = new List<T>();

            foreach (var iteam in collection)
            {

                if (myFilterDelegat(iteam))
                {
                    result.Add(iteam);
                }
            }

            return result;
        }
        public static ICollection<T> Map<T>(this ICollection<T> collection, MyMapDeledate<T> MyMapDeledate)
        {
            var result = new List<T>();

            foreach (var iteam in collection)
            {
                if (MyMapDeledate(iteam)) {
                    result.Add(iteam);
                }
            }

            return result;
        }

        public delegate bool MyFilterDelegate<T>(T filter);
        public delegate bool MyMapDeledate<T>(T map);
    }

}
