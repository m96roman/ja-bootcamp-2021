using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_FlyWeight
{
    class BrickHouse : House
    {
        public BrickHouse(int stages) : base(stages)
        { }

        public override void Build()
        {
            Console.WriteLine(@$"Brick house is duilted and has {Stages} stages");
        }

        public override int GetStages()
        {
            return Stages;
        }

        public override string GetHouseType()
        {
            return "Brick";
        }
    }
}
