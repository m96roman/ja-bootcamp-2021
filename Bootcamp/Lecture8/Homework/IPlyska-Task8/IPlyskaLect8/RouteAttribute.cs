using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect8
{
    public class RouteAttribute : Attribute
    {
        public string Name { get; set; }

        public RouteAttribute(string name)
        {
            Name = name;
        }
    }
}
