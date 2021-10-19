using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DIvanyshyn-UnitTests-Day1")]
namespace DIVanyshyn_Task4
{
    class Program
    {
        internal static void Main(string[] args)
        {
            RunProgram(CreateHolder(new int[] { 4, 8, 25 }, new OutLogger()), 10);
        }

        /// <summary>
        /// Adds the object of <see cref="Nokia"/> and <see cref="IPhone13"/> with levels in <paramref name="batteryLevels"/>
        /// to <see cref="PhoneEmeregencyTestHolder"/> that returns
        /// </summary>
        /// <param name="batteryLevels">Levels of battery with which <see cref="Nokia"/> and <see cref="IPhone13"/> will be created</param>
        /// <param name="logger"> <see cref="ILogger"/> which will be logging the phone messages</param>
        /// <returns>new intance of <see cref="PhoneEmeregencyTestHolder"/> filled with values</returns>
        internal static PhoneEmeregencyTestHolder CreateHolder(int[] batteryLevels, ILogger logger)
        {
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

            return holder;
        }

        /// <summary>
        /// Runs pro
        /// </summary>
        /// <param name="holder"></param>
        /// <param name="iterationCount"></param>
        internal static void RunProgram(PhoneEmeregencyTestHolder holder, int iterationCount)
        {
            for (int i = 0; i < iterationCount; i++)
            {
                try
                {
                    PhoneEmeregencyTestHolder.TestEmeregency(holder);
                }
                catch (BatteryIsDeadException bs)
                {
                    bs.Phone.Charge();
                }
            }
        }
    }
}
