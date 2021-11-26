using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class BuisnessClients : IWaterService
    {
        public void Update(IWaterInform subject)
        {
            if ((subject as WaterInform).State==false)
            {
                Console.WriteLine("Buisness clients have no water");
            }
        }
    }
}
