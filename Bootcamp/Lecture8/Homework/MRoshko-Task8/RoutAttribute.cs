using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task8
{
    public class RouteAttribute : Attribute
    {
        public string Name { get; private set; }

        public RouteAttribute(string name)
        {
            Name = name;
        }
    }
}
