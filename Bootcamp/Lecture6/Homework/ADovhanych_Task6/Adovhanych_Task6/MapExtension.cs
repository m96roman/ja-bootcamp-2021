using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adovhanych_Task6
{
    class MapExtension
    { 
        public static int MapFilter(string str)
        {
            return str.Length;
        }

        public static ICollection<string> Map(this ICollection<string>, Func<string, int> filter)
        {

        }
    }
}
