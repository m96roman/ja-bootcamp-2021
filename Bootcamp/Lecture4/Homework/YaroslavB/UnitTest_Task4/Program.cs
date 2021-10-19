using System;
using Yaroslav_Task4;

namespace UnitTest_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing class \'IPhone13\'");
            Console.WriteLine();

            BatryLevel_HappyPath_40();
            BateryLevel_Exception_101();
            BateryLevel_Exception_minus1();
            CallAmbulance_BeteryDecreasing_By_5_percent();
            BateryLevelIsBelow_5_BatteryIsDeadException();


            Console.WriteLine("\n\nPress \'Enter\' to exit");
            Console.ReadLine();
        }

        static void BatryLevel_HappyPath_40()
        {
            int bateryLevel = 40;

            Console.WriteLine();

            try
            {
                IPhone13 instance = new IPhone13(bateryLevel);

                if (instance.BatteryLevel == bateryLevel)
                {
                    Console.WriteLine("TestCase for BateryLevel setting at \'40\' - PASSED");
                }
                else
                {
                    Console.WriteLine("TestCase for BateryLevel setting at \'40\' - FAILED");
                    Console.WriteLine($"actual: {instance.BatteryLevel}");
                    Console.WriteLine($"expected: {bateryLevel}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("TestCase for BateryLevel setting at \'40\' - FAILED");
                Console.WriteLine("exception throwed:\n" + ex.Message);
            }
        }

        static void BateryLevel_Exception_minus1()
        {
            int bateryLevel = -1;

            Console.WriteLine();

            try
            {
                IPhone13 instance = new IPhone13(bateryLevel);
                Console.WriteLine("TestCase for BateryLevel setting at \'-1\' - FAILED");
                Console.WriteLine("no exception throwed!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("TestCase for BateryLevel setting at \'-1\' - PASSED");
            }
        }

        static void BateryLevel_Exception_101()
        {
            int bateryLevel = 101;

            Console.WriteLine();

            try
            {
                IPhone13 instance = new IPhone13(bateryLevel);
                Console.WriteLine("TestCase for BateryLevel setting at \'101\' - FAILED");
                Console.WriteLine("no exception throwed!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("TestCase for BateryLevel setting at \'101\' - PASSED");
            }
        }

        static void CallAmbulance_BeteryDecreasing_By_5_percent()
        {
            int bateryLevel = 40;
            int expectedBateryLevel = 35;

            Console.WriteLine();

            IPhone13 instance = new IPhone13(bateryLevel);
            instance.CallAmbulance();

            Console.WriteLine();

            if (instance.BatteryLevel == expectedBateryLevel)
            {
                Console.WriteLine("TestCase for CallAmbulance, decreasing batery level by \'5\' - PASSED");
            }
            else
            {
                Console.WriteLine("TestCase for CallAmbulance, decreasing batery level by \'5\' - FAILED");
                Console.WriteLine($"actual: {instance.BatteryLevel}");
                Console.WriteLine($"expected: {expectedBateryLevel}");
            }
        }

        static void BateryLevelIsBelow_5_BatteryIsDeadException()
        {
            int bateryLevel = 4;

            Console.WriteLine();

            try
            {
                IPhone13 instance = new IPhone13(bateryLevel);
                instance.CallAmbulance();
                Console.WriteLine("TestCase for BateryLevel set below \'5\', BatteryIsDeadException  - FAILED");
                Console.WriteLine("no exception throwed!");

            }
            catch (BatteryIsDeadException)
            {
                Console.WriteLine("TestCase for BateryLevel set below \'5\', BatteryIsDeadException - PASSED");
            }
        }
    }


}
