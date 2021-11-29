using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var productA = new ModelA();
            productA.addAllPartsTogether();

            var productB = new ModelB();
            productB.addAllPartsTogether();

            var productC = new ModelC();
            productC.addAllPartsTogether();
        }
    }
}
