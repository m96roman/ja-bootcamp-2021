using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Facade
{
   public class Compiler
    {
        public void Complile()
        {
            Console.WriteLine("Code is compiled");
        }

        public void Validate()
        {
            Console.WriteLine("Code is validated");
        }
    }
}
