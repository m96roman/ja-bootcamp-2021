using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5_p2
{
    class Kyiv : IStatisticIfCity
    {
        string Name;
        int Number;

        public Kyiv(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public void IStatisticIfCity()
        {
            Console.WriteLine($"{Name}'s population is {Number}");
        }
    }
}