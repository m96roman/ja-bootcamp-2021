using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adovhanych_Task6
{
    public static class MapExtension
    { 
        public static int MapFilter(string str)
        {
            return str.Length;
        }

        public static ICollection<int> Map(this ICollection<string> itemsCollection, Func<string, int> mapFilter)
        {
            var list = new List<int>();

            foreach (var item in itemsCollection)
            {
                list.Add(mapFilter(item));
            }

            return list;
        }
    }
}
