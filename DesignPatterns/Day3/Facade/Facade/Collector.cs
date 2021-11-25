using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Collector
    {
        public void CreateLibrary()
        {
            Console.WriteLine("Library was created");
        }

        public void CopyIntoFolder() 
        {
            Console.WriteLine("File copy to folder");
        }
    }
}
