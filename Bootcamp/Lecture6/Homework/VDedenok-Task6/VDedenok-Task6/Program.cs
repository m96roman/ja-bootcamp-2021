using System;
using System.Collections;
using System.Collections.Generic;


namespace VDedenok_Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------Task1-------");

            List<string> strings = new List<string>() { "Apple", "orange", "trawberry", "cherry", "pear" };
          
            List<string> stringNums = new List<string>() { "1", "2", "3", "4", "5" };
  
            Filter(strings, strings => ToUpperCase(strings));      
           
            Map(stringNums, stringNums => StringToInt(stringNums));
          
            Map(strings, strings => GetLength(strings));
          
          
            Console.WriteLine("-------Task2-------");
          
            var auctioneer = new Auctioneer();

            var bitMonitorer1 = new BitMonitorer1();
            var bitMonitorer2 = new BitMonitorer2();
            var bitMonitorer3 = new BitMonitorer3();

            auctioneer.OnBidChanged += bitMonitorer1.MonitoringBids1;
            auctioneer.OnBidChanged += bitMonitorer2.MonitoringBids2;
            auctioneer.OnBidChanged += bitMonitorer3.MonitoringBids3;
           
            auctioneer.SetBidWalue(50);
          
        }   

        public static List<string> ToUpperCase(List<string> value)
        {
            List<string> result = new List<string>();
           
            foreach (var item in value)
            {            
              result.Add(item.ToUpper());             
            }
            Console.WriteLine("Message from ToUppercase");
            return result;
        }
      
        public static List<int> GetLength(List<string> value)
        {
            List<int> result = new List<int>();

            foreach (var item in value)
            {
                result.Add(item.Length);
            }
            Console.WriteLine("Message from GetLength");
            return result;        
        }

        public static List<int> StringToInt(List<string> value)
        {
            List<int> resultInt = new List<int>();

            foreach (var item in value)  
            {
               resultInt.Add(Convert.ToInt32(item)); 
            }
            Console.WriteLine("Message from StringToInt");
            return resultInt;
        }

        public static void Filter<T>(T a,  Func<T, T> operation)
        {
            T rusult = operation(a);
        }

        public static void Map (List<string> a, Func<List<string>, List<int>> operation)
        {
            List<int> result = operation(a);
        }

    }
}
