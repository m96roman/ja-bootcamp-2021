using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IWaterDepartment
    {
        void AddObserver(IServices services);
        void RemoveObserver(IServices services);
        void NotifyObserver();
    }
}
