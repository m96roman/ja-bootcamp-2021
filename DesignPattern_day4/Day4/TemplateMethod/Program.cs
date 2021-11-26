using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("Go to by items");
            client.Simulate(new ByItems());
            Console.WriteLine();
            Console.WriteLine("Go to by presents");
            client.Simulate(new ByPresent());
            Console.WriteLine();
            Console.WriteLine("Go to by items to by furniture");
            client.Simulate(new ByFurniture());
        }
    }
}
