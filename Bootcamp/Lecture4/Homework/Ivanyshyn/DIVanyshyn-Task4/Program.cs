using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DIvanyshyn-UnitTests-Day1")]
namespace DIVanyshyn_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new OutLogger();
            int[] batteryLevels = new[] { 4, 8, 25 };
            PhoneEmeregencyTestHolder holder = new();

            for (int i = 0; i < batteryLevels.Length; i++)
            {
                try
                {
                    holder.Add(new Nokia(batteryLevels[i], $"Nokia {i}", logger));
                    holder.Add(new IPhone13(batteryLevels[i], $"IPhone13 {i}", logger));
                }
                catch (ArgumentException exc)
                {
                    logger.WriteLine($"{exc.Message} happened in constructor of type {nameof(Phone)} because of parameter {exc.ParamName}", MessageType.Exception);
                }
            }


            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine(new string('-', 20));
                    PhoneEmeregencyTestHolder.TestEmeregency(holder);
                    Console.WriteLine(new string('-', 20));
                }
                catch (BatteryIsDeadException bs)
                {
                    Console.WriteLine(new string('~', 20));
                    bs.Phone.Status();
                    bs.Phone.Charge();
                    bs.Phone.Status();
                    Console.WriteLine(new string('~', 20));
                }
            }
        }
    }
}
