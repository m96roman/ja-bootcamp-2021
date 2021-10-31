using System;
using System.IO;

namespace VDedenok_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Task1-----");

            using (StreamWriter sw = new StreamWriter("TextToCountLinesFrom.txt"))
            {
                sw.WriteLine("This is line 1");
                sw.WriteLine("This is line 2");
                sw.WriteLine("This is line 3");
                sw.WriteLine("This is line 4");
                sw.WriteLine("This is line 5");
            }

            int linesCount = File.ReadAllLines("TextToCountLinesFrom.txt").Length;
            Console.WriteLine($"Number of lines in file is {linesCount}.");

            Console.WriteLine("------Task2------");

            Task2 task2 = new Task2();
            task2.RunTask2();

            Console.WriteLine("-----Task3-----");

            Task3 task3 = new Task3();
            task3.RunTask3();

            Console.WriteLine("-----Task4-----");

            Logger logger = new Logger();

            Nokia nokia1 = new Nokia() { BatteryLevel = 99 };

            Nokia nokia2 = new Nokia() { BatteryLevel = 10 };

            Phone iPhone10 = new IPhone() { BatteryLevel = 12 };

            Phone iPhone13 = new IPhone() { BatteryLevel = 1 };

            Phone[] phoneEmergencyTestHolder = new Phone[] { nokia1, nokia2, iPhone10, iPhone13 };

            TestEmergency startTest = new TestEmergency();

            startTest.CallTestEmergency(phoneEmergencyTestHolder);
        }
    }
}


