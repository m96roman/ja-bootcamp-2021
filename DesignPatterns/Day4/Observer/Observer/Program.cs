using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterDeptartment deptartment = new WaterDeptartment();
            Users users = new Users(deptartment);
            InfoSupplyWater supplyWater = new InfoSupplyWater();
            deptartment.BlockWaterSupply();

            users.GetUpdate(supplyWater);
        }
    }
}
