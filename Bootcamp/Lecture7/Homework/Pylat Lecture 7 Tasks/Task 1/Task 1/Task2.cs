using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1
{
    class Task2
    {
        public static void FindCountOfSymbols()
        {
            var words = "aaavvavfnfn";
            var res = string.Join(", ", words.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).ToList());
            Console.WriteLine(res);
        }
    }
}
