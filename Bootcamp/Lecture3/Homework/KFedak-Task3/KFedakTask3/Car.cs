using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask3
{
    class Car : Vehicle
    {
        private static readonly string Name = "Infiniti";
        protected const int MaxSpeed = 220;

        public Car() : base(Name) { }//create costructor on the base class Vehicle

        public override void Move()
        {
            Console.WriteLine("The car went");
        }

        private void SomeSecretAboutEninge()//use private because i do not want that someone can see this information
        {
            Console.WriteLine("Eninge private function\n");
        }
    }
}

