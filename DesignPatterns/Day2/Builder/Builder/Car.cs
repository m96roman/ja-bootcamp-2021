using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        private List<object> _parts = new List<object>();

        public Car() 
        { 
        }

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public void ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            Console.WriteLine("Product parts: " + str + "\n"); 
        }

    }
}
