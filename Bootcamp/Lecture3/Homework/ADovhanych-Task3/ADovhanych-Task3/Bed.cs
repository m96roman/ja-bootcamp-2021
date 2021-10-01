using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task3
{
    public class Bed : Furniture
    {
        public Bed() : this("Bed, duh", "wood") { }

        public Bed(string name, string material) : base(name, material)
        {

        }

        public override void ActionWith()
        {
            Console.WriteLine("You can try to carry it");
        }

        public override void LayOn()
        {
            Console.WriteLine("Comfy bed, ngl");
        }

        public override void BaseForBed()
        {
            Console.WriteLine("Fun with bed");
            base.BaseForBed();
        }
    }
}
