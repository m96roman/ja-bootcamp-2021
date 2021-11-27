using System;

namespace Task4_Strategy
{ 
    class Painter : IExpert
    {
        public void Decorate()
        {
            Console.WriteLine("Added drawing on the wall.");
        }
    }
}
