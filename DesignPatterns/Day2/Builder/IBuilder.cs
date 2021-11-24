using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        void BuildEngine(string name);
        void BuildWheels(string name);
        void BuildChair(string name);
    }
}
