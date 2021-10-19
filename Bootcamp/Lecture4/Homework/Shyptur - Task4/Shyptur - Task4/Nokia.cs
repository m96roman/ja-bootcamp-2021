using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Shyptur - UnitTest 1")]
namespace Shyptur___Task4
{
    internal class Nokia : Phone
    {
        public Nokia(int baterylevel, IMessageLogger logger = null):base(baterylevel,logger)
        {
        
                 
        }

      
        public void PrayForBattery()
        {
            BateryLevel += 8;
            _logger.Log("praying for the battery in Nokoia");
                       
        }
    }
}
