using System;

namespace Facade.View
{
    class TextRedactor : ITextRedactor
    {
        public void Save()
        {
            Console.WriteLine("Saved!!!");
        }
    }
}
