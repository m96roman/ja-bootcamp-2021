using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_FlyWeight
{
    class PanelHouse : House
    { 
        public PanelHouse(int stages) : base(stages)
        { }

        public override void Build()
        {
            Console.WriteLine(@$"Panel house is duilted and has {Stages} stages");
        }

        public override int GetStages()
        {
            return Stages;
        }

        public override string GetHouseType()
        {
            return "Panel";
        }
    }
}
