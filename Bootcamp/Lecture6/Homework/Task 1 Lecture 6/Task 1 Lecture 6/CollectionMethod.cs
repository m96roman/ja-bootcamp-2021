using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_Lecture_6
{
   static class CollectionMethod
    {


        static public ICollection<T> Filter<T>(this ICollection<T> collection, Func<T, bool>Func)
        {
            var list = new List<T>();

            foreach (var item in collection)
            {
                if (Func(item))
                {
                    list.Add(item);

                }
                Console.WriteLine(item);

            }
            return list;
        }
    
        

    }
}
