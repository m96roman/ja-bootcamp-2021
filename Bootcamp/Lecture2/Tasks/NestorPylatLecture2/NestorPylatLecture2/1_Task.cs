using System;
using System.Collections.Generic;
using System.Text;

namespace NestorPylatLecture2

{
    struct Market
    {
        public string color;
        public static int index;
    }
    public class _1_Task
    {
        public static void doTask()
        {
            Market market1;
            Market market2;

            market1.color = "red";
            market2.color = "blue";

            Console.WriteLine($"Market1 index - {Market.index} , market1 color - {market1.color}");
            Console.WriteLine($"Market1 index - {Market.index} , market1 color - {market2.color}");
        }
    }
}
