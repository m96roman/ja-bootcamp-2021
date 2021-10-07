using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask6HW
{
    class Task1
    {
        public void task1()
        {
            List<int> list = new List<int>() { 1, 2, 3, 5, 0 };
            List<string> list1 = new List<string>() { "Afs", "sfaf", "sfaf" };
            var a = list.Filter(FilterCollecions);
            var b = list1.Filter(str1 => char.IsUpper(str1[0]));
            var c = list1.MapFilter(FilterCollecions);

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("____________________");

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
        }
        public static bool FilterCollecions(int s)
        {
            return s>0;
        }
        public static int FilterCollecions(string s)
        {
            return s.Length ;
        } 
    }
    
}
