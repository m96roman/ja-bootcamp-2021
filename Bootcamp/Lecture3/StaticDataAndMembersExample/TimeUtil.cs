using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
using static System.DateTime;

namespace StaticDataAndMembersExample
{
    // Static classes can only
    // contain static members!
    static class TimeUtil
    {
        public static void PrintTime()
                => WriteLine(Now.ToShortTimeString());

        public static void PrintDate()
            => WriteLine(Today.ToShortDateString());
    }
}
