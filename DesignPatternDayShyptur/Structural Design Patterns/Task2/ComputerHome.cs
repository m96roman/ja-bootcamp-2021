﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ComputerHome : Computer
    {
        public ComputerHome() : base("Home PC")
        {
        }

        public override void Display()
        {
            Console.WriteLine("Home PC");
        }
    }
}
