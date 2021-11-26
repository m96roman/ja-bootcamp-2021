using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        void BuildModelA1(string config);

        void BuildModelA2(string config);

        void BuildModelA5(string config);
    }
}
