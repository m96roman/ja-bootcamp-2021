using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class WaterDeptartment : IWaterDepartment
    {
        InfoSupplyWater waterSupply;

        private List<IServices> _services;

        public WaterDeptartment()
        {
            _services = new List<IServices>();
            waterSupply = new InfoSupplyWater();
        }

        public void AddObserver(IServices services)
        {
            _services.Add(services);
        }

        public void NotifyObserver()
        {
            foreach (var service in _services)
            {
                service.GetUpdate(waterSupply);
            }
        }

        public void RemoveObserver(IServices services)
        {
            _services.Remove(services);
        }

        public void BlockWaterSupply()
        {
            waterSupply.isAvaliable = false;
        }
    }
}
