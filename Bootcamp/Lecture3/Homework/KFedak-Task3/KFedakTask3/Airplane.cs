using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask3
{
    class Airplane : Vehicle
    {
        private static readonly string Name = "SkyUp";

        public Airplane() : base(Name) { }

        public override void Move()
        {
            Console.WriteLine("The plane took off");
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("The turbines are also started");
            Console.WriteLine(DisplayStatus());
        }
    }
}
