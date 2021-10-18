using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect4
{
    class Loger
    {
        public static List<string> messages = new List<string>();

        public static void Log(string message)
        {
            Console.WriteLine(message);
            messages.Add(message);
        }
    }
}
