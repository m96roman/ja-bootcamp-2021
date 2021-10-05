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
            MyFilterDelegate del = MyFilter;

            MyMapDeledate delMap = MyMap;

            var myColection = new List<string> { "Hello World", "hello World", "hello World", "1", "2", "3" };

            var result2 = myColection.Map(delMap);

            Console.WriteLine($"============Map==================");

            foreach (var iteam in result2)
            {
                Console.Write($"{iteam}\n");
            }

            Console.WriteLine($"============Filter==================");

            foreach (var iteam in myColection.Filter(str => char.IsLower(str[0])))
            {
                Console.Write($"{iteam}\n");
            }

            MyMapDeledate delMap2 = MyMap;

            var myColection1 = new List<string>() { "234","23423asd","asdsdasdsd" };

            Console.WriteLine($"============Map2==================");

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

        public static bool MyFilter(string filter)
        {

            return Char.IsUpper(filter, 0);

        }

        public static int MyMap(string param)
        {

            return param.Length;
        }

        public static ICollection Filter(this ICollection<string> collection, MyFilterDelegate myFilterDelegat)
        {
            var result = new List<string>();

            foreach (var iteam in collection)
            {

                if (myFilterDelegat(iteam))
                {
                    result.Add(iteam);
                }
            }

            return result;
        }

        public static ICollection Map(this ICollection<string> collection, MyMapDeledate myMapDeledate)
        {
            var result = new List<int>();

            foreach (var iteam in collection)
            {
                result.Add(myMapDeledate(iteam));
            }

            return result;
        }

        public delegate bool MyFilterDelegate (string filter);

        public delegate int MyMapDeledate(string map);
    }

}
