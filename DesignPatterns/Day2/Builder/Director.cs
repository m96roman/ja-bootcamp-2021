using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
  public  class Director
    {
        public IBuilder builder {  set; get; }

        public void BuildBasic()
        {
            builder.BuildEngine("engine 1.5");
            builder.BuildWheels("wheels 15");
            builder.BuildChair("no heating");
        }

        public void BuildPremium()
        {
            builder.BuildEngine("engine 1.8");
            builder.BuildWheels("wheels 16");
            builder.BuildChair("no heating");
        }

        public void BuildLuxury()
        {
            builder.BuildEngine("engine 1.81");
            builder.BuildWheels("wheels 16");
            builder.BuildChair("heating");
        }
    }
}
