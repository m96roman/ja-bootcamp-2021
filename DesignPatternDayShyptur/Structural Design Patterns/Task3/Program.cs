using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade(new TextEditor(), new Compiller(),new Cleaner());
            facade.Start();
           
        }
    }
}
