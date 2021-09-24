using System;
using System.Collections.Generic;
using System.Text;

namespace ConstExample
{
    class MathClass
    {
        public const double PI = 3.14;

        static void LocalConstStringVariable()
        {
            // A local constant data point can be directly accessed.
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);

            // Error!
            // fixedStr = "This will not work!";
        }
    }
}
