using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask3
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set; }

        public Vehicle(string name)
        {
            this.Name = name;
        }

        public abstract void Move();

        public virtual void Start()
        {
            Console.WriteLine("Motor started");
        }
        /// <summary>
        /// When we declare a field or method as protected, it can only be accessed from the same class and its derived classes.
        /// So i can use this method in deliverd classes
        /// </summary>
        protected string DisplayStatus()
        {
            return "I am in a perfect condition for be useing";
        }
    }
}
