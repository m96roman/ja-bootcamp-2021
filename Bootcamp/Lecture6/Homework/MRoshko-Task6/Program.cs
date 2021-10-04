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

            //Task2();

        }
        public static void Task1()
        {

            MyFilterDelegate<string,bool> del = MyFilter;

            MyMapDeledate<string,int> delMap = MyMap;

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

            MyMapDeledate<string,int> delMap2 = MyMap;
            var myColection1 = new List<int>() { 1, 2, 3, 4, 5, 6, 213 };
            foreach (var iteam in myColection1.Map(delMap2))
            {
                Console.Write($"{iteam}\n");
            }
        }


        public static void Task2()
        {
            var auctioneer = new Auctioneer();

            auctioneer.OnBidChanged += MyNewBid1;
            auctioneer.OnBidChanged += MyNewBid2;
            auctioneer.OnBidChanged += MyNewBid3;
            auctioneer.SetNewBid(122);
            auctioneer.SetNewBid(228);
        }

        public static void MyNewBid1(object arg, int bidValue)
        {
            if (bidValue > 100)
            {
                Console.WriteLine($"Ohhh they really want to by this car for {bidValue}?");
            }

        }

        public static void MyNewBid2(object arg, int bidValue)
        {

            if (bidValue < 300)
            {
                Console.WriteLine($"I can give more, { bidValue} is nothing.");
            }

        }

        public static void MyNewBid3(object arg, int bidValue)
        {

            if (bidValue < 200)
            {
                Console.WriteLine($"I will wait a bit. I think that {bidValue} is not the last price.");
            }
        }

        public static bool MyFilter<T,R>(T filter)
        {
            return Char.IsLower(filter.ToString(), 0);
        }

        public static int  MyMap<T>(T param)
        {
            int.TryParse(param.ToString(), out var r);

            return r;

        }

        public static ICollection<T> Filter<T>(this ICollection<T> collection, MyFilterDelegate<T,R> myFilterDelegat)
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

        public static ICollection<int> Map<T>(this ICollection<T> collection, MyMapDeledate<T> myMapDeledate)
        {
            var result = new List<int>();

            foreach (var iteam in collection)
            {
                result.Add(myMapDeledate(iteam));
            }

            return result;
        }

        public delegate R MyFilterDelegate<T>(T input);

        public delegate R  MyMapDeledate<T>(T input);
    }

}
