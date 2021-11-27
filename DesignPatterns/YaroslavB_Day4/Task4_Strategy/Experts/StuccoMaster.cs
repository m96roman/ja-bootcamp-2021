using System;

namespace Task4_Strategy
{
    class StuccoMaster : IExpert
    {
        public void Decorate()
        {
            Console.WriteLine("Applied stucco on the wall.");
        }
    }
}
