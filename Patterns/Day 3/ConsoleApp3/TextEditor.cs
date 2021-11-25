using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class TextEditor : ITextEditor
    {
        public void Save()
        {
            Console.WriteLine("Saving...");
        }
    }
}
