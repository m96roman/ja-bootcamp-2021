using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIvanyshyn_9.HereWeGoAgain
{
    class Task4
    {
        internal static void Execute()
        {
            int[] batteryLevels = new[] { 4, 8, 25 };
            PhoneEmeregencyTestHolder holder = new();

            for (int i = 0; i < batteryLevels.Length; i++)
            {
                try
                {
                    holder.Add(new Nokia(batteryLevels[i], $"Nokia {i}"));
                    holder.Add(new IPhone13(batteryLevels[i], $"IPhone13 {i}"));
                }
                catch (ArgumentException exc)
                {
                    string message = $"{exc.Message} happened in constructor of type {nameof(Phone)} because of parameter {exc.ParamName}";

                    Console.WriteLine(message);
                    Logger.GetIntance.WriteLine(message, MessageType.Exception);
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
