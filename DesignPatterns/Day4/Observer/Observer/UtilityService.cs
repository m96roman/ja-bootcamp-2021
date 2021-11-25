using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class UtilityService : IServices
    {
        IWaterDepartment waterDepartment;

        public UtilityService(IWaterDepartment department)
        {
            waterDepartment = department;
            waterDepartment.AddObserver(this);
        }

        public void GetUpdate(object obj)
        {
            InfoSupplyWater supplyWater = (InfoSupplyWater)obj;

            if (supplyWater.isAvaliable)
            {
                Console.WriteLine("Water is avaliable");
            }
            else
            {
                Console.WriteLine("Water department blocked the water supply");
            }
        }
    }
}
