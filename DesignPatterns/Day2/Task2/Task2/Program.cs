using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFactory(new JacketFactoryTypeOne());
            TestFactory(new JacketFactoryTypeTwo());
            TestFactory(new JacketFactoryTypeThree());
        }

        private static void TestFactory(AbstractJacketFactory abstractJacketFactory)
        {
            Console.WriteLine(abstractJacketFactory.CreateJacketFirstType());
            Console.WriteLine(abstractJacketFactory.CreateJacketSecondType());
            Console.WriteLine(abstractJacketFactory.CreateJacketThirdType());

        }
    }
}
