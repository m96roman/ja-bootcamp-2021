﻿using System;
using ConsoleApp6.Interfaces;

namespace ConsoleApp6.Decors
{
    public class PaintDecor : IDecorate
    {
        public void Decorate()
        {
            Console.WriteLine("Expert draws");
        }
    }
}
