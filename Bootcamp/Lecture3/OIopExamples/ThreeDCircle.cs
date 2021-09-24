using System;
using System.Collections.Generic;
using System.Text;

namespace OIopExamples
{
    class ThreeDCircle : Circle
    {
        // Hide the PetName property above me.
        public new string PetName { get; set; }

        // Hide any Draw() implementation above me.
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
