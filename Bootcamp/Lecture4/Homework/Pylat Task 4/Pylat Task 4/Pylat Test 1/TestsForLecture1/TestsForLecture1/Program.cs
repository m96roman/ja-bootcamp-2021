using Pylat_Task_4;
using System;
using System.Collections.Generic;

namespace TestsForLecture1
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            Logger logger = new Logger();
            var test2 = new BateryLevelTests("Is", 0);
            var test3 = new BateryLevelTests("Is", 0);
            var test4 = new BateryLevelTests("Is", 66);
            var test5 = new BateryLevelTests("Is", 10);
            var test6 = new BateryLevelTests("Is", 36);
            var test7 = new BateryLevelTests("Is", 3);
            var test8 = new BateryLevelTests("Is", 3);
            var test9 = new BateryLevelTests("Is", 6);

            // Is batery created?
            try
            {
                var test1 = new BateryLevelTests("Is", 10);
                test1.IsBateryLevelCreated();
                Console.WriteLine("Test 1 - passed");
                logger.AddToList("Test 1 - passed");
            }
            catch
            {
                logger.AddToList("Test 1 is passed, but batary level is not between 0 and 100: Batery Level is not between 0 and 100");
            }

            // is batery higner than 5?
            try
            {
                test2.IsBateryLevelHigher5();
                Console.WriteLine("Test 2 passed");
                logger.AddToList("Test 2 passed");
            }
            catch
            {
                logger.AddToList("Test 2 failed: Batary level is 0");
                test2.IsBateryLevelHigher5();
            }

            // charging to 100
            try
            {
                test3.Charge();
                test3.ChargeTo100();
                Console.WriteLine("Test 3 passed");
                logger.AddToList("Test 3 passed");
            }
            catch
            {
                logger.AddToList("Test 3 failed: Batery is not 100");
            }

            // is batary charged a bit?
            try
            {
                test4.IsChargedABit();
                Console.WriteLine("Test 4 passed");
                logger.AddToList("Test 4 passed");
            }
            catch
            {
                logger.AddToList("Test 4 failed");
            }

            // Is batary lower than 5?
            try
            {
                test5.IsBateryDad();
                Console.WriteLine("Test 5 failed");
                logger.AddToList("Test 5 failed");
            }
            catch
            {
                logger.AddToList("Test 5 passed");
                         }

            Console.WriteLine("Logger has values:");
            logger.Print();
        }
    }
}

