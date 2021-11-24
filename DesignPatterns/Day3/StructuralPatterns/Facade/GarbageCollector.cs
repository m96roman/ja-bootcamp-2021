using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class GarbageCollector
    {
        public void BuildLibrary()
        {
            Console.WriteLine("Build library");
        }
        public void CopyToFolder()
        {
            BuildLibrary();
            Console.WriteLine("Copy library to output folder");
        }
    }

}
