using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adovhanych_Task6
{
    public static class FilterExtension
    {
        public static bool FilterFunction(string str)
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

        public static ICollection<string> Filter(this ICollection<string> itemsCollection, Func<string, bool> filter)
        {
            var strList = new List<string>();

            foreach (var list in itemsCollection)
            {
                if (filter(list))
                {
                    strList.Add(list);
                }
            }
            return strList;
        }

        //public static ICollection<T> GenFilter<T>(this ICollection<string> itemsCollection, Func<T, T> filter)
        //{
        //    var someList = new List<string>();
        //}
    }
}
