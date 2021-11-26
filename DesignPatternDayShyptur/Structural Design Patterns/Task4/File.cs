using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class File: Component
    {
        public override string GetRoot()
        {
            return "File";
        }
        public override bool IsComposite()
        {
            return false;
        }
    }
}
