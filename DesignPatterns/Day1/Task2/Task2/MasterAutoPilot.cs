using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MasterAutoPilot : CommonAutoPilot
    {
        public MasterAutoPilot(IMasterDrivable transport) : base(transport)
        {
        }

        public override void Navigate(string destination)
        {
            base.Navigate(destination);

            var masterDriver = ((IMasterDrivable)_transport);

            masterDriver.TurnLeft();
            masterDriver.TurnRight();
        }
    }
}
