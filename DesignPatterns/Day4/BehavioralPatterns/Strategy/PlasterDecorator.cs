﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class PlasterDecorator : IDecorate
    {
        public void Decorate()
        {
            Console.WriteLine("Apply plaster");
        }
    }
}
