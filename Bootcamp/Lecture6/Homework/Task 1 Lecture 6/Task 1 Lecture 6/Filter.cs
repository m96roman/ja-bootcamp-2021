using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_Lecture_6
{
    class Filter
    {
        static bool ForFilter(string a)
        {
            Console.WriteLine(char.IsUpper(a[0]));
            return char.IsUpper(a[0]);
        }

        static public void FilterMain()
        {
            var list = new List<string>() { "Fdsg", "dsfsdfsd", "dfsdfsdf" };
            list.Filter(ForFilter).Map(str => str.Length);
        }
        }
    }

