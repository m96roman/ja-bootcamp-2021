using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Collector
    {
        public void FormatDocumentLibrary()
        {
            Console.WriteLine("I am fomrmatting document.");
        }
        public void CopyDocument()
        {
            Console.WriteLine("I am copying document.");
        }
    }
}
