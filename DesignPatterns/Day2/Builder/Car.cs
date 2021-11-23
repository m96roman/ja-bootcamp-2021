using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
  public  class Car
    {
        public string Name { get; set; }

        private List<object> parts = new List<object>();

        public Car(string name)
        {
            Name = name;
        }

        public void Add(string part)
        {
            parts.Add(part);
        }
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < parts.Count; i++)
            {
                str += parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return $"Car {Name} parts: " + str + "\n";
        }
    }
}
