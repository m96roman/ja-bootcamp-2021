﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSquareEquation
{
    class NoRootsException : Exception
    {
        public NoRootsException() { }
        public NoRootsException(string message) : base(message) { }
    }
}
