using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adovhanych_Task6
{
    class FilterExtension
    {
        public static bool FilterCollection(string str)
        {
            if (char.IsUpper(str[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static ICollection<string> Filter(this ICollection<string> collection, FilterFunction filterFunction)
        {
            
        }

    //    public static icollection<string> map(this icollection<string> map)
    //    {

    //    }
    }
}
