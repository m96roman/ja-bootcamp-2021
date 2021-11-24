using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class PanelHouse : IHouse
    {
        public PanelHouse(int stagesInHouse)
        {
            Stages = stagesInHouse;
        }
    }
}
