using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5_p2
{
    class Lviv : IStatisticIfCity
    {
        string Name;
        int Number;

        public Lviv(string name, int number)
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