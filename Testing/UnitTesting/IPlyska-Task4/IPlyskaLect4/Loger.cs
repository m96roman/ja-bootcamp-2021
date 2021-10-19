using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("PhoneUnitTest")]

namespace IPlyskaLect4
{
    internal class Loger
    {
        internal static List<string> messages = new List<string>();

        public static void Log(string message)
        {
            Console.WriteLine(message);
            messages.Add(message);
        }
    }

}
