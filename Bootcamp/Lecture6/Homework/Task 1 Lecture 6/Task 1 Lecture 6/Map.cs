using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_Lecture_6
{
   static class Map1
    {
      public  static ICollection<T1> Map<T1,T2>(this ICollection<T2> collection, Func<T2,T1> mapper)
        {
            var list = new List<T1>();

            foreach (var item in collection)
            {
                list.Add(mapper(item));
            }

            return list;
        }

        public static void MapMain()
        {
           var list = new List<string>() { "2", "4", "6" };
            list.Map((str)=>{
                var converted = Convert.ToInt32(str);
                Console.WriteLine(converted);
                return converted;
            });
        }
    }
}
