using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1
{
    class Task3
    {
        public static void ToStringConvert()
        {
            var str = new string[] { "Hi", ",", "I", "am", "Nestor" };
            var res = string.Join("", str.Aggregate((current, next) => current + " " + next).ToList());
            Console.WriteLine(res);
        }
    }
}
