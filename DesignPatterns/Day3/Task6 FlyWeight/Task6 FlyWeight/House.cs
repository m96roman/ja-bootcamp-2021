using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_FlyWeight
{
    public abstract class House
    {
        protected int Stages { get; set; }
        public House(int stages)
        {
            Stages = stages;
        }

        public abstract void Build();

        public abstract int GetStages();

        public abstract string GetHouseType();
     
    }
}

