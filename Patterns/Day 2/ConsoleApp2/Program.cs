using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // sew 2 jackets of type A 
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Sew jacket{i} of type A");
                Jacket jacket = new Jacket(new JacketFactoryA());
                jacket.SewJacket();
            }

            // sew 5 jackets of type B 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Sew jacket{i} of type B");
                Jacket jacket = new Jacket(new JacketFactoryB());
                jacket.SewJacket();
            }

            // sew 3 jackets of type C 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Sew jacket{i} of type C");
                Jacket jacket = new Jacket(new JacketFactoryC());
                jacket.SewJacket();
            }
        }
    }
}
