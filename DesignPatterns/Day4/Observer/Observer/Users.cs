using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Users : IServices
    {
        IWaterDepartment waterDepartment;

        public Users(IWaterDepartment department)
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
