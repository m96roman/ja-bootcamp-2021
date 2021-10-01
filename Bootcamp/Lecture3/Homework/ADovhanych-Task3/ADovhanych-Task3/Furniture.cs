using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task3
{
    public abstract class Furniture
    {
        public string Name { get; set; }

        public string Material { get; set; }

        protected Furniture(string name, string material)
        {
            Name = name;
            Material = material;
        }

        public virtual void BaseForBed()
        {
            Console.WriteLine("Idk, something with bed");
        }

        public abstract void ActionWith();

        public abstract void LayOn();
    }
}
