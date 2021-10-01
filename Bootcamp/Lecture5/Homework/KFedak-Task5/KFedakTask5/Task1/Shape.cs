using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public abstract class Shape
    {
        public static void Draw<T>(ICollection<T> drawableList) where T : class
        {
            foreach (T item in drawableList)
            {
                Console.WriteLine($"{item.GetType().Name} was drawn!");
            }
        }

    }
}
