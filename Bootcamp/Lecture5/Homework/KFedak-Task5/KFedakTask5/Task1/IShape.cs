using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public interface IShape
    {
        public static void Draw<T>(ICollection<T> drawableList) where T : IShape
        {
            foreach (T item in drawableList)
            {
                item.Draw();
            }
        }

        public void Draw();
    }
}
