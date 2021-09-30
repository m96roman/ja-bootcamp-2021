using System;
using System.Collections.Generic;

namespace DIVanyshyn_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] batteryLevels = new[] { 4, 8, 25 };
            PhoneEmeregencyTestHolder holder = new(new Phone[0]);

            for (int i = 0; i < batteryLevels.Length; i++)
            {
                try
                {
                    holder.Add(new Nokia(batteryLevels[i], $"Nokia {i}"));
                    holder.Add(new IPhone13(batteryLevels[i], $"IPhone13 {i}"));
                }
                catch (ArgumentException exc)
                {
                    Console.WriteLine($"{exc.Message} happened in constructor of type {nameof(Phone)} because of parameter {exc.ParamName}");
                }
            }

            int count = 10;
            while (count != 0)
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
                count--;
            }
        }
    }
}
