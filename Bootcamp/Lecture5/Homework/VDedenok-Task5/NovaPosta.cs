using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task5
{
  class NovaPosta : Delivery<DomesticPackage>
    {
        protected override string GetPackageInfo(DomesticPackage info)
        {
            return ($"Pop-up notification from NP: You can pick up you package at {info.DepartmentId} department.");
        }
    }
}
